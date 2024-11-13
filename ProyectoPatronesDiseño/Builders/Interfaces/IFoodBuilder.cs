using ProyectoPatronesDiseño.Models.Interface;

namespace ProyectoPatronesDiseño.Builders.Interfaces;

public interface IFoodBuilder
{
    IFood Build();
    void AddIngredient(string ingredient);
    IEnumerable<string> GetIngredients();
    void ShowIngredients();
}
