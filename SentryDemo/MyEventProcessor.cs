using Sentry;
using Sentry.Extensibility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SentryDemo
{
    public class MyEventProcessor : ISentryEventProcessor
    {
        public SentryEvent Process(SentryEvent @event)
        {
            Console.WriteLine("MyEventProcessor");
            return new SentryEvent();
           
        }
    }
}
