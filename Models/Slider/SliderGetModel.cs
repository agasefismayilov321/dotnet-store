namespace dotnet_store.Models;

public class SliderGetModel:SliderModel
{
    public int Id { get; set; }
    public string Resim { get; set; } = null!;
    public bool Aktiv { get; set; }
}