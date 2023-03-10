using Happy_Meat_Farm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Happy_Meat_Farm.Services
{
    public interface myTrangTraiService
    {
        List<NhanVien> Get();
        NhanVien Get(string id);
        NhanVien Create(NhanVien nhanvien);
        void Update(string id, NhanVien nhanvien);
        void Remove(string id);
    }
}
