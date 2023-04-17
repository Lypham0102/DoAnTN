﻿using Happy_Meat_Farm.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Http;

namespace Happy_Meat_Farm.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        private IMongoCollection<NhanVien>_nhanvienCollection;
        //public HomeController(IMongoClient client)
        //{
        //    //_logger = logger;
        //    var database = client.GetDatabase("TrangTrai");
        //    _nhanvienCollection = database.GetCollection<NhanVien>("NhanViens");

        //}
        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public IEnumerable<NhanVien> Get() 
        {
            return null;
            //return _nhanvienCollection.Find(s => s.MaNV != "").ToList();
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
        public IActionResult ThemChuong()
        {
            return View();
        }
        public IActionResult XuatChuong()
        {
            return View();
        }
        public IActionResult ThongTinVatNuoi()
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
