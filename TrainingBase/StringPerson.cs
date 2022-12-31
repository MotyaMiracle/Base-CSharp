using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingBase
{
    public class StringPerson : Person<string>
    {
        public StringPerson(string id) : base(id) { }
    }
}
