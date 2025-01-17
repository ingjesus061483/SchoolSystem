using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiWebApplication
{
    public abstract  class Utilities
    {
        public static string GetErrors(System.Web.Http.ModelBinding.ModelStateDictionary modelstate)
        {
            string msg = "";
            foreach (var item in modelstate.Values)
            {
                foreach (var err in item.Errors)
                {
                    msg += err.ErrorMessage + Environment.NewLine;
                }
            }
            return msg;
        }
    }
}