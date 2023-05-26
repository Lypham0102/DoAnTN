using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Happy_Meat_Farm.Interface;
using Happy_Meat_Farm.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System.Runtime.InteropServices;
using Microsoft.Graph.Models;
using MongoDB.Bson;

namespace Happy_Meat_Farm.Data
{
    public class NhanVienDBContext : INhanVien  
    {
        public readonly IMongoDatabase _db;
        public readonly MongoClient _mongoClient;
        public readonly IMongoCollection<NhanVien> _NV;

        public NhanVienDBContext( IOptions<Settings> options)
        {
            var client = new MongoClient(options.Value.ConnectionString);
            _db = client.GetDatabase(options.Value.Database);

            _NV = _db.GetCollection<NhanVien>("NhanVien");

        }

        public IMongoCollection<NhanVien> nhanviencollection => 
            _db.GetCollection<NhanVien>("NhanVien");

        public IEnumerable<NhanVien> GetAllNhanVien()
        {
            return nhanviencollection.Find(a=>true).ToList();
        }
        public NhanVien GetNhanVienDetails(string Name)
        {
            var nhanviendetails = nhanviencollection.Find(m=>m.TenNV == Name).FirstOrDefault();
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
                .Set("MaNV", nhanvienData.MaNV)
                .Set("TenNV", nhanvienData.TenNV)
                .Set("CCCD", nhanvienData.CCCD)
                .Set("ChucVu", nhanvienData.ChucVu)
                .Set("SDT", nhanvienData.SDT)
                .Set("DiaChi", nhanvienData.DiaChi)
                .Set("MaNongTrai", nhanvienData.MaNT)
                .Set("TenTaiKhoan", nhanvienData.TenTaiKhoan)
                .Set("Passwork", nhanvienData.Passwork);

            nhanviencollection.UpdateOne(filter, update);
        }

        //GetUserByUsernameAsync
        public async Task<NhanVien> GetUserByUsernameAsync(string username)
        {
            var nhanVienCollection = _mongoClient.GetDatabase("YourDatabaseName").GetCollection<NhanVien>("nhanvien");
            var filter = Builders<NhanVien>.Filter.Eq("TenTaiKhoan", username);
            var result = await nhanVienCollection.Find(filter).FirstOrDefaultAsync();
            return result;
        }

        //AddUserAsync
        public async Task<bool> AddUserAsync(NhanVien user)
        {
            try
            {
                await _NV.InsertOneAsync(user);
                return true;
            }
            catch
            {
                return false;
            }
        }


        public void Delete(string Name)
        {
            var filter = Builders<NhanVien>.Filter.Eq(c => c.TenNV, Name);
            nhanviencollection.DeleteOne(filter);
        }

        //đếm số lượng nhân viên
        public async Task<long> CountAllNhanVien()
        {
            var nhanVienCollection = _mongoClient.GetDatabase("TrangTrai").GetCollection<NhanVien>("NhanVien");
            return await nhanVienCollection.CountDocumentsAsync(new BsonDocument());
        }

        public async Task<NhanVien> GetNhanVienByAccountAsync(string account)
        {
            var filter = Builders<NhanVien>.Filter.Eq(x => x.TenTaiKhoan, account);
            return await _NV.Find(filter).FirstOrDefaultAsync();
        }
    }
}
