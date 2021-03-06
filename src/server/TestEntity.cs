using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Akka.Actor;
using Akka.Event;
using Google.Protobuf.WellKnownTypes;
using static Server.ServerMessages.Types;

namespace Server 
{
    public partial class TestEntity :  ReceiveActor
    {
        private readonly ILoggingAdapter _log = Context.GetLogger();
        private readonly Random _rand;

        private IEnumerable<int> _startPoints = Enumerable.Range(1000, 1100);
        private IEnumerable<int> _endPoints = Enumerable.Range(2000, 2100);

        public TestEntity()
        {
            _log.Info("TestEntity Created");
            _rand = new Random();
            Receive<StreamedDataRequest>(x => Handle(x));
        }

        private void Handle(StreamedDataRequest req)
        {
            _log.Info($"Handling StreamedDataRequest");

            for(int i = 0; i < req.NoMessages; i++)
            {
                var payloads = new List<StreamedDataResponse.Types.Payload>();

                for(int j = 0; j < req.Size; j++)
                {
                    payloads.Add(GeneratePayLoad());
                }

                Sender.Tell(new StreamedDataResponse(payloads));
            }

            Sender.Tell(new StreamedDataComplete());

            _log.Info($"Sent 100000");
        }

        private StreamedDataResponse.Types.Payload GeneratePayLoad()
        {
            DateTime date = DateTime.UtcNow.AddDays(_rand.Next(1,365));
            int vertexA = _rand.Next(100);
            int vertexB = _rand.Next(100);
            double amount = _rand.Next(1, 1000);

            return new StreamedDataResponse.Types.Payload(Timestamp.FromDateTime(date), vertexA, vertexB, amount);
        }
    }
}