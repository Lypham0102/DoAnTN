using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Happy_Meat_Farm.Models
{
    [BsonIgnoreExtraElements]
    public class ThucAnModel
	{
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string _id { get; set; }
        public string TenHang { get; set; }
        public string MaLoai { get; set; }
        public string KhoiLuongTinh { get; set; }
        public string DoiTuong { get; set; }
        public string DonGia { get; set; }
        public string HanDung { get; set; }
        public string SoLuong { get; set; }
        public string _idNongTrai { get; set; }
        public string _idKiemKe { get; set; }
    }
}

