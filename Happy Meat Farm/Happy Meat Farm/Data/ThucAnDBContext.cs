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
    }
}