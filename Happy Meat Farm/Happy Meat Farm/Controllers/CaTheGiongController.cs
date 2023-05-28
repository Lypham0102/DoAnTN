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
using System.Globalization;

namespace Happy_Meat_Farm.Controllers
{
    public class CaTheGiongController : Controller
    {
        private readonly ICaTheGiong _context;
        private readonly ISanDe _sanDeContext;
        //public readonly CaTheGiongServices catheGiongServices;
        public readonly IConfiguration _configuration;
        public readonly CaTheGiongDBContext catheGiongDBContext;

        public CaTheGiongController(ICaTheGiong context, ISanDe sanDeContext)
        {
            _context = context;
            _sanDeContext = sanDeContext;
        }


        public IActionResult Index()
        {
            return View(_context.GetAllCaTheGiong());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreatePost(CaTheGiong cathegiongData)
        {
            _context.Create(cathegiongData);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(string Name)
        {
            var md = _context.GetCaTheGiongDetails(Name);
            return View(md);
        }
        [HttpPost]
        public IActionResult EditPost(string _id, CaTheGiong cathegiongdata)
        {
            _context.Update(_id, cathegiongdata);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Details(string Name)
        {
            var md = _context.GetCaTheGiongDetails(Name);
            return View(md);
        }
        [HttpGet]
        public IActionResult Delete(string Name)
        {
            var md = _context.GetCaTheGiongDetails(Name);
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
            var catheGiongs = _context.GetAllCaTheGiong().ToList();
            var workbook = new XLWorkbook();
            var worksheet = workbook.Worksheets.Add("Danh sách cá thể giống");
            worksheet.Cell(1, 1).Value = "Mã giống";
            worksheet.Cell(1, 2).Value = "Ngày nuôi";
            worksheet.Cell(1, 3).Value = "Ngày tuổi";
            worksheet.Cell(1, 4).Value = "Đặc điểm";
            worksheet.Cell(1, 5).Value = "Lần đẻ";
            worksheet.Cell(1, 6).Value = "Lịch sử phối";
            worksheet.Cell(1, 7).Value = "Vị trí chuồng";
            worksheet.Cell(1, 8).Value = "Tình trạng sức khỏe";
            worksheet.Cell(1, 9).Value = "Mã nông trại";

            for (int i = 0; i < catheGiongs.Count; i++)
            {
                var catheGiong = catheGiongs[i];
                worksheet.Cell(i + 2, 1).Value = catheGiong._id;
                worksheet.Cell(i + 2, 2).Value = catheGiong.NgayNuoi;
                worksheet.Cell(i + 2, 3).Value = catheGiong.NgayTuoi;
                worksheet.Cell(i + 2, 4).Value = catheGiong.DacDiem;
                worksheet.Cell(i + 2, 5).Value = catheGiong.LanDe;
                worksheet.Cell(i + 2, 6).Value = catheGiong.LichSuPhoi;
                worksheet.Cell(i + 2, 7).Value = catheGiong.ViTriChuong;
                worksheet.Cell(i + 2, 8).Value = catheGiong.TinhTrangSucKhoe;
                worksheet.Cell(i + 2, 9).Value = catheGiong._idNongTrai;
            }

            using (var stream = new System.IO.MemoryStream())
            {
                workbook.SaveAs(stream);
                var content = stream.ToArray();
                return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "DanhSachCaTheGiong.xlsx");
            }
        }
        [HttpPost]
        public IActionResult Phoi(string id)
        {
            var catheGiong = _context.GetCaTheGiongDetails(id);
            if (catheGiong != null)
            {
                DateTime now = DateTime.Now;
                int lichSuPhoi = 0;

                if (catheGiong.LichSuPhoi != null)
                {
                    lichSuPhoi = catheGiong.LichSuPhoi.Value;
                }

                lichSuPhoi++;
                catheGiong.LichSuPhoi = lichSuPhoi;
                catheGiong.TinhTrangSucKhoe = "Vừa phối " + now.ToString("dd/MM/yyyy");
                _context.Update(id, catheGiong);
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }
        [HttpPost]
        public IActionResult KhongDau(string id)
        {
            var catheGiong = _context.GetCaTheGiongDetails(id);
            if (catheGiong != null)
            {
                catheGiong.LichSuPhoi = 0;
                catheGiong.TinhTrangSucKhoe = "Tốt";
                _context.Update(id, catheGiong);
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        public IActionResult ThuThai(string id)
        {
            var catheGiong = _context.GetCaTheGiongDetails(id);
            if (catheGiong != null)
            {
                catheGiong.TinhTrangSucKhoe = "Mang thai";
                catheGiong.LichSuPhoi = 0;
                catheGiong.NgayThai = DateTime.Now;
                _context.Update(id, catheGiong);
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }
        [HttpGet]
        public IActionResult DuyetCacCaTheGiongMangThai()
        {
            var pregnantCaTheGiongs = _context.GetAllCaTheGiong().Where(c => c.TinhTrangSucKhoe == "Mang thai").ToList();
            foreach (var catheGiong in pregnantCaTheGiongs)
            {
                DateTime duDoanDe = catheGiong.NgayThai.AddDays(110);
                catheGiong.NgayDuDoanDe = duDoanDe;
                catheGiong.SoNgayConLai = (duDoanDe - DateTime.Now).Days;
            }
            return View(pregnantCaTheGiongs);
        }

        
    }
}
