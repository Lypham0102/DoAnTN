﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;


namespace Happy_Meat_Farm.Models
{
    [BsonIgnoreExtraElements]
    public class LichTiemChung
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string _id { get; set; }
        public string TenDotTiem  { get; set; }
        public string NgayTuoiTiem { get; set; }
        public string LieuLuongTiem { get; set; }
    }
}