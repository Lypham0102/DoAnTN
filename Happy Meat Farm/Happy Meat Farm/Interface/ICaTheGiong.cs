using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Happy_Meat_Farm.Models;
using MongoDB.Driver;

namespace Happy_Meat_Farm.Interface
{
    public interface ICaTheGiong
    {
        IMongoCollection<CaTheGiong> cathegiongcollection { get; }
        IEnumerable<CaTheGiong> GetAllCaTheGiong();
        CaTheGiong GetCaTheGiongDetails(string Name);
        CaTheGiong GetCaTheGiongSanDe(string Name);
        //NhanVien Authenticate(string TenTaiKhoan, string Passwork);
        void Create(CaTheGiong cathegiongData);
        void Update(string _id, CaTheGiong cathegiongData);
        void UpdateViTriChuong(string _id, CaTheGiong cathegiongData);
        void Delete(string Name);

    }
}
