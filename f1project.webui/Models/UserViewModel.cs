using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace f1project.webui.Models
{
    public class UserViewModel
    {
        public string Id { get; set; }
        [Required]
        [Display(Name ="Ad")]
        [StringLength(50,ErrorMessage ="Ad maksimum 50 karakter olabilir")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name ="Soyad")]
        [StringLength(50,ErrorMessage ="Soyad maksimum 50 karakter olabilir")]
        public string LastName { get; set; }
        [Display(Name ="Profil Açıklaması")]
        [StringLength(200,ErrorMessage ="açıklama maksimum 200 karakter olabilir")]
        public string ProfileDescription { get; set; }

        [Required(ErrorMessage ="eposta boş olamaz")]
        [Display(Name ="Eposta")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public string ProfilePhoto { get; set; }

        public IEnumerable<string> UserRoles { get; set; }
        public List<IdentityRole> AllRoles { get; set; }

        public bool IsFirstLogin { get; set; }
        [Display(Name ="Abone mi")]
        public bool IsSubscribe { get; set; }
        [Display(Name ="E-posta Onayı")]
        public bool EmailConfirmed { get; set; }
    }
}