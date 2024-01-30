using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.MetasoundEngine;

[UStruct]
public partial struct MetaSoundBuilderOptions
{
    // NameProperty /Script/MetasoundEngine.MetaSoundBuilderOptions:Name
    static readonly int Name_Offset;
    public Name Name;
    
    // BoolProperty /Script/MetasoundEngine.MetaSoundBuilderOptions:bForceUniqueClassName
    static readonly int bForceUniqueClassName_Offset;
    public bool ForceUniqueClassName;
    
    
    public static readonly int NativeDataSize;
    static MetaSoundBuilderOptions()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("MetaSoundBuilderOptions");
        
        Name_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Name");
        bForceUniqueClassName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bForceUniqueClassName");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public MetaSoundBuilderOptions(IntPtr InNativeStruct)
    {
        unsafe
        {
            Name = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, Name_Offset), 0, null);
            ForceUniqueClassName = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bForceUniqueClassName_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, Name_Offset), 0, null, Name);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bForceUniqueClassName_Offset), 0, null, ForceUniqueClassName);
        }
    }
}

public static class MetaSoundBuilderOptionsMarshaler
{
    public static MetaSoundBuilderOptions FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new MetaSoundBuilderOptions(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, MetaSoundBuilderOptions obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return MetaSoundBuilderOptions.NativeDataSize;
    }
}