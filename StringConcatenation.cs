using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class StringConcatenation
    {
        static void Main()
        {
            int number = 9;
            string name = "Bob";

            //string concatenation with integer
            string nameNew = string.Concat(number, name);
            Console.WriteLine("My name is " + name + " and my age is " + number + nameNew);


            Console.WriteLine("My name is " + nameNew.Substring(2) + " and my age is " + number);
            Console.WriteLine("My name is " + nameNew.ToUpper() + " and my age is " + number);
            Console.WriteLine("My name is " + nameNew.ToLower() + " and my age is " + number);
            //string formatter
            Console.WriteLine("My name is {0} and my age is {1}", name,number);


            string newA;
            Console.WriteLine("Please enter your name");
            newA = Console.ReadLine();
            Console.WriteLine("Uppercase =" + newA.ToUpper());
            Console.WriteLine("LowerCase =" + newA.ToLower());
            Console.WriteLine("Uppercase =" + newA.Substring(0,1));// starts at specified position and have specified length
            Console.WriteLine("Trim =" + newA.Trim());//clears white spaces



            Console.ReadKey();


        }
    }
}
