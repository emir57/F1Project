using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using f1project.entity.Abstract;

namespace f1project.entity.Concrete
{
    public class F1Team : IEntity
    {
        [Key]
        public int TeamId { get; set; }
        [Required(ErrorMessage ="Takım ismi boş olamaz")]
        [StringLength(30,ErrorMessage ="Takım ismi maksimum 30 karakter olabilir")]
        [Display(Name ="Takım İsmi")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Takım kurucusu boş olamaz")]
        [StringLength(50,ErrorMessage ="Takım kurucu ismi maksimum 30 karakter olabilir")]
        [Display(Name ="Takım Kurucusu")]
        public string Founder { get; set; }
        [Required(ErrorMessage ="Takım kuruluş tarihi boş olamaz")]
        [Display(Name="Takım Kuruluş Tarihi")]
        public DateTime FoundationYear { get; set; }
        [Required(ErrorMessage ="Takım patronu boş olamaz")]
        [StringLength(30,ErrorMessage ="Takım patronu maksimum 30 karakter olabilir")]
        [Display(Name ="Takım Patronu")]
        public string TeamBoss { get; set; }
        // [Required(ErrorMessage ="Takım resmi boş olamaz")]
        [StringLength(120)]
        [Display(Name ="Takım Resmi")]
        public string TeamImageUrl { get; set; }

        public List<F1Driver> Drivers { get; set; }

        public List<PostTeam> PostsTeams { get; set; }
    }
}