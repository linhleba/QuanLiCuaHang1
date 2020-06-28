using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLiCuaHang.Areas.Manager.ViewModel
{
    public class PhieuMuaHangViewModel
    {
        public int MaPBH { get; set; }

        public int MaNCC { get; set; }

        public DateTime NgayLap { get; set; }

        public decimal TongTien { get; set; }

        public List<CT_PhieuMuaHangViewModel> DSChiTiet { get; set; }
    }
}