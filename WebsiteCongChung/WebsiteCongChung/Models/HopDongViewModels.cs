using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Web;

namespace WebsiteCongChung.Models
{
    public class HopDongViewModel
    {
        public int Id { get; set; }
        public string SoHopDong { get; set; }
        public string SoCongChung { get; set; }
        public string MaLoaiHopDong { get; set; }
        public string HinhThucCongChung { get; set; }
        public string MaNguoiTao { get; set; }
        public string MaCongChungVien { get; set; }
        public string MaCongTacVien { get; set; }
        public string TrangThai { get; set; }
        public DateTime NgayTao { get; set; }
        public DateTime NgayDuyet { get; set; }
        public PhieuYeuCauViewModel PhieuYeuCau { get; set; }

        public HopDongViewModel()
        {
            MaLoaiHopDong = "Hợp đồng chuyển nhượng nhà đất";
        }
        public static HopDongViewModel Sample
        {
            get
            {
                return new HopDongViewModel
                {
                    Id = 1,
                    SoHopDong = "2019042300003",
                    SoCongChung = "",
                    MaLoaiHopDong = "Hợp đồng chuyển nhượng nhà đất",
                    MaNguoiTao = "",
                    HinhThucCongChung = "Trong văn phòng",
                    TrangThai = "Tạo mới",
                    PhieuYeuCau = new PhieuYeuCauViewModel
                    {
                        TenKH = "Phúc Anh",
                        CMND = "123456789",
                        HoKhau = "28 Nguyễn Thị Diệu",
                        NoiDungYeuCau = "Công chứng chuyển nhượng nhà đất"
                    }
                };
            }
        }
    }

    public class TaiSanViewModel
    {
        public string TenTaiSan;
    }

    public class PhieuYeuCauViewModel
    {
        public string TenKH { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string CMND { get; set; }
        public string HoKhau { get; set; }
        public string NoiDungYeuCau { get; set; }
        public string HoSoDinhKem { get; set; }
    }

    public class NoiDungHopDong
    {
        public string MaLoaiHopDong { get; set; }
        public string NoiDung { get; set; }
        private static string result = "";
        public static IList<NoiDungHopDong> Samples
        {
            get
            {
               if (string.IsNullOrEmpty(result))
               {
                    try
                    {
                        result = File.ReadAllText("C:\\Users\\Ju\\source\\repos\\WebsiteCongChung.git\\trunk\\WebsiteCongChung\\WebsiteCongChung\\Files\\Hop.txt");
                    }
                    catch(Exception ex) { }
                }
                
                
                return new List<NoiDungHopDong>() {
                    new NoiDungHopDong()
                    {
                        MaLoaiHopDong = "",
                        NoiDung = result
                    }
                };
            }
        }
    }
}