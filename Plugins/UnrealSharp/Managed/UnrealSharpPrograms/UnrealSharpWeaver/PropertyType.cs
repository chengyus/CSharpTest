﻿namespace UnrealSharpWeaver;

public enum PropertyType
{
    Unknown,

    Bool,

    Int8,
    Int16,
    Int,
    Int64,

    Byte,
    UInt16,
    UInt32,
    UInt64,

    Double,
    Float,

    Enum,

    Interface,
    Struct,
    Class,

    Object,
    LazyObject,
    WeakObject,
    DefaultComponent,

    SoftClass,
    SoftObject,

    Delegate,
    MulticastDelegate,

    Array,
    Map,
    Set,
        
    Str,
    Name,
    Text,

    InternalNativeFixedSizeArray,
    InternalManagedFixedSizeArray
}