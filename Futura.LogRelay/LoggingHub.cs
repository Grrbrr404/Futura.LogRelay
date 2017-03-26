using Microsoft.AspNet.SignalR;
using NLog.SignalR;

namespace Futura.LogRelay {
    public class LoggingHub : Hub<ILoggingHub> {
        public void Log(LogEvent logEvent) {
            Clients.Others.Log(logEvent);
        }
    }
}