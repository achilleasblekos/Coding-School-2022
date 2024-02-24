using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicProcessing
{
    public interface ICreateObjectOperation<T>
    {
        T CreateObject();
    }
}
