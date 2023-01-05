namespace TrainingBase
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] people = { "Tom", "Bob", "Sam", "Tim", "Thomas", "Bill" };

            // создаем новый список для результатов
            var selectedPeople = new List<string>();

            // Проходим по массиву
            foreach (string person in people)
            {
                // если строка начинается на букву T, добавляем в список
                if (person.ToUpper().StartsWith("T"))
                    selectedPeople.Add(person);
            }

            // Сортируем список
            selectedPeople.Sort();

            foreach (string person in selectedPeople)
                Console.WriteLine(person);

            Console.WriteLine();

            var selectedPeople2 = people.Where(p => p.ToUpper().StartsWith("T")).OrderBy(p => p);
            foreach (string person in selectedPeople2)
                Console.WriteLine(person);

        }
    }
}