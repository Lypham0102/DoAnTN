
using System;
using System.Threading.Tasks;
using Happy_Meat_Farm.Interface;
using Happy_Meat_Farm.Models;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Happy_Meat_Farm.Services
{
	public class NhanVienServices 
	{
        private readonly INhanVien _context;
        public readonly MongoClient _mongoClient;


        public NhanVienServices(INhanVien context)
		{
            _context = context;
        }
        //public async Task<long> CountAllNhanVien()
        //{
        //    var nhanVienCollection = _mongoClient.GetDatabase("TrangTrai").GetCollection<NhanVien>("NhanVien");
        //    return await nhanVienCollection.CountDocumentsAsync(new BsonDocument());
        //}

        //public NhanVien Authenticate(string TenTaiKhoan, string Passwork)
        //{
        //    return _context.Authenticate(TenTaiKhoan, Passwork);
        //}
    }
}

