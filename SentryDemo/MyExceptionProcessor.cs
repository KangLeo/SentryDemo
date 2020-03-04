using Sentry;
using Sentry.Extensibility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SentryDemo
{
    public class MyExceptionProcessor : ISentryEventExceptionProcessor
    {
        public void Process(Exception exception, SentryEvent sentryEvent)
        {
            Console.WriteLine("MyExceptionProcessor");
        }
    }
}
