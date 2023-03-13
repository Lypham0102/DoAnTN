using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Happy_Meat_Farm.Interface;
using Happy_Meat_Farm.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace Happy_Meat_Farm.Data
{
    public class NhanVienDBContext : INhanVien
    {
        public readonly IMongoDatabase _db;

        public NhanVienDBContext(IOptions<Settings> options)
        {
            var client = new MongoClient(options.Value.ConnectionString);
            _db = client.GetDatabase(options.Value.Database);

        }

        public IMongoCollection<NhanVien> nhanviencollection => 
            _db.GetCollection<NhanVien>("NhanVien");

        public IEnumerable<NhanVien> GetAllNhanVien()
        {
            return nhanviencollection.Find(a=>true).ToList();
        }
        public NhanVien GetNhanVienDetails(string Name)
        {
            var nhanviendetails = nhanviencollection.Find(a=>a.TenNV == Name).FirstOrDefault();
            return nhanviendetails;
        }

        public void Create(NhanVien nhanvienData)
        {
            nhanviencollection.InsertOne(nhanvienData);
        }
        public void Update(string _id, NhanVien nhanvienData)
        {
            var filter = Builders<NhanVien>.Filter.Eq(c => c._id, _id);
            var update = Builders<NhanVien>.Update
                .Set("Ten", nhanvienData.TenNV)
                .Set("CCCD", nhanvienData.CCCD)
                .Set("SDT", nhanvienData.SDT)
                .Set("DiaChi", nhanvienData.DiaChi);
            nhanviencollection.UpdateOne(filter, update);
        }

        public void Delete(string Name)
        {
            var filter = Builders<NhanVien>.Filter.Eq(c => c.TenNV, Name);
            nhanviencollection.DeleteOne(filter);
        }

    }
}
