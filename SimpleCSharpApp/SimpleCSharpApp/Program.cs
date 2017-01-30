﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCSharpApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display a simple message to the user.
            Console.WriteLine("***** My First C# App *****");
            Console.WriteLine("Hello World!");
            Console.WriteLine();
        }

        // Alt 1:
        // int return type, array of strings as the parameter
        //static int Main(string[] args)
        //{
        //    // Must return a value before exiting!
        //    return 0;
        //}

        // Alt 2:
        // No return type, no parameters
        //static void Main()
        //{

        //}

        // Alt 3:
        // int return type, no parameters
        //static int Main()
        //{
        //    // Must return a value before exiting!
        //    return 0;
        //}
    }
}