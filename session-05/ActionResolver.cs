using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session_05
{
    internal class ActionResolver
    {

        public MessageLogger Logger { get; set; }



        public ActionResolver()
        {

        }


        public ActionResponse Execute(ActionRequest request)
        {

            var response = new ActionResponse();

            // DO ALL THE THINGS!



            return response;
        }

    }
}
