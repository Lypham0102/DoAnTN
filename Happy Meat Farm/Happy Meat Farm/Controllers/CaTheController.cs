using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Happy_Meat_Farm.Models;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using Microsoft.Extensions.Configuration;


namespace Happy_Meat_Farm.Controllers
{
    public class CaTheController : Controller
    {
        private IMongoCollection<CaThe> _collection;

        public CaTheController()
        {
            var client = new MongoClient("mongodb://localhost:5001");
            var database = client.GetDatabase("TrangTrai");
            _collection = database.GetCollection<CaThe>("CaThe");
        }

        public ActionResult BayDanShow(string maBayDan)
        {
            var caThes = _collection.Find(ct => ct.MaBayDan == maBayDan).ToList();
            return View(caThes);
        }
    }
}

