using System;
using Happy_Meat_Farm.Interface;
using Happy_Meat_Farm.Models;
using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace Happy_Meat_Farm.Data
{
    public class ChuTraiDBContext : IChuTrai
    {
        public readonly IMongoDatabase _db;
        public readonly MongoClient _mongoClient;
        public readonly IMongoCollection<ChuTrai> _CT;
        
        public ChuTraiDBContext(IOptions<Settings> options)
        {
            var client = new MongoClient(options.Value.ConnectionString);
            _db = client.GetDatabase(options.Value.Database);

            _CT = _db.GetCollection<ChuTrai>("ChuTrai");
            
        }

        public IMongoCollection<ChuTrai> chutraicollection =>
            _db.GetCollection<ChuTrai>("ChuTrai");

        public IEnumerable<ChuTrai> GetAllChuTrai()
        {
            return chutraicollection.Find(a => true).ToList();
        }
        public ChuTrai GetChuTraiDetails(string Name)
        {
            var chutraidetails = chutraicollection.Find(m => m._id == Name).FirstOrDefault();
            return chutraidetails;
        }

        public void Create(ChuTrai chutraiData)
        {
            chutraicollection.InsertOne(chutraiData);
        }
        public void Update(string _id, ChuTrai chutraiData)
        {
            var filter = Builders<ChuTrai>.Filter.Eq(c => c._id, _id);
            var update = Builders<ChuTrai>.Update
                .Set("TenChuTrai", chutraiData.TenChuTrai)
                .Set("CCCD", chutraiData.CCCD)
                .Set("Email", chutraiData.Email)
                .Set("DiaChi", chutraiData.DiaChi)
                .Set("SDT", chutraiData.SDT)
                .Set("Account", chutraiData.Account)
                .Set("Password", chutraiData.Password);

            chutraicollection.UpdateOne(filter, update);
        }

        


        public void Delete(string Name)
        {
            var filter = Builders<ChuTrai>.Filter.Eq(c => c._id, Name);
            chutraicollection.DeleteOne(filter);
        }

        public async Task<ChuTrai> GetChuTrai(string account, string password)
        {
            var filter = Builders<ChuTrai>.Filter.Eq(u => u.Account, account) & Builders<ChuTrai>.Filter.Eq(u => u.Password, password);
            return await _CT.Find(filter).FirstOrDefaultAsync();
        }

        public async Task<ChuTrai> GetChuTrai(string account)
        {
            var filter = Builders<ChuTrai>.Filter.Eq(u => u.Account, account);
            return await _CT.Find(filter).FirstOrDefaultAsync();
        }

        public async Task<ChuTrai> CreateChuTrai(ChuTrai chuTrai)
        {
            await _CT.InsertOneAsync(chuTrai);
            return chuTrai;
        }

        public async Task<ChuTrai> GetChuTraiByAccountAsync(string account)
        {
            var filter = Builders<ChuTrai>.Filter.Eq(x => x.Account, account);
            return await _CT.Find(filter).FirstOrDefaultAsync();
        }


    }
}

