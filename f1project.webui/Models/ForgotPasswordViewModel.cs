using System.ComponentModel.DataAnnotations;

namespace f1project.webui.Models
{
    public class ForgotPasswordEmailViewModel
    {
        [Required(ErrorMessage ="E-posta adresi boş olamaz")]
        [DataType(DataType.EmailAddress,ErrorMessage ="geçersiz eposta")]
        [Display(Name ="Eposta Adresi")]
        public string Email { get; set; }

        
    }
    public class ForgotPasswordViewModel
    {
        public string userId { get; set; }
        public string token { get; set; }
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