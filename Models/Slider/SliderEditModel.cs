namespace dotnet_store.Models;

public class SliderEditModel:SliderModel
{
    public int Id { get; set; }
    public string? ResimAdi { get; set; }
    public IFormFile? Resim { get; set; } = null!;
    public bool Aktiv { get; set; }
}