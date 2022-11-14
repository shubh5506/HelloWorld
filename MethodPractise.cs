using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class MethodPractise
    {
        static void Main(string[] args)
        {
            string friendOne = "bob";
            string friendTwo = "Stan";
            string friendThree = "Ravi";

            //GreetFriend("bob", "Stan", "Ravi");
            GreetFriend(friendOne,friendTwo,friendThree);
           

            Console.Read();
            WriteNew();
        }
        //access modifier(static), return type method name(parameter 1, parameter 2)
        public static void WriteNew()
        {
            Console.WriteLine("name");
          
        }
        public static void GreetFriend(string friendOne, string friendTwo, string friendThree)
        {
            Console.WriteLine("Hi " + friendOne + ", my friend!");
            Console.WriteLine("Hi " + friendTwo + ", my friend!");
            Console.WriteLine("Hi " + friendThree + ", my friend!");
        }
    }
}
