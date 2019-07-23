using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PasgoWebAdmin.Models
{
    public class ThongTinKhac
    {
        public string MoTa { get; set; }
        
        public bool TrangThai { get; set; }
        public object ThongTinThem { get; set; }
    }
}