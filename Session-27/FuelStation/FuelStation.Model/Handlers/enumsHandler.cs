using FuelStation.Model.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Model.Handlers
{
    public class enumsHandler
    {
        public enumsHandler()
        {

        }

        public IEnumerable GetEmployeeEnumList()
        {
            var employeeEnumData = from EmployeeTypeEnum e in Enum.GetValues(typeof(EmployeeTypeEnum))
                                   select new
                                   {
                                       ID = (int)e,
                                       Name = e.ToString()
                                   };

            return employeeEnumData;
        }
        public IEnumerable GetPaymentEnumList()
        {
            var PaymentEnumData = from PaymentMethodEnum e in Enum.GetValues(typeof(PaymentMethodEnum))
                                  select new
                                  {
                                      ID = (int)e,
                                      Name = e.ToString()
                                  };

            return PaymentEnumData;
        }
        public IEnumerable GetItemTypeEnumList()
        {
            var ProductTypeEnumData = from ItemTypeEnum e in Enum.GetValues(typeof(ItemTypeEnum))
                                      select new
                                      {
                                          ID = (int)e,
                                          Name = e.ToString()
                                      };

            return ProductTypeEnumData;
        }
    }
}
