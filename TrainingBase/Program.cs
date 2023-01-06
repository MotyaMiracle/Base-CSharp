namespace TrainingBase
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Рассмотрим отложенное выполнение
            string[] people = { "Tom", "Sam", "Bob" };
            var selectedPeople = people.Where(s => s.Length == 3).OrderBy(s => s);
            //people[2] = "Mike";
            // выполнение LINQ-запроса
            foreach (string s in selectedPeople)
                Console.WriteLine(s);
            var count = people.Where(s => s.Length == 3).OrderBy(s => s).Count();
            // выполнение запроса
            Console.WriteLine(selectedPeople.Count());   // 3 - до изменения коллекции
            people[2] = "Mike";
            // выполнение запроса
            Console.WriteLine(selectedPeople.Count());   // 2 - после изменения коллекции
            
            // определение и выполнение LINQ-запроса
            var selectedPeople1 = people.Where(s => s.Length == 3).OrderBy(s => s).ToList();
            // изменение массива никак не затронет список selectedPeople
            people[2] = "Mike";
            // выполнение запроса
            foreach (string s in selectedPeople1)
                Console.WriteLine(s);

        }
    }
}