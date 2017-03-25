using Microsoft.AspNet.SignalR;
using NLog.SignalR;

namespace SignalR.Net45
{
    public class LoggingHub : Hub<ILoggingHub>
    {
        public void Log(LogEvent logEvent) {
            Clients.Others.Log(logEvent);
        }


    }
}