using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLFileReader
{
    [Serializable]
    public class NoSceneException : Exception
    {
        public NoSceneException() { }

        public NoSceneException(string message)
            : base(message) { }

        public NoSceneException(string message, Exception inner)
            : base(message, inner) { }
    }
}
