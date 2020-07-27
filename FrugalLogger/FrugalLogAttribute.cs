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
            var log = actionContext.ActionArguments;
        }
    }
}
