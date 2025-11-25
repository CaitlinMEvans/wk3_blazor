using BlazingPizza2.Models;

namespace BlazingPizza2.Services
{
    public class PizzaService
    {
        public List<PizzaSpecial> GetSpecials()
        {
            return new List<PizzaSpecial>
            {
                new PizzaSpecial
                {
                    Id = 1,
                    Name = "Cheese Pizza",
                    Description = "Classic cheese",
                    BasePrice = 9.99m,
                    ImageUrl = "img/cheese.jpg"
                },
                new PizzaSpecial
                {
                    Id = 2,
                    Name = "Pepperoni",
                    Description = "Spicy pepperoni",
                    BasePrice = 10.99m,
                    ImageUrl = "img/pep.jpg"
                },
                new PizzaSpecial
                {
                    Id = 3,
                    Name = "Veggie Special",
                    Description = "Garden fresh",
                    BasePrice = 10.99m,
                    ImageUrl = "img/veg.jpg"
                },
                new PizzaSpecial
                {
                    Id = 4,
                    Name = "Meat Lovers",
                    Description = "All the meats",
                    BasePrice = 12.99m,
                    ImageUrl = "img/sausage.jpg"
                },
                new PizzaSpecial
                {
                    Id = 5,
                    Name = "Hawaiian",
                    Description = "Ham and pineapple",
                    BasePrice = 11.99m,
                    ImageUrl = "img/hawiian.jpg"
                },
                new PizzaSpecial
                {
                    Id = 6,
                    Name = "BBQ Chicken",
                    Description = "Tangy BBQ sauce",
                    BasePrice = 11.99m,
                    ImageUrl = "img/bbq.jpg"
                }
            };
        }
    }
}