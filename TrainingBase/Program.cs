namespace TrainingBase
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] soft = { "Microsoft", "Google", "Apple" };
            string[] hard = { "Apple", "IBM", "Samsung" };
            string[] soft2 = { "Microsoft", "Google", "Apple", "Microsoft", "Google" };

            var result = soft.Except(hard);
            foreach (string s in result)
                Console.WriteLine(s);
            Console.WriteLine();
            // пересечение последовательностей
            result = soft.Intersect(hard);
            foreach (string s in result)
                Console.WriteLine(s);
            Console.WriteLine();
            // удаление дублей
            result = soft2.Distinct();
            foreach (string s in result)
                Console.WriteLine(s);
            Console.WriteLine();
            // объединение последовательностей
            result = soft.Union(hard);
            foreach (string s in result)
                Console.WriteLine(s);
            Console.WriteLine();
            // объединение последовательностей при помощи Concat
            result = soft.Concat(hard);
            foreach (string s in result)
                Console.WriteLine(s);
            Console.WriteLine();


            Person[] students = { new Person("Tom"), new Person("Bob"), new Person("Sam") };
            Person[] employees = { new Person("Tom"), new Person("Bob"), new Person("Mike") };
            // объединение последовательностей
            var people = students.Union(employees);
            foreach (Person person in people)
                Console.WriteLine(person.Name);


        }
    }
}