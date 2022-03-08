using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session_05
{
    public enum ActionEnum
    {
        Convert,
        Uppercase,
        Reverse

    }



    internal abstract class ActionRequest
    {
        public Guid RequestId { get; set; }
        public string Input { get; set; }
        public ActionEnum Action { get; set; }

        public abstract string ToString();

        public ActionRequest()
        {

        }

        internal class Convert : ActionRequest
        {
            public Convert()
            {
               
            }

            public override string ToString()
            {
                return ToString();
            }
        }


        internal class Uppercase : ActionRequest
        {
            public Uppercase()
            {
                
            }

            public override string ToString()
            {
                return ToString();
            }
        }

        internal class Reverse : ActionRequest
        {
            public Reverse()
            {

            }

            public override string ToString()
            {
                return ToString();
            }
        }

    }

    //private string ToString(ActionEnum action)
    //{

    //    if (action == ActionEnum.Convert)
    //    {
    //        return 0;
    //    }
    //    else if (action == ActionEnum.Uppercase)
    //    {
    //        // TODO: DO 2
    //    }
    //    else if (action == ActionEnum.Reverse)
    //    {
    //        // TODO: DO 3
    //    }
    //    else
    //    {
    //        // TODO: DO 4
    //    }
    //}

    internal abstract class ActionResponse
    {

    }



}