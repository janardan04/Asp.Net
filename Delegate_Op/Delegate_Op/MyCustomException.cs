using System;

namespace Delegate_Op
{
    // This is a custom exception class that includes an error code and a custom message
    public class MyCustomException : Exception
    {
        public int ErrorCode { get; set; }  // Property to store the error code

        public MyCustomException(int code, string message) : base(message)
        {
            ErrorCode = code;
        }
    }
}
