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

namespace Happy_Meat_Farm.Controllers
{
    public class LichTiemChungController : Controller
    {
        private readonly ILichTiemChung _context;
        public readonly IConfiguration _configuration;
        public readonly LichTiemChungDBContext lichtiemchungDBContext;

        public LichTiemChungController(ILichTiemChung context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.GetAllLichTiemChung());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreatePost(LichTiemChung lichtiemchungData)
        {
            _context.Create(lichtiemchungData);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(string Name)
        {
            var md = _context.GetLichTiemChungDetails(Name);
            return View(md);
        }
        [HttpPost]
        public IActionResult EditPost(string _id, LichTiemChung lichtiemchungdata)
        {
            _context.Update(_id, lichtiemchungdata);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Details(string Name)
        {
            var md = _context.GetLichTiemChungDetails(Name);
            return View(md);
        }
        [HttpGet]
        public IActionResult Delete(string Name)
        {
            var md = _context.GetLichTiemChungDetails(Name);
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

        //public async Task<IActionResult> CountNhanVien()
        //{
        //    var count = await nhanVienDBContext.CountNhanVienAsync();
        //    return View(count);
        //}
    }
}
