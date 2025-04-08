using System;
using Delegate_Op; // Using your class library namespace

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create object of MyOperations class
            MyOperations op = new MyOperations();

            try
            {
                // Trying to divide 10 by 0 - will throw error
                Console.WriteLine("Trying to divide 10 by 0...");
                int result = op.Divide(10, 0);
                Console.WriteLine("Result: " + result);
            }
            catch (MyCustomException ex)
            {
                // Catch and show custom error with error code and message
                Console.WriteLine($"[ERROR {ex.ErrorCode}] {ex.Message}");
            }

            try
            {
                // Trying to access index 5 in an array of 3 elements
                Console.WriteLine("\nTrying to access index 5 of array [1,2,3]...");
                int[] arr = { 1, 2, 3 };
                int element = op.GetElement(arr, 5);
                Console.WriteLine("Element: " + element);
            }
            catch (MyCustomException ex)
            {
                // Show custom exception details
                Console.WriteLine($"[ERROR {ex.ErrorCode}] {ex.Message}");
            }

            Console.ReadLine(); // Pause console
        }
    }
}
