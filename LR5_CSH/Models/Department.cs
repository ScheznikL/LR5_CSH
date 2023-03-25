using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR5_CSH.Models
{
    class Department
    {
        public int NumberOfWorkers { get; set; }
        public int AmountOfResourses { get; set; }//Wood 1 peace=10 wood
        public Dictionary<string, int> DailyProductAmount { get; set; } = new Dictionary<string, int>(); //"nameofFurnature":amount


        public Department() { }
        public Department(int numberOfWorkers, int amountOfResourses)
        {
            NumberOfWorkers = numberOfWorkers;
            AmountOfResourses = amountOfResourses;
        }        

    }
}
