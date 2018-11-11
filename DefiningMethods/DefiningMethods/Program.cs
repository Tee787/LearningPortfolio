using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 1;                           //Method and variables declared inside "main" scope
            int num2 = 2;

            Console.WriteLine("Sum 1,2");

            Console.WriteLine("Please enter a number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine($"The input {number} changed is: {ChangeSign(number)}");

        }

        public static int ChangeSign(int number)
        {
            return number * -1;
        }

                

    }
}
