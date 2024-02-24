using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicProcessing.Implementations
{
    public class DeleteObjectOperation<T> : IDeleteObjectOperation<T>
    {
        public DeleteObjectOperation()
        {

        }

        public void DeleteObject(T obj, List<T> list)
        {
            list.Remove(obj);
        }
    }
}
