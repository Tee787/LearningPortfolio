using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstname, lastname;

            Console.WriteLine("Please enter your firstname: ");
            firstname = Console.ReadLine();

            Console.WriteLine("Now enter your lastname: ");
            lastname = Console.ReadLine();
        }
        public static void FullName(string firstname, lastname)
        {
            Console.WriteLine("Your name is: " + firstname + " " + lastname);
            
        }
    }
}
