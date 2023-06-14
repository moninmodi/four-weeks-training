namespace LinqFilterAndSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a list of Person objects
            // Use LINQ to filter and sort the list
            // Print the filtered and sorted list of people to the console
            List<Person> person = new List<Person>()
            {
                new Person{FirstName = "Monin", LastName="Modi",age=22},
                new Person{FirstName = "Shreyansh", LastName="Hurkat", age=22},
                new Person{FirstName = "Divyam", LastName="Akbari", age=1},
                new Person{FirstName="Mohit", LastName="Aggarwal", age=23}
            };
            var Older = person.Where(p => p.age >= 18);
            Console.WriteLine("Person of older age...");
            foreach(var p in Older) { Console.Write(p.FirstName, "  ");
                Console.WriteLine(p.LastName);
            };
            var sort = Older.OrderBy(p => p.LastName);
            foreach(var x in sort) { Console.WriteLine(x.FirstName);}
            var sort1 = Older.OrderBy(p => p.FirstName);
            foreach (var x in sort1) { Console.WriteLine(x.FirstName); }

        }
        internal class Person
        {
            public string FirstName;
            public string LastName;
            public int age;

        }
    }
}