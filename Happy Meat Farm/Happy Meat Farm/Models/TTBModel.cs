using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Happy_Meat_Farm.Models
{
    [BsonIgnoreExtraElements]
    public class TTBModel
	{
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string _id { get; set;  }
        public string TenTrangThietBi { get; set; }
        public string LoaiTrangThietBi { get; set; }
        public string KichThuoc { get; set; }
        public string ChatLieu { get; set; }
        public string NSX { get; set; }
        public string HanDung { get; set; }
        public string DonGia { get; set; }
        public string _idBayDan { get; set; }
    }
}

