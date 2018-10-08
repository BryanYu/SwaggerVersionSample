using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SwaggerVersionExample.Controllers.v2
{
    /// <summary>
    /// User v2 Controller
    /// </summary>
    [Route("api/v2/users")]
    public class UserV2Controller : ApiController
    {
        /// <summary>
        /// 取得使用者
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IHttpActionResult GetUser()
        {
            return this.Ok("From V2 Controller");
        }
    }
}
