using Amaury.Helpers;
using System;

namespace Amaury.Abstractions
{
    public abstract class CelebrityEvent : ICelebrityEvent
    {
        protected CelebrityEvent(string aggregatedId, dynamic data)
        {
            AggregatedId = aggregatedId;
            Data = data;

            Name = GetType().GetEventName();
            Timestamp = DateTime.Now;
            EventId = Guid.NewGuid().ToString();
        }

        public string AggregatedId { get; set; }
        public dynamic Data { get; set; }
        public string Name { get; set; }
        public string EventId { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
