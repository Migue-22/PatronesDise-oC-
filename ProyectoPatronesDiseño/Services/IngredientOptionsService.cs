using ProyectoPatronesDiseño.Enums;
using ProyectoPatronesDiseño.Services.Interfaces;

namespace ProyectoPatronesDiseño.Services;

public class IngredientOptionsService : IIngredientOptionsService
{
    public void ShowOptions<T>() where T : Enum
    {
        
        Console.WriteLine("Introduce el Ingrediente que deseas agregar:");
        foreach (T ingredient in Enum.GetValues(typeof(T)))
        {
            Console.WriteLine($"{Convert.ToInt32(ingredient)}. {ingredient}");
        }
    }
    public string? GetIngredientSelected<T>() where T : Enum
    {
        if (int.TryParse(Console.ReadLine(), out int ingredientSelected) && Enum.IsDefined(typeof(T), ingredientSelected))
        {
            return ((T)(object)ingredientSelected).ToString();
        }
        else
        {
            Console.WriteLine("Selección inválida.");
            return null;
        }
    }
}
