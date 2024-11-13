using ProyectoPatronesDiseño.Builders.Interfaces;
using ProyectoPatronesDiseño.Models;
using ProyectoPatronesDiseño.Models.Interface;
using ProyectoPatronesDiseño.Repositorys;
using ProyectoPatronesDiseño.Repositorys.Interfaces;

namespace ProyectoPatronesDiseño.Builders;

internal class WingsBuilder : IFoodBuilder
{
    private readonly IRepository<Wings> _wingsRepository = new WingsRepository();   
    private readonly IFood _wings = new Wings();   
    public void AddIngredient(string ingredient)
    {
        _wingsRepository.AddIngredient(ingredient);
    }

    public IFood Build()
    {
        return _wings;
    }

    public IEnumerable<string> GetIngredients()
    {
       return  _wingsRepository.GetIngredientsList();  
    }

    public void ShowIngredients()
    {
        _wingsRepository.ShowIngredients();
    }
}
