using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Happy_Meat_Farm.Models
{
    [BsonIgnoreExtraElements]
    public class CaThe
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string _id { get; set; }
        public string MaCaThe { get; set; }
        public string DacDiem { get; set; }
        public string NgayTuoi { get; set; }
        public string MaBayDan { get; set; }
        
    }
}
