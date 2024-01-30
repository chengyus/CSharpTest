using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_ToWorldSpace_Location
{
    // StructProperty /Script/ControlRig.RigUnit_ToWorldSpace_Location:Value
    static readonly int Value_Offset;
    public System.DoubleNumerics.Vector3 Value;
    
    // StructProperty /Script/ControlRig.RigUnit_ToWorldSpace_Location:World
    static readonly int World_Offset;
    public System.DoubleNumerics.Vector3 World;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_ToWorldSpace_Location()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_ToWorldSpace_Location");
        
        Value_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Value");
        World_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "World");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_ToWorldSpace_Location(IntPtr InNativeStruct)
    {
        unsafe
        {
            Value = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Value_Offset), 0, null);
            World = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, World_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Value_Offset), 0, null, Value);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, World_Offset), 0, null, World);
        }
    }
}

public static class RigUnit_ToWorldSpace_LocationMarshaler
{
    public static RigUnit_ToWorldSpace_Location FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_ToWorldSpace_Location(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_ToWorldSpace_Location obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_ToWorldSpace_Location.NativeDataSize;
    }
}