using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct CurveRenamedPayload
{
    // StructProperty /Script/Engine.CurveRenamedPayload:NewIdentifier
    static readonly int NewIdentifier_Offset;
    public UnrealSharp.Engine.AnimationCurveIdentifier NewIdentifier;
    
    
    public static readonly int NativeDataSize;
    static CurveRenamedPayload()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("CurveRenamedPayload");
        
        NewIdentifier_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "NewIdentifier");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public CurveRenamedPayload(IntPtr InNativeStruct)
    {
        unsafe
        {
            NewIdentifier = UnrealSharp.Engine.AnimationCurveIdentifierMarshaler.FromNative(IntPtr.Add(InNativeStruct, NewIdentifier_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.Engine.AnimationCurveIdentifierMarshaler.ToNative(IntPtr.Add(Buffer, NewIdentifier_Offset), 0, null, NewIdentifier);
        }
    }
}

public static class CurveRenamedPayloadMarshaler
{
    public static CurveRenamedPayload FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new CurveRenamedPayload(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, CurveRenamedPayload obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return CurveRenamedPayload.NativeDataSize;
    }
}