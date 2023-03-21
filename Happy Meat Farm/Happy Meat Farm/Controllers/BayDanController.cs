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
    public class BayDanController : Controller
    {
        

        // GET: /<controller>/
        public IActionResult IndexBayDan()
        {
            return View();
        }
        public IActionResult ThemBayDan()
        {
            return View();
        }
        
    }
}

