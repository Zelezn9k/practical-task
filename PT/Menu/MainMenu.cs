using System;
using System.Collections.Generic;
using System.Text;

namespace PT
{
    public class MainMenu
    {
        public static bool Menu()
        {
                Console.Clear();
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1) Discond");
                Console.WriteLine("2) TicTacToe");
                Console.WriteLine("3) Towns");
                Console.WriteLine("0) Exit");
                Console.Write("\r\nSelect an option: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine(Order.GetPrice());
                        Console.ReadKey();
                        return true;
                    case "2":
                        new TicTacToe();
                        return true;
                    case "3":
                    Trade.FindMax();
                    Console.ReadKey();
                    return true;
                    case "0":
                        return false;
                    default:
                    Console.WriteLine("There is no such option, please try again");
                    Console.ReadKey();
                    return true;
                }
           
        }
    }
}

