using System.ComponentModel.DataAnnotations;

namespace f1project.webui.Models
{
    public class ChangePofileViewModel
    {
        [Required(ErrorMessage ="ad alanı boş olamaz")]
        [Display(Name ="Ad")]
        [StringLength(50,ErrorMessage ="Ad maksimum 50 karakter olabilir")]
        public string FirstName { get; set; }
        [Required(ErrorMessage ="soyad alanı boş olamaz")]
        [Display(Name ="Soyad")]
        [StringLength(50,ErrorMessage ="soyad maksimum 50 karakter olabilir")]
        public string LastName { get; set; }
        [Display(Name ="Profil Açıklaması")]
        [StringLength(200,ErrorMessage ="açıklama maksimum 200 karakter olabilir")]
        public string ProfileDescription { get; set; }
    }
}