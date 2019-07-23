using PasgoWebAdmin.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PasgoWebAdmin.Models
{
    [Serializable]
    public class DoiTacRender
    {
        public DoiTacRender()
        {
            DiaChiChiTiet = new int[4] { 1, 1, 1, 1 };
            ToaDo = new float[2] { 0, 0 };
            KhoangGia = new int[2] { 0, 100000 };
            ThoiGianPhucVu = new int[4] { 8,12,13,22};
            ThongTinKhacs = new List<ThongTinKhac>();
            foreach(var i in DataConfig.ThongTinKhacs)
            {
                ThongTinKhacs.Add(new ThongTinKhac()
                {
                    MoTa = i,
                    TrangThai = false
                });
            }
            
        }
        [Display(Name = "Mã nhà hàng")]
        public string Ma { get; set; }
        [Display(Name ="Tên nhà hàng(đầy đủ)")]
        public string Ten { get; set; }
        [Display(Name = "Tên nhà hàng(thường gọi)")]
        public string TenPhoBien { get; set; }
        [Display(Name ="Địa chỉ hiển thị")]
        public string DiaChi { get; set; }
        [Display(Name = "Địa Chỉ Chi Tiết")]
        public int[] DiaChiChiTiet { get; set; }
        [Display(Name ="Gần địa danh")]
        public string GanDiaDanh { get; set; }
        [Display(Name = "Số điện thoại")]
        [DataType(DataType.PhoneNumber,ErrorMessage ="Bạn phải nhập đúng số điện thoại")]
        public string SoDienThoai { get; set; }
        [Display(Name ="Tọa độ")]
        public float[] ToaDo { get; set; }
        [Display(Name ="Loại hình ẩm thực")]
        public int LoaiHinhAmThuc { get; set; }
        [Display(Name = "Nguyên liệu chính")]
        public int NguyenLieuChinh { get; set; }
        [Display(Name = "Kiểu không gian,kiến trúc")]
        public int KhongGian { get; set; }
        [Display(Name ="Loại hình phục vụ")]
        public int LoaiHinhPhucVu { get; set; }
        [Display(Name ="Tổng sức chứa")]
        public int SucChua { get; set; }
        [Display(Name ="Khoảng giá")]
        public int[] KhoangGia { get; set; }
        [Display(Name ="Thời gian phục vụ")]
        public int[] ThoiGianPhucVu { get; set; }
        [Display(Name ="Món đặc trưng")]
        public string[] MonDacTrung { get; set; }
        [Display(Name ="Chủ Sở Hữu")]
        public string ChuSoHuu { get; set; }
        [Display(Name ="Độ uy tín")]
        public int DoUyTin { get; set; }
        [Display(Name ="Mô tả")]
        public string MotaChuSoHuu { get; set; }
        [Display(Name ="Đầu bếp")]
        public string DauBep { get; set; }
        [Display(Name ="Độ chuyên nghiệp")]
        public int DoChuyenNghiep { get; set; }
        [Display(Name ="Mô tả")]
        public string MoTaDauBep { get; set; }
        public List<ThongTinKhac> ThongTinKhacs { get; set; }
    }
}