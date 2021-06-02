using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLFileReader
{
    [Serializable]
    public class NoNameException : Exception
    {
        public NoNameException() { }

        public NoNameException(string message)
            : base(message) { }

        public NoNameException(string message, Exception inner)
            : base(message, inner) { }
    }
}
