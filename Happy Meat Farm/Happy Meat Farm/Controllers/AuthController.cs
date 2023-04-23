using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore.Identity;
using Happy_Meat_Farm.Models;
using Happy_Meat_Farm.Services;
using Happy_Meat_Farm.Interface;
using Happy_Meat_Farm.Data;
using System.Text;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using MongoDB.Driver;


namespace Happy_Meat_Farm.Controllers
{
    public class AuthController : Controller
    {
        public readonly NhanVienDBContext _dbContext;
        public readonly IConfiguration _configuration;

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] NhanVien model)
        {
            var user = await _dbContext.GetUserByUsernameAsync(model.TenTaiKhoan);

            if (user == null)
            {
                return BadRequest("Tài khoản hoặc mật khẩu không chính xác");
            }

            var passwordHasher = new PasswordHasher<NhanVien>();
            var result = passwordHasher.VerifyHashedPassword(user, user.TenTaiKhoan, model.Passwork);

            if (result == PasswordVerificationResult.Failed)
            {
                return BadRequest("Tài khoản hoặc mật khẩu không chính xác ");
            }

            var token = GenerateJwtToken(user);

            return Redirect(Url.Action("Index", "Home"));
        }

        private string GenerateJwtToken(NhanVien user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_configuration["Jwt:Secret"]);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
            new Claim(ClaimTypes.NameIdentifier, user.TenTaiKhoan.ToString()),
            new Claim(ClaimTypes.Name, user.TenNV)
                }),
                Expires = DateTime.UtcNow.AddHours(2),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            var tokenString = tokenHandler.WriteToken(token);
            return tokenString;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] NhanVien model)
        {
            var user = await _dbContext.GetUserByUsernameAsync(model.TenTaiKhoan);

            if (user != null)
            {
                return BadRequest("Tài khoản đã tồn tại");
            }

            user = new NhanVien
            {
                MaNV = model.MaNV,
                TenNV = model.TenNV,
                CCCD = model.CCCD,
                SDT = model.SDT,
                DiaChi = model.DiaChi,
                MaNT = model.MaNT,
                TenTaiKhoan = model.TenTaiKhoan,
                Passwork = model.Passwork,
            };

            var passwordHasher = new PasswordHasher<NhanVien>();
            user.Passwork = passwordHasher.HashPassword(user, user.Passwork);

            await _dbContext.AddUserAsync(user);

            return Ok();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Auth");
        }
    }
}

