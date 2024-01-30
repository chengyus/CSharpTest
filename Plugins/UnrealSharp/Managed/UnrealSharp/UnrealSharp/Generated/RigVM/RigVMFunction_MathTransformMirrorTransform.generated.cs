using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMFunction_MathTransformMirrorTransform
{
    // StructProperty /Script/RigVM.RigVMFunction_MathTransformMirrorTransform:Value
    static readonly int Value_Offset;
    public UnrealSharp.Transform Value;
    
    // ByteProperty /Script/RigVM.RigVMFunction_MathTransformMirrorTransform:MirrorAxis
    static readonly int MirrorAxis_Offset;
    public UnrealSharp.CoreUObject.EAxis MirrorAxis;
    
    // ByteProperty /Script/RigVM.RigVMFunction_MathTransformMirrorTransform:AxisToFlip
    static readonly int AxisToFlip_Offset;
    public UnrealSharp.CoreUObject.EAxis AxisToFlip;
    
    // StructProperty /Script/RigVM.RigVMFunction_MathTransformMirrorTransform:CentralTransform
    static readonly int CentralTransform_Offset;
    public UnrealSharp.Transform CentralTransform;
    
    // StructProperty /Script/RigVM.RigVMFunction_MathTransformMirrorTransform:Result
    static readonly int Result_Offset;
    public UnrealSharp.Transform Result;
    
    
    public static readonly int NativeDataSize;
    static RigVMFunction_MathTransformMirrorTransform()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMFunction_MathTransformMirrorTransform");
        
        Value_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Value");
        MirrorAxis_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MirrorAxis");
        AxisToFlip_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AxisToFlip");
        CentralTransform_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "CentralTransform");
        Result_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Result");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMFunction_MathTransformMirrorTransform(IntPtr InNativeStruct)
    {
        unsafe
        {
            Value = BlittableMarshaller<UnrealSharp.Transform>.FromNative(IntPtr.Add(InNativeStruct, Value_Offset), 0, null);
            MirrorAxis = BlittableMarshaller<UnrealSharp.CoreUObject.EAxis>.FromNative(IntPtr.Add(InNativeStruct, MirrorAxis_Offset), 0, null);
            AxisToFlip = BlittableMarshaller<UnrealSharp.CoreUObject.EAxis>.FromNative(IntPtr.Add(InNativeStruct, AxisToFlip_Offset), 0, null);
            CentralTransform = BlittableMarshaller<UnrealSharp.Transform>.FromNative(IntPtr.Add(InNativeStruct, CentralTransform_Offset), 0, null);
            Result = BlittableMarshaller<UnrealSharp.Transform>.FromNative(IntPtr.Add(InNativeStruct, Result_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.Transform>.ToNative(IntPtr.Add(Buffer, Value_Offset), 0, null, Value);
            BlittableMarshaller<UnrealSharp.CoreUObject.EAxis>.ToNative(IntPtr.Add(Buffer, MirrorAxis_Offset), 0, null, MirrorAxis);
            BlittableMarshaller<UnrealSharp.CoreUObject.EAxis>.ToNative(IntPtr.Add(Buffer, AxisToFlip_Offset), 0, null, AxisToFlip);
            BlittableMarshaller<UnrealSharp.Transform>.ToNative(IntPtr.Add(Buffer, CentralTransform_Offset), 0, null, CentralTransform);
            BlittableMarshaller<UnrealSharp.Transform>.ToNative(IntPtr.Add(Buffer, Result_Offset), 0, null, Result);
        }
    }
}

public static class RigVMFunction_MathTransformMirrorTransformMarshaler
{
    public static RigVMFunction_MathTransformMirrorTransform FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMFunction_MathTransformMirrorTransform(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMFunction_MathTransformMirrorTransform obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMFunction_MathTransformMirrorTransform.NativeDataSize;
    }
}