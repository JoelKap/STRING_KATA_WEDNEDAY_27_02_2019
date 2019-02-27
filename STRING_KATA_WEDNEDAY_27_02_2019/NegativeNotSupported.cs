using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace STRING_KATA_WEDNEDAY_27_02_2019
{
    [Serializable]
    internal class NegativeNotSupported : Exception
    {
        public NegativeNotSupported()
        {
        }

        public NegativeNotSupported(string message) : base(message)
        {
        }

        public NegativeNotSupported(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NegativeNotSupported(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
