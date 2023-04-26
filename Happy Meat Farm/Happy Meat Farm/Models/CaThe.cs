using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Happy_Meat_Farm.Models
{
    [BsonIgnoreExtraElements]
    public class CaThe
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string _id { get; set; }
        public string DacDiem { get; set; }
        public int NgayTuoi { get; set; }
        public string Chuong { get; set; }
        public string CanNang { get; set; }
        public DateTime NgayNuoi { get; set; }
        public string TinhTrangSucKhoe { get; set; }
        public string _idNongTrai { get; set; }
        public string _idThucAn { get; set; }
        public string _idGiaiDoanNuoi { get; set; }

    }


}
