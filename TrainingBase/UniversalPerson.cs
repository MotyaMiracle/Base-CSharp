using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingBase
{
    public class UniversalPerson<T> : Person<T>
    {
        public UniversalPerson(T id) : base(id) { }
    }
}
