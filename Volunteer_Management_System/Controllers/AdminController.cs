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
    public class AdminController : ApiController
    {

        [HttpGet]
        [Route("api/admin/all")]
        public HttpResponseMessage GetAll()
        {
            var data = AdminService.Get();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [HttpGet]
        [Route("api/admin/{id}")]
        public HttpResponseMessage Get(int id)
        {
            var data = AdminService.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [HttpPost]
        [Route("api/admin/create")]
        public HttpResponseMessage Create(AdminDTO a)
        {
            AdminService.Create(a);
      
            return Request.CreateResponse(HttpStatusCode.OK, "Admin Added Successfully");
        }

        [HttpPut]
        [Route("api/admin/update/{id}")]
        public HttpResponseMessage Update(int id, AdminDTO s)
        {
            AdminService.Update(id, s);
            return Request.CreateResponse(HttpStatusCode.OK, "Admin updated successfully.");
        }

        [HttpDelete]
        [Route("api/admin/delete/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            AdminService.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, "Admin deleted successfully.");
        }

        [HttpGet]
        [Route("api/admin/{id}/event")]
        public HttpResponseMessage GetwithEvents(int id)
        {
            var data = AdminService.GetwithEvents(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [HttpGet]
        [Route("api/admin/{id}/volunteer")]
        public HttpResponseMessage GetwithVolunteers(int id)
        {
            var data = AdminService.GetwithVolunteers(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

    }
}
