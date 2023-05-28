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
    public class SanDeDBContext : ISanDe
    {
        public readonly IMongoDatabase _db;
        public readonly MongoClient _mongoClient;
        public readonly IMongoCollection<SanDe> _SD;

        public SanDeDBContext(IOptions<Settings> options)
        {
            var client = new MongoClient(options.Value.ConnectionString);
            _db = client.GetDatabase(options.Value.Database);

            _SD = _db.GetCollection<SanDe>("SanDe");

        }

        public IMongoCollection<SanDe> sandecollection =>
            _db.GetCollection<SanDe>("SanDe");

        public IEnumerable<SanDe> GetAllSanDe()
        {
            return sandecollection.Find(a => true).ToList();
        }
        public SanDe GetSanDeDetails(string Name)
        {
            var sandedetails = sandecollection.Find(m => m._id == Name).FirstOrDefault();
            return sandedetails;
        }

        public void Create(SanDe sandeData)
        {
            sandecollection.InsertOne(sandeData);
        }
        public void Update(string _id, SanDe sandeData)
        {
            var filter = Builders<SanDe>.Filter.Eq(c => c._id, _id);
            var update = Builders<SanDe>.Update
                .Set("SoSanDe", sandeData.SoSanDe)
                .Set("TrangThai", sandeData.TrangThai);
            sandecollection.UpdateOne(filter, update);
        }


        public void Delete(string Name)
        {
            var filter = Builders<SanDe>.Filter.Eq(c => c._id, Name);
            sandecollection.DeleteOne(filter);
        }
    }
}
