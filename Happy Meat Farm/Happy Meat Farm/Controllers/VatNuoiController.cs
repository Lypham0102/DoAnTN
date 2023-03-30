using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Happy_Meat_Farm.Interface;
using Happy_Meat_Farm.Models;
using MongoDB.Bson;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Happy_Meat_Farm.Controllers
{
    public class VatNuoiController : Controller
    {
        private readonly ICaThe _context;

        public VatNuoiController(ICaThe context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.GetAllCaThe());
            //var md = _context.GetAllCaThe(Name).ToString();
            //return View(md);
        }

        //public IActionResult Create()
        //{
        //    return View();
        //}
        //[HttpPost]
        //public IActionResult CreatePost(CaThe catheData)
        //{
        //    _context.Create(catheData);
        //    return RedirectToAction("Index");
        //}
        //[HttpGet]
        //public IActionResult Edit(string Name)
        //{
        //    var md = _context.GetCaTheDetails(Name);
        //    return View(md);
        //}
        //[HttpPost]
        //public IActionResult EditPost(string _id,CaThe cathedata)
        //{
        //    _context.Update(_id, cathedata);
        //    return RedirectToAction("Index");
        //}
        //[HttpGet]
        //public IActionResult Details(string Name)
        //{
        //    var md = _context.GetCaTheDetails(Name);
        //    return View(md);
        //}
        //[HttpGet]
        //public IActionResult Delete(string Name)
        //{
        //    var md = _context.GetCaTheDetails(Name);
        //    return View(md);
        //}
        //[HttpPost]
        //public IActionResult DeletePost(string Name)
        //{
        //    _context.Delete(Name);
        //    return RedirectToAction("Index");
        //}


        // GET: /<controller>/
        [HttpGet]
        public IActionResult VatNuoi(string Name)
        {
            //var md = _context.GetCaTheTheoBay(Name);
            return View();
        }
        //public IActionResult ShowBayDan()
        //{
        //    var VatNuoi = _context.GetCollection<CaThe>("BayDan")
        //    //var allVatNuoi = VatNuoi.Find(new BsonDocument()).ToList();
        //        .Aggregate()
        //        .Lookup("BayDan", "MaBayDan", "_id", "BayDan")
        //        .ToList();
        //    return View(VatNuoi);
        //}
        //public IActionResult CaTheoTheoBay(string Name)
        //{
        //    return View(_context.GetCaTheTheoBay(Name));
        //}

        //[HttpGet]
        //public IActionResult ChiTietTheoBayDan(string Name)
        //{
        //    var md = _context.GetCaTheTheoBay(Name);
        //    return View(md);
        }
        //public IActionResult ThemVatNuoi()
        //{
        //    return View();
        //}
        //public IActionResult ThemChuong()
        //{
        //    return View();
        //}
        //public IActionResult ThemBayDan()
        //{
        //    return View();
        //}
        //public IActionResult XuatChuong()
        //{
        //    return View();
        //}
    //}
}

