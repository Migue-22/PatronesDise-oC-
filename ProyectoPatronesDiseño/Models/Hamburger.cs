using ProyectoPatronesDiseño.Models.Interface;

namespace ProyectoPatronesDiseño.Models;

public class Hamburger : IFood
{
    public List<string> Ingredients { get; set; }
}
