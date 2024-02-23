using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    internal class ActionResponse : Response
    {
        
        public string Output { get; set; }

        public ActionResponse()
        {
            ResponseID = Guid.NewGuid();
            // Initialize string properties so they won't be Null
            Output = string.Empty;
        }
    }
}
