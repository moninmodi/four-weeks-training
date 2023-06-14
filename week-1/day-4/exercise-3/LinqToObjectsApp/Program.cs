namespace LinqToObjectsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>
            {
                new Person { Name = "John", Age = 25, Country = "USA" },
                new Person { Name = "Jane", Age = 31, Country = "Canada" },
                new Person { Name = "Mark", Age = 28, Country = "USA" },
                new Person { Name = "Emily", Age = 22, Country = "Australia" }
            };
            var USA = people.Where(P => P.Country == "USA");
            Console.WriteLine("People from USA....");
            foreach (var person in USA)
            {
                Console.WriteLine(person.Name);
            }
            var age = people.Where(p => p.Age >= 30);
            Console.WriteLine("People with age above 30.....");
            foreach (var person in age)
            {
                Console.WriteLine(person.Name);
            }
            var name = people.OrderBy(p => p.Name);
            Console.WriteLine("Sorting by Name.....");
            foreach (var person in name)
            {
                    Console.WriteLine(person.Name);
            }
            Console.WriteLine("Name and Country of all people....");
            var project = people.Select(p => new { Name = p.Name, Country = p.Country }).ToList();
            foreach (var item in project)
            {
                Console.WriteLine($"Name: {item.Name}, Country: {item.Country}");
            }
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Country { get; set; }
    }
}