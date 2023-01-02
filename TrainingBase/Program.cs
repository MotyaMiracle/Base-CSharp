namespace TrainingBase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y = 1;
            try
            {
                int result1 = x / y;
                int result2 = y / x;
                
                
            }
            catch(DivideByZeroException) when (y == 0)
            {
                Console.WriteLine("Y не должен быть равен 0");
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine($"Возникло исключение {ex.Message}");
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