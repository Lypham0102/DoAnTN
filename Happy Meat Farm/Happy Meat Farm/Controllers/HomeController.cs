using Happy_Meat_Farm.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Http;
using Happy_Meat_Farm.Services;
using Happy_Meat_Farm.Data;
using Microsoft.AspNetCore.Authorization;

namespace Happy_Meat_Farm.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMongoDatabase _database;

        public HomeController(ILogger<HomeController> logger, IMongoDatabase database)
        {
            _logger = logger;
            _database = database;
        }
        private IMongoCollection<NhanVien>_nhanvienCollection;

        [Authorize]
        public async Task<IActionResult> Index()
        {
            var collection = _database.GetCollection<NhanVien>("NhanVien");
            var count = await collection.CountDocumentsAsync(new BsonDocument());
            ViewData["Count"] = count;

            var cathecollection = _database.GetCollection<CaThe>("CaThe");
            var countCathe = await cathecollection.CountDocumentsAsync(new BsonDocument());
            ViewData["countCathe"] = countCathe;

            var baydancollection = _database.GetCollection<BayDan>("BayDan");
            var countBaydan = await baydancollection.CountDocumentsAsync(new BsonDocument());
            ViewData["countBaydan"] = countBaydan;

            return View();
        }
       

        [HttpGet]
        public IEnumerable<NhanVien> Get() 
        {
            return null;
        }

        public IActionResult QuanLyCongViec()
        {
            return View();
        }
        public IActionResult QuanLyBanHang()
        {
            return View();
        }
        
        public IActionResult ThongKe()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
