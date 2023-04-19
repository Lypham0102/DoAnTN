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
    public class TTBController : Controller
    {
        public readonly TTB_Interface _Interface;
        // GET: /<controller>/

        public TTBController (TTB_Interface tTB_)
        {
            _Interface = tTB_;
        }

        public IActionResult Index()
        {
            return View(_Interface.GetAllTrangThietBi());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreatePost(TTBModel TrangThietBiData)
        {
            _Interface.Create(TrangThietBiData);
            return RedirectToAction("Index");
        }
    }
}

