using System;

namespace Futura.LogRelay.DTOs {

    /// <summary>
    /// Represents the different log levels.
    /// </summary>
    public enum LogLevel {
        
        /// <summary>
        /// The information log level
        /// </summary>
        Info
    }

    /// <summary>
    /// 
    /// </summary>
    public class LogEventDto {

        /// <summary>
        /// Gets or sets the log level.
        /// </summary>
        /// <value>
        /// The level.
        /// </value>
        public LogLevel Level { get; set; }

        /// <summary>
        /// Gets or sets the time stamp.
        /// </summary>
        /// <value>
        /// The time stamp.
        /// </value>
        public DateTime TimeStamp { get; set; }

        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        /// <value>
        /// The message.
        /// </value>
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets the exception.
        /// </summary>
        /// <value>
        /// The exception.
        /// </value>
        public Exception Exception { get; set; }    

    }
}