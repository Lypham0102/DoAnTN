using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Happy_Meat_Farm.Interface;
using Happy_Meat_Farm.Services;
using Microsoft.Extensions.Configuration;
using Happy_Meat_Farm.Models;

namespace Happy_Meat_Farm.Controllers
{
    public class ThuocController : Controller
    {
        public readonly IThuoc thuoc;
        // GET: /<controller>/

        public ThuocController(IThuoc _thuoc)
        {
            thuoc = _thuoc;
        }

        public IActionResult Index()
        {
            return View(thuoc.GetAllThuoc());
            //return View();
        }
        public IActionResult IndexNV()
        {
            return View(thuoc.GetAllThuoc());
            //return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult CreateNV()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreatePost(ThuocModel ThuocData)
        {
            thuoc.Create(ThuocData);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(string Name)
        {
            var md = thuoc.GetThuocDetails(Name);
            return View(md);
        }
        [HttpGet]
        public IActionResult EditNV(string Name)
        {
            var md = thuoc.GetThuocDetails(Name);
            return View(md);
        }
        [HttpPost]
        public IActionResult EditPost(string _id, ThuocModel ThuocData)
        {
            thuoc.Update(_id, ThuocData);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Details(string Name)
        {
            var md = thuoc.GetThuocDetails(Name);
            return View(md);
        }
        [HttpGet]
        public IActionResult DetailsNV(string Name)
        {
            var md = thuoc.GetThuocDetails(Name);
            return View(md);
        }

        [HttpGet]
        public IActionResult Delete(string Name)
        {
            var md = thuoc.GetThuocDetails(Name);
            //return View(md);
            thuoc.Delete(Name);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult DeletePost(string Name)
        {
            thuoc.Delete(Name);
            return RedirectToAction("Index");
        }
    }
}

