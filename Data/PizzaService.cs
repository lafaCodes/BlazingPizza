// BlazingPizza/Data/PizzaService.cs

using System.Threading.Tasks;

namespace BlazingPizza.Data
{
    public class PizzaService
    {
        // Assume you have a real data source or service to obtain pizzas
        public Task<Pizza[]> GetPizzasAsync()
        {
            // Call your actual data access technology here
            // This is a placeholder for the actual implementation
            // For example, you could use Entity Framework to query a database
            // Or make an HTTP request to a web service
            // The specific implementation depends on your data source
            // For the sake of the example, let's return some dummy data
            return Task.FromResult(new[]
            {
                new Pizza
                {
                    PizzaId = 1,
                    Name = "Margherita",
                    Description = "Classic tomato and cheese",
                    Price = 8.99m,
                    Vegetarian = true,
                    Vegan = false
                },
                new Pizza
                {
                    PizzaId = 2,
                    Name = "Pepperoni",
                    Description = "Pepperoni and cheese",
                    Price = 9.99m,
                    Vegetarian = false,
                    Vegan = false
                },
                // Add more pizzas as needed
            });
        }
    }
}
