using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCSharpApp
{
    class Program
    {
        static void ShowEnvironmentalDetails()
        {
            foreach (string drive in Environment.GetLogicalDrives())
            {
                Console.WriteLine("Drive: {0}", drive);
            }

            Console.WriteLine("OS: {0}", Environment.OSVersion);
            Console.WriteLine("Number of processors: {0}", Environment.ProcessorCount);
            Console.WriteLine(".NET Version: {0}", Environment.Version);
        }
        static void Main(string[] args)
        {
            // Display a simple message to the user.
            Console.WriteLine("***** My First C# App *****");
            Console.WriteLine("Hello World!");
            Console.WriteLine();

            // Get arguments using System.Environment
            string[] theArgs = Environment.GetCommandLineArgs();
            foreach (string arg in theArgs)
            {
                Console.WriteLine("Arg: {0}", arg);
            }

            Console.WriteLine();
            ShowEnvironmentalDetails();

            Console.ReadLine();
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

        // Note we are now returning an int, rather than void.
        //static int Main(string[] args)
        //{
        //    // Display a simple message to the user.
        //    Console.WriteLine("***** My First C# App *****");
        //    Console.WriteLine("Hello World!");
        //    Console.WriteLine();
        //    Console.ReadLine();

        //    // Return an arbitrary error code.
        //    return -1;
        //}
    }
}
