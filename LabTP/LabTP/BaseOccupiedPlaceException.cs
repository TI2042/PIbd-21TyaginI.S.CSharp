using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTP
{
    class BaseOccupiedPlaceException : Exception
    {
        public BaseOccupiedPlaceException(int i) : base("На месте" + i + " уже стоит техника")
        {

        }
    }
}
