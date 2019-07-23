using System.ComponentModel.DataAnnotations;

namespace PasgoWebAdmin.Models
{
    public class MonAnRender
    {
        public MonAnRender()
        {
            STT = 0;
            Ten = "Thịt trâu xào rau muống";
            Loai = "Đồ Ăn";
            Nhom = "Thịt trâu";
            QuiCach = "Đĩa";
            Gia = 120000;
            GiaMangVe = 100000;
        }
        public MonAnRender(int i)
        {
            STT = i;
            Ten = "Thịt trâu xào rau muống";
            Loai = "Đồ Ăn";
            Nhom = "Thịt trâu";
            QuiCach = "Đĩa";
            Gia = 120000;
            GiaMangVe = 100000;
        }
        public int STT { get; set; }
        [Display(Name = "Tên món ăn")]
        public string Ten { get; set; }
        [Display(Name = "Loại món")]
        public string Loai { get; set; }
        [Display(Name = "Nhóm món")]
        public string Nhom { get; set; }
        [Display(Name = "Quy Cách")]
        public string QuiCach { get; set; }
        [Display(Name ="Giá bán")]
        public int Gia { get; set; }
        [Display(Name = "Giá mang về")]
        public int GiaMangVe;
    }
}