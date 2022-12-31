namespace TrainingBase
{
    public class Program
    {
        static void Main(string[] args)
        {
            Person<string> person1 = new Person<string>("34");
            Person<int> person3 = new Person<int>(45);
            UniversalPerson<int> person2 = new UniversalPerson<int>(33);
            Console.WriteLine(person1.Id);
            Console.WriteLine(person2.Id);
            Console.WriteLine(person3.Id);

            StringPerson person4 = new StringPerson("3453463");
            Person<string> person5 = new Person<string>("454353");
            // так нельзя написать
            //Person<int> person6 = new StringPerson("45545");
            Console.WriteLine(person4.Id);
            Console.WriteLine(person5.Id);

            IntPerson<string> person7 = new IntPerson<string>(5, "r2141");
            Person<int> person8 = new IntPerson<int>(7, 4674);
            Console.WriteLine(person7.Id);
            Console.WriteLine(person8.Id);

            MixedPerson<string, int> person9 = new MixedPerson<string, int>("avfd", 27);
            Person<string> person10 = new MixedPerson<string, int>("asav", 28);
            Console.WriteLine(person9.Id);
            Console.WriteLine(person10.Id);


        }

    }
}