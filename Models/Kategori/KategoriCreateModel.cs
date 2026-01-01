using System.ComponentModel.DataAnnotations;

namespace dotnet_store.Models;

public class KategoriCreateModel
{
    [Required]
    [StringLength(30)]
    [Display(Name = "Kategori Adi")]
    public string KategoriAdi { get; set; } = null!;

    [Required]
    [StringLength(30)]
    [Display(Name = "Url")]
    public string Url { get; set; } = null!;
}