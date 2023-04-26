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

        
        private readonly IMongoCollection<NhanVien> _users;

        public AuthDBContext(IMongoDatabase database)
        {
            _users = database.GetCollection<NhanVien>("NhanVien");
        }

        public async Task<NhanVien> GetUser(string username, string password)
        {
            var filter = Builders<NhanVien>.Filter.Eq(u => u.TenTaiKhoan, username) & Builders<NhanVien>.Filter.Eq(u => u.Passwork, password);
            return await _users.Find(filter).FirstOrDefaultAsync();
        }
    

    }
}