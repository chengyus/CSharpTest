using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.InterchangeEngine;

[UStruct]
public partial struct InterchangeStackInfo
{
    // NameProperty /Script/InterchangeEngine.InterchangeStackInfo:StackName
    static readonly int StackName_Offset;
    public Name StackName;
    
    
    public static readonly int NativeDataSize;
    static InterchangeStackInfo()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("InterchangeStackInfo");
        
        StackName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "StackName");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public InterchangeStackInfo(IntPtr InNativeStruct)
    {
        unsafe
        {
            StackName = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, StackName_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, StackName_Offset), 0, null, StackName);
        }
    }
}

public static class InterchangeStackInfoMarshaler
{
    public static InterchangeStackInfo FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new InterchangeStackInfo(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, InterchangeStackInfo obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return InterchangeStackInfo.NativeDataSize;
    }
}