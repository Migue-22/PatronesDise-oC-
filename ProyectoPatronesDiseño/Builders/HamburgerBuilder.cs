using ProyectoPatronesDiseño.Builders.Interfaces;
using ProyectoPatronesDiseño.Models;
using ProyectoPatronesDiseño.Models.Interface;
using ProyectoPatronesDiseño.Repositorys;
using ProyectoPatronesDiseño.Repositorys.Interfaces;

namespace ProyectoPatronesDiseño.Builders;

public class HamburgerBuilder : IFoodBuilder
{
    private readonly IRepository<Hamburger> _hamburgerRepository = new HamburgerRepository();
    private readonly IFood _hamburger = new Hamburger();
    public IFood Build()
    {
        return _hamburger;
    }
    public void AddIngredient(string ingredient)
    {
        _hamburgerRepository.AddIngredient(ingredient);
    }

    public void ShowIngredients()
    {
        _hamburgerRepository.ShowIngredients();
    }

    public IEnumerable<string> GetIngredients()
    {
        return _hamburgerRepository.GetIngredientsList();
    }

    
}
