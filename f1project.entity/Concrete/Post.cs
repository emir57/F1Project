using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using f1project.entity.Abstract;

namespace f1project.entity.Concrete
{
    public class Post : IEntity
    {
        [Key]
        public int PostId { get; set; }
        [Required]
        [StringLength(45,MinimumLength =3)]
        [Display(Name ="Haber Başlığı")]
        public string Title { get; set; }
        
        [StringLength(120)]
        [Display(Name ="Haber Başlık Resmi")]
        public string ImageTitleUrl { get; set; }
        [Required]
        [StringLength(50000,MinimumLength =5)]
        [Display(Name ="Haber İçeriği")]
        public string BodyText { get; set; }
        // [StringLength(120)]
        // [Display(Name ="Haber İçeriği Resmi 1(Zorunlu değil)")]
        // public string ImageUrl1 { get; set; }
        // [Display(Name ="Haber İçeriği Resmi 2(Zorunlu değil)")]
        // [StringLength(120)]
        // public string ImageUrl2 { get; set; }

        public DateTime SharingDateTime { get; set; }

        public List<PostTeam> PostsTeams { get; set; }
        public List<PostDriver> PostsDrivers { get; set; }
    }
}