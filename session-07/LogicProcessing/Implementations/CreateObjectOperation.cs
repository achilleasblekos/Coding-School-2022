using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicProcessing.Implementations
{
    public class CreateObjectOperation<T> : ICreateObjectOperation<T>
    {
        public CreateObjectOperation()
        {
        }

        public T CreateObject()
        {
            // TODO: Create an object of variable type?
            T obj = (T)new object();

            return obj;
        }
    }
}
