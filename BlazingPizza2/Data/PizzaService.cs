namespace BlazingPizza.Data;
using BlazingPizza.Models;

public class PizzaService
{
    public static Pizza[] GetPizzas()
    {
        return new Pizza[]
        {
            new Pizza { Id = 1, Name = "Cheese Pizza", Description = "Classic cheese", Price = 9.99m, Vegetarian = true },
            new Pizza { Id = 2, Name = "Pepperoni", Description = "Spicy pepperoni", Price = 10.99m },
            new Pizza { Id = 3, Name = "Veggie Special", Description = "Garden fresh", Price = 10.99m, Vegetarian = true, Vegan = true },
            new Pizza { Id = 4, Name = "Meat Lovers", Description = "All the meats", Price = 12.99m },
            new Pizza { Id = 5, Name = "Hawaiian", Description = "Ham and pineapple", Price = 11.99m },
            new Pizza { Id = 6, Name = "BBQ Chicken", Description = "Tangy BBQ sauce", Price = 11.99m },
        };
    }
}