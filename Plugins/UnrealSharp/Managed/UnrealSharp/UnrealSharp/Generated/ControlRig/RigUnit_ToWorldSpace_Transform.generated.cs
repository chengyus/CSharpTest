using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_ToWorldSpace_Transform
{
    // StructProperty /Script/ControlRig.RigUnit_ToWorldSpace_Transform:Value
    static readonly int Value_Offset;
    public UnrealSharp.Transform Value;
    
    // StructProperty /Script/ControlRig.RigUnit_ToWorldSpace_Transform:World
    static readonly int World_Offset;
    public UnrealSharp.Transform World;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_ToWorldSpace_Transform()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_ToWorldSpace_Transform");
        
        Value_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Value");
        World_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "World");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_ToWorldSpace_Transform(IntPtr InNativeStruct)
    {
        unsafe
        {
            Value = BlittableMarshaller<UnrealSharp.Transform>.FromNative(IntPtr.Add(InNativeStruct, Value_Offset), 0, null);
            World = BlittableMarshaller<UnrealSharp.Transform>.FromNative(IntPtr.Add(InNativeStruct, World_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.Transform>.ToNative(IntPtr.Add(Buffer, Value_Offset), 0, null, Value);
            BlittableMarshaller<UnrealSharp.Transform>.ToNative(IntPtr.Add(Buffer, World_Offset), 0, null, World);
        }
    }
}

public static class RigUnit_ToWorldSpace_TransformMarshaler
{
    public static RigUnit_ToWorldSpace_Transform FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_ToWorldSpace_Transform(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_ToWorldSpace_Transform obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_ToWorldSpace_Transform.NativeDataSize;
    }
}