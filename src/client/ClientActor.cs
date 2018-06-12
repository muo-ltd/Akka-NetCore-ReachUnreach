using System;
using System.Diagnostics;
using Akka.Actor;
using Akka.Cluster.Sharding;
using Akka.Event;

namespace Client
{
    public partial class ClientActor :  ReceiveActor
    {
        public class DummyRequest {}
        public class DummyResponse {} 

        private readonly ILoggingAdapter _log = Context.GetLogger();

        private MessageProcessor _processor;

        private IActorRef _origonalActor; 
        private int _count;

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

            var message = new Server.TestEntity.StreamedDataRequest();
            var envelope = new Server.Envelope(1, message);

            shardRegion.Tell(envelope);

            _log.Info("Handled DummyRequest");
        }

        public void Handle(Server.TestEntity.StreamedDataResponse res)
        {

            Stopwatch watch = new Stopwatch();
            watch.Start();

            _processor.DoSomeWork();

            watch.Stop();

            if ((_count % 1000) == 0)
            {
                _log.Info($"Received Message: {watch.ElapsedMilliseconds} ms");
            }

            _count++;
        }

        public void Handle(Server.TestEntity.StreamedDataComplete res)
        {
            _log.Info($"Complete");
            _origonalActor.Tell(new DummyResponse());
        }

        public static Props Props()
        {
            return Akka.Actor.Props.Create(() => new ClientActor());
        }

    }
}