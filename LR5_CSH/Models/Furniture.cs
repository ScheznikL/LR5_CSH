using System;

namespace LR5_CSH.Models
{
    [Serializable]
    public class Furniture
    {
        public string Name { get; set; }
        public int Amount { get; set; }

        public Furniture() { }
        public Furniture(string name, int amount)
        {
            Name = name;
            Amount = amount;
        }
    }
}
