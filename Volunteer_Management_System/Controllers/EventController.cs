using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Volunteer_Management_System.Auth;

namespace Volunteer_Management_System.Controllers
{
    public class EventController : ApiController
    {
        [Logged]

        [HttpGet]
        [Route("api/event/all")]
        public HttpResponseMessage GetAll()
        {
            var data = EventService.Get();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Logged]
        [HttpGet]
        [Route("api/event/{id}")]
        public HttpResponseMessage Get(int id)
        {
            var data = EventService.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Logged]
        [HttpPost]
        [Route("api/event/create")]
        public HttpResponseMessage Create(EventDTO a)
        {
            EventService.Create(a);

            return Request.CreateResponse(HttpStatusCode.OK, "Event Added Successfully");
        }

        [Logged]
        [HttpPut]
        [Route("api/event/update/{id}")]
        public HttpResponseMessage Update(int id, EventDTO e)
        {
            EventService.Update(id, e);
            return Request.CreateResponse(HttpStatusCode.OK, "Event updated successfully.");
        }

        [Logged]
        [HttpDelete]
        [Route("api/event/delete/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            EventService.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, "Event deleted successfully.");
        }

        [Logged]
        [HttpGet]
        [Route("api/event/{id}/admin")]
        public HttpResponseMessage GetwithAdmin(int id)
        {
            var data = EventService.GetwithAdmin(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Logged]
        [HttpGet]
        [Route("api/event/{id}/volunteer")]
        public HttpResponseMessage GetwithVolunteer(int id)
        {
            var data = EventService.GetwithVolunteer(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
    }
}
