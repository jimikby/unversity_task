using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.util
{
    internal interface IDataHelper<T>
    {
        void Clean();
        T Read();
        void Write(T objectToWrite);
    }
}
