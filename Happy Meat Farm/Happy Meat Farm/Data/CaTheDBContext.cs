using Happy_Meat_Farm.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Happy_Meat_Farm.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using MongoDB.Bson;
using Microsoft.AspNetCore.Mvc;
using QRCoder;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Web.Mvc;

namespace Happy_Meat_Farm.Data
{
    public class CaTheDBContext : ICaThe
    {
        public readonly IMongoDatabase _db;
        public readonly MongoClient _mongoClient;

        public CaTheDBContext(IOptions<Settings> options)
        {
            var client = new MongoClient(options.Value.ConnectionString);
            _db = client.GetDatabase(options.Value.Database);

        }
        public IMongoCollection<CaThe> cathecollection =>
            _db.GetCollection<CaThe>("CaThe");

        public IEnumerable<CaThe> GetAllCaThe()
        { 
            return cathecollection.Find(a=>true).ToList();
        }

        //Đếm cá thể
        

        public CaThe GetCaTheDetails(string Name)
        {
            var cathedetails = cathecollection.Find(m => m._id == Name).FirstOrDefault();
            return cathedetails;
        }

        public void Create(CaThe catheData)
        {
            cathecollection.InsertOne(catheData);
        }
        public void Update(string _id, CaThe catheData)
        {
            var filter = Builders<CaThe>.Filter.Eq(c => c._id, _id);
            var update = Builders<CaThe>.Update
                .Set("DacDiem", catheData.DacDiem)
                .Set("NgayTuoi", catheData.NgayTuoi)
                .Set("Chuong", catheData.Chuong)
                .Set("ThucAn", catheData.ThucAn)
                .Set("CanNang", catheData.CanNang)
                .Set("GiaBan", catheData.GiaBan)
                .Set("NgayBan", catheData.NgayBan)
                .Set("Thuoc", catheData.Thuoc);
            cathecollection.UpdateOne(filter, update);
        }
        public void Delete(string Name)
        {
            var filter = Builders<CaThe>.Filter.Eq(c => c._id, Name);
            cathecollection.DeleteOne(filter);
        }
        public IEnumerable<CaThe> GetCaTheTheoBay(string Name)
        {
           
            return cathecollection.Find(a => a.Chuong == Name).ToList();
        }

    }
}
