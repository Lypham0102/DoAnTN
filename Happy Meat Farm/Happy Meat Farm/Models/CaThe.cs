using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Happy_Meat_Farm.Models
{
    [BsonIgnoreExtraElements]
    public class CaThe
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string _id { get; set; }
        public string DacDiem { get; set; }
        public string NgayTuoi { get; set; }
        public string MaChuong { get; set; }

    }


}
