using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTP
{
    class BaseNotFoundException : Exception
    {
        public BaseNotFoundException(int i) : base("Не найдена техника по месту" + i)
        {

        }
    }
}
