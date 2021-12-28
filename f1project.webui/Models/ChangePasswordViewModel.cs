using System.ComponentModel.DataAnnotations;

namespace f1project.webui.Models
{
    public class ChangePassWordViewModel
    {
        [Required(ErrorMessage ="Şifre boş olamaz")]
        [DataType(DataType.Password)]
        [Display(Name ="Eski Şifre")]
        public string OldPassword { get; set; }
        [Required(ErrorMessage ="Şifre boş olamaz")]
        [DataType(DataType.Password)]
        [Display(Name ="Şifre")]
        public string Password { get; set; }
        [Required(ErrorMessage ="Şifre tekrarı boş olamaz")]
        [DataType(DataType.Password)]
        [Display(Name ="Şifre Tekrar")]
        [Compare("Password",ErrorMessage ="Şifreler uyuşmuyor")]
        public string RePassword { get; set; }
    }
}