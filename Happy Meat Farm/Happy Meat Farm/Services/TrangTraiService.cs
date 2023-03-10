using Happy_Meat_Farm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace Happy_Meat_Farm.Services
{
    public class TrangTraiService : myTrangTraiService
    {
        private readonly IMongoCollection<NhanVien> _nhanvien;

        public TrangTraiService(myTrangTraiDataSettings settings, IMongoClient mongoClient)
        {
            var database = mongoClient.GetDatabase(settings.Databasename);
            _nhanvien = database.GetCollection<NhanVien>(settings.NhanVienCollectionName);
        }
        public NhanVien Create(NhanVien nhanvien)
        {
            _nhanvien.InsertOne(nhanvien);
            return nhanvien;
        }

        public List<NhanVien> Get()
        {
            return _nhanvien.Find(nhanvien => true).ToList();

        }

        public NhanVien Get(string id)
        {
            return _nhanvien.Find(nhanvien => nhanvien.MaNV == id).FirstOrDefault();
        }

        public void Remove(string id)
        {
            _nhanvien.DeleteOne(nhanvien => nhanvien.MaNV == id);
        }

        public void Update(string id, NhanVien nhanvien)
        {
            _nhanvien.ReplaceOne(nhanvien => nhanvien.MaNV == id, nhanvien);
        }
    }
}
