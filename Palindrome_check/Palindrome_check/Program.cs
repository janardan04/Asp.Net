using System;

namespace Palindrome_check
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int Original = n;
            int palindrome = 0;

            // Without Recursion
            int temp = n;
            while (temp > 0)
            {
                int digit = temp % 10;
                palindrome = (palindrome * 10) + digit;
                temp /= 10;
            }

            if (Original == palindrome)
            {
                Console.WriteLine("The number is palindrome");
            }
            else
            {
                Console.WriteLine("The number is not palindrome!!");
            }

            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Using Recursion");

            int reversed = Is_palindrome(n, 0);

            if (n == reversed)
            {
                Console.WriteLine("The number is palindrome (using recursion)");
            }
            else
            {
                Console.WriteLine("The number is not palindrome (using recursion)");
            }
        }

        // Recursive method to reverse number
        static int Is_palindrome(int n, int palindrome)
        {
            if (n == 0)
                return palindrome;

            int digit = n % 10;
            palindrome = (palindrome * 10) + digit;
            return Is_palindrome(n / 10, palindrome);
        }
    }
}
