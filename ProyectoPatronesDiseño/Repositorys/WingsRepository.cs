using ProyectoPatronesDiseño.Repositorys.Interfaces;
using ProyectoPatronesDiseño.Models;

namespace ProyectoPatronesDiseño.Repositorys;

internal class WingsRepository : IRepository<Wings>
{
    private List<string> _ingredients = new List<string>();
    public void AddIngredient(string ingredient)
    {
        _ingredients.Add(ingredient);
    }

    public IEnumerable<string> GetIngredientsList()
    {
        return _ingredients;
    }

    public void ShowIngredients()
    {
        foreach (var ingredients in _ingredients)
        {
            Console.WriteLine($"Las Alitas contiene: {ingredients}");
        }
    }
}
