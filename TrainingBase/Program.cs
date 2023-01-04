namespace TrainingBase
{
    internal class Program
    {
        async static Task Main(string[] args)
        {
            // определяем и запускаем задачи
            var task1 = PrintAsync("Hello C#");
            var task2 = PrintAsync("Hello World");
            var task3 = PrintAsync("Hello METANIT.COM");

            // ожидаем завершения всех задач
            //await Task.WhenAll(task1, task2, task3);
            // ожидаем завершения хотя бы одной задачи
            await Task.WhenAny(task1, task2, task3);

            async Task PrintAsync(string message)
            {
                await Task.Delay(new Random().Next(1000, 2000));    // имитация продолжительной операции
                Console.WriteLine(message);
            }

            // определяем и запускаем задачи
            var task4 = SquareAsync(4);
            var task5 = SquareAsync(5);
            var task6 = SquareAsync(6);

            // ожидаем завершения всех задач
            int[] results = await Task.WhenAll(task4, task5, task6);
            // получаем результаты:
            foreach (int result in results)
                Console.WriteLine(result);
            // получаем результат задачи task2
            Console.WriteLine($"task2 result: {task5.Result}"); // task2 result: 25

            async Task<int> SquareAsync(int n)
            {
                await Task.Delay(1000);
                return n * n;
            }
        }
    }
}