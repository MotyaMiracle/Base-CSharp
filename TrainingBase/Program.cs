namespace TrainingBase
{
    public class Program
    {
        static void Main(string[] args)
        {
            Person<int> tom = new Person<int>(546, "Tom");
            Person<string> sam = new Person<string>("abc123", "Sam");

            int tomId = tom.Id;
            string samId = sam.Id;

            Console.WriteLine(tomId);
            Console.WriteLine(samId);
            Console.WriteLine();

            Company<Person<int>> microsoft = new Company<Person<int>>(tom);
            Console.WriteLine(microsoft.CEO.Id);
            Console.WriteLine(microsoft.CEO.Name);
            Console.WriteLine();

            Person<int> kate = new Person<int>(543, "Kate");
            Person<int>.code = 1234;

            Person<string> alice = new Person<string>("cba321", "Alice");
            Person<string>.code = "meta";

            Console.WriteLine(Person<int>.code);
            Console.WriteLine(Person<string>.code);
            Console.WriteLine();

            Person2<int, string> bob = new Person2<int, string>(123, "abc", "Bob");
            Console.WriteLine(bob.Id);
            Console.WriteLine(bob.Password);
            Console.WriteLine();

            int x = 7;
            int y = 25;
            Swap<int>(ref x, ref y); // или так Swap(ref x, ref y);
            Console.WriteLine($"x={x}, y={y}");   // x=25   y=7
            Console.WriteLine();
            string s1 = "hello";
            string s2 = "bye";
            Swap<string>(ref s1, ref s2); // или так Swap(ref s1, ref s2);
            Console.WriteLine($"s1={s1}, s2={s2}"); // s1=bye   s2=hello


        }
        public static void Swap<T>(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }
    }
}