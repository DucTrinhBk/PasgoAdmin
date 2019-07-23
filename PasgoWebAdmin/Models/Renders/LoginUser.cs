
using System.ComponentModel.DataAnnotations;

namespace PasgoWebAdmin.Models
{
    public class LoginUser
    {
        [Required(ErrorMessage ="Yêu cầu nhập tên")]
        [Display(Name="Tên đăng nhập")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Yêu cầu nhập mật khẩu")]
        [Display(Name = "Mật khẩu")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}