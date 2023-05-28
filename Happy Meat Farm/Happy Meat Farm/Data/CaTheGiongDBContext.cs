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
    public class CaTheGiongDBContext : ICaTheGiong
    {
        public readonly IMongoDatabase _db;
        public readonly MongoClient _mongoClient;
        public readonly IMongoCollection<CaTheGiong> _CTG;

        public CaTheGiongDBContext(IOptions<Settings> options)
        {
            var client = new MongoClient(options.Value.ConnectionString);
            _db = client.GetDatabase(options.Value.Database);

            _CTG = _db.GetCollection<CaTheGiong>("CaTheGiong");

        }

        public IMongoCollection<CaTheGiong> cathegiongcollection =>
            _db.GetCollection<CaTheGiong>("CaTheGiong");

        public IEnumerable<CaTheGiong> GetAllCaTheGiong()
        {
            return cathegiongcollection.Find(a => true).ToList();
        }
        public CaTheGiong GetCaTheGiongDetails(string Name)
        {
            var cathegiongdetails = cathegiongcollection.Find(m => m._id == Name).FirstOrDefault();
            return cathegiongdetails;
        }

        public void Create(CaTheGiong cathegiongData)
        {
            cathegiongcollection.InsertOne(cathegiongData);
        }
        public void Update(string _id, CaTheGiong cathegiongData)
        {
            var filter = Builders<CaTheGiong>.Filter.Eq(c => c._id, _id);
            var update = Builders<CaTheGiong>.Update
                .Set("NgayNuoi", cathegiongData.NgayNuoi)
                .Set("DacDiem", cathegiongData.DacDiem)
                .Set("LanDe", cathegiongData.LanDe)
                .Set("LichSuPhoi", cathegiongData.LichSuPhoi)
                .Set("ViTriChuong", cathegiongData.ViTriChuong)
                .Set("TinhTrangSucKhoe", cathegiongData.TinhTrangSucKhoe)
                .Set("NgayThai", cathegiongData.NgayThai);
            cathegiongcollection.UpdateOne(filter, update);
        }
        public void Delete(string Name)
        {
            var filter = Builders<CaTheGiong>.Filter.Eq(c => c._id, Name);
            cathegiongcollection.DeleteOne(filter);
        }

        //đếm số lượng nhân viên
        public async Task<long> CountAllCaTheGiong()
        {
            var catheGiongCollection = _mongoClient.GetDatabase("TrangTrai").GetCollection<CaTheGiong>("CaTheGiong");
            return await catheGiongCollection.CountDocumentsAsync(new BsonDocument());
        }

    }
}
