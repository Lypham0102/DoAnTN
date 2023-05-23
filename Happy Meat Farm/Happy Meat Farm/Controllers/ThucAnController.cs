using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Happy_Meat_Farm.Interface;
using Happy_Meat_Farm.Services;
using Happy_Meat_Farm.Models;
using Microsoft.Extensions.Configuration;
using ClosedXML.Excel;

namespace Happy_Meat_Farm.Controllers
{
    public class ThucAnController : Controller
    {
        public readonly IThucAn thucAn;
        // GET: /<controller>/

        public ThucAnController (IThucAn _thucAn)
        {
            thucAn = _thucAn;
        }

        public IActionResult Index()
        {
            return View(thucAn.GetAllThucAn());
            //return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreatePost(ThucAn ThucAnData)
        {
            thucAn.Create(ThucAnData);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Details(string Name)
        {
            var md = thucAn.GetThucAnDetails(Name);
            return View(md);
        }

        [HttpGet]
        public IActionResult Edit(string Name)
        {
            var md = thucAn.GetThucAnDetails(Name);
            return View(md);
        }
        [HttpPost]
        public IActionResult EditPost(string _id, ThucAn ThucAnData)
        {
            thucAn.Update(_id, ThucAnData);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Delete(string Name)
        {
            var md = thucAn.GetThucAnDetails(Name);
            //return View(md);
            thucAn.Delete(Name);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult DeletePost(string Name)
        {
            thucAn.Delete(Name);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Export()
        {
            var thucAns = thucAn.GetAllThucAn().ToList();
            var workbook = new XLWorkbook();
            var worksheet = workbook.Worksheets.Add("Danh sách thức ăn");
            worksheet.Cell(1, 1).Value = "Mã hàng";
            worksheet.Cell(1, 2).Value = "Tên NV";
            worksheet.Cell(1, 3).Value = "Mã loại";
            worksheet.Cell(1, 4).Value = "Khối lượng tịnh";
            worksheet.Cell(1, 5).Value = "Đối tượng";
            worksheet.Cell(1, 6).Value = "Đơn giá";
            worksheet.Cell(1, 7).Value = "Hạn dùng";
            worksheet.Cell(1, 8).Value = "Số lượng";
            worksheet.Cell(1, 9).Value = "Mã nông trại";
            worksheet.Cell(1, 10).Value = "Mã kiểm kê";
            worksheet.Cell(1, 11).Value = "Ngày tuổi";

            for (int i = 0; i < thucAns.Count; i++)
            {
                var thucAn = thucAns[i];
                worksheet.Cell(i + 2, 1).Value = thucAn._id;
                worksheet.Cell(i + 2, 2).Value = thucAn.TenHang;
                worksheet.Cell(i + 2, 3).Value = thucAn.MaLoai;
                worksheet.Cell(i + 2, 4).Value = thucAn.KhoiLuongTinh;
                worksheet.Cell(i + 2, 5).Value = thucAn.DoiTuong;
                worksheet.Cell(i + 2, 6).Value = thucAn.DonGia;
                worksheet.Cell(i + 2, 7).Value = thucAn.HanDung;
                worksheet.Cell(i + 2, 8).Value = thucAn.SoLuong;
                worksheet.Cell(i + 2, 9).Value = thucAn._idNongTrai;
                worksheet.Cell(i + 2, 10).Value = thucAn.NgayTuoi;

            }

            using (var stream = new System.IO.MemoryStream())
            {
                workbook.SaveAs(stream);
                var content = stream.ToArray();
                return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "DanhSachThucAn.xlsx");
            }
        }
    }
}

