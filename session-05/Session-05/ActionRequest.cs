using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    internal class ActionRequest : Request
    {
        public String Input { get; set; }
        public ActionEnum Action { get; set; }

        public ActionRequest()
        {
            RequestID = Guid.NewGuid();
            // Initialize string properties to not be Null
            Input = String.Empty;
        }
    }
}
