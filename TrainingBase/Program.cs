namespace TrainingBase
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Метод Aggregate
            int[] numbers = { 1, 2, 3, 4, 5 };
            int query = numbers.Aggregate((x, y) => x - y); // -13
            Console.WriteLine(query + "\n");

            query = numbers.Aggregate((x, y) => x + y);
            Console.WriteLine(query + "\n"); // 15

            string[] words = { "Gaudeamus", "igitur", "Juvenes", "dum", "sumus" };
            var sentence = words.Aggregate("Text:", (first, next) => $"{first} {next}");
            Console.WriteLine(sentence);  // Text: Gaudeamus igitur Juvenes dum sumus
            Console.WriteLine();
            // Получение размера выборки. Метод Count
            int size = numbers.Count();
            Console.WriteLine(size); // 5
            Console.WriteLine();
            // Получение суммы
            int[] numbers2 = { 1, 2, 3, 4, 10, 34, 55, 66, 77, 88 };
            int sum = numbers2.Sum(); // 340
            Console.WriteLine(sum);
            Console.WriteLine();
            // Если мы работаем со сложными объектами
            Person[] people = { new Person("Tom", 37), new Person("Sam", 28), new Person("Bob", 41) };
            int ageSum = people.Sum(p => p.Age);
            Console.WriteLine(ageSum);     // 106
            Console.WriteLine();
            // Максимальное, минимальное и среднее значения
            int[] numbers3 = { 1, 2, 3, 4, 10, 34, 55, 66, 77, 88 };
            int min = numbers3.Min();
            int max = numbers3.Max();
            double average = numbers3.Average();
            Console.WriteLine($"Min: {min}");           // Min: 1
            Console.WriteLine($"Max: {max}");           // Max: 88
            Console.WriteLine($"Average: {average}");   // Average: 34
            Console.WriteLine();
            // Если мы работаем со сложными объектами
            int minAge = people.Min(p => p.Age); // минимальный возраст
            int maxAge = people.Max(p => p.Age); // максимальный возраст
            double averageAge = people.Average(p => p.Age); //средний возраст

            Console.WriteLine($"Min Age: {minAge}");           // Min Age: 28
            Console.WriteLine($"Max Age: {maxAge}");           // Max Age: 41
            Console.WriteLine($"Average Age: {averageAge}");   // Average Age: 35,33
        }
    }
}