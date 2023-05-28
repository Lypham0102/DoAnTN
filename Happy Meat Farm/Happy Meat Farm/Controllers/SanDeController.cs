using Microsoft.AspNetCore.Mvc;
using System;
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
using Microsoft.Graph.Models;
using ClosedXML.Excel;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;

namespace Happy_Meat_Farm.Controllers
{
    public class SanDeController : Controller
    {
        private readonly ISanDe _context;
        public readonly NhanVienServices sanDeServices;
        public readonly IConfiguration _configuration;
        public readonly SanDeDBContext sanDeDBContext;

        public SanDeController(ISanDe context)
        {
            _context = context;

        }

        public IActionResult Index()
        {
            return View(_context.GetAllSanDe());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreatePost(SanDe sandeData)
        {
            _context.Create(sandeData);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(string Name)
        {
            var md = _context.GetSanDeDetails(Name);
            return View(md);
        }
        [HttpPost]
        public IActionResult EditPost(string _id, SanDe sandedata)
        {
            _context.Update(_id, sandedata);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Details(string Name)
        {
            var md = _context.GetSanDeDetails(Name);
            return View(md);
        }
        [HttpGet]
        public IActionResult Delete(string Name)
        {
            var md = _context.GetSanDeDetails(Name);
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
        public List<SanDe> GetSanDeTrong()
        {
            return _context.GetAllSanDe().Where(s => s.TrangThai != "Đã dùng").ToList();

        }
    }
}
