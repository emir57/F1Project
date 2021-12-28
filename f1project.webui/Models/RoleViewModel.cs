using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using f1project.webui.Identity;

namespace f1project.webui.Models
{
    public class RoleViewModel
    {
        [Required(ErrorMessage ="Rol ismi boş olamaz")]
        [StringLength(20,ErrorMessage ="Rol ismi maksimum 20 karakter olabilir")]
        [Display(Name ="Rol ismi")]
        public string Name { get; set; }

        public IList<User> Users { get; set; }
    }
}