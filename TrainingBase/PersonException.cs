using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingBase
{
    public class PersonException : ArgumentException
    {
        public int Value { get; }
        public PersonException(string message, int val) : base(message) 
        {
            Value = val;        
        }
    }
}
