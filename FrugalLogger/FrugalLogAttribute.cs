using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Reflection;
using System.Security.Principal;
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
            String authString = actionContext.Request.Headers.Authorization.Parameter.ToString();
            var handler = new JwtSecurityTokenHandler();
            var readableToken = handler.CanReadToken(authString);
            if (readableToken == true)
            {
                var token = handler.ReadJwtToken(authString);
                var claims = token.Claims;
                string identity = claims.First(claim => claim.Type == "appid").Value;
                var upn = claims.FirstOrDefault(claim => claim.Type == "upn");

                if (identity == null)
                {
                    identity = upn.Value.ToLower().Split('@')[0];
                }

            }
        }
    }
}
