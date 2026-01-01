using System.ComponentModel.DataAnnotations;

namespace dotnet_store.Models;

public class SliderModel
{
    [Display(Name = "Başlık")]
    [Required(ErrorMessage = "{0} girmelisiniz.")]
    [StringLength(50, ErrorMessage = "{0} icin {2}-{1} karakter araliginda deger girmelisiniz", MinimumLength = 10)]
    public string? Baslik { get; set; }

    [Display(Name = "Açıklama")]
    [Required(ErrorMessage = "{0} girmelisiniz.")]
    [StringLength(50, ErrorMessage = "{0} icin {2}-{1} karakter araliginda deger girmelisiniz", MinimumLength = 10)]
    public string? Aciklama { get; set; }


    [Display(Name = "İndex")]
    [Required(ErrorMessage = "{0} zorunlu.")]
    public int? Index { get; set; }
}