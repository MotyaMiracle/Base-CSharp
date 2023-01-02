using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingBase
{
    public class Person
    {
        private int age;
        public string Name { get; set; } = "";
        public int Age 
        { 
            get => age;
            set
            {
                if(value < 18)
                {
                    throw new PersonException("Лицам до 18 регистрация запрещена", value);
                }
                else
                    age = value;
            }
        }
    }
}
