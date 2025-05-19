using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Volunteer_Management_System.Auth;

namespace Volunteer_Management_System.Controllers
{
    public class VolunteerController : ApiController
    {


        [Logged]
        [HttpGet]
        [Route("api/volunteer/all")]
        public HttpResponseMessage GetAll()
        {
            var data = VolunteerService.Get();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [LoggedVol]
        [HttpGet]
        [Route("api/volunteer/{id}")]
        public HttpResponseMessage Get(int id)
        {
            var data = VolunteerService.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [Logged]
        [HttpPost]
        [Route("api/volunteer/create")]
        public HttpResponseMessage Create(VolunteerDTO v)
        {
            VolunteerService.Create(v);

            return Request.CreateResponse(HttpStatusCode.OK, "Volunteer Added Successfully");
        }

        [Logged]
        [HttpPut]
        [Route("api/volunteer/update/{id}")]
        public HttpResponseMessage Update(int id, VolunteerDTO s)
        {
            VolunteerService.Update(id, s);
            return Request.CreateResponse(HttpStatusCode.OK, "Volunteer updated successfully.");
        }

        [Logged]
        [HttpDelete]
        [Route("api/volunteer/delete/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            VolunteerService.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, "Volunteer deleted successfully.");
        }
        // Search by Foriegn Key

        [Logged]
        [HttpGet]
        [Route("api/volunteer/{id}/admin")]
        public HttpResponseMessage GetwithAdmin(int id)
        {
            var data = VolunteerService.GetwithAdmin(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [Logged]
        [HttpGet]
        [Route("api/volunteer/{id}/event")]
        public HttpResponseMessage GetwithEvent(int id)
        {
            var data = VolunteerService.GetwithEvent(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [Logged]
        // Search by Feature
        [HttpGet]
        [Route("api/volunteer/search/name/{name}")]
        public HttpResponseMessage SearchByName(string name)
        {
            var data = VolunteerService.SearchByName(name);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Logged]
        [HttpGet]
        [Route("api/volunteer/search/availability/{availability}")]
        public HttpResponseMessage SearchByAvailability(string availability)
        {
            var data = VolunteerService.SearchByAvailability(availability);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }


    }
}
