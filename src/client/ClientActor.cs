using System;
using System.Diagnostics;
using Akka.Actor;
using Akka.Cluster.Sharding;
using Akka.Event;

namespace Client
{
    public partial class ClientActor :  ReceiveActor
    {
        public class DummyRequest 
        {
            public int Size { get; }
            public int NoMessages  { get; }

            public DummyRequest(int size, int noMessages)
            {
                Size = size;
                NoMessages = noMessages;
            }
        }
        public class DummyResponse {} 

        private readonly ILoggingAdapter _log = Context.GetLogger();

        private MessageProcessor _processor;

        private IActorRef _origonalActor; 
        private int _count;
        private Stopwatch _totalTimer;

        public ClientActor()
        {
            _processor = new MessageProcessor();

            Receive<DummyRequest>(x => Handle(x));
            Receive<Server.TestEntity.StreamedDataResponse>(x => Handle(x));
            Receive<Server.TestEntity.StreamedDataComplete>(x => Handle(x));
        }

        public void Handle(DummyRequest req)
        {
            _origonalActor = Sender;
            var shardRegion = ClusterSharding.Get(Context.System).ShardRegion("testregion");

            var message = new Server.TestEntity.StreamedDataRequest(req.Size, req.NoMessages);
            var envelope = new Server.Envelope(1, message);

            shardRegion.Tell(envelope);

            _count = 0;
            _totalTimer = new Stopwatch();
            _totalTimer.Start();

            _log.Info("Handled DummyRequest");
        }

        public void Handle(Server.TestEntity.StreamedDataResponse res)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();

            //_processor.DoSomeWork();
            _count++;

            watch.Stop();

            if ((_count % 1000) == 0)
            {
                var average = (decimal)_totalTimer.ElapsedMilliseconds / (decimal)_count;
                var perSec = (decimal)_count / (decimal)_totalTimer.Elapsed.TotalSeconds;
                _log.Info($"Received ({_count}), last message exec ({watch.ElapsedMilliseconds} ms), Average {Math.Round(average, 2)} ms, {Math.Round(perSec,2)} per sec");
            }
        }

        public void Handle(Server.TestEntity.StreamedDataComplete res)
        {
            _totalTimer.Stop();
            _log.Info($"Complete: {_totalTimer.Elapsed.TotalSeconds} seconds");
            _origonalActor.Tell(new DummyResponse());
        }

        public static Props Props()
        {
            return Akka.Actor.Props.Create(() => new ClientActor());
        }

    }
}