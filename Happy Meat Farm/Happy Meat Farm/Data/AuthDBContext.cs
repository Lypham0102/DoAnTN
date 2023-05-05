using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Happy_Meat_Farm.Interface;
using Happy_Meat_Farm.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.Graph.Models;
using MongoDB.Driver;

namespace Happy_Meat_Farm.Data
{
    public class AuthDBContext : IAuth
    {

        
        private readonly IMongoCollection<ChuTrai> _users;

        public AuthDBContext(IMongoDatabase database)
        {
            _users = database.GetCollection<ChuTrai>("ChuTrai");
        }

        public async Task<ChuTrai> GetUser(string username, string password)
        {
            var filter = Builders<ChuTrai>.Filter.Eq(u => u.Account, username) & Builders<ChuTrai>.Filter.Eq(u => u.Password, password);
            return await _users.Find(filter).FirstOrDefaultAsync();
        }
    

    }
}