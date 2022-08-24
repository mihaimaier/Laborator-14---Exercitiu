using System;
using System.Collections.Generic;
using System.Text;

namespace Laborator_14___Exercitiu
{
    internal class NullException : Exception
    {
        private const string nullException = "Null Exception";

        public NullException():base(nullException)
        {
        }
    }
}
