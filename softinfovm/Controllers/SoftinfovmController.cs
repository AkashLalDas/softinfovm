using softinfovm.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace softinfovm.Controllers
{
    public class SoftinfovmController : ApiController
    {
        [Route("api/getSubsectionCode")]
        [HttpPost]
        public IHttpActionResult GetSubsectionCode([FromBody] string[] payload)
        {
            var sectionService = new SectionService();
            return Ok(sectionService.getSubsectionCode(payload));
        }
    }
}
