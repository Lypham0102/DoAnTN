using System;
using Happy_Meat_Farm.Interface;
using Happy_Meat_Farm.Models;
using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace Happy_Meat_Farm.Data
{
    public class LichTiemChungRepository : ILichTiemChungRepository
    {
        private readonly IMongoDatabase _database;

        public LichTiemChungRepository(IMongoDatabase database)
        {
            _database = database;
        }

        public List<LichTiemChung> GetAllLichTiemChung()
        {
            // Implement your code to retrieve all LichTiemChung entities from the database
            // and return the list of LichTiemChung objects.
            // Example:
            // return _database.GetCollection<LichTiemChung>("LichTiemChungCollection").AsQueryable().ToList();
            return new List<LichTiemChung>();
        }
    }
}

