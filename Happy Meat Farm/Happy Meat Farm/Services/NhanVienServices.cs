
using System;
using Happy_Meat_Farm.Interface;
using Happy_Meat_Farm.Models;

namespace Happy_Meat_Farm.Services
{
	public class NhanVienServices
	{
        private readonly INhanVien _context;

        public NhanVienServices(INhanVien context)
		{
            _context = context;
        }
        //public NhanVien Authenticate(string TenTaiKhoan, string Passwork)
        //{
        //    return _context.Authenticate(TenTaiKhoan, Passwork);
        //}
    }
}

