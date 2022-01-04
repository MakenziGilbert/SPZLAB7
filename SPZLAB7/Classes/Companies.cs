using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPZLAB7.Classes
{
    public class Companies
    {
        public string Company { get; set; }
        public int AmountOfWorkers { get; set; }
        public Companies(string company, int amountOfWorkers)
        {
            Company = company;
            AmountOfWorkers = amountOfWorkers;
        }
        public Companies() { }
    }
}
