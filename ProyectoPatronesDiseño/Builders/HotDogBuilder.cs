using ProyectoPatronesDiseño.Builders.Interfaces;
using ProyectoPatronesDiseño.Models;
using ProyectoPatronesDiseño.Models.Interface;

namespace ProyectoPatronesDiseño.Builders;

public class HotDogBuilder : IFoodBuilder
{
    private readonly IFood _hotDog = new HotDog();
    public void AddIngredient(string ingredient)
    {
        _hotDog.Ingredients.Add(ingredient);
    }

    public IFood Build()
    {
        return _hotDog;
    }

    public IEnumerable<string> GetIngredients()
    {
        return _hotDog.Ingredients;
    }

    public void ShowIngredients()
    {
        foreach (string hotDogs in _hotDog.Ingredients)
        {
            Console.WriteLine($"El HotDog contiene {hotDogs}");
        }
    }
}
