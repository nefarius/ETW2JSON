﻿namespace Nefarius.Utilities.ETW.Deserializer;

internal interface IEventTraceOperand
{
    int EventMetadataTableIndex { get; }

    EventMetadata Metadata { get; }

    IEnumerable<IEventTracePropertyOperand> EventPropertyOperands { get; }
}