using System;
using System.Collections.Generic;
using System.Text;

namespace PT
{
    public class Order
    {
        public static double GetPrice()
        {
            double[]  discond = new double[100];
            double[] price = new double[100];
            int i, n = 0;
            double sum = 0;
            Console.Write("\n\nFind sum of all elements of array:\n");
            Console.Write("--------------------------------------\n");
            Console.Write("Input the number of elements to be stored in the array :");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input {0} elements in the array :\n", n);
            for (i = 1; i <= n; i++)
            {
                Console.Write("element - {0} : ", i);
                price[i] = Convert.ToDouble(Console.ReadLine());
                Console.Write("discond - {0} : ", i);
                discond[i] = Convert.ToDouble(Console.ReadLine());

            }
            for (i = 1; i <= n; i++)
            {
                sum += price[i] - price[i] * (discond[i]/100);
            }

             Console.Write("Sum of all elements stored in the array is : ");
            return sum;
        }
    }
}
