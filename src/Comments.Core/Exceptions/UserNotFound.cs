using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SunsilEdizioni.Core.Model;

namespace SunsilEdizioni.Core.Exceptions
{
    public class UserNotFound : Exception
    {
        public UserNotFound(int id) : base($"Commento non trovato: {id}")
        {
        }
    }
}
