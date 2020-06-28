using QuanLiCuaHang.Areas.Manager.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLiCuaHang.Areas.Manager.Repository
{
    public class PhieuBanHangRepository
    {
        private QUANLYCUAHANGEntity objQUANLYCUAHANGEntity;

        public PhieuBanHangRepository()
        {
            objQUANLYCUAHANGEntity = new QUANLYCUAHANGEntity();

        }

        public IEnumerable<SelectListItem> GetPhieuBanHang()
        {
            IEnumerable<SelectListItem> objSelectListItem = new List<SelectListItem>();
            objSelectListItem = (from obj in objQUANLYCUAHANGEntity.PHIEUBANHANGs
                                 select new SelectListItem()
                                 {
                                     Text = obj.TenKH,
                                     Value = obj.MaPBH.ToString(),
                                     Selected = true

                                 }).ToList();
            return objSelectListItem;
        }
    }
}