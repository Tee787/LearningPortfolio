//Using "if and else" statements in programming
//Here are examples using "int" identifier for whole numbers in equations 
//Using the keyword "boolean" as the identifier for "true or false" output statement
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfandElse
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int a = 9;
            int b = 7;
            int c = 6;

            if (a * b + c > 100) 
            {
                Console.WriteLine("The answer is greater than 100");
            }
            else 
            {
                Console.WriteLine("The answer is less than 100");
            }
            Console.ReadLine();*/

            int a = 9 * 10;
            int b = 81 / 9;
            int c = 1000;

            if (a * b + c == 1000)
            {
                Console.WriteLine("The answer is greater than 100");
            }
            else
            {
                Console.WriteLine("The answer is less than 100");
            }
            Console.ReadLine();


        }
    }
}
