using System;
using System.ComponentModel.DataAnnotations;
using MongoDB.Bson.Serialization.Attributes;

namespace Happy_Meat_Farm.Models
{
    [BsonIgnoreExtraElements]
    public class ChuTrai
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string _id { get; set; }
        public string TenChuTrai { get; set; }
        public string GioiTinh { get; set; }
        public string CCCD { get; set; }
        public string Email { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
        [BsonElement("Account")]
        public string Account { get; set; }
        [BsonElement("Password")]
        public string Password { get; set; }
       
        [Compare("Password", ErrorMessage = "Mật khẩu không khớp.")]
        public string ConfirmPassword { get; set; }

    }
}

