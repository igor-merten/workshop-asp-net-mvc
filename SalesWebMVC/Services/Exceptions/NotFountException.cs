using System;

namespace SalesWebMVC.Services.Exceptions
{
    public class NotFountException : ApplicationException
    {
        public NotFountException (string message) : base(message) { }
    }
}
