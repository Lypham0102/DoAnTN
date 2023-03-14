using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Happy_Meat_Farm.Controllers
{
    public class VatNuoiController : Controller
    {
        // GET: /<controller>/
        public IActionResult VatNuoi()
        {
            return View();
        }
        public IActionResult ThemVatNuoi()
        {
            return View();
        }
        public IActionResult ThemChuong()
        {
            return View();
        }
        public IActionResult XuatChuong()
        {
            return View();
        }
    }
}

