using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR5_CSH.Models
{
    class Factory
    {
        public int NumberOfDepartments { get; set; }
        public int BankAccount { get; private set; } //TODO investigate
        public List<Department> departmentsList { get; set; } = new List<Department>();

        public Factory(int numberOfDepartments, int bankAccount)
        {
            NumberOfDepartments = numberOfDepartments;
            BankAccount = bankAccount;
        }

        public void StartAllDepartments()
        {
            //TODO thread1 starts all deps and they work to the point NoResourses 
            //meanwhile stack the departments with resourses
        }
        public void Selling(int periodOfPurchases)
        {
            //TODO thread2 periodicly sleep(??period) //ind a Day lasting**
            ///numbers od product --
            ///money++ tobank
            BankAccount += 10;
        }
        public void MoneyWithdrawal()
        {
            //TODO thread3 RestoreResourses + MoneyToTheWorkers(*!*priorityhigher*!*)

        }
        private void PriceGeneration()
        {

        }
        //TODO log XML

    }
}
