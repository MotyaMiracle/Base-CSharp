using System;

namespace TrainingBase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Person person = new Person { Name = "Tom", Age = 17 };
            }
            catch (PersonException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
                Console.WriteLine($"Некорректное значение: {ex.Value}");
            }
        }
    }
}