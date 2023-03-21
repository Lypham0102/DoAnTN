using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Happy_Meat_Farm.Models
{
    [BsonIgnoreExtraElements]
    public class BayDan
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        
        public string MaBayDan { get; set; }
        public string MaChuong { get; set; }
    }
    public class CaThe : BayDan
    {
        public string DacDiem { get; set; }
        public string NgayTuoi { get; set; }
    }
}

