using System;
using Happy_Meat_Farm.Models;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Happy_Meat_Farm.Interface
{
    public interface IChuTrai
    {
        IMongoCollection<ChuTrai> chutraicollection { get; }
        IEnumerable<ChuTrai> GetAllChuTrai();
        ChuTrai GetChuTraiDetails(string Name);
        //NhanVien Authenticate(string TenTaiKhoan, string Passwork);
        void Create(ChuTrai chutraiData);
        void Update(string _id, ChuTrai chutraiData);
        void Delete(string Name);
        Task<ChuTrai> GetChuTrai(string account, string password);
        Task<ChuTrai> GetChuTrai(string account);
        Task<ChuTrai> CreateChuTrai(ChuTrai chuTrai);
        Task<ChuTrai> GetChuTraiByAccountAsync(string account);
        //Task<List<NongTrai>> GetNongTraiByChuTraiIdAsync(string chuTraiId);

    }
}

