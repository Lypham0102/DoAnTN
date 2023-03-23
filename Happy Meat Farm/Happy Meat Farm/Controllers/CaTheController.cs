using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Happy_Meat_Farm.Models;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using Microsoft.Extensions.Configuration;
using Happy_Meat_Farm.Interface;

namespace Happy_Meat_Farm.Controllers
{
    public class CaTheController : Controller
    {
        private readonly ICaThe _context;

        public CaTheController(ICaThe context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.GetAllCaThe());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreatePost(CaThe catheData)
        {
            _context.Create(catheData);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(string Name)
        {
            var md = _context.GetCaTheDetails(Name);
            return View(md);
        }
        [HttpPost]
        public IActionResult EditPost(string _id, CaThe cathedata)
        {
            _context.Update(_id, cathedata);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Details(string _id)
        {
            var md = _context.GetCaTheDetails(_id);
            return View(md);
        }
        [HttpGet]
        public IActionResult Delete(string _id)
        {
            var md = _context.GetCaTheDetails(_id);
            return View(md);
        }
        [HttpPost]
        public IActionResult DeletePost(string _id)
        {
            _context.Delete(_id);
            return RedirectToAction("Index");
        }
    }
}

