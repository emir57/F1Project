using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace f1project.webui.Identity
{
    public class User : IdentityUser
    {
        [Required]
        [StringLength(50,ErrorMessage ="isim maksimum 50 karakter olabilir")]
        public string FirstName { get; set; }
        [Required]
        [StringLength(50,ErrorMessage ="soyisim maksimum 50 karakter olabilir")]
        public string LastName { get; set; }
        
        [StringLength(200,ErrorMessage ="açıklama maksimum 200 karakter olabilir")]
        public string ProfileDescription { get; set; }

        public string ProfilePhoto { get; set; }

        public bool IsFirstLogin { get; set; }
        public bool IsSubscribe { get; set; }
    }
}