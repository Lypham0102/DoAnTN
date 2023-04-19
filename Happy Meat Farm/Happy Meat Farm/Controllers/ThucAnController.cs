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
    }
}

