using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMFunction_AccumulateTransformMul
{
    // StructProperty /Script/RigVM.RigVMFunction_AccumulateTransformMul:Multiplier
    static readonly int Multiplier_Offset;
    public UnrealSharp.Transform Multiplier;
    
    // StructProperty /Script/RigVM.RigVMFunction_AccumulateTransformMul:InitialValue
    static readonly int InitialValue_Offset;
    public UnrealSharp.Transform InitialValue;
    
    // BoolProperty /Script/RigVM.RigVMFunction_AccumulateTransformMul:bFlipOrder
    static readonly int bFlipOrder_Offset;
    public bool FlipOrder;
    
    // BoolProperty /Script/RigVM.RigVMFunction_AccumulateTransformMul:bIntegrateDeltaTime
    static readonly int bIntegrateDeltaTime_Offset;
    public bool IntegrateDeltaTime;
    
    // StructProperty /Script/RigVM.RigVMFunction_AccumulateTransformMul:Result
    static readonly int Result_Offset;
    public UnrealSharp.Transform Result;
    
    
    public static readonly int NativeDataSize;
    static RigVMFunction_AccumulateTransformMul()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMFunction_AccumulateTransformMul");
        
        Multiplier_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Multiplier");
        InitialValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "InitialValue");
        bFlipOrder_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bFlipOrder");
        bIntegrateDeltaTime_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bIntegrateDeltaTime");
        Result_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Result");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMFunction_AccumulateTransformMul(IntPtr InNativeStruct)
    {
        unsafe
        {
            Multiplier = BlittableMarshaller<UnrealSharp.Transform>.FromNative(IntPtr.Add(InNativeStruct, Multiplier_Offset), 0, null);
            InitialValue = BlittableMarshaller<UnrealSharp.Transform>.FromNative(IntPtr.Add(InNativeStruct, InitialValue_Offset), 0, null);
            FlipOrder = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bFlipOrder_Offset), 0, null);
            IntegrateDeltaTime = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bIntegrateDeltaTime_Offset), 0, null);
            Result = BlittableMarshaller<UnrealSharp.Transform>.FromNative(IntPtr.Add(InNativeStruct, Result_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.Transform>.ToNative(IntPtr.Add(Buffer, Multiplier_Offset), 0, null, Multiplier);
            BlittableMarshaller<UnrealSharp.Transform>.ToNative(IntPtr.Add(Buffer, InitialValue_Offset), 0, null, InitialValue);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bFlipOrder_Offset), 0, null, FlipOrder);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bIntegrateDeltaTime_Offset), 0, null, IntegrateDeltaTime);
            BlittableMarshaller<UnrealSharp.Transform>.ToNative(IntPtr.Add(Buffer, Result_Offset), 0, null, Result);
        }
    }
}

public static class RigVMFunction_AccumulateTransformMulMarshaler
{
    public static RigVMFunction_AccumulateTransformMul FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMFunction_AccumulateTransformMul(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMFunction_AccumulateTransformMul obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMFunction_AccumulateTransformMul.NativeDataSize;
    }
}