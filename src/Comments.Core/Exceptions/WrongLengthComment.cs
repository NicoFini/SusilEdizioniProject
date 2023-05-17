using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SunsilEdizioni.Core.Model;

namespace SunsilEdizioni.Core.Exceptions
{
    public class WrongLengthComment : Exception
    {
        public WrongLengthComment(string comment) : base($"La lunghezza del commento deve essere minimo 10 caratteri: {comment}")
        {
        }
    }
}
