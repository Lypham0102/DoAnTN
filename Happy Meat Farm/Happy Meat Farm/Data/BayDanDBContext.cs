using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Happy_Meat_Farm.Interface;
using Happy_Meat_Farm.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Driver;
using Newtonsoft.Json;
using QRCoder;
using ZXing;
using ZXing.Common;

namespace Happy_Meat_Farm.Data
{
    public class BayDanDBContext : IBayDan
    {
     
        public readonly IMongoDatabase _db;

        public BayDanDBContext(IOptions<Settings> options)
        {
            var clinet = new MongoClient(options.Value.ConnectionString);
            _db = clinet.GetDatabase(options.Value.Database);
        }

        public IMongoCollection<BayDan> baydancollection =>
            _db.GetCollection<BayDan>("BayDan");

        public IMongoCollection<CaThe> cathebaydancollection =>
            _db.GetCollection<CaThe>("CaThe");

        public IEnumerable<BayDan> GetAllBayDan()
        {
            return baydancollection.Find(a => true).ToList();
        }

        public BayDan GetBayDanDetails(string Name)
        {
            var baydandetails = baydancollection.Find(m => m._id == Name).FirstOrDefault();
            return baydandetails;
        }
        public void Create(BayDan baydanData)
        {
            baydancollection.InsertOne(baydanData);
        }

        public void Update(string _id, BayDan baydanData)
        {
            var filter = Builders<BayDan>.Filter.Eq(c => c._id, _id);
            var update = Builders<BayDan>.Update
                .Set("Chuong", baydanData.Chuong);


            baydancollection.UpdateOne(filter, update);
        }

        public void Delete(string Name)
        {
            var filter = Builders<BayDan>.Filter.Eq(c => c._id, Name);
            baydancollection.DeleteOne(filter);
        }

        //public BayDan Inf(string Name)
        //{
        //    var baydancathe = baydancollection.Find(m => m.Chuong == Name).FirstOrDefault();
        //    return baydancathe;
        //}
        
        public IMongoCollection<CaThe> cathecollection =>
            _db.GetCollection<CaThe>("CaThe");
        public IEnumerable<CaThe> GetCaTheTheoBay(string Name)
        {

            //return cathecollection.Find(a => a.Chuong == Name).ToList();
            var caTheList = cathecollection.Find(a => a.Chuong == Name).ToList();

            foreach (var caThe in caTheList)
            {
                // Tính ngày tuổi của cá thể
                int tuoi = TinhNgayTuoi(caThe._id);

                // Cập nhật giá trị tuổi lên MongoDB
                CapNhatNgayTuoi(caThe._id, tuoi);

                // Gán giá trị tuổi cho thuộc tính trong đối tượng caThe (cá thể)
                caThe.NgayTuoi = tuoi;
            }

            return caTheList;
        }
        public CaThe GetCaTheDetails(string id)
        {
            var caTheDetails = cathecollection.Find(c => c._id == id).FirstOrDefault();
            return caTheDetails;
        }
        public int TinhNgayTuoi(string Name)
        {
            var caThe = cathecollection.Find(c => c._id == Name).FirstOrDefault();
            if (caThe == null)
            {
                // Xử lý khi không tìm thấy cá thể
                return -1;
            }

            TimeSpan ngayTuoi = DateTime.Now - caThe.NgayNuoi;
            return (int)ngayTuoi.TotalDays;
        }

        public void CapNhatNgayTuoi(string id, int tuoi)
        {
            var filter = Builders<CaThe>.Filter.Eq(c => c._id, id);
            var update = Builders<CaThe>.Update.Set(c => c.NgayTuoi, tuoi);
            cathecollection.UpdateOne(filter, update);
        }


    }
}

