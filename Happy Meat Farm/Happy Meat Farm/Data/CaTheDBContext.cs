using Happy_Meat_Farm.Interface;
using Happy_Meat_Farm.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Happy_Meat_Farm.Data
{
    //public class CaTheDBContext:ICaThe
    //{
    //    public readonly IMongoDatabase _db;

    //    public CaTheDBContext(IOptions<Settings> options)
    //    {
    //        var client = new MongoClient(options.Value.ConnectionString);
    //        _db = client.GetDatabase(options.Value.Database);

    //    }

    //    //public IMongoCollection<CaThe>GetCollection<CaThe>(string Name)
    //    //{
    //    //    return _db.GetCollection<CaThe>("CaThe");
    //    //}
        //public IMongoCollection<CaThe> Find(FilterDefinition<CaThe> filter)
        //{
        //    return _db.GetCollection<CaThe>("CaThe").Find(filter);
        //}


        //public IMongoCollection<CaThe> cathecollection =>
        //    _db.GetCollection<CaThe>("CaThe");

        //public IEnumerable<CaThe> GetAllCaThe()
        //{
        //    return cathecollection.Find(a => true).ToList();
        //}
        ////public CaThe GetCaTheDetails(string Name)
        ////{
        ////    var nhanviendetails = cathecollection.Find(m => m.MaCaThe == Name).FirstOrDefault();
        ////    return nhanviendetails;
        ////}

        //public void Create(CaThe catheData)
        //{
        //    cathecollection.InsertOne(catheData);
        //}
        //public void Update(string _id, CaThe catheData)
        //{
        //    var filter = Builders<CaThe>.Filter.Eq(c => c._id, _id);
        //    var update = Builders<CaThe>.Update
        //        .Set("MaCaThe", catheData.MaCaThe)
        //        .Set("DacDiem", catheData.DacDiem)
        //        .Set("NgayTuoi", catheData.NgayTuoi)
        //        .Set("MaBayDan", catheData.MaBayDan);
        //    cathecollection.UpdateOne(filter, update);
        //}

        //public void Delete(string Name)
        //{

        //    //var filter = Builders<NhanVien>.Filter.Eq(c => c.TenNV, Name);
        //    var filter = Builders<CaThe>.Filter.Eq(c => c.MaCaThe, Name);
        //    cathecollection.DeleteOne(filter);
        //}






    //}

}
