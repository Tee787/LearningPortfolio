using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("********************************************************************");
            //Console.WriteLine("**************************Question 1********************************");
            //Console.WriteLine("********************************************************************\n");

            //string input;
            
            //Console.WriteLine("\nPlease enter a letter and I will tell you if it is a Vowel or not\n: ");
            //input = Console.ReadLine();

            //switch (input)
            //{
            //    case "a":
            //    case "e":
            //    case "i":
            //    case "o":
            //    case "u":
            //        Console.WriteLine($"\n{input} is a vowel");
            //        break;                    
            //    default:
            //        Console.WriteLine($"\n{input} is a consonant");
            //        break;                    
            //}
            //Console.ReadLine();

            //Console.WriteLine("********************************************************************");
            //Console.WriteLine("**************************Question 2********************************");
            //Console.WriteLine("********************************************************************\n");

            //double weight;
            //double height;

            //Console.WriteLine("\nPlease enter your weight in kilograms: ");
            //weight = double.Parse(Console.ReadLine());
            //Console.WriteLine("\nNow enter your height in centimeters: ");
            //height = (double.Parse(Console.ReadLine()))/100;

            //Console.WriteLine("\nYour BMI is: " + (weight / (height * height)));
            //Console.ReadLine();


            //Console.WriteLine("********************************************************************");
            //Console.WriteLine("**************************Question 3********************************");
            //Console.WriteLine("********************************************************************\n");

            //double total = 0;

            //for(int i=1; i<=20; i++)
            //{
            //    Console.WriteLine($"Please enter number {i}: ");
            //    total = total + double.Parse(Console.ReadLine());
                
            //}
            //Console.WriteLine($"The sum of the numbers that have been entered is: {total} ");
            //Console.ReadLine();


            Console.WriteLine("********************************************************************");
            Console.WriteLine("**************************Question 4********************************");
            Console.WriteLine("********************************************************************\n");

            int n, factorial, result;
            

            Console.WriteLine("Please enter your number: ");
            n = int.Parse(Console.ReadLine());

            //factorial = 1;
            /*--------------------------------------------------------------------------------------------------------------*/
            //for (int i = 1; i <= n; i++)   //for statement
            //{
            //    factorial *= i;
            //}
            //Console.WriteLine(factorial);
            /*---------------------------------------------------------------------------------------------------------------*/
            //factorial = 1;
            //do                               //do while statement
            //{
            //    factorial *= n;
            //    n--;
            //} while (n > 0);

            //Console.WriteLine("{0}", factorial);
            /*----------------------------------------------------------------------------------------------------------------*/
            result = 1;
            while (true)
            {
                Console.Write(n);
                if (n == 1)
                {
                    break;
                }
                Console.Write(" * ");
                result *= n;
                n--;
            }
            Console.WriteLine("{0}", result);

            Console.ReadLine();


        }
    }
}
