using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_VisualDebugTransform
{
    // StructProperty /Script/ControlRig.RigUnit_VisualDebugTransform:Value
    static readonly int Value_Offset;
    public UnrealSharp.Transform Value;
    
    // BoolProperty /Script/ControlRig.RigUnit_VisualDebugTransform:bEnabled
    static readonly int bEnabled_Offset;
    public bool Enabled;
    
    // FloatProperty /Script/ControlRig.RigUnit_VisualDebugTransform:Thickness
    static readonly int Thickness_Offset;
    public float Thickness;
    
    // FloatProperty /Script/ControlRig.RigUnit_VisualDebugTransform:Scale
    static readonly int Scale_Offset;
    public float Scale;
    
    // NameProperty /Script/ControlRig.RigUnit_VisualDebugTransform:BoneSpace
    static readonly int BoneSpace_Offset;
    public Name BoneSpace;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_VisualDebugTransform()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_VisualDebugTransform");
        
        Value_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Value");
        bEnabled_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bEnabled");
        Thickness_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Thickness");
        Scale_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Scale");
        BoneSpace_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BoneSpace");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_VisualDebugTransform(IntPtr InNativeStruct)
    {
        unsafe
        {
            Value = BlittableMarshaller<UnrealSharp.Transform>.FromNative(IntPtr.Add(InNativeStruct, Value_Offset), 0, null);
            Enabled = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bEnabled_Offset), 0, null);
            Thickness = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Thickness_Offset), 0, null);
            Scale = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Scale_Offset), 0, null);
            BoneSpace = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, BoneSpace_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.Transform>.ToNative(IntPtr.Add(Buffer, Value_Offset), 0, null, Value);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bEnabled_Offset), 0, null, Enabled);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Thickness_Offset), 0, null, Thickness);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Scale_Offset), 0, null, Scale);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, BoneSpace_Offset), 0, null, BoneSpace);
        }
    }
}

public static class RigUnit_VisualDebugTransformMarshaler
{
    public static RigUnit_VisualDebugTransform FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_VisualDebugTransform(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_VisualDebugTransform obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_VisualDebugTransform.NativeDataSize;
    }
}