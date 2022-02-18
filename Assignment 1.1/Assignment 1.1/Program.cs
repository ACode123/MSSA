using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            float age;
            string firstName;
            string address;
            Console.WriteLine("Please enter your name");
            firstName = Console.ReadLine();
            Console.WriteLine("Please enter your age");
            age = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter your street address");
            address = Console.ReadLine();
            Console.ReadLine();

            Console.WriteLine("Your Information:");
            Console.WriteLine("Name is {0} , age is {1} , address is {2}", firstName, age, address);
            Console.ReadLine();
            

     
        }
    }
}
