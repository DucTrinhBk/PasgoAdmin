using System.ComponentModel.DataAnnotations;

namespace PasgoWebAdmin.Models { 
    public class BaiVietRender
    {
        public string Id { get; set; }
        [Display(Name="Link bài viết")]
        public string Link { get; set; }
        [Display(Name ="Tiêu Đề Chi Nhánh")]
        public string TieuDe { get; set; }
        [Display(Name ="Giới thiệu")]
        public string GioiThieu { get; set; }
        public string LinkAnh { get; set; }
    }
}