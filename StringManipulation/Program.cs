﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            FileReader file = new FileReader();
            file.ReadFile();
            Console.ReadLine();
        }
    }
}
