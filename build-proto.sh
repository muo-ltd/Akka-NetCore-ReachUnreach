#!/bin/bash
set -euo pipefail
IFS=$'\n\t'

~/.nuget/packages/google.protobuf.tools/3.6.0/tools/macosx_x64/protoc \
        --proto_path=src/proto \
        --proto_path=src/proto/common \
        --csharp_out=src/client/proto \
        clientmessages.proto

~/.nuget/packages/google.protobuf.tools/3.6.0/tools/macosx_x64/protoc \
        --proto_path=src/proto \
        --proto_path=src/proto/common \
        --csharp_out=src/server/proto \
        servermessages.proto