using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.util
{
    internal interface IDataSerivce<T>
    {
        T Read();
        void Write(T objectToWrite);
    }
}
