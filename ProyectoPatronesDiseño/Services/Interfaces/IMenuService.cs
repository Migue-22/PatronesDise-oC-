﻿using ProyectoPatronesDiseño.Builders;
using ProyectoPatronesDiseño.Builders.Interfaces;
using ProyectoPatronesDiseño.Models.Interface;

namespace ProyectoPatronesDiseño.Services.Interfaces;

public interface IMenuService
{
    void MainMenu();
    void PizzaMenu(IFoodBuilder foodBuilder);
    void HamburgerMenu(IFoodBuilder foodBuilder);
    void HotDogMenu(IFoodBuilder foodBuilder);
    void WingsMenu(IFoodBuilder foodBuilder);
    void ViewOrder(IEnumerable<IFood> order);


}
