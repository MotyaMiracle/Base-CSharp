using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingBase
{
    public class Company
    {
        public string? Title { get; set; }
        public string? Language { get; set; }
        public Company(string title, string language)
        {
            Title = title;
            Language = language;
        }
    }
}
