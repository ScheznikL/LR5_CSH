using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR5_CSH.Models
{
    class Furniture
    {
        public string Name { get; set; }
        public int Amount { get; set; }

        public Furniture(string name,int amount)
        {
            Name = name;
            Amount = amount;
        }
    }
}
