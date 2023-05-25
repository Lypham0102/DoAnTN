﻿using Happy_Meat_Farm.Interface;
using Happy_Meat_Farm.Models;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Happy_Meat_Farm.Controllers
{
    public class HienThiCanTiemChungController : Controller
    {
        private readonly ICaThe _CT;
        private readonly ILichTiemChung _LTC;

        public HienThiCanTiemChungController(ICaThe ct, ILichTiemChung ltc)
        {
            _CT = ct;
            _LTC = ltc;
        }

        public IActionResult HienThiCaTheCanTiemChung()
        {
            var cacCaThe = _CT.GetAllCaThe();
            var cacLichTiemChung = _LTC.GetAllLichTiemChung();

            // Lọc danh sách cá thể cần tiêm chủng
            var cacCaTheCanTiemChung = new List<(CaThe, string, int)>();
            int soLuongCaTheCanTiemChung = 0; // Biến đếm số cá thể cần tiêm chủng

            DateTime ngayHienTai = DateTime.Now;

            foreach (var caThe in cacCaThe)
            {
                int tuoiCuaCaThe = caThe.NgayTuoi;

                foreach (var tiemChung in cacLichTiemChung)
                {
                    int ngayTuoiTiem = tiemChung.NgayTuoiTiem;

                    // Lấy các cá thể có ngày tuổi gần bằng ngày tuổi tiêm (từ ngày hiện tại - 1 đến ngày hiện tại + 1)
                    if (tuoiCuaCaThe >= ngayTuoiTiem - 1 && tuoiCuaCaThe <= ngayTuoiTiem + 1)
                    {
                        cacCaTheCanTiemChung.Add((caThe, tiemChung.TenDotTiem, tiemChung.NgayTuoiTiem));
                        soLuongCaTheCanTiemChung++; // Tăng biến đếm khi tìm thấy cá thể cần tiêm chủng
                        break; // Thoát khỏi vòng lặp lịch tiêm chủng nếu tìm thấy cá thể cần tiêm chủng
                    }
                }
            }

            ViewBag.SoLuongCaTheCanTiemChung = soLuongCaTheCanTiemChung; // Truyền số lượng cá thể cần tiêm chủng vào ViewBag

            return View(cacCaTheCanTiemChung);
        }

    }
}