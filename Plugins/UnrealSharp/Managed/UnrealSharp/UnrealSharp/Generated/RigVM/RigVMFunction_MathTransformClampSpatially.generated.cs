using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMFunction_MathTransformClampSpatially
{
    // StructProperty /Script/RigVM.RigVMFunction_MathTransformClampSpatially:Value
    static readonly int Value_Offset;
    public UnrealSharp.Transform Value;
    
    // ByteProperty /Script/RigVM.RigVMFunction_MathTransformClampSpatially:Axis
    static readonly int Axis_Offset;
    public UnrealSharp.CoreUObject.EAxis Axis;
    
    // ByteProperty /Script/RigVM.RigVMFunction_MathTransformClampSpatially:Type
    static readonly int Type_Offset;
    public UnrealSharp.RigVM.ERigVMClampSpatialMode Type;
    
    // FloatProperty /Script/RigVM.RigVMFunction_MathTransformClampSpatially:Minimum
    static readonly int Minimum_Offset;
    public float Minimum;
    
    // FloatProperty /Script/RigVM.RigVMFunction_MathTransformClampSpatially:Maximum
    static readonly int Maximum_Offset;
    public float Maximum;
    
    // StructProperty /Script/RigVM.RigVMFunction_MathTransformClampSpatially:Space
    static readonly int Space_Offset;
    public UnrealSharp.Transform Space;
    
    // BoolProperty /Script/RigVM.RigVMFunction_MathTransformClampSpatially:bDrawDebug
    static readonly int bDrawDebug_Offset;
    public bool DrawDebug;
    
    // StructProperty /Script/RigVM.RigVMFunction_MathTransformClampSpatially:DebugColor
    static readonly int DebugColor_Offset;
    public UnrealSharp.CoreUObject.LinearColor DebugColor;
    
    // FloatProperty /Script/RigVM.RigVMFunction_MathTransformClampSpatially:DebugThickness
    static readonly int DebugThickness_Offset;
    public float DebugThickness;
    
    // StructProperty /Script/RigVM.RigVMFunction_MathTransformClampSpatially:Result
    static readonly int Result_Offset;
    public UnrealSharp.Transform Result;
    
    
    public static readonly int NativeDataSize;
    static RigVMFunction_MathTransformClampSpatially()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMFunction_MathTransformClampSpatially");
        
        Value_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Value");
        Axis_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Axis");
        Type_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Type");
        Minimum_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Minimum");
        Maximum_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Maximum");
        Space_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Space");
        bDrawDebug_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bDrawDebug");
        DebugColor_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DebugColor");
        DebugThickness_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DebugThickness");
        Result_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Result");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMFunction_MathTransformClampSpatially(IntPtr InNativeStruct)
    {
        unsafe
        {
            Value = BlittableMarshaller<UnrealSharp.Transform>.FromNative(IntPtr.Add(InNativeStruct, Value_Offset), 0, null);
            Axis = BlittableMarshaller<UnrealSharp.CoreUObject.EAxis>.FromNative(IntPtr.Add(InNativeStruct, Axis_Offset), 0, null);
            Type = BlittableMarshaller<UnrealSharp.RigVM.ERigVMClampSpatialMode>.FromNative(IntPtr.Add(InNativeStruct, Type_Offset), 0, null);
            Minimum = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Minimum_Offset), 0, null);
            Maximum = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Maximum_Offset), 0, null);
            Space = BlittableMarshaller<UnrealSharp.Transform>.FromNative(IntPtr.Add(InNativeStruct, Space_Offset), 0, null);
            DrawDebug = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bDrawDebug_Offset), 0, null);
            DebugColor = BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.FromNative(IntPtr.Add(InNativeStruct, DebugColor_Offset), 0, null);
            DebugThickness = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, DebugThickness_Offset), 0, null);
            Result = BlittableMarshaller<UnrealSharp.Transform>.FromNative(IntPtr.Add(InNativeStruct, Result_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.Transform>.ToNative(IntPtr.Add(Buffer, Value_Offset), 0, null, Value);
            BlittableMarshaller<UnrealSharp.CoreUObject.EAxis>.ToNative(IntPtr.Add(Buffer, Axis_Offset), 0, null, Axis);
            BlittableMarshaller<UnrealSharp.RigVM.ERigVMClampSpatialMode>.ToNative(IntPtr.Add(Buffer, Type_Offset), 0, null, Type);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Minimum_Offset), 0, null, Minimum);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Maximum_Offset), 0, null, Maximum);
            BlittableMarshaller<UnrealSharp.Transform>.ToNative(IntPtr.Add(Buffer, Space_Offset), 0, null, Space);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bDrawDebug_Offset), 0, null, DrawDebug);
            BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.ToNative(IntPtr.Add(Buffer, DebugColor_Offset), 0, null, DebugColor);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, DebugThickness_Offset), 0, null, DebugThickness);
            BlittableMarshaller<UnrealSharp.Transform>.ToNative(IntPtr.Add(Buffer, Result_Offset), 0, null, Result);
        }
    }
}

public static class RigVMFunction_MathTransformClampSpatiallyMarshaler
{
    public static RigVMFunction_MathTransformClampSpatially FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMFunction_MathTransformClampSpatially(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMFunction_MathTransformClampSpatially obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMFunction_MathTransformClampSpatially.NativeDataSize;
    }
}