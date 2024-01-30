using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_SetControlRotator
{
    // NameProperty /Script/ControlRig.RigUnit_SetControlRotator:Control
    static readonly int Control_Offset;
    public Name Control;
    
    // FloatProperty /Script/ControlRig.RigUnit_SetControlRotator:Weight
    static readonly int Weight_Offset;
    public float Weight;
    
    // StructProperty /Script/ControlRig.RigUnit_SetControlRotator:Rotator
    static readonly int Rotator_Offset;
    public UnrealSharp.Rotator Rotator;
    
    // EnumProperty /Script/ControlRig.RigUnit_SetControlRotator:Space
    static readonly int Space_Offset;
    public UnrealSharp.RigVM.ERigVMTransformSpace Space;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_SetControlRotator()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_SetControlRotator");
        
        Control_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Control");
        Weight_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Weight");
        Rotator_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Rotator");
        Space_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Space");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_SetControlRotator(IntPtr InNativeStruct)
    {
        unsafe
        {
            Control = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, Control_Offset), 0, null);
            Weight = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Weight_Offset), 0, null);
            Rotator = BlittableMarshaller<UnrealSharp.Rotator>.FromNative(IntPtr.Add(InNativeStruct, Rotator_Offset), 0, null);
            Space = BlittableMarshaller<UnrealSharp.RigVM.ERigVMTransformSpace>.FromNative(IntPtr.Add(InNativeStruct, Space_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, Control_Offset), 0, null, Control);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Weight_Offset), 0, null, Weight);
            BlittableMarshaller<UnrealSharp.Rotator>.ToNative(IntPtr.Add(Buffer, Rotator_Offset), 0, null, Rotator);
            BlittableMarshaller<UnrealSharp.RigVM.ERigVMTransformSpace>.ToNative(IntPtr.Add(Buffer, Space_Offset), 0, null, Space);
        }
    }
}

public static class RigUnit_SetControlRotatorMarshaler
{
    public static RigUnit_SetControlRotator FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_SetControlRotator(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_SetControlRotator obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_SetControlRotator.NativeDataSize;
    }
}