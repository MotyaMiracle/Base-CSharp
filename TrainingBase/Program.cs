namespace TrainingBase
{
    internal class Program
    {
        async static Task Main(string[] args)
        {
            Repository repo = new Repository();
            IAsyncEnumerable<string> data = repo.GetDataAsync();
            await foreach (var name in data)
            {
                Console.WriteLine(name);
            }
        }
    }
}