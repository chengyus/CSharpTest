using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_HierarchyAddControlElement
{
    // StructProperty /Script/ControlRig.RigUnit_HierarchyAddControlElement:OffsetTransform
    static readonly int OffsetTransform_Offset;
    public UnrealSharp.Transform OffsetTransform;
    
    // EnumProperty /Script/ControlRig.RigUnit_HierarchyAddControlElement:OffsetSpace
    static readonly int OffsetSpace_Offset;
    public UnrealSharp.RigVM.ERigVMTransformSpace OffsetSpace;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_HierarchyAddControlElement()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_HierarchyAddControlElement");
        
        OffsetTransform_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "OffsetTransform");
        OffsetSpace_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "OffsetSpace");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_HierarchyAddControlElement(IntPtr InNativeStruct)
    {
        unsafe
        {
            OffsetTransform = BlittableMarshaller<UnrealSharp.Transform>.FromNative(IntPtr.Add(InNativeStruct, OffsetTransform_Offset), 0, null);
            OffsetSpace = BlittableMarshaller<UnrealSharp.RigVM.ERigVMTransformSpace>.FromNative(IntPtr.Add(InNativeStruct, OffsetSpace_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.Transform>.ToNative(IntPtr.Add(Buffer, OffsetTransform_Offset), 0, null, OffsetTransform);
            BlittableMarshaller<UnrealSharp.RigVM.ERigVMTransformSpace>.ToNative(IntPtr.Add(Buffer, OffsetSpace_Offset), 0, null, OffsetSpace);
        }
    }
}

public static class RigUnit_HierarchyAddControlElementMarshaler
{
    public static RigUnit_HierarchyAddControlElement FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_HierarchyAddControlElement(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_HierarchyAddControlElement obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_HierarchyAddControlElement.NativeDataSize;
    }
}