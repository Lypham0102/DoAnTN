using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;


namespace Happy_Meat_Farm.Models
{
    [BsonIgnoreExtraElements]
    public class CaTheGiong
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string _id { get; set; }
        public string NgayNuoi { get; set; }
        public string NgayTuoi { get; set; }
        public string DacDiem { get; set; }
        public string LanDe { get; set; }
        public string LichSuPhoi { get; set; }
        public string ViTriChuong { get; set; }
        public string TinhTrangSucKhoe { get; set; }
        public string _idNongTrai { get; set; }
    }
}
