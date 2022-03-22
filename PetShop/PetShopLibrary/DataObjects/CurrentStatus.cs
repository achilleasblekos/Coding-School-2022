using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopLibrary.DataObjects
{
    public enum Status
    {
        Active,
        Inactive
    }
    public class CurrentStatus
    {
        public Status ObjectStatus { get; set; } = Status.Active;
    }
}
