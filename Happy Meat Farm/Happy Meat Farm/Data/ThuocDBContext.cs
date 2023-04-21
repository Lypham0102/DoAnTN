﻿using System;
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
	public class ThuocDBContext : IThuoc
	{
        public readonly IMongoDatabase mongoDatabase;
        public readonly MongoClient mongoClient;
        public readonly IMongoCollection<ThuocModel> _collection;

        public ThuocDBContext(IOptions<Settings> options)
		{
            var client = new MongoClient(options.Value.ConnectionString);
            mongoDatabase = client.GetDatabase(options.Value.Database);

            _collection = mongoDatabase.GetCollection<ThuocModel>("Thuoc");
        }
        public IMongoCollection<ThuocModel> ThuocCollection =>
            mongoDatabase.GetCollection<ThuocModel>("Thuoc");

        public IEnumerable<ThuocModel> GetAllThuoc()
        {
            return ThuocCollection.Find(a => true).ToList();
        }
        public ThuocModel GetThuocDetails(string Name)
        {
            var details = ThuocCollection.Find(m => m.TenThuoc == Name).FirstOrDefault();
            return details;
        }

        public void Create(ThuocModel TrangThietBiData)
        {
            ThuocCollection.InsertOne(TrangThietBiData);
        }
        public void Update(string _id, ThuocModel TrangThietBiData)
        {
            var filter = Builders<ThuocModel>.Filter.Eq(c => c._id, _id);
            var update = Builders<ThuocModel>.Update
                .Set("TenTrangThietBi", TrangThietBiData.TenThuoc)
                .Set("LoaiTrangThietBi", TrangThietBiData.NSX)
                .Set("KichThuoc", TrangThietBiData.LoaiThuoc)
                .Set("ChatLieu", TrangThietBiData.ChiDinh)
                .Set("NSX", TrangThietBiData.LieuLuong)
                .Set("HanDung", TrangThietBiData.DungTich)
                .Set("DonGia", TrangThietBiData.HanDung)
                .Set("DonGia", TrangThietBiData.DonGia)
                .Set("DonGia", TrangThietBiData._idNongTrai)
                .Set("DonGia", TrangThietBiData._idKiemKe)
                .Set("DonGia", TrangThietBiData._idPhieuNhapThuoc);


            ThuocCollection.UpdateOne(filter, update);
        }


        public void Delete(string Name)
        {
            var filter = Builders<ThuocModel>.Filter.Eq(c => c.TenThuoc, Name);
            ThuocCollection.DeleteOne(filter);
        }

    }
}
