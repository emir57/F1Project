using System.ComponentModel.DataAnnotations;

namespace f1project.webui.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage ="Lütfen eposta adresinizi giriniz")]
        [DataType(DataType.EmailAddress)]
        [Display(Name ="Eposta Adresi")]
        public string Email { get; set; }
        [Required(ErrorMessage ="Lütfen şifrenizi giriniz")]
        [DataType(DataType.Password)]
        [Display(Name ="Şifre")]
        public string Password { get; set; }
    }
}