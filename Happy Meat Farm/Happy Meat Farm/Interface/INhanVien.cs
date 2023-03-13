using System;
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

        void Create(NhanVien nhanvienData);
        void Update(string _id, NhanVien nhanvienData);
        void Delete(string Name);

    }
}
