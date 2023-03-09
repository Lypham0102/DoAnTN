﻿using Happy_Meat_Farm.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Happy_Meat_Farm.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult QuanLyCongViec()
        {
            return View();
        }
        public IActionResult QuanLyBanHang()
        {
            return View();
        }
        public IActionResult QuanLyVatNuoi()
        {
            return View();
        }
        public IActionResult ThongKe()
        {
            return View();
        }

        //Trang đăng nhập
        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            if (CheckCredentials(username, password))
            {
                // Đăng nhập thành công
                return RedirectToAction("Index", "Home");
            }
            else
            {
                // Thông báo lỗi đăng nhập
                ViewBag.Error = "Invalid username or password";
                return View();
            }
        }

        private bool CheckCredentials(string username,string password)
        {
            // Kiểm tra thông tin đăng nhập
            // ...
        }


        public IActionResult DangKy()
        {
            return View();
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
