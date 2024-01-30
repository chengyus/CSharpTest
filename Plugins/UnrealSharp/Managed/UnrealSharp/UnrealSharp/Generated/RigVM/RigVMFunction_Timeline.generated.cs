using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMFunction_Timeline
{
    // FloatProperty /Script/RigVM.RigVMFunction_Timeline:Speed
    static readonly int Speed_Offset;
    public float Speed;
    
    // FloatProperty /Script/RigVM.RigVMFunction_Timeline:Time
    static readonly int Time_Offset;
    public float Time;
    
    
    public static readonly int NativeDataSize;
    static RigVMFunction_Timeline()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMFunction_Timeline");
        
        Speed_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Speed");
        Time_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Time");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMFunction_Timeline(IntPtr InNativeStruct)
    {
        unsafe
        {
            Speed = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Speed_Offset), 0, null);
            Time = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Time_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Speed_Offset), 0, null, Speed);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Time_Offset), 0, null, Time);
        }
    }
}

public static class RigVMFunction_TimelineMarshaler
{
    public static RigVMFunction_Timeline FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMFunction_Timeline(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMFunction_Timeline obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMFunction_Timeline.NativeDataSize;
    }
}