using System.ComponentModel.DataAnnotations;

namespace f1project.webui.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage ="ad boş olamaz")]
        [Display(Name ="Ad")]
        [StringLength(50,ErrorMessage ="ad maksimum 50 karakter olabilir")]
        public string FirstName { get; set; }
        [Required(ErrorMessage ="soyad boş olamaz")]
        [Display(Name ="Soyad")]
        [StringLength(50,ErrorMessage ="soyad maksimum 50 karakter olabilir")]
        public string LastName { get; set; }
        [Required(ErrorMessage ="eposta boş olamaz")]
        [Display(Name ="Eposta")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required(ErrorMessage ="kullanıcı adı boş olamaz")]
        [Display(Name ="Kullanıcı Adı")]
        [StringLength(25,ErrorMessage ="kullanıcı adı maksimum 25 karakter olabilir")]
        public string UserName { get; set; }
        [Required(ErrorMessage ="şifre boş olamaz")]
        [Display(Name ="Şifre")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage ="şifre onayı boş olamaz")]
        [DataType(DataType.Password)]
        [Display(Name ="Şifre Tekrar")]
        [Compare("Password",ErrorMessage ="şifreler uyuşmuyor")]
        public string RePassword { get; set; }
        [Display(Name ="Haber bültenine abone olmak istiyorum")]
        public bool IsSubscribe { get; set; }
    }
}