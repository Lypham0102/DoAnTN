using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Happy_Meat_Farm.Models
{
    [BsonIgnoreExtraElements]
    public class NongTrai    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string _id { get; set; }
        public string TenNongTrai { get; set; }
        public string DiaChi { get; set; }
        public string SoChuongNuoi { get; set; }
        public string TenVatNuoi { get; set; }
        public string DienTich { get; set; }
        public string _idChuTrai { get; set; }
    }
}

