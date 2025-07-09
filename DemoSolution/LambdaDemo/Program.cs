namespace LambdaDemo;

class Product
{
    public string Description { get; set; }
    public decimal Price { get; set; }
}

internal class Program
{
    static List<Product> _products = new List<Product>
    {
        new Product { Description = "Apple", Price = 0.60m },
        new Product { Description = "Banana", Price = 0.50m },
        new Product { Description = "Cherry", Price = 0.75m },
        new Product { Description = "Date", Price = 1.00m },
        new Product { Description = "Elderberry", Price = 1.50m },
        new Product { Description = "Fig", Price = 0.80m },
        new Product { Description = "Grape", Price = 0.90m },
        new Product { Description = "Koneydew", Price = 1.20m },
        new Product { Description = "Kiwi", Price = 1.10m },
        new Product { Description = "Lemon", Price = 0.70m },
        new Product { Description = "Mango", Price = 1.30m },
        new Product { Description = "Nectarine", Price = 1.40m },
        new Product { Description = "Orange", Price = 0.65m },
        new Product { Description = "Papaya", Price = 1.25m },
        new Product { Description = "Quince", Price = 1.60m },
        new Product { Description = "Raspberry", Price = 0.85m },
        new Product { Description = "Strawberry", Price = 0.95m },
        new Product { Description = "Tangerine", Price = 1.15m },
        new Product { Description = "Ugli fruit", Price = 1.45m },
        new Product { Description = "Vanilla bean", Price = 2.00m }
    };

    static void Main(string[] args)
    {
        PrintExpensiveProducts();
        Console.WriteLine("=========");
        PrintProductsStartingWithLetter('K');
        Console.WriteLine("=========");

        //Predicate<Product> filterExpensiveProducts = delegate (Product product)
        //{
        //    Console.WriteLine("checken op product " + product.Description);
        //    return product.Price > 1m;
        //};


        //_products.Where(x => x.Price > 50).
        // Java: x ->
        // JavaScript: x => 
        _products.Where(x => x.Description.StartsWith("D")).Select(x => new
        {
            Bla = x.Description
        }).OrderBy(x => x.Bla);
        // EF Core: database
        //modelBuilder.HasKey(x => new { x.ProductId, x > CategoryId })



        Predicate<Product> filterExpensiveProducts = p => p.Price > 1m;
        PrintProducts(p => p.Price > 1m);
    }

    // don't actually do this stuff. use .NET's built-in LINQ features.
    static void PrintProducts(Predicate<Product> filterding)
    {
        foreach (var product in _products)
        {
            if (filterding(product))
            {
                Console.WriteLine($"{product.Description} kost maar liefst {product.Price}");
            }
        }
    }

    static void PrintExpensiveProducts()
    {
        foreach (var product in _products)
        {
            if (product.Price > 1m)
            {
                Console.WriteLine($"{product.Description} kost maar liefst {product.Price}");
            }
        }
    }
    static void PrintProductsStartingWithLetter(char letter)
    {
        foreach (var product in _products)
        {
            if (product.Description.StartsWith(letter))
            {
                Console.WriteLine($"{product.Description} begint met een {letter}");
            }
        }
    }

}
