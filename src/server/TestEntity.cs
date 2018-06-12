using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Akka.Actor;
using Akka.Event;

namespace Server 
{
    public partial class TestEntity :  ReceiveActor
    {
        private readonly ILoggingAdapter _log = Context.GetLogger();

        private IEnumerable<int> _startPoints = Enumerable.Range(1000, 1100);
        private IEnumerable<int> _endPoints = Enumerable.Range(2000, 2100);

        public TestEntity()
        {
            _log.Info("TestEntity Created");
            Receive<StreamedDataRequest>(x => Handle(x));
        }

        private void Handle(StreamedDataRequest req)
        {
            _log.Info($"Handling StreamedDataRequest");

            for(int i = 0; i < 100000; i++)
            {
                Sender.Tell(new StreamedDataResponse());
            }

            Sender.Tell(new StreamedDataComplete());

            _log.Info($"Sent 100000");
        }
    }
}