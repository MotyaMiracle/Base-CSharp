namespace TrainingBase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                object obj = "you";
                int num = (int)obj;     // System.InvalidCastException
                Console.WriteLine($"Результат: {num}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Возникло исключение DivideByZeroException");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Возникло исключение IndexOutOfRangeException");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Исключение: {ex.Message}");
            }

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