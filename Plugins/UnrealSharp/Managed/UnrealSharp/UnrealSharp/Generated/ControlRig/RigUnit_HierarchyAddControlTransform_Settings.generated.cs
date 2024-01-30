using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_HierarchyAddControlTransform_Settings
{
    // EnumProperty /Script/ControlRig.RigUnit_HierarchyAddControlTransform_Settings:InitialSpace
    static readonly int InitialSpace_Offset;
    public UnrealSharp.RigVM.ERigVMTransformSpace InitialSpace;
    
    // StructProperty /Script/ControlRig.RigUnit_HierarchyAddControlTransform_Settings:Shape
    static readonly int Shape_Offset;
    public UnrealSharp.ControlRig.RigUnit_HierarchyAddControl_ShapeSettings Shape;
    
    // StructProperty /Script/ControlRig.RigUnit_HierarchyAddControlTransform_Settings:Proxy
    static readonly int Proxy_Offset;
    public UnrealSharp.ControlRig.RigUnit_HierarchyAddControl_ProxySettings Proxy;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_HierarchyAddControlTransform_Settings()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_HierarchyAddControlTransform_Settings");
        
        InitialSpace_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "InitialSpace");
        Shape_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Shape");
        Proxy_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Proxy");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_HierarchyAddControlTransform_Settings(IntPtr InNativeStruct)
    {
        unsafe
        {
            InitialSpace = BlittableMarshaller<UnrealSharp.RigVM.ERigVMTransformSpace>.FromNative(IntPtr.Add(InNativeStruct, InitialSpace_Offset), 0, null);
            Shape = UnrealSharp.ControlRig.RigUnit_HierarchyAddControl_ShapeSettingsMarshaler.FromNative(IntPtr.Add(InNativeStruct, Shape_Offset), 0, null);
            Proxy = UnrealSharp.ControlRig.RigUnit_HierarchyAddControl_ProxySettingsMarshaler.FromNative(IntPtr.Add(InNativeStruct, Proxy_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.RigVM.ERigVMTransformSpace>.ToNative(IntPtr.Add(Buffer, InitialSpace_Offset), 0, null, InitialSpace);
            UnrealSharp.ControlRig.RigUnit_HierarchyAddControl_ShapeSettingsMarshaler.ToNative(IntPtr.Add(Buffer, Shape_Offset), 0, null, Shape);
            UnrealSharp.ControlRig.RigUnit_HierarchyAddControl_ProxySettingsMarshaler.ToNative(IntPtr.Add(Buffer, Proxy_Offset), 0, null, Proxy);
        }
    }
}

public static class RigUnit_HierarchyAddControlTransform_SettingsMarshaler
{
    public static RigUnit_HierarchyAddControlTransform_Settings FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_HierarchyAddControlTransform_Settings(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_HierarchyAddControlTransform_Settings obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_HierarchyAddControlTransform_Settings.NativeDataSize;
    }
}