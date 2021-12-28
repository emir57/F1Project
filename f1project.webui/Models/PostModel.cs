using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using f1project.entity.Concrete;

namespace f1project.webui.Models
{
    public class PostModel
    {
        public int PostId { get; set; }
        [Required(ErrorMessage ="Haber başlığı boş olamaz")]
        [StringLength(45,MinimumLength =3,ErrorMessage ="Minimum 3 maksimum 45 karakter olabilir")]
        [Display(Name ="Haber Başlığı")]
        public string Title { get; set; }
        
        [StringLength(120)]
        [Display(Name ="Haber Başlık Resmi")]
        public string ImageTitleUrl { get; set; }
        [Required(ErrorMessage ="Haber içeriği boş olamaz")]
        [StringLength(50000,MinimumLength =5,ErrorMessage ="Minimum 5 maksimum 50000 karakter olabilir")]
        [Display(Name ="Haber İçeriği")]
        public string BodyText { get; set; }
        // [StringLength(120)]
        // [Display(Name ="Haber İçeriği Resmi 1(Zorunlu değil)")]
        // public string ImageUrl1 { get; set; }
        // [Display(Name ="Haber İçeriği Resmi 2(Zorunlu değil)")]
        // [StringLength(120)]
        // public string ImageUrl2 { get; set; }
        
        public List<F1Driver> SelectedDrivers { get; set; }
        public List<F1Team> SelectedTeams { get; set; }

        public List<FileModel> Images { get; set; }
    }
}