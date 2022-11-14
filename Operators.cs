using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Operators
    {
        static void Main()
        {
            int numOne = 3;
            int numTwo = 4;
            int numThree = 5;

            //unary operator
            int numFour = -numThree;
            Console.WriteLine("value of number Four:" + numFour);
            

            bool flag = true;
            Console.WriteLine("value of flag:" + !flag);
            

            //increment operator
            int num = 10;
            num++;
            Console.WriteLine("New Number 1: " + num);
            Console.WriteLine("New Number 2: " + num++);
            Console.WriteLine("New Number 3: " + num++);
            Console.WriteLine("New Number 4: " + num);


            //decrement operator
            int numDec = 20;
            numDec--;
            Console.WriteLine("New Number decrement 1: " + numDec);
            Console.WriteLine("New Number decrement 2: " + numDec--);
            Console.WriteLine("New Number decrement 3: " + numDec--);
            Console.WriteLine("New Number decrement 4: " + numDec--);
            

            //pre-decrement

            Console.WriteLine("New Number pre decrement 5: " + --numDec);
           


            //Modular 
            int result = numOne + numTwo;
            Console.WriteLine("result = "+ result);
            int modResult = result % numOne;
            Console.WriteLine("Modular = " + modResult);
            

            //relational and type operator
            bool relResult;
            relResult = modResult < result;
            Console.WriteLine("Relational = " + relResult);

            //equality operator
            bool equResult = result == modResult;
            Console.WriteLine("Equal Result = " + equResult);

            bool equResultnot = result != modResult;
            Console.WriteLine("Not Equal Result = " + equResultnot);
           

            //conditional operator
            bool condResult = equResult && equResultnot;
            Console.WriteLine("And Condition Result =" + condResult);
        

            bool condOrResult = equResult || equResultnot;
            Console.WriteLine("OR Condition Result =" + condOrResult);
            Console.ReadLine();

        }
    }
}
