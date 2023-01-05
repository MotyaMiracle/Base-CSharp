using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingBase
{
    public class Person
    {
        public string? Name { get; set; }
        public int Age { get; set; }
        public List<string> Languages = new();

        public Person(string name) 
        {
            Name = name;
        }
        public Person(string? name, int age, List<string> languages)
        {
            Name = name;
            Age = age;
            Languages = languages;
        }
    }
}
