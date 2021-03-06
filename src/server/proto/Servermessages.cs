// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: servermessages.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Server {

  /// <summary>Holder for reflection information generated from servermessages.proto</summary>
  public static partial class ServermessagesReflection {

    #region Descriptor
    /// <summary>File descriptor for servermessages.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ServermessagesReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChRzZXJ2ZXJtZXNzYWdlcy5wcm90bxIGU2VydmVyGg90aW1lc3RhbXAucHJv",
            "dG8iqQIKDlNlcnZlck1lc3NhZ2VzGjcKE1N0cmVhbWVkRGF0YVJlcXVlc3QS",
            "DAoEU2l6ZRgBIAEoBRISCgpOb01lc3NhZ2VzGAIgASgFGsUBChRTdHJlYW1l",
            "ZERhdGFSZXNwb25zZRJGCglSZXNwb25zZXMYBSADKAsyMy5TZXJ2ZXIuU2Vy",
            "dmVyTWVzc2FnZXMuU3RyZWFtZWREYXRhUmVzcG9uc2UuUGF5bG9hZBplCgdQ",
            "YXlsb2FkEigKBERhdGUYASABKAsyGi5nb29nbGUucHJvdG9idWYuVGltZXN0",
            "YW1wEhAKCFZlcnRleHRBGAIgASgFEhAKCFZlcnRleHRCGAMgASgFEgwKBENv",
            "c3QYBCABKAEaFgoUU3RyZWFtZWREYXRhQ29tcGxldGViBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Server.ServerMessages), global::Server.ServerMessages.Parser, null, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::Server.ServerMessages.Types.StreamedDataRequest), global::Server.ServerMessages.Types.StreamedDataRequest.Parser, new[]{ "Size", "NoMessages" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Server.ServerMessages.Types.StreamedDataResponse), global::Server.ServerMessages.Types.StreamedDataResponse.Parser, new[]{ "Responses" }, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::Server.ServerMessages.Types.StreamedDataResponse.Types.Payload), global::Server.ServerMessages.Types.StreamedDataResponse.Types.Payload.Parser, new[]{ "Date", "VertextA", "VertextB", "Cost" }, null, null, null)}),
            new pbr::GeneratedClrTypeInfo(typeof(global::Server.ServerMessages.Types.StreamedDataComplete), global::Server.ServerMessages.Types.StreamedDataComplete.Parser, null, null, null, null)})
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ServerMessages : pb::IMessage<ServerMessages> {
    private static readonly pb::MessageParser<ServerMessages> _parser = new pb::MessageParser<ServerMessages>(() => new ServerMessages());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ServerMessages> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Server.ServermessagesReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ServerMessages() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ServerMessages(ServerMessages other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ServerMessages Clone() {
      return new ServerMessages(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ServerMessages);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ServerMessages other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ServerMessages other) {
      if (other == null) {
        return;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the ServerMessages message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public sealed partial class StreamedDataRequest : pb::IMessage<StreamedDataRequest> {
        private static readonly pb::MessageParser<StreamedDataRequest> _parser = new pb::MessageParser<StreamedDataRequest>(() => new StreamedDataRequest());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<StreamedDataRequest> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::Server.ServerMessages.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public StreamedDataRequest() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public StreamedDataRequest(StreamedDataRequest other) : this() {
          size_ = other.size_;
          noMessages_ = other.noMessages_;
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public StreamedDataRequest Clone() {
          return new StreamedDataRequest(this);
        }

        /// <summary>Field number for the "Size" field.</summary>
        public const int SizeFieldNumber = 1;
        private int size_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int Size {
          get { return size_; }
          set {
            size_ = value;
          }
        }

        /// <summary>Field number for the "NoMessages" field.</summary>
        public const int NoMessagesFieldNumber = 2;
        private int noMessages_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int NoMessages {
          get { return noMessages_; }
          set {
            noMessages_ = value;
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other) {
          return Equals(other as StreamedDataRequest);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(StreamedDataRequest other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (Size != other.Size) return false;
          if (NoMessages != other.NoMessages) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode() {
          int hash = 1;
          if (Size != 0) hash ^= Size.GetHashCode();
          if (NoMessages != 0) hash ^= NoMessages.GetHashCode();
          if (_unknownFields != null) {
            hash ^= _unknownFields.GetHashCode();
          }
          return hash;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override string ToString() {
          return pb::JsonFormatter.ToDiagnosticString(this);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void WriteTo(pb::CodedOutputStream output) {
          if (Size != 0) {
            output.WriteRawTag(8);
            output.WriteInt32(Size);
          }
          if (NoMessages != 0) {
            output.WriteRawTag(16);
            output.WriteInt32(NoMessages);
          }
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize() {
          int size = 0;
          if (Size != 0) {
            size += 1 + pb::CodedOutputStream.ComputeInt32Size(Size);
          }
          if (NoMessages != 0) {
            size += 1 + pb::CodedOutputStream.ComputeInt32Size(NoMessages);
          }
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(StreamedDataRequest other) {
          if (other == null) {
            return;
          }
          if (other.Size != 0) {
            Size = other.Size;
          }
          if (other.NoMessages != 0) {
            NoMessages = other.NoMessages;
          }
          _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(pb::CodedInputStream input) {
          uint tag;
          while ((tag = input.ReadTag()) != 0) {
            switch(tag) {
              default:
                _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
                break;
              case 8: {
                Size = input.ReadInt32();
                break;
              }
              case 16: {
                NoMessages = input.ReadInt32();
                break;
              }
            }
          }
        }

      }

      public sealed partial class StreamedDataResponse : pb::IMessage<StreamedDataResponse> {
        private static readonly pb::MessageParser<StreamedDataResponse> _parser = new pb::MessageParser<StreamedDataResponse>(() => new StreamedDataResponse());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<StreamedDataResponse> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::Server.ServerMessages.Descriptor.NestedTypes[1]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public StreamedDataResponse() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public StreamedDataResponse(StreamedDataResponse other) : this() {
          responses_ = other.responses_.Clone();
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public StreamedDataResponse Clone() {
          return new StreamedDataResponse(this);
        }

        /// <summary>Field number for the "Responses" field.</summary>
        public const int ResponsesFieldNumber = 5;
        private static readonly pb::FieldCodec<global::Server.ServerMessages.Types.StreamedDataResponse.Types.Payload> _repeated_responses_codec
            = pb::FieldCodec.ForMessage(42, global::Server.ServerMessages.Types.StreamedDataResponse.Types.Payload.Parser);
        private readonly pbc::RepeatedField<global::Server.ServerMessages.Types.StreamedDataResponse.Types.Payload> responses_ = new pbc::RepeatedField<global::Server.ServerMessages.Types.StreamedDataResponse.Types.Payload>();
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public pbc::RepeatedField<global::Server.ServerMessages.Types.StreamedDataResponse.Types.Payload> Responses {
          get { return responses_; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other) {
          return Equals(other as StreamedDataResponse);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(StreamedDataResponse other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if(!responses_.Equals(other.responses_)) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode() {
          int hash = 1;
          hash ^= responses_.GetHashCode();
          if (_unknownFields != null) {
            hash ^= _unknownFields.GetHashCode();
          }
          return hash;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override string ToString() {
          return pb::JsonFormatter.ToDiagnosticString(this);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void WriteTo(pb::CodedOutputStream output) {
          responses_.WriteTo(output, _repeated_responses_codec);
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize() {
          int size = 0;
          size += responses_.CalculateSize(_repeated_responses_codec);
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(StreamedDataResponse other) {
          if (other == null) {
            return;
          }
          responses_.Add(other.responses_);
          _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(pb::CodedInputStream input) {
          uint tag;
          while ((tag = input.ReadTag()) != 0) {
            switch(tag) {
              default:
                _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
                break;
              case 42: {
                responses_.AddEntriesFrom(input, _repeated_responses_codec);
                break;
              }
            }
          }
        }

        #region Nested types
        /// <summary>Container for nested types declared in the StreamedDataResponse message type.</summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static partial class Types {
          public sealed partial class Payload : pb::IMessage<Payload> {
            private static readonly pb::MessageParser<Payload> _parser = new pb::MessageParser<Payload>(() => new Payload());
            private pb::UnknownFieldSet _unknownFields;
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            public static pb::MessageParser<Payload> Parser { get { return _parser; } }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            public static pbr::MessageDescriptor Descriptor {
              get { return global::Server.ServerMessages.Types.StreamedDataResponse.Descriptor.NestedTypes[0]; }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            pbr::MessageDescriptor pb::IMessage.Descriptor {
              get { return Descriptor; }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            public Payload() {
              OnConstruction();
            }

            partial void OnConstruction();

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            public Payload(Payload other) : this() {
              date_ = other.date_ != null ? other.date_.Clone() : null;
              vertextA_ = other.vertextA_;
              vertextB_ = other.vertextB_;
              cost_ = other.cost_;
              _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            public Payload Clone() {
              return new Payload(this);
            }

            /// <summary>Field number for the "Date" field.</summary>
            public const int DateFieldNumber = 1;
            private global::Google.Protobuf.WellKnownTypes.Timestamp date_;
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            public global::Google.Protobuf.WellKnownTypes.Timestamp Date {
              get { return date_; }
              set {
                date_ = value;
              }
            }

            /// <summary>Field number for the "VertextA" field.</summary>
            public const int VertextAFieldNumber = 2;
            private int vertextA_;
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            public int VertextA {
              get { return vertextA_; }
              set {
                vertextA_ = value;
              }
            }

            /// <summary>Field number for the "VertextB" field.</summary>
            public const int VertextBFieldNumber = 3;
            private int vertextB_;
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            public int VertextB {
              get { return vertextB_; }
              set {
                vertextB_ = value;
              }
            }

            /// <summary>Field number for the "Cost" field.</summary>
            public const int CostFieldNumber = 4;
            private double cost_;
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            public double Cost {
              get { return cost_; }
              set {
                cost_ = value;
              }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            public override bool Equals(object other) {
              return Equals(other as Payload);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            public bool Equals(Payload other) {
              if (ReferenceEquals(other, null)) {
                return false;
              }
              if (ReferenceEquals(other, this)) {
                return true;
              }
              if (!object.Equals(Date, other.Date)) return false;
              if (VertextA != other.VertextA) return false;
              if (VertextB != other.VertextB) return false;
              if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Cost, other.Cost)) return false;
              return Equals(_unknownFields, other._unknownFields);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            public override int GetHashCode() {
              int hash = 1;
              if (date_ != null) hash ^= Date.GetHashCode();
              if (VertextA != 0) hash ^= VertextA.GetHashCode();
              if (VertextB != 0) hash ^= VertextB.GetHashCode();
              if (Cost != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Cost);
              if (_unknownFields != null) {
                hash ^= _unknownFields.GetHashCode();
              }
              return hash;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            public override string ToString() {
              return pb::JsonFormatter.ToDiagnosticString(this);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            public void WriteTo(pb::CodedOutputStream output) {
              if (date_ != null) {
                output.WriteRawTag(10);
                output.WriteMessage(Date);
              }
              if (VertextA != 0) {
                output.WriteRawTag(16);
                output.WriteInt32(VertextA);
              }
              if (VertextB != 0) {
                output.WriteRawTag(24);
                output.WriteInt32(VertextB);
              }
              if (Cost != 0D) {
                output.WriteRawTag(33);
                output.WriteDouble(Cost);
              }
              if (_unknownFields != null) {
                _unknownFields.WriteTo(output);
              }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            public int CalculateSize() {
              int size = 0;
              if (date_ != null) {
                size += 1 + pb::CodedOutputStream.ComputeMessageSize(Date);
              }
              if (VertextA != 0) {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(VertextA);
              }
              if (VertextB != 0) {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(VertextB);
              }
              if (Cost != 0D) {
                size += 1 + 8;
              }
              if (_unknownFields != null) {
                size += _unknownFields.CalculateSize();
              }
              return size;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            public void MergeFrom(Payload other) {
              if (other == null) {
                return;
              }
              if (other.date_ != null) {
                if (date_ == null) {
                  date_ = new global::Google.Protobuf.WellKnownTypes.Timestamp();
                }
                Date.MergeFrom(other.Date);
              }
              if (other.VertextA != 0) {
                VertextA = other.VertextA;
              }
              if (other.VertextB != 0) {
                VertextB = other.VertextB;
              }
              if (other.Cost != 0D) {
                Cost = other.Cost;
              }
              _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            public void MergeFrom(pb::CodedInputStream input) {
              uint tag;
              while ((tag = input.ReadTag()) != 0) {
                switch(tag) {
                  default:
                    _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
                    break;
                  case 10: {
                    if (date_ == null) {
                      date_ = new global::Google.Protobuf.WellKnownTypes.Timestamp();
                    }
                    input.ReadMessage(date_);
                    break;
                  }
                  case 16: {
                    VertextA = input.ReadInt32();
                    break;
                  }
                  case 24: {
                    VertextB = input.ReadInt32();
                    break;
                  }
                  case 33: {
                    Cost = input.ReadDouble();
                    break;
                  }
                }
              }
            }

          }

        }
        #endregion

      }

      public sealed partial class StreamedDataComplete : pb::IMessage<StreamedDataComplete> {
        private static readonly pb::MessageParser<StreamedDataComplete> _parser = new pb::MessageParser<StreamedDataComplete>(() => new StreamedDataComplete());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<StreamedDataComplete> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::Server.ServerMessages.Descriptor.NestedTypes[2]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public StreamedDataComplete() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public StreamedDataComplete(StreamedDataComplete other) : this() {
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public StreamedDataComplete Clone() {
          return new StreamedDataComplete(this);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other) {
          return Equals(other as StreamedDataComplete);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(StreamedDataComplete other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode() {
          int hash = 1;
          if (_unknownFields != null) {
            hash ^= _unknownFields.GetHashCode();
          }
          return hash;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override string ToString() {
          return pb::JsonFormatter.ToDiagnosticString(this);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void WriteTo(pb::CodedOutputStream output) {
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize() {
          int size = 0;
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(StreamedDataComplete other) {
          if (other == null) {
            return;
          }
          _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(pb::CodedInputStream input) {
          uint tag;
          while ((tag = input.ReadTag()) != 0) {
            switch(tag) {
              default:
                _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
                break;
            }
          }
        }

      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
