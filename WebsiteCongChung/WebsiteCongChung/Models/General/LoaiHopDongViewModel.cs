using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebsiteCongChung.Models.General
{
    public class LoaiHopDongViewModel
    {
        public string Id { get; set; }
        public string ParentId { get; set; }
        public string Name { get; set; }
        public string ImageURL { get; set; }

        public LoaiHopDongViewModel() { }
        public LoaiHopDongViewModel(string id, string parentId, string name, string url)
        {
            Id = id;
            ParentId = parentId;
            Name = name;
            ImageURL = url;
        }
        public static IList<LoaiHopDongViewModel> Samples
        {
            get
            {
                return new List<LoaiHopDongViewModel>() {
                    new LoaiHopDongViewModel("1", "", "Nhà Đất", "../../assets/pages/img/templates/house.png"),
                    new LoaiHopDongViewModel("1.1", "1","Nhà", "../../assets/pages/img/templates/house.png"),
                    new LoaiHopDongViewModel("1.2", "1","Đất", "../../assets/pages/img/templates/land.png"),
                    new LoaiHopDongViewModel("1.3", "1", "Chung Cư","../../assets/pages/img/templates/office.png"),
                    new LoaiHopDongViewModel("1.1.1", "1.1", "Mua Bán","../../assets/pages/img/templates/money.png"),
                    new LoaiHopDongViewModel("1.1.2", "1.1", "Tặng Cho","../../assets/pages/img/templates/money.png"),
                    new LoaiHopDongViewModel("1.1.1.1", "1.1.1", "Sổ Hồng Sau Năm 2009",""),
                    new LoaiHopDongViewModel("1.1.1.2", "1.1.1", "Sổ Hồng Trước Năm 2009",""),
                    new LoaiHopDongViewModel("1.1.1.1.1", "1.1.1.0", "MBN Toàn Bộ", "../../assets/pages/img/templates/mortgage.png"),
                    new LoaiHopDongViewModel("1.1.1.1.1", "1.1.1.1", "Một Phần Có Tách Thửa", ""),
                    new LoaiHopDongViewModel("1.1.1.1.2", "1.1.1.1", "Một Phần Thuộc Sở Hữu", ""),
                    new LoaiHopDongViewModel("1.1.1.2.1", "1.1.1.2", "Một Phần Có Tách Thửa", ""),
                    new LoaiHopDongViewModel("1.1.1.2.2", "1.1.1.2", "Một Phần Thuộc Sở Hữu", ""),
                    new LoaiHopDongViewModel("1.2.1", "1.2", "Mua Bán","muaban"),
                    new LoaiHopDongViewModel("1.2.2", "1.2", "Tặng Cho","tangcho"),
                    new LoaiHopDongViewModel("1.2.2.1", "1.2.1", "Sổ Hồng Sau Năm 2009",""),
                    new LoaiHopDongViewModel("1.2.2.2", "1.2.2", "Sổ Hồng Trước Năm 2009",""),
                    new LoaiHopDongViewModel("1.2.2.1.1", "1.2.1.1", "Một Phần Có Tách Thửa", ""),
                    new LoaiHopDongViewModel("1.2.2.1.2", "1.2.1.2", "Một Phần Thuộc Sở Hữu", ""),
                    new LoaiHopDongViewModel("1.2.2.2.1", "1.2.2.1", "Một Phần Có Tách Thửa", ""),
                    new LoaiHopDongViewModel("1.2.2.2.2", "1.2.2.2", "Một Phần Thuộc Sở Hữu", ""),
                    new LoaiHopDongViewModel("1.3.1", "1.3", "Thuê","../../assets/pages/img/templates/money.png"),
                    new LoaiHopDongViewModel("2", "","Thừa Kế", ""),
                    new LoaiHopDongViewModel("3", "", "Thuê",""),
                    new LoaiHopDongViewModel("4", "","Vay Tiền", ""),
                };
            }
        }
    }
}