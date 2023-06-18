using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Happy_Meat_Farm.Models;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using Microsoft.Extensions.Configuration;
using Happy_Meat_Farm.Interface;
using ZXing;
using System.Drawing;
using ZXing.QrCode;
using System.IO;
using System.Security.Cryptography;
using MongoDB.Bson;
using QRCoder;
using System.Drawing.Imaging;
using Microsoft.EntityFrameworkCore;

namespace Happy_Meat_Farm.Controllers
{
    public class CaTheController : Controller
    {
        private readonly ICaThe _context;
        private readonly IThucAn _ct;

        public CaTheController(ICaThe context, IThucAn ct)
        {
            _context = context;
            _ct = ct;
        }

        public IActionResult Index()
        {
            return View(_context.GetAllCaThe());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreatePost(CaThe catheData)
        {
            _context.Create(catheData);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(string Name)
        {
            var md = _context.GetCaTheDetails(Name);
            return View(md);
        }

        [HttpPost]
        public IActionResult EditPost(string _id, CaThe cathedata)
        {
            _context.Update(_id, cathedata);
            return RedirectToAction("Index");
        }

        [HttpGet]
        // Phương thức Details đã được cập nhật
        // Phương thức Details đã được cập nhật
        public IActionResult Details(string Name)
        {
            var caThe = _context.GetCaTheDetails(Name);

            // Lấy danh sách các đối tượng ThucAn từ cơ sở dữ liệu MongoDB
            List<ThucAn> danhSachThucAn = _ct.GetAllThucAn().ToList();

            // Tạo danh sách mới để lưu thông tin thức ăn của CaThe
            List<string> danhSachThucAnCaThe = new List<string>();

            // Duyệt qua từng đối tượng ThucAn
            foreach (var thucAn in danhSachThucAn)
            {
                // Kiểm tra nếu ngày tuổi của CaThe lớn hơn hoặc bằng ngày tuổi của ThucAn
                if (caThe.NgayTuoi >= thucAn.NgayTuoi)
                {
                    // Tạo chuỗi thông tin thức ăn
                    string thongTinThucAn = $"{thucAn.TenHang} - {thucAn.MaLoai}";

                    // Thêm thông tin thức ăn vào danh sách
                    danhSachThucAnCaThe.Add(thongTinThucAn);
                }
            }

            // Cập nhật thông tin thức ăn của CaThe
            caThe.ThucAn = string.Join(", ", danhSachThucAnCaThe);

            // Cập nhật thông tin của CaThe vào cơ sở dữ liệu
            _context.Update(caThe._id, caThe);

            return View(caThe);
        }
        public IActionResult QRCheck(string Name)
        {
            var caThe = _context.GetCaTheDetails(Name);

            // Lấy danh sách các đối tượng ThucAn từ cơ sở dữ liệu MongoDB
            List<ThucAn> danhSachThucAn = _ct.GetAllThucAn().ToList();

            // Tạo danh sách mới để lưu thông tin thức ăn của CaThe
            List<string> danhSachThucAnCaThe = new List<string>();

            // Duyệt qua từng đối tượng ThucAn
            foreach (var thucAn in danhSachThucAn)
            {
                // Kiểm tra nếu ngày tuổi của CaThe lớn hơn hoặc bằng ngày tuổi của ThucAn
                if (caThe.NgayTuoi >= thucAn.NgayTuoi)
                {
                    // Tạo chuỗi thông tin thức ăn
                    string thongTinThucAn = $"{thucAn.TenHang} - {thucAn.MaLoai}";

                    // Thêm thông tin thức ăn vào danh sách
                    danhSachThucAnCaThe.Add(thongTinThucAn);
                }
            }

            // Cập nhật thông tin thức ăn của CaThe
            caThe.ThucAn = string.Join(", ", danhSachThucAnCaThe);

            // Cập nhật thông tin của CaThe vào cơ sở dữ liệu
            _context.Update(caThe._id, caThe);

            return View(caThe);
        }




        [HttpPost]
        public IActionResult Delete(string _id)
        {
            var md = _context.GetCaTheDetails(_id);
            _context.Delete(_id);
            return View(md);
        }

        [HttpPost]
        public IActionResult DeletePost(string _id)
        {
            _context.Delete(_id);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Sell(string caTheId, string weight, string price)
        {
            var caThe = _context.GetCaTheDetails(caTheId);
            caThe.Chuong = "";
            // Lưu thông tin cân nặng và giá bán vào đối tượng "CaThe"
            caThe.CanNang = weight;
            caThe.GiaBan = price;
            caThe.NgayBan = DateTime.Now;
            _context.Update(caThe._id, caThe);
            string returnUrl = Request.Headers["Referer"].ToString();
            return Redirect(returnUrl);
        }
        public IActionResult DanhSachCaTheDaBan()
        {
            var caTheDaBan = _context.GetAllCaThe().Where(c => c.Chuong == "").ToList();

            return View(caTheDaBan);
        }

    }

}


