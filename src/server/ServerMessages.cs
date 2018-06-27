using System.Collections.Generic;
using Google.Protobuf.WellKnownTypes;

namespace Server 
{
    public partial class ServerMessages
    {
        public partial class Types
        {
            public partial class StreamedDataRequest
            {
                public StreamedDataRequest(int size, int noMessages)
                {
                    Size = size;
                    NoMessages = noMessages;
                }
            }

            public partial class StreamedDataResponse
            {
                public StreamedDataResponse(IEnumerable<Types.Payload> items)
                {
                    Responses.AddRange(items);
                }

                public partial class Types
                {
                    public partial class Payload
                    {
                        public Payload(Timestamp date, int vertexa, int vertexb, double cost)
                        {
                            Date = date;
                            VertextA = vertexa;
                            VertextB = vertexb;
                            Cost = cost;                    
                        }
                    }
                }
            }
        }
    }
}