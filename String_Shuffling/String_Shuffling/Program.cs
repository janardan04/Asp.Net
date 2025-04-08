using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Shuffling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //accepting the string

            Console.WriteLine("Enter the String :");
            string str=Console.ReadLine();
            int len=str.Length;
            if (len < 2)
            {
                Console.WriteLine("Enter the string which contains more than two words");
            }
            else
            {
                char first = str[0];
                char last = str[len - 1];
                string middle = str.Substring(1, len - 2);
                Console.WriteLine(last + middle + first);
            }
        }
    }
}
