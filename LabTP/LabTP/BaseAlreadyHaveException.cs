using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTP
{
    class BaseAlreadyHaveException : Exception
    {
        public BaseAlreadyHaveException() : base ("На базе уже есть такая техника") { }
    }
}
