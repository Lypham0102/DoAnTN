using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Happy_Meat_Farm.Interface;
using Happy_Meat_Farm.Services;
using Happy_Meat_Farm.Models;
using Microsoft.Extensions.Configuration;

namespace Happy_Meat_Farm.Controllers
{
    public class ThucAnController : Controller
    {
        public readonly IThucAn thucAn;
        // GET: /<controller>/

        public ThucAnController (IThucAn _thucAn)
        {
            thucAn = _thucAn;
        }

        public IActionResult Index()
        {
            return View(thucAn.GetAllThucAn());
            //return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreatePost(ThucAnModel ThucAnData)
        {
            thucAn.Create(ThucAnData);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Details(string Name)
        {
            var md = thucAn.GetThucAnDetails(Name);
            return View(md);
        }

        [HttpGet]
        public IActionResult Edit(string Name)
        {
            var md = thucAn.GetThucAnDetails(Name);
            return View(md);
        }
        [HttpPost]
        public IActionResult EditPost(string _id, ThucAnModel ThucAnData)
        {
            thucAn.Update(_id, ThucAnData);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Delete(string Name)
        {
            var md = thucAn.GetThucAnDetails(Name);
            //return View(md);
            thucAn.Delete(Name);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult DeletePost(string Name)
        {
            thucAn.Delete(Name);
            return RedirectToAction("Index");
        }
    }
}

