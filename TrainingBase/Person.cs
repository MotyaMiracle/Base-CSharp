using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingBase
{
    public class Person
    {
         public string Name { get; }
        public Person(string name) => Name = name;

        public override bool Equals(object? obj)
        {
            if (obj is Person person) return Name == person.Name;
            return false;
        }
        public override int GetHashCode() => Name.GetHashCode();
    }
}
