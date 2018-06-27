using System;
using System.Collections.Generic;
using System.Text;
using Akka.Actor;
using Akka.Event;

namespace Server 
{
    public partial class TestEntity
    {
        public class StreamedDataRequest 
        {
            public int Size { get; }
            public int NoMessages { get; }

            public StreamedDataRequest(int size, int noMessages)
            {
                Size = size;
                NoMessages = noMessages;
            }
        } 

        public class StreamedDataResponse 
        {
            public class Payload
            {
                public DateTime Date { get; }
                public int VertexA { get; }
                public int VertexB { get; }
                public decimal Cost { get; }

                public Payload(DateTime date, int vertexA, int vertexB, decimal cost)
                {
                    Date = date;
                    VertexA = vertexA;
                    VertexB = VertexB;
                    Cost = cost;
                }
            }

            public IReadOnlyList<Payload> Responses  { get; }

            public StreamedDataResponse(IReadOnlyList<Payload> responses)
            {
                Responses = responses;
            }
        }

        public class StreamedDataComplete
        {
        }

    }
}