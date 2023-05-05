using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Happy_Meat_Farm.Data;
using Happy_Meat_Farm.Interface;
using Happy_Meat_Farm.Models;
using Happy_Meat_Farm.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace Happy_Meat_Farm.Controllers
{
    public class NongTraiController : Controller
    {
        private readonly INongTrai _context;
        public readonly IConfiguration _configuration;
        public readonly NongTraiDBContext nongTraiDBContext;

        public NongTraiController(INongTrai context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.GetAllNongTrai());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreatePost(NongTrai nongtraiData)
        {
            _context.Create(nongtraiData);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(string Name)
        {
            var md = _context.GetNongTraiDetails(Name);
            return View(md);
        }
        [HttpPost]
        public IActionResult EditPost(string _id, NongTrai nongtraidata)
        {
            _context.Update(_id, nongtraidata);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Details(string Name)
        {
            var md = _context.GetNongTraiDetails(Name);
            return View(md);
        }
        [HttpGet]
        public IActionResult Delete(string Name)
        {
            var md = _context.GetNongTraiDetails(Name);
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

