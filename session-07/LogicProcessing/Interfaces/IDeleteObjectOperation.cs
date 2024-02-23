using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicProcessing
{
    public interface IDeleteObjectOperation<T>
    {
        void DeleteObject(T obj, List<T> list);
    }
}
