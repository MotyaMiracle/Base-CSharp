using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingBase
{
    public class Person2<T, K>
    {
        public T Id { get; set; }
        public K Password { get; set; }
        public string Name { get; set; }
        public Person2(T id, K password, string name)
        {
            Id = id;
            Password = password;
            Name = name;
        }
    }
}
