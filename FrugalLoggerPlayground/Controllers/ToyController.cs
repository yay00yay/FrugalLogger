using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace FrugalLoggerPlayground.Controllers
{
    public class ToyController : ApiController
    {
        [Route("Toy")]
        [HttpGet]
        public HttpResponseMessage ToyGet(DateTime date, string str)
        {
            HttpResponseMessage response = new HttpResponseMessage();
            response.Content = new StringContent(JsonConvert.SerializeObject("Toy"));

            return response;
        }
    }
}