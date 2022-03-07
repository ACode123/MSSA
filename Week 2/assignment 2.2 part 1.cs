using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

        
            namespace Assignement_2._2
    {
    //Write a console application to create a text file and save your basic details like name, age, address ( use dummy data). Read the details from same file and print on console.
    class Program
        {
            static string Filename;
            static string path = @"C:\Files\";
            static void Main(string[] args)
            {
                Console.WriteLine("This application will create a file to store basic info");
                Console.WriteLine("enter a file name:");
                Filename = Console.ReadLine() + ".txt";
                path = path + Filename;
                Console.WriteLine("enter your name");
                string name = Console.ReadLine();
                Console.WriteLine("enter your age");
                int age = Int32.Parse(Console.ReadLine());
                Console.WriteLine("enter your address");
                string address = Console.ReadLine();
                Appendlines("\n" + "name:" + name + "age:" + age + "address:" + address);
                Readfromlog();
                Console.ReadLine();



            }
            static void Readfromlog()
            {
                StreamReader stream = new StreamReader(path);
                string data = stream.ReadToEnd();
                Console.WriteLine("Contents" + data);
                stream.Close();
            }
            static void Appendlines(string data)
            {
                File.AppendAllText(path, data);
            }
        }
    }
}
