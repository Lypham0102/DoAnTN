using Happy_Meat_Farm.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Happy_Meat_Farm.Data;
using Microsoft.Graph.Models;

namespace Happy_Meat_Farm.Interface
{
    
        public interface IAuth
        {
            Task<NhanVien> GetUser(string TenTaiKhoan, string Passwork);
        }
    
}
