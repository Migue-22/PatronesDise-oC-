namespace ProyectoPatronesDiseño.Repositorys.Interfaces;

public interface IRepository<T>
{
    public void AddIngredient(string ingredient);

    public IEnumerable<string> GetIngredientsList();

    void ShowIngredients();
}
