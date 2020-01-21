using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTP
{
    class BaseOverflowException:Exception
    {
        public BaseOverflowException() : base("Нет свободных мест")
        {

        }
    }
}
