using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct ChaosRemovalEvent
{
    // ObjectProperty /Script/Engine.ChaosRemovalEvent:Component
    static readonly int Component_Offset;
    public UnrealSharp.Engine.PrimitiveComponent Component;
    
    // StructProperty /Script/Engine.ChaosRemovalEvent:Location
    static readonly int Location_Offset;
    public System.DoubleNumerics.Vector3 Location;
    
    // FloatProperty /Script/Engine.ChaosRemovalEvent:Mass
    static readonly int Mass_Offset;
    public float Mass;
    
    
    public static readonly int NativeDataSize;
    static ChaosRemovalEvent()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("ChaosRemovalEvent");
        
        Component_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Component");
        Location_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Location");
        Mass_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Mass");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public ChaosRemovalEvent(IntPtr InNativeStruct)
    {
        unsafe
        {
            Component = ObjectMarshaller<UnrealSharp.Engine.PrimitiveComponent>.FromNative(IntPtr.Add(InNativeStruct, Component_Offset), 0, null);
            Location = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Location_Offset), 0, null);
            Mass = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Mass_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            ObjectMarshaller<UnrealSharp.Engine.PrimitiveComponent>.ToNative(IntPtr.Add(Buffer, Component_Offset), 0, null, Component);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Location_Offset), 0, null, Location);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Mass_Offset), 0, null, Mass);
        }
    }
}

public static class ChaosRemovalEventMarshaler
{
    public static ChaosRemovalEvent FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new ChaosRemovalEvent(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, ChaosRemovalEvent obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return ChaosRemovalEvent.NativeDataSize;
    }
}