namespace ProyectoPatronesDiseño.Services.Interfaces;

internal interface IIngredientOptionsService
{
    void ShowOptions<T>() where T : Enum;

    string? GetIngredientSelected<T>() where T : Enum;
}
