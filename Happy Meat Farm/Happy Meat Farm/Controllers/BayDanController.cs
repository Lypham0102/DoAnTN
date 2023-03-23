using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Happy_Meat_Farm.Interface;
using Happy_Meat_Farm.Models;
using Microsoft.AspNetCore.Http;

namespace Happy_Meat_Farm.Controllers
{
    public class BayDanController: Controller
    {
        private readonly IBayDan _context;

        public BayDanController(IBayDan context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.GetAllBayDan());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreatePost(BayDan baydanData)
        {
            _context.Create(baydanData);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(string Name)
        {
            var md = _context.GetBayDanDetails(Name);
            return View(md);
        }
        [HttpPost]
        public IActionResult EditPost(string _id, BayDan baydandata)
        {
            _context.Update(_id, baydandata);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Details(string Name)
        {
            var md = _context.GetBayDanDetails(Name);
            return View(md);
        }
        [HttpGet]
        public IActionResult Delete(string Name)
        {
            var md = _context.GetBayDanDetails(Name);
            _context.Delete(Name);
            return RedirectToAction("Index");
            //return View(md);
        }
        [HttpPost]
        public IActionResult DeletePost(string Name)
        {
            _context.Delete(Name);
            return RedirectToAction("Index");
        }

        //public IActionResult CaTheBayDan(string Name)
        //{
        //    var md = _context.GetCaTheBayDan(Name);
        //    return View(md);
        //}
    }
}

