using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace SwaggerVersionExample.Controllers.v1
{
    /// <summary>
    /// User v1 Controller
    /// </summary>
    [Route("api/v1/users")]
    public class UserV1Controller : ApiController
    {
        /// <summary>
        /// 取得使用者
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IHttpActionResult GetUser()
        {
            return this.Ok("From V1 Controller");
        }
    }
}