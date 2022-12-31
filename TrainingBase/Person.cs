using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingBase
{
    public class Person<T>
    {
        public static T? code;
        public T Id { get; set; }
        public string Name { get; set; }

        public Person(T id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
