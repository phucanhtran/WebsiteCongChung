using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebsiteCongChung.Models
{
    public class HopDongViewModel
    {
        public int Id { get; set; }
        public string SoHopDong { get; set; }
        public string SoCongChung { get; set; }
        public int MaLoaiHopDong { get; set; }
        public DateTime MaNguoiTao { get; set; }
        public string MaCongChungVien { get; set; }
        public string MaCongTacVien { get; set; }
        public string TrangThai { get; set; }
        public DateTime NgayTao { get; set; }
        public DateTime NgayDuyet { get; set; }
    }

    public class TaiSanViewModel
    {
        public string TenTaiSan;
    }

    public class PhieuYeuCauViewModel
    {
        public string TenKH { get; set; }
        public DateTime NgaySinh { get; set; }
        public string CMND { get; set; }
        public string HoKhau { get; set; }
        public string NoiDungYeuCau { get; set; }
        public string HoSoDinhKem { get; set; }
    }
}