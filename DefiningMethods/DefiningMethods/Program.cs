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
            //int num1 = 1;                           //Method and variables declared inside "main" scope
            //int num2 = 2;

            //Console.WriteLine("Sum 1,2");

            //Console.WriteLine("Please enter a number: ");
            //int number = int.Parse(Console.ReadLine());
            //Console.WriteLine($"The input {number} changed is: {ChangeSign(number)}");


            Console.WriteLine($"Enter number of miles to be coverted: ");
            

            //Console.WriteLine($"Enter number of kilometers to be converted: ");
            //double kilometers = Int32.Parse(Console.ReadLine());

            Console.ReadLine();

            string[] days = { "Mon", "Tues", "Wed", "Thurs", "Fri", "Sat", "Sun" };
            Console.WriteLine($"Please enter a number i will tell you the coresponding day: ");
            int input = int.Parse(Console.ReadLine());
            CheckDay(input, days);

        }

        //public static int Sum(int num1, int num2)   //Creating new scope to call variables called in the "main" scope
        //{
        //    return num1+num2;
        //}

        //public static int ChangeSign(int number)
        //{
        //    return number * -1; 
        //}


        //Q2
        public static double ConvertMilesToKilometers(double miles)
        {
            double result = miles * 0.62137;
            return result;
        }

        //Q2
        public static double ConvertKilometersToMiles(double kilometers)
        {
            return kilometers * 0.62137;
        }

        //Q4
        public static void CheckDay(int input, string[] days)
        {
            Console.WriteLine($"The day is: {days[input - 1]}");
        }

    }
}
