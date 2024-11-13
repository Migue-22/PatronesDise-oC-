using ProyectoPatronesDiseño.Models.Interface;

namespace ProyectoPatronesDiseño.Models;

public class Order
{
    public List<IFood> MealOrder { get; set; }

    public Order()
    {
        MealOrder = new List<IFood>();
    }

}
