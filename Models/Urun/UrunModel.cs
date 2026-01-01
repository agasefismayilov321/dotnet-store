using System.ComponentModel.DataAnnotations;

namespace dotnet_store.Models;

public class UrunModel
{
    [Display(Name = "Urun adi")]
    [Required(ErrorMessage = "{0} girmelisiniz.")]
    [StringLength(50, ErrorMessage = "{0} icin {2}-{1} karakter araliginda deger girmelisiniz", MinimumLength = 10)]
    public string UrunAd { get; set; } = null!;

    [Display(Name = "Fiyat")]
    [Required(ErrorMessage = "{0} zorunlu.")]
    [Range(0,1000000,ErrorMessage = "{0} icin girdiginiz deger {1} ile {2} arasinda olmalidir.")]
    public double? Fiyat { get; set; }

    public IFormFile? Resim { get; set; }

    public string? Aciklama { get; set; }

    public bool Active { get; set; }

    public bool Anasayfa { get; set; }

    [Display(Name = "Kategori")]
    [Required(ErrorMessage = "{0} zorunlu.")]
    public int? KategoriId { get; set; }
}