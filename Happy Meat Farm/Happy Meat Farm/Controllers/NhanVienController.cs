using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Happy_Meat_Farm.Interface;
using Happy_Meat_Farm.Models;
using Microsoft.AspNetCore.Http;
using Happy_Meat_Farm.Services;
using Happy_Meat_Farm.Data;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Configuration;
using Microsoft.Graph.Models;
using ClosedXML.Excel;


namespace Happy_Meat_Farm.Controllers
{
    public class NhanVienController : Controller
    {
        private readonly INhanVien _context;
        public readonly NhanVienServices nhanVienServices;
        public readonly IConfiguration _configuration;
        public readonly NhanVienDBContext nhanVienDBContext;

        public NhanVienController(INhanVien context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.GetAllNhanVien());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreatePost(NhanVien nhanvienData)
        {
            _context.Create(nhanvienData);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(string Name)
        {
            var md = _context.GetNhanVienDetails(Name);
            return View(md);
        }
        [HttpPost]
        public IActionResult EditPost(string _id, NhanVien nhanviendata)
        {
            _context.Update(_id, nhanviendata);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Details(string Name)
        {
            var md = _context.GetNhanVienDetails(Name);
            return View(md);
        }
        [HttpGet]
        public IActionResult Delete(string Name)
        {
            var md = _context.GetNhanVienDetails(Name);
            //return View(md);
            _context.Delete(Name);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult DeletePost(string Name)
        {
            _context.Delete(Name);
            return RedirectToAction("Index");
        }

        //public async Task<IActionResult> CountNhanVien()
        //{
        //    var count = await nhanVienDBContext.CountNhanVienAsync();
        //    return View(count);
        //}
        [HttpGet]
        public IActionResult Export()
        {
            var nhanViens = _context.GetAllNhanVien().ToList();
            var workbook = new XLWorkbook();
            var worksheet = workbook.Worksheets.Add("Danh sách nhân viên");
            worksheet.Cell(1, 1).Value = "Mã NV";
            worksheet.Cell(1, 2).Value = "Tên NV";
            worksheet.Cell(1, 3).Value = "CCCD";
            worksheet.Cell(1, 4).Value = "Số điện thoại";
            worksheet.Cell(1, 5).Value = "Địa chỉ";
            worksheet.Cell(1, 6).Value = "Mã NT";
            worksheet.Cell(1, 7).Value = "Chức vụ";
            worksheet.Cell(1, 8).Value = "Hệ số lương";
            worksheet.Cell(1, 9).Value = "Ngân hàng";
            worksheet.Cell(1, 10).Value = "Số tài khoản";
            worksheet.Cell(1, 11).Value = "ID Trang trại";

            for (int i = 0; i < nhanViens.Count; i++)
            {
                var nhanVien = nhanViens[i];
                worksheet.Cell(i + 2, 1).Value = nhanVien.MaNV;
                worksheet.Cell(i + 2, 2).Value = nhanVien.TenNV;
                worksheet.Cell(i + 2, 3).Value = nhanVien.CCCD;
                worksheet.Cell(i + 2, 4).Value = nhanVien.SDT;
                worksheet.Cell(i + 2, 5).Value = nhanVien.DiaChi;
                worksheet.Cell(i + 2, 6).Value = nhanVien.MaNT;
                worksheet.Cell(i + 2, 7).Value = nhanVien.ChucVu;
                worksheet.Cell(i + 2, 8).Value = nhanVien.HeSoLuong;
                worksheet.Cell(i + 2, 9).Value = nhanVien.NganHang;
                worksheet.Cell(i + 2, 10).Value = nhanVien.STK;
                worksheet.Cell(i + 2, 11).Value = nhanVien._idNongTrai;
            }

            using (var stream = new System.IO.MemoryStream())
            {
                workbook.SaveAs(stream);
                var content = stream.ToArray();
                return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "DanhSachNhanVien.xlsx");
            }
        }
    }
}
