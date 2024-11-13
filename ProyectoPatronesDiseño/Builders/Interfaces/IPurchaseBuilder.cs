using ProyectoPatronesDiseño.Models.Interface;

namespace ProyectoPatronesDiseño.Builders.Interfaces;

    public interface IPurchaseBuilder
    {
    void CreateOrder(IFood food);
    IEnumerable<IFood> GetOrder();


    }

