﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLFileReader
{
    [Serializable]
    public class NoStoryException : Exception
    {
        public NoStoryException() { }

        public NoStoryException(string message)
            : base(message) { }

        public NoStoryException(string message, Exception inner)
            : base(message, inner) { }
    }
}
