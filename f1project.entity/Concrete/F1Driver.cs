using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using f1project.entity.Abstract;

namespace f1project.entity.Concrete
{
    public class F1Driver : IEntity
    {
        [Key]
        public int DriverId { get; set; }
        [Required(ErrorMessage ="Sürücü adı boş olamaz")]
        [Display(Name ="Sürücü Adı")]
        public string DriverName { get; set; }

        [Required(ErrorMessage ="Sürücü soyadı boş olamaz")]
        [Display(Name ="Sürücü Soyadı")]
        public string DriverSurname { get; set; }

        [Required(ErrorMessage ="Sürücü numarası boş olamaz")]
        [Display(Name ="Sürücü Numarası")]
        public byte DriverNumber { get; set; }

        public F1Team Team { get; set; }
        [Required(ErrorMessage ="Sürücü takımı boş olamaz")]
        [Display(Name ="Sürücü Takımı")]
        public int TeamId { get; set; }

        [Required(ErrorMessage ="Sürücü doğum tarihi boş olamaz")]
        [Display(Name ="Sürücü doğum tarihi")]
        public DateTime DateOfBirth { get; set; }
        // [Required(ErrorMessage ="Sürücü fotoğrafı boş olamaz")]
        [StringLength(120)]
        [Display(Name ="Sürücü fotoğrafı")]
        public string DriverImageUrl { get; set; }

        public Country Country { get; set; }
        [Required(ErrorMessage ="Sürücü ülkesi boş olamaz")]
        [Display(Name ="Sürücü Ülkesi")]
        public int CountryId { get; set; }

        public List<PostDriver> PostsDrivers { get; set; }
    }
}