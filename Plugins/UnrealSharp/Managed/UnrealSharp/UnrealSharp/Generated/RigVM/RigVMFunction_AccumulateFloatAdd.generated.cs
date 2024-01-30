using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMFunction_AccumulateFloatAdd
{
    // FloatProperty /Script/RigVM.RigVMFunction_AccumulateFloatAdd:Increment
    static readonly int Increment_Offset;
    public float Increment;
    
    // FloatProperty /Script/RigVM.RigVMFunction_AccumulateFloatAdd:InitialValue
    static readonly int InitialValue_Offset;
    public float InitialValue;
    
    // BoolProperty /Script/RigVM.RigVMFunction_AccumulateFloatAdd:bIntegrateDeltaTime
    static readonly int bIntegrateDeltaTime_Offset;
    public bool IntegrateDeltaTime;
    
    // FloatProperty /Script/RigVM.RigVMFunction_AccumulateFloatAdd:Result
    static readonly int Result_Offset;
    public float Result;
    
    
    public static readonly int NativeDataSize;
    static RigVMFunction_AccumulateFloatAdd()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMFunction_AccumulateFloatAdd");
        
        Increment_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Increment");
        InitialValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "InitialValue");
        bIntegrateDeltaTime_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bIntegrateDeltaTime");
        Result_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Result");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMFunction_AccumulateFloatAdd(IntPtr InNativeStruct)
    {
        unsafe
        {
            Increment = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Increment_Offset), 0, null);
            InitialValue = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, InitialValue_Offset), 0, null);
            IntegrateDeltaTime = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bIntegrateDeltaTime_Offset), 0, null);
            Result = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Result_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Increment_Offset), 0, null, Increment);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, InitialValue_Offset), 0, null, InitialValue);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bIntegrateDeltaTime_Offset), 0, null, IntegrateDeltaTime);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Result_Offset), 0, null, Result);
        }
    }
}

public static class RigVMFunction_AccumulateFloatAddMarshaler
{
    public static RigVMFunction_AccumulateFloatAdd FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMFunction_AccumulateFloatAdd(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMFunction_AccumulateFloatAdd obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMFunction_AccumulateFloatAdd.NativeDataSize;
    }
}