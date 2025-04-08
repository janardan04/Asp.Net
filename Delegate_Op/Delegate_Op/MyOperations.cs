using System;

namespace Delegate_Op
{
    public class MyOperations
    {
        // Function to divide two numbers and handle divide-by-zero
        public int Divide(int a, int b)
        {
            try
            {
                return a / b; // This may cause DivideByZeroException
            }
            catch (DivideByZeroException)
            {
                // Throw custom exception with code 101
                throw new MyCustomException(101, "You cannot divide by zero.");
            }
        }

        // Function to get element at specific index from array
        public int GetElement(int[] arr, int index)
        {
            try
            {
                return arr[index]; // This may cause IndexOutOfRangeException
            }
            catch (IndexOutOfRangeException)
            {
                // Throw custom exception with code 102
                throw new MyCustomException(102, "Index is out of range.");
            }
        }
    }
}
