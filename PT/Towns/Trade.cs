using System;
using System.Collections.Generic;
using System.Text;

namespace PT
{
    public static class Trade
    {
        static Town Lubek;
        static Town Reval;
        static Town Bergen;
        static Town []Towns = {Lubek , Reval , Bergen};
        static Dealer Dealer;
        static Trade()
        {

            Dictionary<Good, int> LubekPriceList = new Dictionary<Good, int>();
            LubekPriceList.Add(Good.salt, 20);
            LubekPriceList.Add(Good.fish, 50);
            LubekPriceList.Add(Good.cloth, 60);
            LubekPriceList.Add(Good.copper, 36);
            LubekPriceList.Add(Good.furs, 96);

            Dictionary<Good, int> RevalPriceList = new Dictionary<Good, int>();
            RevalPriceList.Add(Good.salt, 35);
            RevalPriceList.Add(Good.fish, 50);
            RevalPriceList.Add(Good.cloth, 40);
            RevalPriceList.Add(Good.copper, 60);
            RevalPriceList.Add(Good.furs, 45);

            Dictionary<Good, int> BergenPriceList = new Dictionary<Good, int>();
            BergenPriceList.Add(Good.salt, 62);
            BergenPriceList.Add(Good.fish, 15);
            BergenPriceList.Add(Good.cloth, 18);
            BergenPriceList.Add(Good.copper, 82);
            BergenPriceList.Add(Good.furs, 54);

            Dealer = new Dealer();

            Lubek = new Town("Lubek", LubekPriceList);
            Reval = new Town("Reval", RevalPriceList);
            Bergen = new Town("Bergen", BergenPriceList);
            
        }

        //Честно говоря потратил несколько дней, но так и не смог придумать алгоритм для выбора самого выгодного пути=(
        public static void FindMax()
        {
            Console.WriteLine("The programer did not invented Algorithm yet");
            Console.WriteLine("Come back later =(");
            /*for (int i = 0; i< 3; i++)
            {
                for(int j =0; i<5; i++)
                {
                    Dealer.Buy((Good)j);
                }
            }*/
        }
    }
}
