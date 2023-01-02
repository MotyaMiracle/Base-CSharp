namespace TrainingBase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                try
                {
                    Console.Write("Введите имя: ");
                    string? name = Console.ReadLine();
                    if (name == null || name.Length < 2)
                    {
                        throw new Exception("Длина имени меньше 2 символов");
                    }
                    else
                    {
                        Console.WriteLine($"Ваше имя: {name}");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Ошибка: {e.Message}");
                    throw;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
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