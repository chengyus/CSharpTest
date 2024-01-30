using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMFunction_AccumulateVectorMul
{
    // StructProperty /Script/RigVM.RigVMFunction_AccumulateVectorMul:Multiplier
    static readonly int Multiplier_Offset;
    public System.DoubleNumerics.Vector3 Multiplier;
    
    // StructProperty /Script/RigVM.RigVMFunction_AccumulateVectorMul:InitialValue
    static readonly int InitialValue_Offset;
    public System.DoubleNumerics.Vector3 InitialValue;
    
    // BoolProperty /Script/RigVM.RigVMFunction_AccumulateVectorMul:bIntegrateDeltaTime
    static readonly int bIntegrateDeltaTime_Offset;
    public bool IntegrateDeltaTime;
    
    // StructProperty /Script/RigVM.RigVMFunction_AccumulateVectorMul:Result
    static readonly int Result_Offset;
    public System.DoubleNumerics.Vector3 Result;
    
    
    public static readonly int NativeDataSize;
    static RigVMFunction_AccumulateVectorMul()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMFunction_AccumulateVectorMul");
        
        Multiplier_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Multiplier");
        InitialValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "InitialValue");
        bIntegrateDeltaTime_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bIntegrateDeltaTime");
        Result_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Result");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMFunction_AccumulateVectorMul(IntPtr InNativeStruct)
    {
        unsafe
        {
            Multiplier = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Multiplier_Offset), 0, null);
            InitialValue = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, InitialValue_Offset), 0, null);
            IntegrateDeltaTime = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bIntegrateDeltaTime_Offset), 0, null);
            Result = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Result_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Multiplier_Offset), 0, null, Multiplier);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, InitialValue_Offset), 0, null, InitialValue);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bIntegrateDeltaTime_Offset), 0, null, IntegrateDeltaTime);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Result_Offset), 0, null, Result);
        }
    }
}

public static class RigVMFunction_AccumulateVectorMulMarshaler
{
    public static RigVMFunction_AccumulateVectorMul FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMFunction_AccumulateVectorMul(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMFunction_AccumulateVectorMul obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMFunction_AccumulateVectorMul.NativeDataSize;
    }
}