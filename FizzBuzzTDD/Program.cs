﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzzLibrary;

namespace FizzBuzzTDD
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 100; i++)
            {
                //cannot add FIzzBuzzLibrary because of different versions, thanks VISUAL STUDIO!
                //Console.WriteLine(FizzBuzer.GetValue(i).ToString);
            }
            Console.ReadKey();
        }
    }
}
