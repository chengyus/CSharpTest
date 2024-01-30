using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMFunction_AccumulateTransformLerp
{
    // StructProperty /Script/RigVM.RigVMFunction_AccumulateTransformLerp:TargetValue
    static readonly int TargetValue_Offset;
    public UnrealSharp.Transform TargetValue;
    
    // StructProperty /Script/RigVM.RigVMFunction_AccumulateTransformLerp:InitialValue
    static readonly int InitialValue_Offset;
    public UnrealSharp.Transform InitialValue;
    
    // FloatProperty /Script/RigVM.RigVMFunction_AccumulateTransformLerp:Blend
    static readonly int Blend_Offset;
    public float Blend;
    
    // BoolProperty /Script/RigVM.RigVMFunction_AccumulateTransformLerp:bIntegrateDeltaTime
    static readonly int bIntegrateDeltaTime_Offset;
    public bool IntegrateDeltaTime;
    
    // StructProperty /Script/RigVM.RigVMFunction_AccumulateTransformLerp:Result
    static readonly int Result_Offset;
    public UnrealSharp.Transform Result;
    
    
    public static readonly int NativeDataSize;
    static RigVMFunction_AccumulateTransformLerp()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMFunction_AccumulateTransformLerp");
        
        TargetValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "TargetValue");
        InitialValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "InitialValue");
        Blend_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Blend");
        bIntegrateDeltaTime_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bIntegrateDeltaTime");
        Result_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Result");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMFunction_AccumulateTransformLerp(IntPtr InNativeStruct)
    {
        unsafe
        {
            TargetValue = BlittableMarshaller<UnrealSharp.Transform>.FromNative(IntPtr.Add(InNativeStruct, TargetValue_Offset), 0, null);
            InitialValue = BlittableMarshaller<UnrealSharp.Transform>.FromNative(IntPtr.Add(InNativeStruct, InitialValue_Offset), 0, null);
            Blend = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Blend_Offset), 0, null);
            IntegrateDeltaTime = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bIntegrateDeltaTime_Offset), 0, null);
            Result = BlittableMarshaller<UnrealSharp.Transform>.FromNative(IntPtr.Add(InNativeStruct, Result_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.Transform>.ToNative(IntPtr.Add(Buffer, TargetValue_Offset), 0, null, TargetValue);
            BlittableMarshaller<UnrealSharp.Transform>.ToNative(IntPtr.Add(Buffer, InitialValue_Offset), 0, null, InitialValue);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Blend_Offset), 0, null, Blend);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bIntegrateDeltaTime_Offset), 0, null, IntegrateDeltaTime);
            BlittableMarshaller<UnrealSharp.Transform>.ToNative(IntPtr.Add(Buffer, Result_Offset), 0, null, Result);
        }
    }
}

public static class RigVMFunction_AccumulateTransformLerpMarshaler
{
    public static RigVMFunction_AccumulateTransformLerp FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMFunction_AccumulateTransformLerp(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMFunction_AccumulateTransformLerp obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMFunction_AccumulateTransformLerp.NativeDataSize;
    }
}