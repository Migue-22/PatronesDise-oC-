using ProyectoPatronesDiseño.Models.Interface;

namespace ProyectoPatronesDiseño.Models;

public class HotDog : IFood
{
    public List<string> Ingredients { get; set; }

    public HotDog()
    {
        Ingredients = new List<string>();
    }
}
