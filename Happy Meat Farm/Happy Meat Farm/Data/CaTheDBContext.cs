using Happy_Meat_Farm.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Happy_Meat_Farm.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace Happy_Meat_Farm.Data
{
    public class CaTheDBContext : ICaThe
    {
        public readonly IMongoDatabase _db;

        public CaTheDBContext(IOptions<Settings> options)
        {
            var client = new MongoClient(options.Value.ConnectionString);
            _db = client.GetDatabase(options.Value.Database);

        }
        public IMongoCollection<CaThe> cathecollection =>
            _db.GetCollection<CaThe>("CaThe");

        public IEnumerable<CaThe> GetAllCaThe()
        {
            return cathecollection.Find(a=>true).ToList();
        }
        public CaThe GetCaTheDetails(string Name)
        {
            var cathedetails = cathecollection.Find(m => m._id == Name).FirstOrDefault();
            return cathedetails;
        }

        public void Create(CaThe catheData)
        {
            cathecollection.InsertOne(catheData);
        }
        public void Update(string _id, CaThe catheData)
        {
            var filter = Builders<CaThe>.Filter.Eq(c => c._id, _id);
            var update = Builders<CaThe>.Update
                .Set("DacDiem", catheData.DacDiem)
                .Set("NgayTuoi", catheData.NgayTuoi)
                .Set("MaChuong", catheData.MaChuong);
            cathecollection.UpdateOne(filter, update);
        }
        public void Delete(string Name)
        {
            var filter = Builders<CaThe>.Filter.Eq(c => c._id, Name);
            cathecollection.DeleteOne(filter);
        }
    }
}
