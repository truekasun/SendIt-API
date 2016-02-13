using System.Net;
using System.Net.Http;
using System.Web.Http;
using HelperLayer.Framework;
using HelperLayer.Modals;

namespace SendIt.Controllers {
    public class MailerController : ApiController {
        [Route("api/Send")]
        [HttpPost]
        public HttpResponseMessage Send(Email message) {
            var retObj = new SendResult();

            if (message.To != null && message.From != null) {
                var mailer = new Mailer();
                retObj.Message = mailer.SendEmail(message);
                
                if (retObj.Message.Contains("Error")) {
                    retObj.Status=false;
                    return Request.CreateResponse(HttpStatusCode.BadRequest, retObj);
                }
                retObj.Status = true;
                return Request.CreateResponse(HttpStatusCode.OK, retObj);
            }
            retObj.Status = false;
            retObj.Message = "Invalid Content";
            return Request.CreateResponse(HttpStatusCode.NotFound, retObj);
        }
    }
}
