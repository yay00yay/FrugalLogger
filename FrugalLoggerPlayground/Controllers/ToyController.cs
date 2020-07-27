using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using FrugalLogger;

namespace FrugalLoggerPlayground.Controllers
{
    [RoutePrefix("api/v1.0/Toy")]
    public class ToyController : ApiController
    {
        [FrugalLog]
        [Route("Get")]
        [HttpGet]
        public HttpResponseMessage ToyGet(DateTime date, string str)
        {
            HttpResponseMessage response = new HttpResponseMessage();
            response.Content = new StringContent(JsonConvert.SerializeObject("Toy"));

            return response;
        }
    }
}