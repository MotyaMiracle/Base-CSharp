namespace TrainingBase
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] people = { "Tom", "Sam", "Mike", "Kate", "Bob" };

            // Пропускаем первые два элемента
            var result = people.Skip(2); // "Mike", "Kate", "Bob" 
            foreach (var person in result)
                Console.WriteLine(person);
            Console.WriteLine();
            // пропускаем последние два элемента
            var result2 = people.SkipLast(2); // "Tom", "Sam", "Mike"
            foreach (var person in result2)
                Console.WriteLine(person);
            Console.WriteLine();
            // пропускаем первые элементы, длина которых равна 3
            var result3 = people.SkipWhile(p => p.Length == 3); // "Mike", "Kate", "Bob"
            foreach (var person in result3)
                Console.WriteLine(person);
            Console.WriteLine();
            // извлекаем первые 3 элемента
            var result4 = people.Take(3); // "Tom", "Sam", "Mike"
            foreach (var person in result4)
                Console.WriteLine(person);
            Console.WriteLine();
            // извлекаем последние 3 элемента
            var result5 = people.TakeLast(3); // "Mike", "Kate", "Bob"
            foreach (var person in result5)
                Console.WriteLine(person);
            Console.WriteLine();
            // извлекаем первые элементы, длина которых равна 3
            var result6 = people.TakeWhile(p => p.Length == 3); // "Tom", "Sam"
            foreach (var person in result6)
                Console.WriteLine(person);
            Console.WriteLine();
            // пропускаем 3 элемента и выбираем 2 элемента
            string[] people2 = { "Tom", "Sam", "Mike", "Kate", "Bob", "Alice" };
            var result7 = people2.Skip(3).Take(2);    // "Kate", "Bob"
            foreach (var person in result7)
                Console.WriteLine(person);
            Console.WriteLine();
        }
    }
}