using Happy_Meat_Farm.Interface;
using Happy_Meat_Farm.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;

namespace Happy_Meat_Farm.Data
{
    public class LichTiemChungDBContext : ILichTiemChung
    {
        private readonly IMongoDatabase _db;
        private readonly IMongoCollection<LichTiemChung> _lichtiemchungcollection;
        private readonly ICaThe _catheContext;

        public LichTiemChungDBContext(IOptions<Settings> options, ICaThe catheContext)
        {
            var client = new MongoClient(options.Value.ConnectionString);
            _db = client.GetDatabase(options.Value.Database);
            _lichtiemchungcollection = _db.GetCollection<LichTiemChung>("LichTiemChung");
            _catheContext = catheContext;
        }

        public IEnumerable<LichTiemChung> GetAllLichTiemChung()
        {
            return _lichtiemchungcollection.Find(a => true).ToList();
        }

        public LichTiemChung GetLichTiemChungDetails(string Name)
        {
            var lichtiemchungdetails = _lichtiemchungcollection.Find(m => m._id == Name).FirstOrDefault();
            return lichtiemchungdetails;
        }

        public void Create(LichTiemChung lichtiemchungData)
        {
            _lichtiemchungcollection.InsertOne(lichtiemchungData);
        }

        public void Update(string _id, LichTiemChung lichtiemchungData)
        {
            var filter = Builders<LichTiemChung>.Filter.Eq(c => c._id, _id);
            var update = Builders<LichTiemChung>.Update
                .Set("TenDotTiem", lichtiemchungData.TenDotTiem)
                .Set("NgayTuoiTiem", lichtiemchungData.NgayTuoiTiem)
                .Set("LieuLuongTiem", lichtiemchungData.LieuLuongTiem);
            _lichtiemchungcollection.UpdateOne(filter, update);
        }

        public void Delete(string Name)
        {
            var filter = Builders<LichTiemChung>.Filter.Eq(c => c._id, Name);
            _lichtiemchungcollection.DeleteOne(filter);
        }

        public IEnumerable<CaThe> GetCaTheByMatchingNgayTuoiTiem()
        {
            var allCaThe = _catheContext.GetAllCaThe().ToList();
            var matchingCaTheList = new List<CaThe>();

            foreach (var caThe in allCaThe)
            {
                var matchingLichTiemChung = _lichtiemchungcollection.Find(ltc => ltc.NgayTuoiTiem == caThe.NgayTuoi).FirstOrDefault();
                if (matchingLichTiemChung != null)
                {
                    matchingCaTheList.Add(caThe);
                }
            }

            return matchingCaTheList;
        }

        public IMongoCollection<LichTiemChung> lichtiemchungcollection => _lichtiemchungcollection;


    }
}
