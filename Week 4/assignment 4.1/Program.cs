using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace assignment_4._1
{
    class Program
    {
        //Write a method that returns a string of even numbers greater than 0 and less than 100.
        //Given a year as integer, write a method that checks if year is leap.
        //Given a string, write a method that returns that string in reverse order.
        //Write a program in C# Sharp to create a function to input a string and count number of spaces are in the string.
        static void Main(string[] args)
        {
            char choice = 'y';
            while (choice == 'y' || choice == 'Y')
            {
                CallMenu();
                Console.WriteLine("Do you want to continue? enter Y/y for yes or press any other " +
                    "character for no");
                choice = Convert.ToChar(Console.ReadLine());
            }
            Console.ReadLine();

        }
        static void CallMenu()
        {
            Console.WriteLine("Which operation do you want to perform today?Enter a number");
            Console.WriteLine("1. Display all even numbers less than 100");
            Console.WriteLine("2. Check if year is leap year");
            Console.WriteLine("3. reverse a sentence");
            Console.WriteLine("4. count the spaces in a sentence");
            int choice = Int32.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    EvenNum();


                    break;
                case 2:
                    LeapYear();

                    break;

                case 3:
                    Reverse1();

                    break;
                case 4:
                    Spaces();
                    break;

            }


        }
        static void EvenNum()
        {
            int i;
            
            for (i = 0; i < 100; i++)
            {
                if ((i > 0) && (i % 2 == 0))
                {

                    StringBuilder even = new StringBuilder();
                    even.Append(i+" ");
                    Console.Write(even);
                }
                
            }
        }
            static void LeapYear()
        {
           
            Console.WriteLine("enter a year");
            int Y;
            Y = Int32.Parse(Console.ReadLine());
            if(Y %4==0 || Y%100!=0 && Y%400==0)
            {
                Console.WriteLine("This is a leap year");
            }
            else
            {
                Console.WriteLine("This isnt a leap year");
                   
                    }

                
        }
        static void Reverse1()
        {
            Console.WriteLine("Type a sentence");
            string sentence = Console.ReadLine();
            char[] charArray = sentence.ToCharArray();
            Array.Reverse(charArray);
            Console.WriteLine(new string(charArray));
        }
        static void Spaces()
        {
            Console.WriteLine("Enter a sentence");
            String str = Console.ReadLine();
            int spaces = 0;
            for(int i = 0; i < str.Length; i++)
            {
                if(str[i] == ' ')
                {
                    spaces++;

                }
                
            }
            Console.WriteLine(spaces);
        }
        

    }
}
