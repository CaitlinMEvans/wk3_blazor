namespace BlazingPizza2.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public List<Pizza> Pizzas { get; set; } = new();

        public decimal GetTotalPrice()
        {
            return Pizzas.Sum(p => p.GetTotalPrice());
        }

        public string GetFormattedTotalPrice()
        {
            return GetTotalPrice().ToString("0.00");
        }
    }
}