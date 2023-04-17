﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Happy_Meat_Farm.Interface;
using Happy_Meat_Farm.Models;
using Microsoft.AspNetCore.Http;
using Happy_Meat_Farm.Services;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Configuration;

namespace Happy_Meat_Farm.Controllers
{
    public class NhanVienController : Controller
    {
        private readonly INhanVien _context;
        public readonly NhanVienServices nhanVienServices;
        public readonly IConfiguration _configuration;

        public NhanVienController(INhanVien context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.GetAllNhanVien());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreatePost(NhanVien nhanvienData)
        {
            _context.Create(nhanvienData);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(string Name)
        {
            var md = _context.GetNhanVienDetails(Name);
            return View(md);
        }
        [HttpPost]
        public IActionResult EditPost(string _id, NhanVien nhanviendata)
        {
            _context.Update(_id, nhanviendata);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Details(string Name)
        {
            var md = _context.GetNhanVienDetails(Name);
            return View(md);
        }
        [HttpGet]
        public IActionResult Delete(string Name)
        {
            var md = _context.GetNhanVienDetails(Name);
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
    }
}
