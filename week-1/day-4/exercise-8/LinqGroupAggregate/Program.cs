namespace LinqGroupAggregate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a list of Product objects
            List<Product> products = new List<Product>
        {
            new Product { Name = "Laptop", Category = "Electronics", Price = 1200.00M },
            new Product { Name = "Smartphone", Category = "Electronics", Price = 800.00M },
            new Product { Name = "Headphones", Category = "Electronics", Price = 200.00M },
            new Product { Name = "Shirt", Category = "Clothing", Price = 30.00M },
            new Product { Name = "Jeans", Category = "Clothing", Price = 60.00M },
            new Product { Name = "Sneakers", Category = "Footwear", Price = 100.00M }
        };

            // Use LINQ to perform the following operations:
            // 1. Group products by category
            // 2. Count the number of products in each category
            // 3. Calculate the total price of products in each category
            // 4. Find the most expensive product in each category
            var gcategory = products.GroupBy(p => p.Category).ToList();
            foreach (var product in gcategory)
            {
                Console.WriteLine($"Category: {product.Key}");
                foreach (var item in product)
                {
                    Console.WriteLine($"- {item.Name}");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Number of products in each category.");
            foreach(var product in gcategory)
            {
                Console.WriteLine($"Category: {product.Key}");
                Console.WriteLine($"Number of Products - {product.Count()}");
                foreach(var item in product)
                {
                    Console.WriteLine($"- {item.Name}");
                }
                Console.WriteLine();
            }
            foreach(var product in gcategory)
            {
                Console.WriteLine($"Category: {product.Key}");
                Console.WriteLine($"Total price of products in each category - {product.Sum(p=>p.Price):C2}");
                Console.WriteLine($"Max price item in each category - {product.Max(p => p.Price)}");
                foreach(var item in product)
                {
                    Console.WriteLine($"-{item.Name}");
                }
                Console.WriteLine();
            }
        }
    }
}