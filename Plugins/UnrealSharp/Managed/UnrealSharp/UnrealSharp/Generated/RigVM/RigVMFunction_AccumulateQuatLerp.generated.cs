using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMFunction_AccumulateQuatLerp
{
    // StructProperty /Script/RigVM.RigVMFunction_AccumulateQuatLerp:TargetValue
    static readonly int TargetValue_Offset;
    public System.DoubleNumerics.Quaternion TargetValue;
    
    // StructProperty /Script/RigVM.RigVMFunction_AccumulateQuatLerp:InitialValue
    static readonly int InitialValue_Offset;
    public System.DoubleNumerics.Quaternion InitialValue;
    
    // FloatProperty /Script/RigVM.RigVMFunction_AccumulateQuatLerp:Blend
    static readonly int Blend_Offset;
    public float Blend;
    
    // BoolProperty /Script/RigVM.RigVMFunction_AccumulateQuatLerp:bIntegrateDeltaTime
    static readonly int bIntegrateDeltaTime_Offset;
    public bool IntegrateDeltaTime;
    
    // StructProperty /Script/RigVM.RigVMFunction_AccumulateQuatLerp:Result
    static readonly int Result_Offset;
    public System.DoubleNumerics.Quaternion Result;
    
    
    public static readonly int NativeDataSize;
    static RigVMFunction_AccumulateQuatLerp()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMFunction_AccumulateQuatLerp");
        
        TargetValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "TargetValue");
        InitialValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "InitialValue");
        Blend_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Blend");
        bIntegrateDeltaTime_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bIntegrateDeltaTime");
        Result_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Result");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMFunction_AccumulateQuatLerp(IntPtr InNativeStruct)
    {
        unsafe
        {
            TargetValue = BlittableMarshaller<System.DoubleNumerics.Quaternion>.FromNative(IntPtr.Add(InNativeStruct, TargetValue_Offset), 0, null);
            InitialValue = BlittableMarshaller<System.DoubleNumerics.Quaternion>.FromNative(IntPtr.Add(InNativeStruct, InitialValue_Offset), 0, null);
            Blend = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Blend_Offset), 0, null);
            IntegrateDeltaTime = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bIntegrateDeltaTime_Offset), 0, null);
            Result = BlittableMarshaller<System.DoubleNumerics.Quaternion>.FromNative(IntPtr.Add(InNativeStruct, Result_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<System.DoubleNumerics.Quaternion>.ToNative(IntPtr.Add(Buffer, TargetValue_Offset), 0, null, TargetValue);
            BlittableMarshaller<System.DoubleNumerics.Quaternion>.ToNative(IntPtr.Add(Buffer, InitialValue_Offset), 0, null, InitialValue);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Blend_Offset), 0, null, Blend);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bIntegrateDeltaTime_Offset), 0, null, IntegrateDeltaTime);
            BlittableMarshaller<System.DoubleNumerics.Quaternion>.ToNative(IntPtr.Add(Buffer, Result_Offset), 0, null, Result);
        }
    }
}

public static class RigVMFunction_AccumulateQuatLerpMarshaler
{
    public static RigVMFunction_AccumulateQuatLerp FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMFunction_AccumulateQuatLerp(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMFunction_AccumulateQuatLerp obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMFunction_AccumulateQuatLerp.NativeDataSize;
    }
}