using QuanLiCuaHang.Areas.Manager.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace QuanLiCuaHang.Areas.Manager.ViewModel
{
    public class PhieuBanHangViewModel
    {
       
        public int MaPBH { get; set; }

        public string TenKH { get; set; }

        public DateTime NgayLap { get; set; }

        public decimal TongTien { get; set; }

        public List<CT_PhieuBanHangViewModel> DSChiTiet { get; set; }
    }
}