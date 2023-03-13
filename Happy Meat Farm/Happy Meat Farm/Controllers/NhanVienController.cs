using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Happy_Meat_Farm.Interface;

namespace Happy_Meat_Farm.Controllers
{
    public class NhanVienController : Controller
    {
        private readonly INhanVien _context;

        public NhanVienController(INhanVien context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.GetAllNhanVien());
        }
    }
}
