using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;


namespace Happy_Meat_Farm.Models
{
    [BsonIgnoreExtraElements]
    public class NhanVien
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string _id { get; set; }
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public string CCCD { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }
        public string MaNT { get; set; }
        public string TenTaiKhoan { get; set; }
        public string Passwork { get; set; }
    }
}
