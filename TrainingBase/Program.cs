namespace TrainingBase
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] people = { "Tom", "Tim", "Bob", "Sam" };
            // проверяем, все ли элементы имеют длину в 3 символа
            bool allHas3Chars = people.All(s => s.Length == 3);     // true
            Console.WriteLine(allHas3Chars);
            // проверяем, все ли строки начинаются на T
            bool allStartsWithT = people.All(s => s.StartsWith("T"));   // false
            Console.WriteLine(allStartsWithT);
            Console.WriteLine("-------------");

            // проверяем, есть ли хотя бы один элемент имеющий длину в >3 символа
            bool anyHasMore3Chars = people.Any(s => s.Length > 3);     // false
            Console.WriteLine(anyHasMore3Chars);
            // проверяем, есть ли хотя бы один элемент начинающийся на T
            bool anyStartsWithT = people.Any(s => s.StartsWith("T"));   // true
            Console.WriteLine(anyStartsWithT);
            Console.WriteLine("-------------");

            // проверяем, есть ли строка Tom
            bool hasTom = people.Contains("Tom");     // true
            Console.WriteLine(hasTom);
            // проверяем, есть ли строка Mike
            bool hasMike = people.Contains("Mike");     // false
            Console.WriteLine(hasMike);
            Console.WriteLine("-------------");

            // Contains учитывает регистры
            string[] people1 = { "tom", "Tim", "bOb", "Sam" };
            // проверяем, есть ли строка Tom
            bool hasTom1 = people1.Contains("Tom", new CustomStringComparer());     // true
            Console.WriteLine(hasTom);
            // проверяем, есть ли строка Bob
            bool hasMike1 = people1.Contains("Bob", new CustomStringComparer());     // true
            Console.WriteLine(hasMike);
            Console.WriteLine("-------------");

            // проверяем, есть ли строка Tom
            var first = people.First();  // Tom
            Console.WriteLine(first);
            // первая строка, длина которой равна 4 символам
            //Стоит учитывать, что если коллекция пуста или в коллекции нет элементов,
            // который соответствуют условию, то будет сгенерировано исключение.
            string[] people2 = { "Tom", "Bob", "Kate", "Tim", "Mike", "Sam" };
            var firstWith4Chars = people2.First(s => s.Length == 4);  // Kate
            Console.WriteLine(firstWith4Chars);
            Console.WriteLine("-------------");

            string[] people3 = { "Tom", "Bob", "Kate", "Tim", "Mike", "Sam" };
            // первый элемент
            var firstOrDefault = people3.FirstOrDefault();  // Tom
            Console.WriteLine(firstOrDefault);
            // первая строка, длина которой равна 4 символам
            var firstOrDefaultWith4Chars = people3.FirstOrDefault(s => s.Length == 4);  // Kate
            Console.WriteLine(firstOrDefaultWith4Chars);
            // первый элемент из пустой коллекции
            var firstOrDefaultNull = new string[] { }.FirstOrDefault();
            Console.WriteLine(firstOrDefaultNull);  // null
            Console.WriteLine("-------------");

            string? firstWith5Chars = people3.FirstOrDefault(s => s.Length == 5, "Undefined");
            Console.WriteLine(firstWith5Chars); // Undefined
            // первый элемент из пустой коллекции строк
            firstOrDefault = new string[] { }.FirstOrDefault("hello"); // hello - значение по умолчанию
            Console.WriteLine(firstOrDefault);  // hello
            // первый элемент из пустой коллекции int
            int firstNumber = new int[] { }.FirstOrDefault(100); // 100 - значение по умолчанию
            Console.WriteLine(firstNumber); // 100
            Console.WriteLine("-------------");

            string? last = people3.LastOrDefault();
            Console.WriteLine(last); // Sam
            string? lastWith4Chars = people3.LastOrDefault(s => s.Length == 4);
            Console.WriteLine(lastWith4Chars); // Mike
            string? lastWith5Chars = people3.LastOrDefault(s => s.Length == 5);
            Console.WriteLine(lastWith5Chars); // null
            string? lastWith5CharsOrDefault = people3.LastOrDefault(s => s.Length == 5, "Undefined");
            Console.WriteLine(lastWith5CharsOrDefault); // Undefined
            // первый элемент из пустой коллекции строк
            string? lastOrDefault = new string[] { }.LastOrDefault("hello");
            Console.WriteLine(lastOrDefault);  // hello
            Console.WriteLine("-------------");

        }
    }
}