﻿using System;
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
            //Console.WriteLine("Welcome to Shawn's equality tracker.");
            ////enter first number
            //Console.WriteLine("Please enter your first number and press Enter.");
            //double firstNum = double.Parse(Console.ReadLine());

            ////enter secon number
            //Console.WriteLine("Please enter your second number and press Enter.");
            //double secondNum = double.Parse(Console.ReadLine());

            ////if equal else not
            //if (firstNum == secondNum)
            //{
            //    Console.WriteLine("These numbers are indeed equal.");
            //}
            //else
            //{
            //    Console.WriteLine("These number are so not equal.");
            //}

            ////exercise 2
            //Console.WriteLine("Is your number even or odd? Let's find out!");
            ////enter number

            //Console.WriteLine("Please enter your number and press Enter.");
            //double num = double.Parse(Console.ReadLine());

            ////if and else
            //if (num % 2 == 0)
            //{
            //    Console.WriteLine("This numer is even.");

            //}
            //else
            //{
            //    Console.WriteLine("This numer is odd.");
            //}

            // exercise 3
            //Console.WriteLine("Is your number possitive or negative?");

            //Console.WriteLine("Please enter your number and press enter.");
            //double num = double.Parse(Console.ReadLine());
            //if (num >= 0)
            //{
            //    Console.WriteLine("ARRG THIS NUMBARE BE POSSITIVE SO IT BEEE.");
            //}
            //else
            //{
            //    Console.WriteLine("Yeah its like, totaly negative guy.");
            //}

            //exercise 4
            //Console.WriteLine(" Is it a letter and vowel or consonant?");
            //Console.WriteLine("Please type a letter and press enter.");

            //string letter = Console.ReadLine();
            //switch(letter)
            //{
            //    case "a":
            //    case "A":
            //            Console.WriteLine("ITS A VOWEL");
            //        break;

            //    case "e":
            //    case "E":
            //            Console.WriteLine("ITS A VOWEL");
            //    break;

            //    case "i":
            //    case "I":
            //        Console.WriteLine("ITS A VOWEL");
            //        break;

            //    case "o":
            //    case "O":
            //        Console.WriteLine("ITS A VOWEL");
            //        break;

            //    case "u":
            //    case "U":
            //        Console.WriteLine("ITS A VOWEL");
            //        break;

            //    case "y":
            //    case "Y":
            //        Console.WriteLine("ITS A VOWEL (but only some times...)");
            //        break;

            //    default:
            //        Console.WriteLine("ITS A CONSONANT");
            //        break;
            //}
            //exercise 5
            //Console.WriteLine("Let's see what number is bigger.");
            //Console.WriteLine("Please type your first number and press enter.");
            //double firstNum = double.Parse(Console.ReadLine());

            //Console.WriteLine("Now type your second number and press enter.");
            //double secondNum = double.Parse(Console.ReadLine());

            //if(firstNum > secondNum)
            //{
            //    Console.WriteLine(firstNum + "is bigger.");
            //} 
            //else if(firstNum < secondNum)
            //{
            //    Console.WriteLine(secondNum + "is bigger.");
            //} 
            //else
            //{
            //    Console.WriteLine("These numbers are equaly awsome.");
            //}
            Console.WriteLine("Lets find the mean of four numbers.");
            Console.WriteLine("Please enter your first number and press enter.");
            double first = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your second number and press enter.");
            double second = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your thired number and press enter.");
            double thired = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your fourth number and press enter.");
            double fourth = double.Parse(Console.ReadLine());

            double mean = (first + second + thired + fourth) / 4;
            Console.WriteLine(mean + " is the mean, or average of your four numbers."); 


        }
    }
}
