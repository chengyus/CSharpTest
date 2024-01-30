using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_EndProfilingTimer
{
    // IntProperty /Script/ControlRig.RigUnit_EndProfilingTimer:NumberOfMeasurements
    static readonly int NumberOfMeasurements_Offset;
    public int NumberOfMeasurements;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_EndProfilingTimer()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_EndProfilingTimer");
        
        NumberOfMeasurements_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "NumberOfMeasurements");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_EndProfilingTimer(IntPtr InNativeStruct)
    {
        unsafe
        {
            NumberOfMeasurements = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, NumberOfMeasurements_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, NumberOfMeasurements_Offset), 0, null, NumberOfMeasurements);
        }
    }
}

public static class RigUnit_EndProfilingTimerMarshaler
{
    public static RigUnit_EndProfilingTimer FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_EndProfilingTimer(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_EndProfilingTimer obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_EndProfilingTimer.NativeDataSize;
    }
}