namespace TrainingBase
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] people = { "Tom", "Bob", "Sam", "Tim", "Thomas", "Bill" };

            // создаем новый список для результатов
            var selectedPeople = people.Where(p => p.Length == 3);

            foreach (string person in selectedPeople)
                Console.WriteLine(person);
            Console.WriteLine();
            // Аналогичный запрос с помощью операторов LINQ
            var selectedPeople1 = from p in people
                                 where p.Length == 3
                                 select p;
            foreach (string person in selectedPeople)
                Console.WriteLine(person);
            Console.WriteLine();

            int[] numbers = { 1, 2, 3, 4, 10, 34, 55, 66, 77, 88 };
            // методы расширения
            var evens1 = numbers.Where(i => i % 2 == 0 && i > 10);
            foreach (int even in evens1)
                Console.WriteLine(even);
            Console.WriteLine();
            // операторы запросов
            var evens2 = from i in numbers
                         where i % 2 == 0 && i > 10
                         select i;
            foreach (int even in evens2)
                Console.WriteLine(even);
            Console.WriteLine();

            var peopleList = new List<Person>
            {
                new Person("Tom", 23, new List<string>{"english", "german"}),
                new Person("Bob", 27, new List<string>{"english", "french"}),
                new Person("Sam", 29, new List<string>{"english", "spanish"}),
                new Person("Alice", 24, new List<string>{"spanish", "german"})
            };

            //var selectedPeopleList = from p in peopleList
            //where p.Age > 25
            //select p;
            // Аналогичный запрос с помощью метода расширения Where
            //var selectedPeopleList = peopleList.Where(p => p.Age > 25);
            var selectedPeopleList = peopleList.SelectMany(u => u.Languages, (u, l) => new { Person = u, Lang = l })
                .Where(u => u.Lang == "english" && u.Person.Age < 28)
                .Select(u => u.Person);
            foreach (Person person in selectedPeopleList)
                    Console.WriteLine($"{person.Name} - {person.Age}");
            Console.WriteLine();

            var peopleList2 = new List<Person>
            {
                new Student("Tom"),
                new Person("Sam"),
                new Student("Bob"),
                new Employee("Mike")

            };

            var students = peopleList2.OfType<Student>();
            foreach (var student in students)
                Console.WriteLine(student.Name);

        }
    }
}