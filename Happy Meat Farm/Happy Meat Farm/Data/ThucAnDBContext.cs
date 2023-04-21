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
        public readonly IMongoCollection<ThucAnModel> _collection;

        public ThucAnDBContext(IOptions<Settings> options)
        {
            var client = new MongoClient(options.Value.ConnectionString);
            mongoDatabase = client.GetDatabase(options.Value.Database);

            _collection = mongoDatabase.GetCollection<ThucAnModel>("ThucAn");
        }

        public IMongoCollection<ThucAnModel> ThucAnCollection =>
            mongoDatabase.GetCollection<ThucAnModel>("ThucAn");

        public IEnumerable<ThucAnModel> GetAllThucAn()
        {
            return ThucAnCollection.Find(a => true).ToList();
        }
        public ThucAnModel GetThucAnDetails(string Name)
        {
            var details = ThucAnCollection.Find(m => m.TenHang == Name).FirstOrDefault();
            return details;
        }

        public void Create(ThucAnModel ThucAnData)
        {
            ThucAnCollection.InsertOne(ThucAnData);
        }
        public void Update(string _id, ThucAnModel ThucAnData)
        {
            var filter = Builders<ThucAnModel>.Filter.Eq(c => c._id, _id);
            var update = Builders<ThucAnModel>.Update
                .Set("TenHang", ThucAnData.TenHang)
                .Set("MaLoai", ThucAnData.MaLoai)
                .Set("KhoiLuongTinh", ThucAnData.KhoiLuongTinh)
                .Set("DoiTuong", ThucAnData.DoiTuong)
                .Set("DonGia", ThucAnData.DonGia)
                .Set("HanDung", ThucAnData.HanDung)
                .Set("SoLuong", ThucAnData.SoLuong)
                .Set("_idNongTrai", ThucAnData._idNongTrai)
                .Set("_idKiemKe", ThucAnData._idKiemKe);


            ThucAnCollection.UpdateOne(filter, update);
        }


        public void Delete(string Name)
        {
            var filter = Builders<ThucAnModel>.Filter.Eq(c => c.TenHang, Name);
            ThucAnCollection.DeleteOne(filter);
        }
    }
}