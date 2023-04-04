using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace LR5_CSH.Models
{
    class Department
    {
        public int NumberOfWorkers { get; set; }
        public int AmountOfResourses { get; set; }//Wood 1 peace=10 wood
        public List<Furniture> DailyProductAmount { get; set; } = new List<Furniture>(); //"nameofFurnature":amount


        public Department() { }
        public Department(int numberOfWorkers, int amountOfResourses)
        {
            NumberOfWorkers = numberOfWorkers;
            AmountOfResourses = NumberOfWorkers * 1000; //1 worker can process 1000 resourses to complete 100 furnature peaces
            AmountOfResourses = amountOfResourses;
            Produce();
        }
        public void Produce()
        {
            //var randomNumberofFurniture = new Random();
            var numbOfChaires = 50;
            var numbOfTables = 50;
            for (int i = 0; AmountOfResourses > 0; i++)
            {                
                DailyProductAmount.Add(new Furniture("chairs", numbOfChaires));
                AmountOfResourses -= numbOfChaires * 10;
                Factory.TotalAmountOfResourses -= numbOfChaires * 10;
               // numbOfChaires = DailyProductAmount.Count;
                Thread.Sleep(20);                
                
                DailyProductAmount.Add(new Furniture("tables", numbOfTables));
                AmountOfResourses -= numbOfChaires * 10;
                Factory.TotalAmountOfResourses -= numbOfChaires * 10;
                 Thread.Sleep(20);
                
                if (AmountOfResourses < 0)
                    AmountOfResourses = 0;
            }
                        
        }
        
    }
}
