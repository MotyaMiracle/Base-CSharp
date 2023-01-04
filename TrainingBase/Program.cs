namespace TrainingBase
{
    internal class Program
    {
        async static Task Main(string[] args)
        {
            await PrintAsync();   // вызов асинхронного метода
            Console.WriteLine("Некоторые действия в методе Main");

            await PrintNameAsync("Tom");
            await PrintNameAsync("Bob");
            await PrintNameAsync("Sam");

            




            void Print()
            {
                Thread.Sleep(3000);     // имитация продолжительной работы
                Console.WriteLine("Hello METANIT.COM");
            }

            // определение асинхронного метода
            async Task PrintAsync()
            {
                await Task.Delay(3000); // имитация продолжительной работы
                // или так
                //await Task.Delay(TimeSpan.FromMilliseconds(3000));
                Console.WriteLine("Начало метода PrintAsync"); // выполняется синхронно
                await Task.Run(() => Print());                // выполняется асинхронно
                Console.WriteLine("Конец метода PrintAsync");
            }
            // определение асинхронного метода
            async Task PrintNameAsync(string name)
            {
                await Task.Delay(3000);     // имитация продолжительной работы
                Console.WriteLine(name);
            }
            // асинхронное лямбда-выражение
            Func<string, Task> printer = async (message) =>
            {
                await Task.Delay(3000);
                Console.WriteLine(message);
            };

            await printer("Hello World");
            await printer("Hello METANIT.COM");
        }
    }
}