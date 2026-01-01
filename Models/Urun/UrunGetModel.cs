namespace dotnet_store.Models;

public class UrunGetModel
{
    public int Id { get; set; }
    public string UrunAd { get; set; } = null!;
    public double Fiyat { get; set; }
    public string? Resim { get; set; }
    public bool Active { get; set; }
    public bool Anasayfa { get; set; }
    public string KategoriAdi { get; set; } = null!;
}