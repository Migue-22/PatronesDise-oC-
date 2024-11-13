using ProyectoPatronesDiseño.Builders;
using ProyectoPatronesDiseño.Builders.Interfaces;
using ProyectoPatronesDiseño.Enums;
using ProyectoPatronesDiseño.Factorys.Interfaces;

namespace ProyectoPatronesDiseño.Factorys;

public class MealFactory : IMealFactory
{
    public IFoodBuilder CreateMeal(Food food)
    {
        switch (food)
        {
            case Food.Pizza:
                return new PizzaBuilder();

            case Food.Hamburger:
                return new HamburgerBuilder();
            case Food.Hotdog:
                return new HotDogBuilder();
            case Food.Wings:
                return new WingsBuilder();

            default:
                throw new ArgumentException("Tipo de comida no soportado", nameof(food));
        }
    }
}

