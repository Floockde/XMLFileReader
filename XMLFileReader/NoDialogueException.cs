using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLFileReader
{
    [Serializable]
    public class NoDialogueException : Exception
    {
        public NoDialogueException() { }

        public NoDialogueException(string message)
            : base(message) { }

        public NoDialogueException(string message, Exception inner)
            : base(message, inner) { }
    }
}
