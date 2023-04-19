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
    }
}

