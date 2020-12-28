using System;

namespace BS.CrossCutting.ValueObject
{
    public class DomainException: Exception
    {
        
        public DomainException()
        {
            
        }

        public DomainException(string message): base(message)
        { }
        public DomainException(string message, Exception exception): base(message, exception)
        { }
    }
}