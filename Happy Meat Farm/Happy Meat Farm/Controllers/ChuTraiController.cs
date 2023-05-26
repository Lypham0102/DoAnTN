using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Happy_Meat_Farm.Interface;
using Happy_Meat_Farm.Models;
using Microsoft.AspNetCore.Http;
using Happy_Meat_Farm.Services;
using Happy_Meat_Farm.Data;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace Happy_Meat_Farm.Controllers
{
    public class ChuTraiController : Controller
    {
        private readonly IChuTrai _context;
        public readonly IConfiguration _configuration;
        public readonly ChuTraiDBContext nhanvienDBContext;

        public ChuTraiController(IChuTrai context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.GetAllChuTrai());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreatePost(ChuTrai chutraiData)
        {
            _context.Create(chutraiData);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(string Name)
        {
            var md = _context.GetChuTraiDetails(Name);
            return View(md);
        }
        [HttpPost]
        public IActionResult EditPost(string _id, ChuTrai chutraidata)
        {
            _context.Update(_id, chutraidata);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Details(string Name)
        {
            var md = _context.GetChuTraiDetails(Name);
            return View(md);
        }
        [HttpGet]
        public IActionResult Delete(string Name)
        {
            var md = _context.GetChuTraiDetails(Name);
            //return View(md);
            _context.Delete(Name);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult DeletePost(string Name)
        {
            _context.Delete(Name);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult RegisterChuTrai()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RegisterChuTrai(ChuTrai model)
        {
            if (ModelState.IsValid)
            {
                var userExists = await _context.GetChuTrai(model.Account);
                if (userExists == null)
                {
                    if (model.Password == model.ConfirmPassword)
                    {
                        await _context.CreateChuTrai(model);
                        TempData["message"] = "Đăng ký thành công!";
                        return RedirectToAction("Login", "Auth");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Mật khẩu không khớp.");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Tên tài khoản đã được sử dụng!");
                }
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(ChuTrai model)
        {
            var chuTrai = await _context.GetChuTraiByAccountAsync(model.Account);
            if (chuTrai == null || chuTrai.Password != model.Password)
            {
                ModelState.AddModelError("", "Tài khoản hoặc mật khẩu không đúng");
                return View(model);
            }

            var claims = new[] { new Claim(ClaimTypes.Name, chuTrai.TenChuTrai) };
            var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            var principal = new ClaimsPrincipal(identity);
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

            return RedirectToAction("Index", "NongTrai");
        }
        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "NongTrai");

        }
    }
}

