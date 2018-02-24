using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SensorApi.Models;

namespace SensorApi.Controllers
{
    public class TripController : ApiController
    {
        // GET: api/Trip
        public IEnumerable<Trip> Get()
        {
            return new List<Trip>();
        }

        // GET: api/Trip/5
        public string Get(Trip id)
        {
            return "value";
        }

        // POST: api/Trip
        public void Post([FromBody]Trip trip)
        {
        }

        // DELETE: api/Trip/5
        public void Delete(int id)
        {
        }
    }
}
