using System;
using System.Diagnostics;
using System.Diagnostics.Tracing;

namespace Tsri.Framework.VB6MigrationSupport.Logging
{
    /// <summary>
    /// Provides the default logging behavior for Tsri Logging framework, mainly limited to output to an attached debugger.
    /// </summary>
    internal sealed class DefaultEventListener : EventListener
    {
        /// <inheritdoc/>
        /// <remarks>Only events from <see cref="LogSource"/> are tracked by this listener.</remarks>
        protected override void OnEventSourceCreated(EventSource eventSource)
        {
            base.OnEventSourceCreated(eventSource);

            if (eventSource.Name == TsriLogEventSource.EventSourceName)
                EnableEvents(eventSource, EventLevel.LogAlways, EventKeywords.All);
        }

        /// <inheritdoc/>
        protected override void OnEventWritten(EventWrittenEventArgs eventData)
        {
            var outputMessage = $@"{eventData.TimeStamp:HH:mm} | {eventData.OSThreadId} | {eventData.Level}";

            outputMessage
                = $"{outputMessage} | {(eventData.Payload != null ? eventData.Payload[0] : "Missing Exception Payload")}";

            if (eventData.Keywords.HasFlag(Keywords.ExceptionKeyword))
            {
                outputMessage = $@"{outputMessage}{Environment.NewLine}    {
                    (eventData.Payload != null ? eventData.Payload[4] : "Missing Exception Payload")}";
            }

            Debugger.Log(0, null, $"{outputMessage}{Environment.NewLine}");

            base.OnEventWritten(eventData);
        }
    }
}

