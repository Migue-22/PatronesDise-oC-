using ProyectoPatronesDiseño.Builders.Interfaces;
using ProyectoPatronesDiseño.Models;
using ProyectoPatronesDiseño.Models.Interface;

namespace ProyectoPatronesDiseño.Builders;

public class PurchaseBuilder : IPurchaseBuilder
{
    public PurchaseBuilder(IFood food)
    {
        CreateOrder(food);
    }
    private readonly Order _order = new Order();
    public void CreateOrder(IFood food)
    {
        _order.MealOrder.Add(food);
    }

    public IEnumerable<IFood> GetOrder()
    {
        return _order.MealOrder;
    }
}
