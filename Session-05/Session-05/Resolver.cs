using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    abstract class Resolver
    {
        public Resolver()
        {

        }

        public abstract ActionResponse Execute(ActionRequest actionRequest);
    }
}
