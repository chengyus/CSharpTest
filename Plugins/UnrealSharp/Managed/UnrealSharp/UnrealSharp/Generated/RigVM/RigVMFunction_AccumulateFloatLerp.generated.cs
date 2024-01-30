using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMFunction_AccumulateFloatLerp
{
    // FloatProperty /Script/RigVM.RigVMFunction_AccumulateFloatLerp:TargetValue
    static readonly int TargetValue_Offset;
    public float TargetValue;
    
    // FloatProperty /Script/RigVM.RigVMFunction_AccumulateFloatLerp:InitialValue
    static readonly int InitialValue_Offset;
    public float InitialValue;
    
    // FloatProperty /Script/RigVM.RigVMFunction_AccumulateFloatLerp:Blend
    static readonly int Blend_Offset;
    public float Blend;
    
    // BoolProperty /Script/RigVM.RigVMFunction_AccumulateFloatLerp:bIntegrateDeltaTime
    static readonly int bIntegrateDeltaTime_Offset;
    public bool IntegrateDeltaTime;
    
    // FloatProperty /Script/RigVM.RigVMFunction_AccumulateFloatLerp:Result
    static readonly int Result_Offset;
    public float Result;
    
    
    public static readonly int NativeDataSize;
    static RigVMFunction_AccumulateFloatLerp()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMFunction_AccumulateFloatLerp");
        
        TargetValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "TargetValue");
        InitialValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "InitialValue");
        Blend_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Blend");
        bIntegrateDeltaTime_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bIntegrateDeltaTime");
        Result_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Result");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMFunction_AccumulateFloatLerp(IntPtr InNativeStruct)
    {
        unsafe
        {
            TargetValue = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, TargetValue_Offset), 0, null);
            InitialValue = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, InitialValue_Offset), 0, null);
            Blend = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Blend_Offset), 0, null);
            IntegrateDeltaTime = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bIntegrateDeltaTime_Offset), 0, null);
            Result = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Result_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, TargetValue_Offset), 0, null, TargetValue);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, InitialValue_Offset), 0, null, InitialValue);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Blend_Offset), 0, null, Blend);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bIntegrateDeltaTime_Offset), 0, null, IntegrateDeltaTime);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Result_Offset), 0, null, Result);
        }
    }
}

public static class RigVMFunction_AccumulateFloatLerpMarshaler
{
    public static RigVMFunction_AccumulateFloatLerp FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMFunction_AccumulateFloatLerp(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMFunction_AccumulateFloatLerp obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMFunction_AccumulateFloatLerp.NativeDataSize;
    }
}