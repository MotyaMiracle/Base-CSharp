namespace TrainingBase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int x = 5;
                int y = x / 0;
                Console.WriteLine($"Результат: {y}");
                
            }
            catch
            {
                Console.WriteLine("Возникло исключение!");
            }
            finally // Блок можно опустить
            {
                Console.WriteLine("Блок finally");
            }
            Console.WriteLine("Конец программы");

            Square("12");
            Square("ab");
        }

        public static void Square(string data)
        {
            if(int.TryParse(data, out var x)) 
            {
                Console.WriteLine($"Квадрат числа {x}: {x * x}");
            }
            else
            {
                Console.WriteLine("Некорректный ввод");
            }
            
        }
    }
}