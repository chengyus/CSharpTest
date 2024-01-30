using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct SoftComponentReference
{
    // SoftObjectProperty /Script/Engine.SoftComponentReference:OtherActor
    static readonly int OtherActor_Offset;
    public SoftObject<UnrealSharp.Engine.Actor> OtherActor;
    
    
    public static readonly int NativeDataSize;
    static SoftComponentReference()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("SoftComponentReference");
        
        OtherActor_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "OtherActor");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public SoftComponentReference(IntPtr InNativeStruct)
    {
        unsafe
        {
            OtherActor = BlittableMarshaller<SoftObject<UnrealSharp.Engine.Actor>>.FromNative(IntPtr.Add(InNativeStruct, OtherActor_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<SoftObject<UnrealSharp.Engine.Actor>>.ToNative(IntPtr.Add(Buffer, OtherActor_Offset), 0, null, OtherActor);
        }
    }
}

public static class SoftComponentReferenceMarshaler
{
    public static SoftComponentReference FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new SoftComponentReference(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, SoftComponentReference obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return SoftComponentReference.NativeDataSize;
    }
}