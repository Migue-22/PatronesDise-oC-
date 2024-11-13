using ProyectoPatronesDiseño.Builders.Interfaces;
using ProyectoPatronesDiseño.Enums;
using ProyectoPatronesDiseño.Models.Interface;

namespace ProyectoPatronesDiseño.Factorys.Interfaces;
public interface IMealFactory
{
    IFoodBuilder CreateMeal(Food food);
}
