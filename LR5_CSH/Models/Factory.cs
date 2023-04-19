using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;
using System.Threading;

namespace LR5_CSH.Models
{
    [Serializable]
    public class Factory
    {
        private static int _bankAccount;
        private static int _totalAmountOfResourses;
        private Random _randomPriceChooser = new Random();
        public static int NumberOfWorkersInOneDepartment { set; get; }
        public static int NumberOfDepartments { get; set; }
        public static int BankAccount
        {
            get => _bankAccount;
            set { if (value >= 0) _bankAccount = value; }
        }
        public static List<Department> DepartmentsList { get; set; } = new List<Department>();
        public static int TotalAmountOfResourses
        {
            get => _totalAmountOfResourses;
            set { if (value >= 0) _totalAmountOfResourses = value; }
        }
        public static int CommonResousesPrice { get; set; }
        public static int SpenOnPayment { get; set; }
        public static object Locker { get; } = new object();
        public static object BankLocker { get; } = new object();

        public Factory() { }
        public Factory(int numberOfDepartments, int setNumberOfWorkersInOneDepartment, int bankAccount = 0)
        {
            NumberOfDepartments = numberOfDepartments;
            BankAccount = bankAccount;
            NumberOfWorkersInOneDepartment = setNumberOfWorkersInOneDepartment;
            TotalAmountOfResourses = setNumberOfWorkersInOneDepartment * 1000 * NumberOfDepartments;
            CommonResousesPrice = _randomPriceChooser.Next(1, 3);
        }
        public static int GetCurrentNumbOfFurniture()
        {
            int currentNumOfProd = 0;
            foreach (var dep in DepartmentsList)
            {
                lock (dep.Locker)
                {
                    currentNumOfProd += dep.DailyProductAmountList.Select(y => y.Amount).Sum();
                }
            }
            return currentNumOfProd;
        }
        public static void FillDepartmentsWithResourses()
        {
            foreach (var dep in DepartmentsList)
            {
                dep.AmountOfResourses = TotalAmountOfResourses / NumberOfDepartments;
            }
        }

    }
}
