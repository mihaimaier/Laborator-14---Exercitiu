using System;
using System.Collections.Generic;
using System.Text;

namespace Laborator_14___Exercitiu
{
    class InvalidAccountException : Exception
    {
        private const string invalidAccount = "Account is Invalid!";

        public InvalidAccountException(): base(invalidAccount)
        {
        }
    }
}
