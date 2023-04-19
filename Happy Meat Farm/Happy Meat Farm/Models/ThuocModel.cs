using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Happy_Meat_Farm.Models
{
    [BsonIgnoreExtraElements]
    public class ThuocModel
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string _id { get; set; }
        public string TenThuoc { get; set; }
        public string NSX { get; set; }
        public string LoaiThuoc { get; set; }
        public string ChiDinh { get; set; }
        public string LieuLuong { get; set; }
        public string DungTich { get; set; }
        public string HanDung { get; set; }
        public string DonGia { get; set; }
        public string _idNongTrai { get; set; }
        public string _idKiemKe { get; set; }
        public string _idPhieuNhapThuoc { get; set; }
    }
}

