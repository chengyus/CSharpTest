using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_GetControlTransform
{
    // NameProperty /Script/ControlRig.RigUnit_GetControlTransform:Control
    static readonly int Control_Offset;
    public Name Control;
    
    // EnumProperty /Script/ControlRig.RigUnit_GetControlTransform:Space
    static readonly int Space_Offset;
    public UnrealSharp.RigVM.ERigVMTransformSpace Space;
    
    // StructProperty /Script/ControlRig.RigUnit_GetControlTransform:Transform
    static readonly int Transform_Offset;
    public UnrealSharp.Transform Transform;
    
    // StructProperty /Script/ControlRig.RigUnit_GetControlTransform:Minimum
    static readonly int Minimum_Offset;
    public UnrealSharp.Transform Minimum;
    
    // StructProperty /Script/ControlRig.RigUnit_GetControlTransform:Maximum
    static readonly int Maximum_Offset;
    public UnrealSharp.Transform Maximum;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_GetControlTransform()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_GetControlTransform");
        
        Control_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Control");
        Space_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Space");
        Transform_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Transform");
        Minimum_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Minimum");
        Maximum_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Maximum");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_GetControlTransform(IntPtr InNativeStruct)
    {
        unsafe
        {
            Control = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, Control_Offset), 0, null);
            Space = BlittableMarshaller<UnrealSharp.RigVM.ERigVMTransformSpace>.FromNative(IntPtr.Add(InNativeStruct, Space_Offset), 0, null);
            Transform = BlittableMarshaller<UnrealSharp.Transform>.FromNative(IntPtr.Add(InNativeStruct, Transform_Offset), 0, null);
            Minimum = BlittableMarshaller<UnrealSharp.Transform>.FromNative(IntPtr.Add(InNativeStruct, Minimum_Offset), 0, null);
            Maximum = BlittableMarshaller<UnrealSharp.Transform>.FromNative(IntPtr.Add(InNativeStruct, Maximum_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, Control_Offset), 0, null, Control);
            BlittableMarshaller<UnrealSharp.RigVM.ERigVMTransformSpace>.ToNative(IntPtr.Add(Buffer, Space_Offset), 0, null, Space);
            BlittableMarshaller<UnrealSharp.Transform>.ToNative(IntPtr.Add(Buffer, Transform_Offset), 0, null, Transform);
            BlittableMarshaller<UnrealSharp.Transform>.ToNative(IntPtr.Add(Buffer, Minimum_Offset), 0, null, Minimum);
            BlittableMarshaller<UnrealSharp.Transform>.ToNative(IntPtr.Add(Buffer, Maximum_Offset), 0, null, Maximum);
        }
    }
}

public static class RigUnit_GetControlTransformMarshaler
{
    public static RigUnit_GetControlTransform FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_GetControlTransform(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_GetControlTransform obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_GetControlTransform.NativeDataSize;
    }
}