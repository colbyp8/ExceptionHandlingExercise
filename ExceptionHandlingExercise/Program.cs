using System;
using System.Collections.Generic;
using System.IO;

namespace ExceptionHandlingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // -----------------------------------------------------------------------------
            // First create a char[], it must contain 6 numbers and 3 letters - name it arr
            // Create a list called numbers that will hold integers
            // Create a string variable with an empty string initializer - name it str
            // using a foreach loop, attempt to parse the elements in your char[] with int.Parse()
            // and Exceptions will be thrown 
            // Below we will set this up 
            // ------------------------------------------------------------------------------

            var arr = new char[] { '1', '2', '3', '4', '5', '6', 'a', 'b', 'c' };
            List<int> numbers = new List<int>();
            string str;
            foreach (var character in arr)
            {
                int number;
                try
                {
                    str = character.ToString();
                    number = int.Parse(str);
                    numbers.Add(number);
                }
                catch(Exception e)
                {
                    Console.WriteLine($"Unable to Parse '{character}'");
                }
            }
            Console.WriteLine("List of Numbers:");
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
