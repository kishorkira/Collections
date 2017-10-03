using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries
{
    class PrimeMinister
    {
        public string Name { get;private set; }
        public int YearEelected { get; private set; }

        public PrimeMinister(string name,int yearSelected)
        {
            Name = name;
            YearEelected = yearSelected;
        }

        public override string ToString()
            => $"Name : {Name} - Year Selected : {YearEelected}";
        
    }
}
