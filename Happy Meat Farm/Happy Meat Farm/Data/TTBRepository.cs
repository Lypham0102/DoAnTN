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
	public class TTBRepository : TTB_Interface
	{
        public readonly IMongoDatabase mongoDatabase;
        public readonly MongoClient mongoClient;
        public readonly IMongoCollection<TTBModel> _collection;

        public TTBRepository(IOptions<Settings> options)
        {
            var client = new MongoClient(options.Value.ConnectionString);
            mongoDatabase = client.GetDatabase(options.Value.Database);

            _collection = mongoDatabase.GetCollection<TTBModel>("TrangThietBi");
        }
        public IMongoCollection<TTBModel> TrangThietBiCollection =>
            mongoDatabase.GetCollection<TTBModel>("TrangThietBi");

        public IEnumerable<TTBModel> GetAllTrangThietBi()
        {
            return TrangThietBiCollection.Find(a => true).ToList();
        }

        public TTBModel GetTrangThietBiDetails(string Name)
        {
            var details = TrangThietBiCollection.Find(m => m.TenTrangThietBi == Name).FirstOrDefault();
            return details;
        }

        public void Create(TTBModel TrangThietBiData)
        {
            TrangThietBiCollection.InsertOne(TrangThietBiData);
        }
        public void Update(string _id, TTBModel TrangThietBiData)
        {
            var filter = Builders<TTBModel>.Filter.Eq(c => c._id, _id);
            var update = Builders<TTBModel>.Update
                .Set("TenTrangThietBi", TrangThietBiData.TenTrangThietBi)
                .Set("LoaiTrangThietBi", TrangThietBiData.LoaiTrangThietBi)
                .Set("KichThuoc", TrangThietBiData.KichThuoc)
                .Set("ChatLieu", TrangThietBiData.ChatLieu)
                .Set("NSX", TrangThietBiData.NSX)
                .Set("HanDung", TrangThietBiData.HanDung)
                .Set("DonGia", TrangThietBiData.DonGia);

            TrangThietBiCollection.UpdateOne(filter, update);
        }


        public void Delete(string Name)
        {
            var filter = Builders<TTBModel>.Filter.Eq(c => c.TenTrangThietBi, Name);
            TrangThietBiCollection.DeleteOne(filter);
        }

    }
}

