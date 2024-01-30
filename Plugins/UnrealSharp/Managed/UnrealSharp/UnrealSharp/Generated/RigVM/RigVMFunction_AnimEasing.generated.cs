using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMFunction_AnimEasing
{
    // FloatProperty /Script/RigVM.RigVMFunction_AnimEasing:Value
    static readonly int Value_Offset;
    public float Value;
    
    // EnumProperty /Script/RigVM.RigVMFunction_AnimEasing:Type
    static readonly int Type_Offset;
    public UnrealSharp.RigVM.ERigVMAnimEasingType Type;
    
    // FloatProperty /Script/RigVM.RigVMFunction_AnimEasing:SourceMinimum
    static readonly int SourceMinimum_Offset;
    public float SourceMinimum;
    
    // FloatProperty /Script/RigVM.RigVMFunction_AnimEasing:SourceMaximum
    static readonly int SourceMaximum_Offset;
    public float SourceMaximum;
    
    // FloatProperty /Script/RigVM.RigVMFunction_AnimEasing:TargetMinimum
    static readonly int TargetMinimum_Offset;
    public float TargetMinimum;
    
    // FloatProperty /Script/RigVM.RigVMFunction_AnimEasing:TargetMaximum
    static readonly int TargetMaximum_Offset;
    public float TargetMaximum;
    
    // FloatProperty /Script/RigVM.RigVMFunction_AnimEasing:Result
    static readonly int Result_Offset;
    public float Result;
    
    
    public static readonly int NativeDataSize;
    static RigVMFunction_AnimEasing()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMFunction_AnimEasing");
        
        Value_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Value");
        Type_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Type");
        SourceMinimum_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SourceMinimum");
        SourceMaximum_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SourceMaximum");
        TargetMinimum_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "TargetMinimum");
        TargetMaximum_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "TargetMaximum");
        Result_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Result");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMFunction_AnimEasing(IntPtr InNativeStruct)
    {
        unsafe
        {
            Value = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Value_Offset), 0, null);
            Type = BlittableMarshaller<UnrealSharp.RigVM.ERigVMAnimEasingType>.FromNative(IntPtr.Add(InNativeStruct, Type_Offset), 0, null);
            SourceMinimum = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, SourceMinimum_Offset), 0, null);
            SourceMaximum = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, SourceMaximum_Offset), 0, null);
            TargetMinimum = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, TargetMinimum_Offset), 0, null);
            TargetMaximum = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, TargetMaximum_Offset), 0, null);
            Result = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Result_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Value_Offset), 0, null, Value);
            BlittableMarshaller<UnrealSharp.RigVM.ERigVMAnimEasingType>.ToNative(IntPtr.Add(Buffer, Type_Offset), 0, null, Type);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, SourceMinimum_Offset), 0, null, SourceMinimum);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, SourceMaximum_Offset), 0, null, SourceMaximum);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, TargetMinimum_Offset), 0, null, TargetMinimum);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, TargetMaximum_Offset), 0, null, TargetMaximum);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Result_Offset), 0, null, Result);
        }
    }
}

public static class RigVMFunction_AnimEasingMarshaler
{
    public static RigVMFunction_AnimEasing FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMFunction_AnimEasing(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMFunction_AnimEasing obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMFunction_AnimEasing.NativeDataSize;
    }
}