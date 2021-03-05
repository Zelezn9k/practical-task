using System;
using System.Collections.Generic;
using System.Text;

namespace PT
{
    public class Town
    {
        public string Name { get; set; }
        public Dictionary<Good, int> PriceList { get; set; }
        public Town(string name , Dictionary<Good, int> priceList)
        {
            Name = name;
            PriceList = priceList;
        }
    }
}
