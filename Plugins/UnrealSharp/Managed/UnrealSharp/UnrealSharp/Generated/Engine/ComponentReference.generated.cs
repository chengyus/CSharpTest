using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct ComponentReference
{
    // WeakObjectProperty /Script/Engine.ComponentReference:OtherActor
    static readonly int OtherActor_Offset;
    public WeakObject<UnrealSharp.Engine.Actor> OtherActor;
    
    
    public static readonly int NativeDataSize;
    static ComponentReference()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("ComponentReference");
        
        OtherActor_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "OtherActor");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public ComponentReference(IntPtr InNativeStruct)
    {
        unsafe
        {
            OtherActor = BlittableMarshaller<WeakObject<UnrealSharp.Engine.Actor>>.FromNative(IntPtr.Add(InNativeStruct, OtherActor_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<WeakObject<UnrealSharp.Engine.Actor>>.ToNative(IntPtr.Add(Buffer, OtherActor_Offset), 0, null, OtherActor);
        }
    }
}

public static class ComponentReferenceMarshaler
{
    public static ComponentReference FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new ComponentReference(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, ComponentReference obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return ComponentReference.NativeDataSize;
    }
}