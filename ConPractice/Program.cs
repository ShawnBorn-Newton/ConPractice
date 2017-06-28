using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Shawn's equality tracker.");
            //enter first number
            Console.WriteLine("Please enter your first number and press Enter.");
            double firstNum = int.Parse(Console.ReadLine());

            //enter secon number
            Console.WriteLine("Please enter your second number and press Enter.");
            double secondNum = int.Parse(Console.ReadLine());
            
            //if equal else not
            if (firstNum == secondNum)
            {
                Console.WriteLine("These numbers are indeed equal.");
            }
            else
            {
                Console.WriteLine("These number are so not equal.");
            }
        }
    }
}
