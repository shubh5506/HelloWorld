
namespace NewFile
{
    public class MyItems
    {
        static void Main()
        {
            //Name,Gender,Salary,Email
            Console.WriteLine("Enter Name");
            string nam = Console.ReadLine();
            Console.WriteLine("Enter Gender");
            char gender = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter Email");
            string email = Console.ReadLine();
            Console.WriteLine("Enter Salary ");
            double salary = Convert.ToInt32(Console.ReadLine());
            AllDetails(nam, gender, email, salary);
        }
        private static void AllDetails(string name, char gender, string email, double salary)
        {               
            Console.WriteLine("My name is " + name + " , gender is" + gender + ". Please reachout on my email" + email + " and I am poor man with salary" + salary);
        }
    }
}
