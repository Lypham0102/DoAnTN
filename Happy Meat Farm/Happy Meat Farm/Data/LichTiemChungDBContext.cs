using Happy_Meat_Farm.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Happy_Meat_Farm.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using MongoDB.Bson;

namespace Happy_Meat_Farm.Data
{
    public class LichTiemChungDBContext : ILichTiemChung 
    {
        public readonly IMongoDatabase _db;
        public readonly MongoClient _mongoClient;

        public LichTiemChungDBContext(IOptions<Settings> options)
        {
            var client = new MongoClient(options.Value.ConnectionString);
            _db = client.GetDatabase(options.Value.Database);

        }
        public IMongoCollection<LichTiemChung> lichtiemchungcollection =>
            _db.GetCollection<LichTiemChung>("LichTiemChung");

        public IEnumerable<LichTiemChung> GetAllLichTiemChung()
        {
            return lichtiemchungcollection.Find(a => true).ToList();
        }
     
      
        public LichTiemChung GetLichTiemChungDetails(string Name)
        {
            var lichtiemchungdetails = lichtiemchungcollection.Find(m => m._id == Name).FirstOrDefault();
            return lichtiemchungdetails;
        }

        public void Create(LichTiemChung lichtiemchungData)
        {
            lichtiemchungcollection.InsertOne(lichtiemchungData);
        }
        public void Update(string _id, LichTiemChung lichtiemchungData)
        {
            var filter = Builders<LichTiemChung>.Filter.Eq(c => c._id, _id);
            var update = Builders<LichTiemChung>.Update
                .Set("TenDotTiem", lichtiemchungData.TenDotTiem)
                .Set("NgayTuoiTiem", lichtiemchungData.NgayTuoiTiem)
                .Set("LieuLuongTiem", lichtiemchungData.LieuLuongTiem);
            lichtiemchungcollection.UpdateOne(filter, update);
        }
        public void Delete(string Name)
        {
            var filter = Builders<LichTiemChung>.Filter.Eq(c => c._id, Name);
            lichtiemchungcollection.DeleteOne(filter);
        }
        


    }
}
