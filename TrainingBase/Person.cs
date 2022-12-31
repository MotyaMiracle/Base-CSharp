using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingBase
{
    public class Person<T>
    {
        public T Id { get; }
        public Person(T id)
        {
            Id = id;
        }
    }
}
