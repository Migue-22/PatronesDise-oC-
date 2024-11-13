using ProyectoPatronesDiseño.Models.Interface;

namespace ProyectoPatronesDiseño.Models;

public class Pizza : IFood
{
    public List<string> Ingredients { get; set; }
    public Pizza()
    {
        Ingredients = new List<string>(); 
    }
}
