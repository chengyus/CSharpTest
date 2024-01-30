using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct CurveFlagsChangedPayload
{
    // IntProperty /Script/Engine.CurveFlagsChangedPayload:OldFlags
    static readonly int OldFlags_Offset;
    public int OldFlags;
    
    
    public static readonly int NativeDataSize;
    static CurveFlagsChangedPayload()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("CurveFlagsChangedPayload");
        
        OldFlags_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "OldFlags");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public CurveFlagsChangedPayload(IntPtr InNativeStruct)
    {
        unsafe
        {
            OldFlags = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, OldFlags_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, OldFlags_Offset), 0, null, OldFlags);
        }
    }
}

public static class CurveFlagsChangedPayloadMarshaler
{
    public static CurveFlagsChangedPayload FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new CurveFlagsChangedPayload(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, CurveFlagsChangedPayload obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return CurveFlagsChangedPayload.NativeDataSize;
    }
}