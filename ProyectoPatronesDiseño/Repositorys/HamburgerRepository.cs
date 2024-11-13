using ProyectoPatronesDiseño.Models;
using ProyectoPatronesDiseño.Repositorys.Interfaces;

namespace ProyectoPatronesDiseño.Repositorys;

public class HamburgerRepository : IRepository<Hamburger>
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
            Console.WriteLine($"La Hamburguesa contiene: {ingredients}");
        }
    }
}
