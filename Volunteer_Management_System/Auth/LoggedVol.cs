using BLL.Services;
using System;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace Volunteer_Management_System.Auth
{
    public class LoggedVol: AuthorizationFilterAttribute
    {
        public override void OnAuthorization(HttpActionContext actionContext)
        {
            var auth1 = actionContext.Request.Headers.Authorization;
            if (auth1 == null)
            {
                actionContext.Response = actionContext.Request.CreateResponse(System.Net.HttpStatusCode.Unauthorized, "Token Not provided");
            }
            else if (!AuthService.IsTokenValid1(auth1.ToString()))
            {
                actionContext.Response = actionContext.Request.CreateResponse(System.Net.HttpStatusCode.Unauthorized, "Supply Token is Invalid or Expired");

            }
            base.OnAuthorization(actionContext);
        }
    }
}