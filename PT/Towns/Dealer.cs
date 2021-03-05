using System;
using System.Collections.Generic;
using System.Text;

namespace PT
{
    public class Dealer
    {
        public int money { get; set; } = 50;
        public Town CurrentTown { get; private set; }
        public Good ItemInBag { get; set; }
        public HashSet<Town> VisitedTowns { get; set; }
        public void Buy(Good good)
        {
            int price = CurrentTown.PriceList.GetValueOrDefault(good);
            if (money >= price)
            {
                money -= price;
                ItemInBag = good;
            }
        }
        public void Sell(Good good)
        {
            if (good == ItemInBag)
            {
                money += CurrentTown.PriceList.GetValueOrDefault(good);
                ItemInBag = Good.empty;
            }
        }
        public void Visit(Town town)
        {
            if (!VisitedTowns.Contains(town))
            {
                CurrentTown = town;
                VisitedTowns.Add(town);
            }
        }
    }
}
