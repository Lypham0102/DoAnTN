using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Happy_Meat_Farm.Models;
using MongoDB.Driver;

namespace Happy_Meat_Farm.Interface
{
    public interface ISanDe
    {
        IMongoCollection<SanDe> sandecollection { get; }
        IEnumerable<SanDe> GetAllSanDe();
        SanDe GetSanDeDetails(string Name);
        IEnumerable<CaThe> GetCaTheTheoSan(string Name);
        //NhanVien Authenticate(string TenTaiKhoan, string Passwork);
        void Create(SanDe sandeData);
        void Update(string _id, SanDe sandeData);
        void Delete(string Name);

    }
}
