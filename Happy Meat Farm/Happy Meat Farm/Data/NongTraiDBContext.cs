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
    public class NongTraiDBContext : INongTrai
    {
        public readonly IMongoDatabase _db;
        public readonly MongoClient _mongoClient;
        public readonly IMongoCollection<NongTrai> _NT;

        public NongTraiDBContext(IOptions<Settings> options)
        {
            var client = new MongoClient(options.Value.ConnectionString);
            _db = client.GetDatabase(options.Value.Database);

            _ = _db.GetCollection<NongTrai>("NongTrai");

        }
        public IMongoCollection<NongTrai> nongtraicollection =>
            _db.GetCollection<NongTrai>("NongTrai");

        public IEnumerable<NongTrai> GetAllNongTrai()
        {
            return nongtraicollection.Find(a => true).ToList();
        }
        public NongTrai GetNongTraiDetails(string Name)
        {
            var nongtraidetails = nongtraicollection.Find(m => m.TenNongTrai == Name).FirstOrDefault();
            return nongtraidetails;
        }

        public void Create(NongTrai nongtraiData)
        {
            nongtraicollection.InsertOne(nongtraiData);
        }
        public void Update(string _id, NongTrai nongtraiData)
        {
            var filter = Builders<NongTrai>.Filter.Eq(c => c._id, _id);
            var update = Builders<NongTrai>.Update
                .Set("TenNongTrai", nongtraiData.TenNongTrai)
                .Set("SoChuongNuoi", nongtraiData.SoChuongNuoi)
                .Set("DienTich", nongtraiData.DienTich)
                .Set("TenVatNuoi", nongtraiData.TenVatNuoi);
            nongtraicollection.UpdateOne(filter, update);
        }
        public void Delete(string Name)
        {
            var filter = Builders<NongTrai>.Filter.Eq(c => c.TenNongTrai, Name);
            nongtraicollection.DeleteOne(filter);
        }

    }
}

