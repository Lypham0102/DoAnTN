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
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;
using FirebaseAdmin;
using Google.Apis.Auth.OAuth2;
using Firebase.Database;
using Happy_Meat_Farm.Interface;
using Microsoft.Extensions.Configuration;
using System.Net.NetworkInformation;
using System.IO;
using System.Text;
using Newtonsoft.Json.Linq;

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
        private IMongoCollection<NhanVien> _nhanvienCollection;
        //[Authorize]
        public async Task<IActionResult> Index()
        {
            //var accountSid = "AC0abe64fe348a8ce67a95cf76f32ddf5f";
            //var authToken = "8bcd7be9e20a6691d73b2f693f3afc3f";
            //TwilioClient.Init(accountSid, authToken);
            //var messageOptions = new CreateMessageOptions(new PhoneNumber("+84386834480"));
            //messageOptions.From = new PhoneNumber("+18052738662");
            //messageOptions.Body = "Test nhiệt độ, độ ẩm";

            //var message = MessageResource.Create(messageOptions);
            //Console.WriteLine(message.Body);


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

        public IActionResult IOT()
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




