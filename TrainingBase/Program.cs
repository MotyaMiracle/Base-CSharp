namespace TrainingBase
{
    public class Program
    {
        static void Main(string[] args)
        {
            Person[] people =
            {
                new Person("Tom", "Microsoft"), new Person("Sam", "Google"),
                new Person("Bob", "JetBrains"), new Person("Mike", "Microsoft"),
            };
            Company[] companies =
            {
                new Company("Microsoft", "C#"),
                new Company("Google", "Go"),
                new Company("Oracle", "Java")
            };
            //var employees = from p in people
            //                join c in companies on p.Company equals c.Title
            //                select new { Name = p.Name, Company = c.Title, Language = c.Language };
            var employees = people.Join(companies, p => p.Company, c => c.Title,
                (p, c) => new { Name = p.Name, Company = c.Title, Language = c.Language });

            foreach (var emp in employees)
                Console.WriteLine($"{emp.Name} - {emp.Company} ({emp.Language})");

            Console.WriteLine();

            var personnel = companies.GroupJoin(people, // второй набор
                    c => c.Title, // свойство-селектор объекта из первого набора
                    p => p.Company, // свойство-селектор объекта из второго набора
                    (c, employees) => new   // результат
             {
                 Title = c.Title,
                 Employees = employees
             });
            foreach (var company in personnel)
            {
                Console.WriteLine(company.Title);
                foreach (var emp in company.Employees)
                {
                    Console.WriteLine(emp.Name);
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            // Метод Zip()
            var courses = new List<Course> { new Course("C#"), new Course("Java") };
            var students = new List<Student> { new Student("Tom"), new Student("Bob") };

            var enrollments = courses.Zip(students);
            foreach (var enrollment in enrollments)
            {
                Console.WriteLine($"{enrollment.First.Title} - {enrollment.Second.Name}");
            }

        }
    }
}