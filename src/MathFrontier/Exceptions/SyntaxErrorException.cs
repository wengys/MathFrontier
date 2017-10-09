using System;

namespace MathFrontier.Exceptions
{
    public class SyntaxErrorException : Exception
    {
        public SyntaxErrorException(string phase, string message)
            : base($"SyntaxError {phase} {message}")
        {
        }
    }
}