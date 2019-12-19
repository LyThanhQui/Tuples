using System;
using System.Collections.Generic;

namespace Tuples
{

    class Program
    {
        static void Main()
        {
            var values = new List<double>() { 10, 20, 30, 40, 50, 60 };
            // Tuple<int, double> t = Calulate(values);
            var result = Calulate(values);
            Console.WriteLine($"There are {result.Item1} values and their sum is {result.Item2}, Test value is {result.Item3}");
            Console.ReadKey();
        }

        //  //Tuples Before C# 7:
        //Declaring the return type as Tuple<int, double>
        /*private static Tuple<int, double> Calulate(IEnumerable<double> values)
        {
            int count = 0;
            double sum = 0.0;
            foreach (var value in values)
            {
                count++;
                sum += value;
            }
            //Creating an object of Tuple class by calling the static Create method
            Tuple<int, double> t = Tuple.Create(count, sum);
            //Returning the tuple instance
            return t;
        }*/

        //overcome the above Problems in C# 7
        /* private static (int, double, int) Calulate(IEnumerable<double> values)
         {
             int count = 0;
             double sum = 0.0;
             int i = 0;
             foreach(var value in values)
             {
                 i--;
                 count++;
                 sum += value;
             }
             return (count, sum, i);
         }*/

        //Tuples in C# with named Parameters:
        private static (int c, double s, int i) Calulate(IEnumerable<double> values)
        {
            int count = 0;
            double sum = 0.0;
            int i = 0;
            foreach (var value in values)
            {
                i--;
                count++;
                sum += value;
            }
            return (count, sum, i);
        }
    
    }
}
