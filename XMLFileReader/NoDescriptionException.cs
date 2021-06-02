using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLFileReader
{
    [Serializable]
    public class NoDescriptionException : Exception
    {
        public NoDescriptionException() { }

        public NoDescriptionException(string message)
            : base(message) { }

        public NoDescriptionException(string message, Exception inner)
            : base(message, inner) { }
    }
}
