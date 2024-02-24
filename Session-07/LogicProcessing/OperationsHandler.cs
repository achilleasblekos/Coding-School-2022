using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicProcessing
{
    public class OperationsHandler<T>
    {
        private ICreateObjectOperation<T> _createObjectOperation;
        private IDeleteObjectOperation<T> _DeleteObjectOperation;

        public OperationsHandler(ICreateObjectOperation<T> createObjectOperation, IDeleteObjectOperation<T> deleteObjectOperation)
        {
            _createObjectOperation = createObjectOperation;
            _DeleteObjectOperation = deleteObjectOperation;
        }

        public T CreateObject()
        {
            return _createObjectOperation.CreateObject();
        }

        public void DeleteObject(T obj, List<T> list)
        {
            _DeleteObjectOperation.DeleteObject(obj, list);
        }

    }

}
