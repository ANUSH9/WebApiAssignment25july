using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
namespace WebApi3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IDController : ControllerBase
    {
        Dictionary<int, (string, string)> obj = new Dictionary<int, (string, string)>()
        {

                {1,("delhi","local silversmiths")},
                {2,("UP","local silversmiths")},
                {3,("MP","local silversmiths")},
                {4,("UK","local silversmiths")},
                {5,("delhi","local silversmiths")},


        };
        [HttpGet]
        public ActionResult GetID()
        {
            var serialized= JsonConvert.SerializeObject(obj);
            return Ok(serialized);
        }

    }
}
