using System.ComponentModel.DataAnnotations;
using f1project.entity.Abstract;

namespace f1project.entity.Concrete
{
    public class Country : IEntity
    {
        [Key]
        public int CountryId { get; set; }
        [Required(ErrorMessage ="Ülke ismi boş olamaz")]
        [Display(Name ="Ülke İsmi")]
        [StringLength(60,ErrorMessage ="Ülke ismi maksimum 60 karakter olabilir")]
        public string CountryName { get; set; }
        // [Required(ErrorMessage ="Ülke resmi boş olamaz")]
        [Display(Name ="Ülke Resmi")]
        [StringLength(120)]
        public string CountryImageUrl { get; set; }
    }
}