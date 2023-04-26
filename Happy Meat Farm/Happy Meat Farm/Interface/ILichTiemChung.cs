using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Happy_Meat_Farm.Models;
using MongoDB.Driver;

namespace Happy_Meat_Farm.Interface
{
    public interface ILichTiemChung
    {
        IMongoCollection<LichTiemChung> lichtiemchungcollection { get; }
        IEnumerable<LichTiemChung> GetAllLichTiemChung();
        LichTiemChung GetLichTiemChungDetails(string Name);
        //NhanVien Authenticate(string TenTaiKhoan, string Passwork);
        void Create(LichTiemChung lichtiemchungData);
        void Update(string _id, LichTiemChung LichTiemChungData);
        void Delete(string Name);

    }
}
