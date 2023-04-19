using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Linq;
using System.Threading;

namespace LR5_CSH.Models
{
    [Serializable]
    public class Department
    {
        private static int _amountOfResourses;
        private static int _allAmountOfChairs;
        private static int _allAmountOfTables;
        private static Form1 _toUpdateForm = new Form1();
        private static HashSet<int> _randNumbers = new HashSet<int>();
        private Random _randomPaymentChooser = new Random();
        private object _randLocker = new object();
        private static int _idCounter = 0;
        public static int DailyProductAmount { get; set; }
        public int Id { get; set; }
        public int Payment { get; set; }
        public int NumberOfWorkers { get; set; }
        public int AmountOfResourses
        {
            get => _amountOfResourses;
            set
            {
                if (value >= 0)
                    _amountOfResourses = value;
                else _amountOfResourses = 0;
            }
        }
        public List<Furniture> SoldDailyProductAmountList { get; set; }
        [XmlIgnore]
        public List<Furniture> DailyProductAmountList { get; set; } = new List<Furniture>();
        [XmlIgnore]
        public object Locker { get; } = new object();


        public Department() { }
        public Department(int numberOfWorkers, Form1 ownerForm)//1 worker can process 1000 resourses to complete 100 furnature peaces
        {
            _toUpdateForm = ownerForm;
            NumberOfWorkers = numberOfWorkers;
            Id = ++_idCounter;
            Payment = GetRandomNumber(500, 900);
        }

        public int GetRandomNumber(int from, int to)
        {
            _randNumbers.Add(_randomPaymentChooser.Next(from, to));
            return _randNumbers.Last();
        }
        public void Produce()
        {
            var numbOfChaires = 10;
            var numbOfTables = 10;
            if (AmountOfResourses > 0)
            {
                lock (Locker)
                {
                    DailyProductAmountList.Add(new Furniture("chairs", numbOfChaires));
                }
                DailyProductAmount += numbOfChaires;
                AmountOfResourses -= numbOfChaires * 10;                
                Factory.TotalAmountOfResourses -= numbOfChaires * 10;
                Thread.Sleep(10);
                lock (Locker)
                {
                    DailyProductAmountList.Add(new Furniture("tables", numbOfTables));
                }
                DailyProductAmount += numbOfChaires;
                AmountOfResourses -= numbOfChaires * 10;
                Factory.TotalAmountOfResourses -= numbOfChaires * 10;
                Thread.Sleep(10);
                _toUpdateForm.UpdateProgressBar(Factory.TotalAmountOfResourses);
                ClarifySoldDailyProductAmountList();
            }
        }
        private void ClarifySoldDailyProductAmountList()
        {
            lock (Locker)
            {
                _allAmountOfChairs += DailyProductAmountList.Where(y => y.Name == "chairs").Select(a => a.Amount).Sum();
            }
            lock (Locker)
            {
                _allAmountOfTables += DailyProductAmountList.Where(y => y.Name == "tables").Select(a => a.Amount).Sum();
            }
            SoldDailyProductAmountList = new List<Furniture>();
            SoldDailyProductAmountList.Add(new Furniture("chairs", _allAmountOfChairs));
            SoldDailyProductAmountList.Add(new Furniture("tables", _allAmountOfTables));
        }
    }
}
