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
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace Happy_Meat_Farm.Controllers
{

    public class AuthController : Controller
    {
        private readonly IAuth _userRepository;

        public AuthController(IAuth userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(ChuTrai model)
        {
            if (ModelState.IsValid)
            {
                var user = await _userRepository.GetUser(model.Account, model.Password);
                if (user != null)
                {
                    return RedirectToAction("Index", "NongTrai");
                }
                else
                {
                    ModelState.AddModelError("", "Vui lòng điền đủ thông tin đăng nhập hoặc kiểm tra lại thông tin tài !");

                }
            }
            return View(model);
        }




    }

}

