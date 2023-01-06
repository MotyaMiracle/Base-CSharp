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
                new Person("Kate", "JetBrains"), new Person("Alice", "Microsoft"),
            };

            //var companies = from person in people
            //                group person by person.Company;

            var companies = people.GroupBy(p => p.Company);

            foreach (var company in companies)
            {
                Console.WriteLine(company.Key);

                foreach (var person in company)
                {
                    Console.WriteLine(person.Name);
                }
                Console.WriteLine(); // для разделения между группами
            }

            // Создание нового объекта при группировке
            //var companies1 = from person in people
            //                group person by person.Company into g
            //                select new { Name = g.Key, Count = g.Count() }; ;

            var companies1 = people.GroupBy(p => p.Company).Select(g => new { Name = g.Key, Count = g.Count() });

            foreach (var company in companies1)
            {
                Console.WriteLine($"{company.Name} : {company.Count}");
            }
            Console.WriteLine();
            // Вложенные запросы
            //var companies2 = from person in people
            //                group person by person.Company into g
            //                select new
            //                {
            //                    Name = g.Key,
            //                    Count = g.Count(),
            //                    Employees = from p in g select p
            //                };
            var companies2 = people.GroupBy(p => p.Company).Select(g => new
            {
                Name = g.Key,
                Count = g.Count(),
                Employees = g.Select(p => p)
            });
            foreach (var company in companies2)
            {
                Console.WriteLine($"{company.Name} : {company.Count}");
                foreach (var employee in company.Employees)
                {
                    Console.WriteLine(employee.Name);
                }
                Console.WriteLine(); // для разделения компаний
            }
            Console.WriteLine();
        }
    }
}