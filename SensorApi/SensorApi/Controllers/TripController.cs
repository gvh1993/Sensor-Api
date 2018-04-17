using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SensorApi.Models;
using SensorApi.Services;

namespace SensorApi.Controllers
{
    [RoutePrefix("api/trip")]
    public class TripController : ApiController
    {
        private ITripService _tripService;

        public TripController()
        {
            _tripService = new TripService();   
        }

        // GET: api/Trip
        [HttpGet]
        [Route("GetAll")]
        public IHttpActionResult Get()
        {
            try
            {
                 var trips = _tripService.GetAll();
                return Ok(trips);
            }
            catch (Exception e){
                return InternalServerError();
            }
            
        }

        // GET: api/Trip/5
        public string Get(Trip id)
        {
            return "value";
        }

        // POST: api/Trip
        [HttpPost]
        [Route("Post")]
        public IHttpActionResult Post([FromBody]Trip trip)
        {
            try
            {
                bool insertSuccess = _tripService.Add(trip);
                if (!insertSuccess)
                {
                    return InternalServerError();
                }
                return Ok();
            }
            catch (Exception e)
            {
                return InternalServerError();
            }
        }

        // DELETE: api/Trip/5
        public void Delete(int id)
        {
        }
    }
}
