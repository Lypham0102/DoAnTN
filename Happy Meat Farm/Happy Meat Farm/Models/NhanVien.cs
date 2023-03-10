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
        [BsonRepresentation(BsonType.ObjectId)]
        public string MaNV { get; set; } = String.Empty;

        [BsonElement("tennv")]
        public string TenNV { get; set; } = String.Empty;
        [BsonElement("cccd")]
        public string CCCD { get; set; } = String.Empty;
        [BsonElement("sdt")]
        public string SDT { get; set; }
        [BsonElement("diachi")]
        public string DiaChi { get; set; } = String.Empty;
    }
}
