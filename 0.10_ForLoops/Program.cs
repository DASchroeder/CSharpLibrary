﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._10_ForLoops
{
    class Program
    {
        static void Main(string[] args)
        {

            //lcv = 

            /* for (int lcv = 0; lcv < 15; lcv++)
             {
                 Console.WriteLine("Paul is a Joker");

             for (int i = 0; i < 20; i++)
             {
                 //Console.WriteLine("Paul is a Joker");
                 if (i % 2 == 0)
                 {
                     Console.WriteLine("Even");
                 }
                 else
                 {
                     Console.WriteLine(i);
                 }
             } 


             for (int i = 0; i <= 10; i++)

             {
                 Console.WriteLine(i);
             }
             */
             //adding 1 + 2 + 3 + 4 etc
            int sum = 0;
            for (int i = 0; i <= 10; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine(sum);

            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }



            Console.ReadLine();
            



        }
    }
}
