using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PT
{
    class Program
    {
        static void Main(string[] args)
        {
            
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu.Menu();
            }
        }
    }
}
