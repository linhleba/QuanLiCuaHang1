using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace QuanLiCuaHang.Models
{

    [Table("dbo.DONVITINH")]
    public class DVT
    {
        [Key]
        public int MaDVT { get; set; }
        public string TenDVT { get; set; }
  
    }
}