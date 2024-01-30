using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_HierarchyAddControlVector_Settings
{
    // EnumProperty /Script/ControlRig.RigUnit_HierarchyAddControlVector_Settings:InitialSpace
    static readonly int InitialSpace_Offset;
    public UnrealSharp.RigVM.ERigVMTransformSpace InitialSpace;
    
    // BoolProperty /Script/ControlRig.RigUnit_HierarchyAddControlVector_Settings:bIsPosition
    static readonly int bIsPosition_Offset;
    public bool IsPosition;
    
    // StructProperty /Script/ControlRig.RigUnit_HierarchyAddControlVector_Settings:Limits
    static readonly int Limits_Offset;
    public UnrealSharp.ControlRig.RigUnit_HierarchyAddControlVector_LimitSettings Limits;
    
    // StructProperty /Script/ControlRig.RigUnit_HierarchyAddControlVector_Settings:Shape
    static readonly int Shape_Offset;
    public UnrealSharp.ControlRig.RigUnit_HierarchyAddControl_ShapeSettings Shape;
    
    // StructProperty /Script/ControlRig.RigUnit_HierarchyAddControlVector_Settings:Proxy
    static readonly int Proxy_Offset;
    public UnrealSharp.ControlRig.RigUnit_HierarchyAddControl_ProxySettings Proxy;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_HierarchyAddControlVector_Settings()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_HierarchyAddControlVector_Settings");
        
        InitialSpace_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "InitialSpace");
        bIsPosition_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bIsPosition");
        Limits_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Limits");
        Shape_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Shape");
        Proxy_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Proxy");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_HierarchyAddControlVector_Settings(IntPtr InNativeStruct)
    {
        unsafe
        {
            InitialSpace = BlittableMarshaller<UnrealSharp.RigVM.ERigVMTransformSpace>.FromNative(IntPtr.Add(InNativeStruct, InitialSpace_Offset), 0, null);
            IsPosition = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bIsPosition_Offset), 0, null);
            Limits = UnrealSharp.ControlRig.RigUnit_HierarchyAddControlVector_LimitSettingsMarshaler.FromNative(IntPtr.Add(InNativeStruct, Limits_Offset), 0, null);
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
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bIsPosition_Offset), 0, null, IsPosition);
            UnrealSharp.ControlRig.RigUnit_HierarchyAddControlVector_LimitSettingsMarshaler.ToNative(IntPtr.Add(Buffer, Limits_Offset), 0, null, Limits);
            UnrealSharp.ControlRig.RigUnit_HierarchyAddControl_ShapeSettingsMarshaler.ToNative(IntPtr.Add(Buffer, Shape_Offset), 0, null, Shape);
            UnrealSharp.ControlRig.RigUnit_HierarchyAddControl_ProxySettingsMarshaler.ToNative(IntPtr.Add(Buffer, Proxy_Offset), 0, null, Proxy);
        }
    }
}

public static class RigUnit_HierarchyAddControlVector_SettingsMarshaler
{
    public static RigUnit_HierarchyAddControlVector_Settings FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_HierarchyAddControlVector_Settings(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_HierarchyAddControlVector_Settings obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_HierarchyAddControlVector_Settings.NativeDataSize;
    }
}