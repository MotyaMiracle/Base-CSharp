namespace TrainingBase
{
    internal class Program
    {
        async static Task Main(string[] args)
        {

            Account account = new Account();
            account.Added += PrintVoidAsync;

            account.Put(500);

            await Task.Delay(2000);

            async void PrintVoidAsync(object? obj, string message)
            {
                await Task.Delay(1000);
                Console.WriteLine(message);
            }

            var task =  PrintTaskAsync("Hello Metanit.com");
            Console.WriteLine("Main Works");
            await task;

            async Task PrintTaskAsync(string message)
            {
                await Task.Delay(1000);
                Console.WriteLine(message);
            }

            var square5 = SquareAsync(5);
            var square6 = SquareAsync(6);
            Console.WriteLine("Остальные действия в методе Main");

            int n1 = await square5;
            int n2 = await square6;
            Console.WriteLine($"n1={n1}  n2={n2}"); // n1=25  n2=36


            async Task<int> SquareAsync(int n)
            {
                await Task.Delay(0);
                var result = n * n;
                Console.WriteLine($"Квадрат числа {n} равен {result}");
                return result;
            }
            

            // Task<T>
            var result1 = await AddTaskAsync(4, 5);
            Console.WriteLine(result1);

            Task<int> AddTaskAsync(int a, int b)
            {
                return Task.FromResult(a + b); // синхронно возвратить некоторое значение
            }
            var result2 = await AddVTaskAsync(4, 5);
            Console.WriteLine(result2);
            // ValueTask<T>
            ValueTask<int> AddVTaskAsync(int a, int b)
            {
                return new ValueTask<int>(a + b);
            }

            //Преобразование ValueTask в Task
            var getMessage = GetMessageAsync();
            string message = await getMessage.AsTask();
            Console.WriteLine(message); // Hello

            async ValueTask<string> GetMessageAsync()
            {
                await Task.Delay(0);
                return "Hello";
            }


        }
    }
}