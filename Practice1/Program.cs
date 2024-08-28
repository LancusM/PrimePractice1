using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            //assign a flag to if number is prime(if condition is met)
            bool prime = true;
            string exitResponse = "";
            do
            {
                //initial prompt
                Console.WriteLine("Enter a whole number: ");
                num = Convert.ToInt32(Console.ReadLine());
                //from 2 to input number
                prime = num == 1 ? false : true;
                for (int i = 2; i < num; i++)
                {
                    if (num % i == 0) //check divisibility
                    {
                        prime = false; //flag breaks when false
                        break;
                    }
                }
                //check flag, output result
                if (prime)
                {
                    Console.WriteLine(num + " is a prime number.");
                }
                else
                {
                    Console.WriteLine(num + " is not a prime number.");
                }
                Console.WriteLine("Do you want to continue? (Y/N)?");
                exitResponse = Console.ReadLine();
                //Console.Read();
            }
            while (exitResponse.ToLower().StartsWith("y"));
        }
    }
}
