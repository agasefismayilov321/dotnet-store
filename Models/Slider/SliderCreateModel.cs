namespace dotnet_store.Models;

public class SliderCreateModel:SliderModel
{
    public IFormFile? Resim { get; set; } = null!;
    public bool Aktiv { get; set; }
}