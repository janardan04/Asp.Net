using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_sqrt
{
    internal class Program
    {
        static void Main(string[] args)

        {
            try
            {
                Console.WriteLine("Enter the number :");
                int n = Convert.ToInt32(Console.ReadLine());

                if (n < 0)
                {
                    throw new ArgumentException("Cannot calculate square root of a negative number!");
                }

                Double sqrt = Math.Sqrt(n);
                Console.WriteLine(sqrt);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid Input enter the valid input !!!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected eroor !!" + ex.Message);
            }
        }
    }
}
