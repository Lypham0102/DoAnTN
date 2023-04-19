using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Happy_Meat_Farm.Interface;
using Happy_Meat_Farm.Services;
using Microsoft.Extensions.Configuration;

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
    }
}

