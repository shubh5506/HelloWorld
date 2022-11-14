using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class ImplicitandExplicit
    {

        static void Main()
        {
            int first;
            double second = 13.46;

            float third = 13377;

            //implicit Conversion - smaller type to bigger type
            double implicitNum = third;
            Console.WriteLine("implicit conversion " + implicitNum);
            
            //explicit 
            //cast double to int
            first = (int)second;
            Console.WriteLine("explicit conversion " + first);
            Console.ReadKey();
        }
       
    }
}
