﻿using System.Buffers;

namespace MemoryPack;

public interface IMemoryPackable<T>
{
    static abstract void Serialize<TBufferWriter>(ref SerializationContext<TBufferWriter> context, ref T? value)
        where TBufferWriter : IBufferWriter<byte>;
    static abstract void Deserialize(ref DeserializationContext context, ref T? value);
}