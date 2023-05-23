using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System.Threading.Tasks;
using Happy_Meat_Farm.Interface;
using Happy_Meat_Farm.Models;
using System.Runtime.InteropServices;
using Microsoft.Graph.Models;

namespace Happy_Meat_Farm.Data
{

    public class ThucAnDBContext : IThucAn
    {
        public readonly IMongoDatabase mongoDatabase;
        public readonly MongoClient mongoClient;
        public readonly IMongoCollection<ThucAn> _collection;

        public ThucAnDBContext(IOptions<Settings> options)
        {
            var client = new MongoClient(options.Value.ConnectionString);
            mongoDatabase = client.GetDatabase(options.Value.Database);

            _collection = mongoDatabase.GetCollection<ThucAn>("ThucAn");
        }

        public IMongoCollection<ThucAn> ThucAnCollection =>
            mongoDatabase.GetCollection<ThucAn>("ThucAn");

        public IEnumerable<ThucAn> GetAllThucAn()
        {
            return ThucAnCollection.Find(a => true).ToList();
        }
        public ThucAn GetThucAnDetails(string Name)
        {
            var details = ThucAnCollection.Find(m => m._id == Name).FirstOrDefault();
            return details;
        }

        public void Create(ThucAn ThucAnData)
        {
            ThucAnCollection.InsertOne(ThucAnData);
        }
        public void Update(string _id, ThucAn ThucAnData)
        {
            var filter = Builders<ThucAn>.Filter.Eq(c => c._id, _id);
            var update = Builders<ThucAn>.Update
                .Set("TenHang", ThucAnData.TenHang)
                .Set("MaLoai", ThucAnData.MaLoai)
                .Set("KhoiLuongTinh", ThucAnData.KhoiLuongTinh)
                .Set("DoiTuong", ThucAnData.DoiTuong)
                .Set("DonGia", ThucAnData.DonGia)
                .Set("HanDung", ThucAnData.HanDung)
                .Set("SoLuong", ThucAnData.SoLuong)
                .Set("NgayTuoi", ThucAnData.NgayTuoi);


            ThucAnCollection.UpdateOne(filter, update);
        }


        public void Delete(string Name)
        {
            var filter = Builders<ThucAn>.Filter.Eq(c => c._id, Name);
            ThucAnCollection.DeleteOne(filter);
        }
    }
}