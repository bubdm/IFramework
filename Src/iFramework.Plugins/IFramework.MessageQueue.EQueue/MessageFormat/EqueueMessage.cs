﻿using System.Collections.Generic;

namespace IFramework.MessageQueue.EQueue.MessageFormat
{
    public class EQueueMessage
    {
        public EQueueMessage(object payload = null)
        {
            Headers = new Dictionary<string, object>(System.StringComparer.OrdinalIgnoreCase);
            Payload = payload;
        }

        public IDictionary<string, object> Headers { get; }
        public object Payload { get; set; }
    }
}