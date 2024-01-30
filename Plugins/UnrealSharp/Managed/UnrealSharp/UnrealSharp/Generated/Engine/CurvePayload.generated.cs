using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct CurvePayload
{
    // StructProperty /Script/Engine.CurvePayload:Identifier
    static readonly int Identifier_Offset;
    public UnrealSharp.Engine.AnimationCurveIdentifier Identifier;
    
    
    public static readonly int NativeDataSize;
    static CurvePayload()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("CurvePayload");
        
        Identifier_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Identifier");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public CurvePayload(IntPtr InNativeStruct)
    {
        unsafe
        {
            Identifier = UnrealSharp.Engine.AnimationCurveIdentifierMarshaler.FromNative(IntPtr.Add(InNativeStruct, Identifier_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.Engine.AnimationCurveIdentifierMarshaler.ToNative(IntPtr.Add(Buffer, Identifier_Offset), 0, null, Identifier);
        }
    }
}

public static class CurvePayloadMarshaler
{
    public static CurvePayload FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new CurvePayload(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, CurvePayload obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return CurvePayload.NativeDataSize;
    }
}