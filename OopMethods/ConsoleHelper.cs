﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopMethods
{
    internal class ConsoleHelper
    {
        public static void Print(string message)
        {
            Console.WriteLine(message);
        }

        public static void Print(string label, string message)
        {
            if (!string.IsNullOrEmpty(label))
            {
                Console.WriteLine($"{label}: ");
            }

            Console.WriteLine(message);
        }

        public static void Print(string message, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(message);
            }
        }
    }
}
