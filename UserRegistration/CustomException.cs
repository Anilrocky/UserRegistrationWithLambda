using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class CustomException : Exception
    {
        public enum ExceptionType
        {
            INVALID
        }
        public ExceptionType exceptionType;
        public CustomException(ExceptionType exceptionType, string message) : base(message)
        {
            this.exceptionType = exceptionType;
        }
    }
}
