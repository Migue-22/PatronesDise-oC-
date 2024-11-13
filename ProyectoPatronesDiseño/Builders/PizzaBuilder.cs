using ProyectoPatronesDiseño.Builders.Interfaces;
using ProyectoPatronesDiseño.Models;
using ProyectoPatronesDiseño.Models.Interface;

namespace ProyectoPatronesDiseño.Builders;

public class PizzaBuilder : IFoodBuilder
{
    private readonly IFood _pizza = new Pizza();
    public IFood Build()
    {
        return _pizza;
    }

    public void AddIngredient(string ingredient)
    {
        _pizza.Ingredients.Add(ingredient);
    }

    public void ShowIngredients()
    {
        foreach (string pizzas in _pizza.Ingredients)
        {
            Console.WriteLine($"La pizza contiene {pizzas}");
        }
    }

    public IEnumerable<string> GetIngredients()
    {
        return _pizza.Ingredients;
    }
}
