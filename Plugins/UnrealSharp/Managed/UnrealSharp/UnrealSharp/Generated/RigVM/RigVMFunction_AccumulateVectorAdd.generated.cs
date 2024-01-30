using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMFunction_AccumulateVectorAdd
{
    // StructProperty /Script/RigVM.RigVMFunction_AccumulateVectorAdd:Increment
    static readonly int Increment_Offset;
    public System.DoubleNumerics.Vector3 Increment;
    
    // StructProperty /Script/RigVM.RigVMFunction_AccumulateVectorAdd:InitialValue
    static readonly int InitialValue_Offset;
    public System.DoubleNumerics.Vector3 InitialValue;
    
    // BoolProperty /Script/RigVM.RigVMFunction_AccumulateVectorAdd:bIntegrateDeltaTime
    static readonly int bIntegrateDeltaTime_Offset;
    public bool IntegrateDeltaTime;
    
    // StructProperty /Script/RigVM.RigVMFunction_AccumulateVectorAdd:Result
    static readonly int Result_Offset;
    public System.DoubleNumerics.Vector3 Result;
    
    
    public static readonly int NativeDataSize;
    static RigVMFunction_AccumulateVectorAdd()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMFunction_AccumulateVectorAdd");
        
        Increment_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Increment");
        InitialValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "InitialValue");
        bIntegrateDeltaTime_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bIntegrateDeltaTime");
        Result_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Result");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMFunction_AccumulateVectorAdd(IntPtr InNativeStruct)
    {
        unsafe
        {
            Increment = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Increment_Offset), 0, null);
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
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Increment_Offset), 0, null, Increment);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, InitialValue_Offset), 0, null, InitialValue);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bIntegrateDeltaTime_Offset), 0, null, IntegrateDeltaTime);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Result_Offset), 0, null, Result);
        }
    }
}

public static class RigVMFunction_AccumulateVectorAddMarshaler
{
    public static RigVMFunction_AccumulateVectorAdd FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMFunction_AccumulateVectorAdd(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMFunction_AccumulateVectorAdd obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMFunction_AccumulateVectorAdd.NativeDataSize;
    }
}