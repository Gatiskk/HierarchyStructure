using System;

namespace Hierarchy.Exceptions
{
    public class InvalidOperationException : Exception
    {
        public InvalidOperationException() : base("Sequence contains no elements") { }
    }
}