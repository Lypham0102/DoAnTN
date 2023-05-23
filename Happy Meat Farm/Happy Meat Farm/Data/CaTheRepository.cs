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
    public class CaTheRepository : ICaTheRepository
    {
        private readonly IMongoDatabase _database;

        public CaTheRepository(IMongoDatabase database)
        {
            _database = database;
        }

        public List<CaThe> GetAllCaThe()
        {
            // Implement your code to retrieve all CaThe entities from the database
            // and return the list of CaThe objects.
            // Example:
            // return _database.GetCollection<CaThe>("CaTheCollection").AsQueryable().ToList();
            return new List<CaThe>();
        }
    }
}

