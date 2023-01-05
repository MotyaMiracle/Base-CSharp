namespace TrainingBase
{
    public class Program
    {
        static void Main(string[] args)
        {
            var people = new List<Person>
            {
                new Person("Tom", 23),
                new Person("Bob", 27),
                new Person("Sam", 29),
                new Person("Alice", 24)
            };

            //var names = from p in people select p.Name; // Через оператор запросов LINQ
            var names = people.Select(u => u.Name); // Через метод расширения LINQ

            foreach (string? n in names)
                Console.WriteLine(n);
            Console.WriteLine();

            // проекция на объекты анонимного типа
            var personel = people.Select(p => new
            {
                FirstName = p.Name!,
                Year = DateTime.Now.Year - p.Age
            });
            foreach (var p in personel)
                Console.WriteLine($"{p.FirstName} - {p.Year}");
            Console.WriteLine();

            var personnel = from p in people
                            let name = $"Mr.{p.Name}"
                            let year = DateTime.Now.Year - p.Age
                            select new
                            {
                                Name = name,
                                Year = year
                            };
            foreach (var p in personnel)
                Console.WriteLine($"{p.Name} - {p.Year}");
            Console.WriteLine();

            var courses = new List<Course> { new Course("C#"), new Course("Java") };
            var students = new List<Student> { new Student("Tom"), new Student("Bob") };

            var enrollments = from course in courses // выбираем по одному курсу
                              from student in students // выбираем по одному студенту
                              select new { Student = student.Name, Course = course.Title }; // cоединяем каждого студента с каждым курсом

            foreach (var enrollment in enrollments)
                Console.WriteLine($"{enrollment.Student} - {enrollment.Course}");
            Console.WriteLine();

            var companies = new List<Company>
            {
                new Company("Microsoft", new List<Person>{ new Person("Tom"), new Person("Bob")}),
                new Company("Google", new List<Person>{ new Person("Sam"), new Person("Mike")})
            };

            var employees = companies.SelectMany(c => c.Staff, (c, emp) => new { Name = emp.Name, Company = c.Name});

            foreach (var emp in employees)
                Console.WriteLine($"{emp.Name} - {emp.Company}");
            Console.WriteLine();

        }
    }
}