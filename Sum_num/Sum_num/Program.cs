using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;


//b.	Write a C# program to read ‘n’ digit integer (for ex. 123, 1234, 12345 etc) and print the sum of all digits. 
namespace Sum_num
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number : ");
            int n= Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            while (n > 0)
            {
                //getting the last digit
                int l = n % 10;
                sum += l;
                n /= 10;
            }
            Console.WriteLine("The Sum is : "+sum);
                
        }
    }
}
