﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Happy_Meat_Farm.Models;
using MongoDB.Driver;

namespace Happy_Meat_Farm.Interface
{
    public interface INhanVien
    {
        IMongoCollection<NhanVien> nhanviencollection { get; }
        IEnumerable<NhanVien> GetAllNhanVien();
        NhanVien GetNhanVienDetails(string Name);
        //NhanVien Authenticate(string TenTaiKhoan, string Passwork);
        void Create(NhanVien nhanvienData);
        void Update(string _id, NhanVien nhanvienData);
        void Delete(string Name);
        Task<NhanVien> GetNhanVienByAccountAsync(string account);

    }
}
