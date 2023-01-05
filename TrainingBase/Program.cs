namespace TrainingBase
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 3, 12, 4, 10};
            var orderedNumbers = from i in numbers orderby i select i;
            foreach (int i in orderedNumbers)
                Console.WriteLine(i);
            Console.WriteLine();
            var orderedNumbers2 = numbers.OrderBy(i => i);
            foreach (int i in orderedNumbers2)
                Console.WriteLine(i);
            Console.WriteLine();

            string[] people = { "Tom", "Bob", "Sam" };
            var orderedPeople = from p in people orderby p select p;
            foreach (var p in orderedPeople)
                Console.WriteLine(p);
            Console.WriteLine();
            var orderedPeople2 = people.OrderBy(p => p);
            foreach (var p in orderedPeople2)
                Console.WriteLine(p);
            Console.WriteLine();

            var people2 = new List<Person>
            {
                new Person("Tom", 37),
                new Person("Sam", 28),
                new Person("Tom", 22),
                new Person("Bob", 41),
            };
            // с помощью оператора orderby
            var sortedPeople1 = from p in people2
                                orderby p.Name
                                select p;
            foreach (var p in sortedPeople1)
                Console.WriteLine($"{p.Name} - {p.Age}");
            Console.WriteLine();
            // с помощью метода OrderBy
            var sortedPeople2 = people2.OrderBy(p => p.Name);

            foreach (var p in sortedPeople2)
                Console.WriteLine($"{p.Name} - {p.Age}");
            Console.WriteLine();
            // с помощью оператора orderby descending
            var orderedNumbers3 = from i in numbers
                                 orderby i descending
                                 select i;
            foreach (int i in orderedNumbers3)
                Console.WriteLine(i);
            Console.WriteLine();
            // с помощью метода OrderByDescending
            var orderedNumbers4 = numbers.OrderByDescending(n => n);
            foreach (int i in orderedNumbers4)
                Console.WriteLine(i);
            Console.WriteLine();
            // с помощью оператора orderby
            var sortedPeople3 = from p in people2
                                orderby p.Name, p.Age
                                select p;
            foreach (var p in sortedPeople3)
                Console.WriteLine($"{p.Name} - {p.Age}");
            Console.WriteLine();
            // с помощью оператора orderby
            var sortedPeople4 = from p in people2
                                orderby p.Name, p.Age descending  // сортировка по возрасту по убыванию
                                select p;
            foreach (var p in sortedPeople4)
                Console.WriteLine($"{p.Name} - {p.Age}");
            Console.WriteLine();
            // с помощью метода ThenByDescending
            var sortedPeople5 = people2.OrderBy(p => p.Name).ThenByDescending(p => p.Age);
            foreach (var p in sortedPeople5)
                Console.WriteLine($"{p.Name} - {p.Age}");
            Console.WriteLine();

            string[] people3 = new[] { "Kate", "Tom", "Sam", "Mike", "Alice" };
            var sortedPeople = people3.OrderBy(p => p, new CustomStringComparer());

            foreach (var p in sortedPeople)
                Console.WriteLine(p);
        }
    }
}