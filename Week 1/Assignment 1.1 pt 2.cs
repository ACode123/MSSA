using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    { //Create a simple console application and declare basic datatypes like int, float, decimal, double and print their min and max values.
        static void Main(string[] args)
        {
            Console.Write("Float max value:"); Console.WriteLine(float.MaxValue);
            Console.Write("Float min value:"); Console.WriteLine(float.MinValue);
            Console.Write("int max value:"); Console.WriteLine(int.MaxValue);
            Console.Write("int min value:"); Console.WriteLine(int.MinValue);
            Console.Write("decimal max value:"); Console.WriteLine(decimal.MaxValue);
            Console.Write("decimal min value:"); Console.WriteLine(decimal.MinValue);
            Console.Write("double max value:"); Console.WriteLine(double.MaxValue);
            Console.Write("double min value:"); Console.WriteLine(double.MinValue);

            Console.ReadLine(); 

        }
    }
}
