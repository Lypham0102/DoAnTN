using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Happy_Meat_Farm.Interface;
using Happy_Meat_Farm.Models;
using Microsoft.AspNetCore.Http;
using MongoDB.Bson;
using MongoDB.Driver;
using System.IO;
using ZXing;
using ZXing.Common;
using System.Drawing;
using System.Drawing.Imaging;
using Microsoft.Graph.Models;
using ZXing.QrCode;
using Twilio.TwiML.Voice;
using ZXing.ImageSharp;
using ZXing.SkiaSharp;
using SkiaSharp;
using System.Runtime.InteropServices;


namespace Happy_Meat_Farm.Controllers
{
    public class BayDanController: Controller
    {
        private readonly IBayDan _context;
        

        public BayDanController(IBayDan context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.GetAllBayDan());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreatePost(BayDan baydanData)
        {
            _context.Create(baydanData);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(string Name)
        {
            var md = _context.GetBayDanDetails(Name);
            return View(md);
        }
        [HttpPost]
        public IActionResult EditPost(string _id, BayDan baydandata)
        {
            _context.Update(_id, baydandata);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Details(string Name)
        {
            var md = _context.GetBayDanDetails(Name);
            return View(md);
        }
        [HttpGet]
        public IActionResult Delete(string Name)
        {
            var md = _context.GetBayDanDetails(Name);
            _context.Delete(Name);
            return RedirectToAction("Index");
            //return View(md);
        }
        [HttpPost]
        public IActionResult DeletePost(string Name)
        {
            _context.Delete(Name);
            return RedirectToAction("Index");
        }
        public IActionResult CaTheDetails(string id)
        {
            var caThe = _context.GetCaTheDetails(id);
            if (caThe == null)
            {
                // Xử lý khi không tìm thấy cá thể
                return NotFound();
            }
            return View(caThe);
        }

        public IActionResult Inf(string Name)
        {
            var md = _context.GetCaTheTheoBay(Name);
            return View(md);
        }

        public ActionResult QrCodeImage(string data)
        {
            // Kết hợp mã cá thể và đường dẫn trang chi tiết
            string detailUrl = "https://happymeatfarm.azurewebsites.net" + Url.Action("QRCheck", "CaThe", new { Name = data });

            // Tạo mã QR code từ đường dẫn trang chi tiết
            var writer = new BarcodeWriterPixelData()
            {
                Format = BarcodeFormat.QR_CODE,
                Options = new EncodingOptions
                {
                    Height = 100,
                    Width = 100
                }
            };

            var pixelData = writer.Write(detailUrl);

            // Chuyển đổi mã QR code thành byte array
            using (var bitmap = new SKBitmap(pixelData.Width, pixelData.Height, SKColorType.Rgba8888, SKAlphaType.Premul))
            using (var stream = new MemoryStream())
            {
                // Ghi dữ liệu vào bitmap
                var pixels = bitmap.GetPixels();
                Marshal.Copy(pixelData.Pixels, 0, pixels, pixelData.Pixels.Length);

                // Lưu bitmap dưới dạng byte array
                bitmap.Encode(stream, SKEncodedImageFormat.Png, 100);
                var bytes = stream.ToArray();

                // Trả về hình ảnh mã QR code dưới dạng byte array
                return File(bytes, "image/png");
            }
        }
    }
}

