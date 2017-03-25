using System.Web.Http;
using NLog;

namespace Futura.SignalR.Controller {
    public class LoggingController : ApiController {

        private ILogger _logger = LogManager.GetLogger("LoggingRelay");

        public IHttpActionResult Log(string message) {
            
            _logger.Info(message);
            return Ok();
        }
    }
}
