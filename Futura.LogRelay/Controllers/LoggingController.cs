using System.Web.Http;
using Futura.LogRelay.DTOs;
using NLog;

namespace Futura.LogRelay.Controllers {
    /// <summary>
    /// Logger Api
    /// </summary>
    public class LoggingController : ApiController {

        private readonly ILogger _logger = LogManager.GetLogger("LoggingRelay");

        /// <summary>
        /// Logs the specified message.
        /// </summary>
        /// <param name="logEvent">The log event.</param>
        /// <returns></returns>
        public IHttpActionResult Log(LogEventDto logEvent) {
            _logger.Info(logEvent.Exception, logEvent.Message);
            return Ok();
        }

        /// <summary>
        /// Logs the specified message.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <returns></returns>
        public IHttpActionResult Log(string message) {
            
            _logger.Info(message);
            return Ok();
        }
    }
}
