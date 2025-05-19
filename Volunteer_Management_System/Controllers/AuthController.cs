using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Volunteer_Management_System.Controllers
{
    public class AuthController : ApiController
    {
        [HttpPost]
        [Route("api/login")]
        public HttpResponseMessage Login(AdminDTO a)
        {
            var data = AuthService.Authenticate(a.Username, a.Password);
            if(data != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, data, "Login Successfully");
            }
            return Request.CreateResponse(HttpStatusCode.NotFound, "Username or Password Invalid");
        }
        [HttpPost]
        [Route("api/logout")]
        public HttpResponseMessage Logout(TokenDTO token)
        {
            var data = AuthService.Logout(token.Key);
            if (data ==true)
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Logout Successfully");
            }
            return Request.CreateResponse(HttpStatusCode.NotFound);
        }

        [HttpPost]
        [Route("api/login/volunteer")]
        public HttpResponseMessage Login(VolunteerDTO v)
        {
            var data = AuthService.Authenticate1(v.Name, v.Contact);
            if (data != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            return Request.CreateResponse(HttpStatusCode.NotFound);
        }
    }
}
