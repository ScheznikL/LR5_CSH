using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace LR5_CSH.Models
{
    class Factory
    {
        public static int NumberOfWorkersInOneDepartment { set; get; }
        public static int NumberOfDepartments { get; set; }
        public static int BankAccount { get; set; } 
        public static List<Department> DepartmentsList { get; set; } = new List<Department>();
        public static int TotalAmountOfResourses { get; set; }


        public Factory(int numberOfDepartments, int setNumberOfWorkersInOneDepartment, int bankAccount = 0)
        {
            NumberOfDepartments = numberOfDepartments;
            BankAccount = bankAccount;
            NumberOfWorkersInOneDepartment = setNumberOfWorkersInOneDepartment;
            TotalAmountOfResourses = setNumberOfWorkersInOneDepartment * 1000 * NumberOfDepartments;
            // StartAllDepartments(NumberOfDepartments, setNumberOfWorkersInOneDepartment);
        }

        public void StartAllDepartments(int setNumberOfDepartments, int setNumberOfWorkersInOneDepartment)
        {
            //var startThread = new Thread(StartAllDepartmentsThread);
            //startThread.Name = "StartDepartments";
            ///TODO thread1 starts all deps and they work to the point NoResourses 
            ///meanwhile stack the departments with resourses
            //startThread.Start(this);
            //startThread.Join();
        }
        public static void StartAllDepartmentsThread()
        {
            //var localFactory = factory as Factory;

            for (var i = 0; i < NumberOfDepartments; i++)
            {
                var dep = new Department(NumberOfWorkersInOneDepartment, NumberOfDepartments * NumberOfWorkersInOneDepartment);
                dep.Produce();
                DepartmentsList.Add(dep);
                Thread.Sleep(10);
            }
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
