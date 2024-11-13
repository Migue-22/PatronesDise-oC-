using ProyectoPatronesDiseño.Builders;
using ProyectoPatronesDiseño.Builders.Interfaces;
using ProyectoPatronesDiseño.Enums;
using ProyectoPatronesDiseño.Factorys;
using ProyectoPatronesDiseño.Services.Interfaces;

namespace ProyectoPatronesDiseño.Services;

public class MenuService : IMenuService
{
    MealFactory mealFactory = new MealFactory();

    public void MainMenu()
    {
        
        string OpcionInput;
        int Opcion = 0;
        IFoodBuilder foodBuilder;
        IEnumerable<string> ingredients = [];
        do
        {
            Console.WriteLine("Selecciona una opcion del menu: ");
            Console.WriteLine("1.Crear una Pizza\n2.Crear una Hamburguesa\n3.Crear HotDog\n4.Crear Alitas\n5.Mostrar Orden Creada\n6.Salir");
            OpcionInput = Console.ReadLine();
            
            int.TryParse(OpcionInput, out Opcion);
            switch (Opcion)
            {
                case 1:
                    foodBuilder = mealFactory.CreateMeal(Food.Pizza);
                    PizzaMenu(foodBuilder);
                    ingredients = foodBuilder.GetIngredients();
                    break;
                case 2:
                    foodBuilder = mealFactory.CreateMeal(Food.Hamburger);
                    HamburgerMenu(foodBuilder);
                    ingredients = foodBuilder.GetIngredients();
                    break;
                case 3:
                    foodBuilder = mealFactory.CreateMeal(Food.Hotdog);
                    HotDogMenu(foodBuilder);
                    ingredients = foodBuilder.GetIngredients();
                    break;
                case 4:
                    foodBuilder = mealFactory.CreateMeal(Food.Wings);
                    WingsMenu(foodBuilder);
                    ingredients = foodBuilder.GetIngredients();
                    break;
                case 5:
                    if (ingredients is null)
                    {
                        Console.WriteLine("Arma tu orden");
                        break;
                    }
                    ShowIngredients(ingredients);
                    break;
                default:
                    Console.WriteLine("Selecciona una opcion correcta");
                    break;
            }
            

        } while (Opcion != 6);
    }
    private void ShowIngredients(IEnumerable<string> ingredients)
    {
        foreach (string ingredient in ingredients)
        {
            Console.WriteLine($"La orden contiene {ingredient}");
        }
    }
    //Pizza
    public void PizzaMenu(IFoodBuilder foodBuilder)
    {
        IngredientOptionsService ingredientOptionsService = new();
        
        // Tipo de Masa
        ingredientOptionsService.ShowOptions<TypeDough>();
        var typeDough = ingredientOptionsService.GetIngredientSelected<TypeDough>();
        if (typeDough != null)
        {
            foodBuilder.AddIngredient(typeDough);
        }

        // Tipo de Queso
        ingredientOptionsService.ShowOptions<Cheeses>();
        var cheese = ingredientOptionsService.GetIngredientSelected<Cheeses>();
        if (cheese != null)
        {
            foodBuilder.AddIngredient(cheese);
        }

        // Ingrediente Principal
        ingredientOptionsService.ShowOptions<MainIngredient>();
        var mainIngredient = ingredientOptionsService.GetIngredientSelected<MainIngredient>();
        if (mainIngredient != null)
        {
            foodBuilder.AddIngredient(mainIngredient);
        }

        // Ingrediente Secundario
        ingredientOptionsService.ShowOptions<SecondaryIngredient>();
        var secondaryIngredient = ingredientOptionsService.GetIngredientSelected<SecondaryIngredient>();
        if (secondaryIngredient != null)
        {
            foodBuilder.AddIngredient(secondaryIngredient);
        }

        // Salsas
        ingredientOptionsService.ShowOptions<Dressings>();
        var dressing = ingredientOptionsService.GetIngredientSelected<Dressings>();
        if (dressing != null)
        {
            foodBuilder.AddIngredient(dressing);
        }

        Console.WriteLine("Resumen de orden:");
        foodBuilder.ShowIngredients();
    }
    //Hamburguesa
    public void HamburgerMenu(IFoodBuilder foodBuilder)
    {
        IngredientOptionsService ingredientOptionsService = new();

        // Tipo de Pan
        ingredientOptionsService.ShowOptions<TypeBread>();
        var hamburgerBunType = ingredientOptionsService.GetIngredientSelected<TypeBread>();
        if (hamburgerBunType != null)
        {
            foodBuilder.AddIngredient(hamburgerBunType);
        }

        // Tipo de Queso
        ingredientOptionsService.ShowOptions<Cheeses>();
        var cheese = ingredientOptionsService.GetIngredientSelected<Cheeses>();
        if (cheese != null)
        {
            foodBuilder.AddIngredient(cheese);
        }

        // Ingrediente Principal
        ingredientOptionsService.ShowOptions<MainIngredient>();
        var mainIngredient = ingredientOptionsService.GetIngredientSelected<MainIngredient>();
        if (mainIngredient != null)
        {
            foodBuilder.AddIngredient(mainIngredient);
        }

        // Ingrediente Secundario
        ingredientOptionsService.ShowOptions<SecondaryIngredient>();
        var secondaryIngredient = ingredientOptionsService.GetIngredientSelected<SecondaryIngredient>();
        if (secondaryIngredient != null)
        {
            foodBuilder.AddIngredient(secondaryIngredient);
        }

        // Salsas
        ingredientOptionsService.ShowOptions<Dressings>();
        var dressing = ingredientOptionsService.GetIngredientSelected<Dressings>();
        if (dressing != null)
        {
            foodBuilder.AddIngredient(dressing);
        }

        Console.WriteLine("Resumen de orden:");
        foodBuilder.ShowIngredients();
    }
    //HotDog
    public void HotDogMenu(IFoodBuilder foodBuilder)
    {
        IngredientOptionsService ingredientOptionsService = new();

        // Tipo de Pan
        ingredientOptionsService.ShowOptions<TypeBread>();
        var typeBread = ingredientOptionsService.GetIngredientSelected<TypeBread>();
        if (typeBread != null)
        {
            foodBuilder.AddIngredient(typeBread);
        }

        // Tipo de Queso
        ingredientOptionsService.ShowOptions<Cheeses>();
        var cheese = ingredientOptionsService.GetIngredientSelected<Cheeses>();
        if (cheese != null)
        {
            foodBuilder.AddIngredient(cheese);
        }

        // Ingrediente Principal
        ingredientOptionsService.ShowOptions<MainIngredient>();
        var mainIngredient = ingredientOptionsService.GetIngredientSelected<MainIngredient>();
        if (mainIngredient != null)
        {
            foodBuilder.AddIngredient(mainIngredient);
        }

        // Ingrediente Secundario
        ingredientOptionsService.ShowOptions<SecondaryIngredient>();
        var secondaryIngredient = ingredientOptionsService.GetIngredientSelected<SecondaryIngredient>();
        if (secondaryIngredient != null)
        {
            foodBuilder.AddIngredient(secondaryIngredient);
        }

        // Salsas
        ingredientOptionsService.ShowOptions<Dressings>();
        var dressing = ingredientOptionsService.GetIngredientSelected<Dressings>();
        if (dressing != null)
        {
            foodBuilder.AddIngredient(dressing);
        }

        Console.WriteLine("Resumen de orden:");
        foodBuilder.ShowIngredients();
    }
    //Alitas
    public void WingsMenu(IFoodBuilder foodBuilder)
    {
        IngredientOptionsService ingredientOptionsService = new();

        // Tamaño Orden
        ingredientOptionsService.ShowOptions<WingsOrderSize>();
        var wingsOrderSize = ingredientOptionsService.GetIngredientSelected<WingsOrderSize>();
        if (wingsOrderSize != null)
        {
            foodBuilder.AddIngredient(wingsOrderSize);
        }

        ingredientOptionsService.ShowOptions<SecondaryIngredient>();
        var secondaryIngredient = ingredientOptionsService.GetIngredientSelected<SecondaryIngredient>();
        if (secondaryIngredient != null)
        {
            foodBuilder.AddIngredient(secondaryIngredient);
        }

        // Salsas
        ingredientOptionsService.ShowOptions<Dressings>();
        var dressing = ingredientOptionsService.GetIngredientSelected<Dressings>();
        if (dressing != null)
        {
            foodBuilder.AddIngredient(dressing);
        }

        Console.WriteLine("Resumen de orden:");
        foodBuilder.ShowIngredients();
    }
}
