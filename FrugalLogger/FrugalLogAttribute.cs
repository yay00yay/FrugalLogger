using System;
using System.Collections.Generic;
using System.Text;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;


namespace FrugalLogger
{
    public class FrugalLogAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            Dictionary<string, object> log = actionContext.ActionArguments;
            string methodName = actionContext.ActionDescriptor.ActionName;
            var request = actionContext.Request;
            object customObject;
            request.Properties.TryGetValue("alias", out customObject);
            //string alias = (string)customObject;
        }
    }
}
