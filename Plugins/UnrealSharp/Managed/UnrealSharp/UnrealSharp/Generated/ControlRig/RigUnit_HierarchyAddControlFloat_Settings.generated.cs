using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_HierarchyAddControlFloat_Settings
{
    // EnumProperty /Script/ControlRig.RigUnit_HierarchyAddControlFloat_Settings:PrimaryAxis
    static readonly int PrimaryAxis_Offset;
    public UnrealSharp.ControlRig.ERigControlAxis PrimaryAxis;
    
    // StructProperty /Script/ControlRig.RigUnit_HierarchyAddControlFloat_Settings:Limits
    static readonly int Limits_Offset;
    public UnrealSharp.ControlRig.RigUnit_HierarchyAddControlFloat_LimitSettings Limits;
    
    // StructProperty /Script/ControlRig.RigUnit_HierarchyAddControlFloat_Settings:Shape
    static readonly int Shape_Offset;
    public UnrealSharp.ControlRig.RigUnit_HierarchyAddControl_ShapeSettings Shape;
    
    // StructProperty /Script/ControlRig.RigUnit_HierarchyAddControlFloat_Settings:Proxy
    static readonly int Proxy_Offset;
    public UnrealSharp.ControlRig.RigUnit_HierarchyAddControl_ProxySettings Proxy;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_HierarchyAddControlFloat_Settings()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_HierarchyAddControlFloat_Settings");
        
        PrimaryAxis_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PrimaryAxis");
        Limits_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Limits");
        Shape_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Shape");
        Proxy_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Proxy");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_HierarchyAddControlFloat_Settings(IntPtr InNativeStruct)
    {
        unsafe
        {
            PrimaryAxis = BlittableMarshaller<UnrealSharp.ControlRig.ERigControlAxis>.FromNative(IntPtr.Add(InNativeStruct, PrimaryAxis_Offset), 0, null);
            Limits = UnrealSharp.ControlRig.RigUnit_HierarchyAddControlFloat_LimitSettingsMarshaler.FromNative(IntPtr.Add(InNativeStruct, Limits_Offset), 0, null);
            Shape = UnrealSharp.ControlRig.RigUnit_HierarchyAddControl_ShapeSettingsMarshaler.FromNative(IntPtr.Add(InNativeStruct, Shape_Offset), 0, null);
            Proxy = UnrealSharp.ControlRig.RigUnit_HierarchyAddControl_ProxySettingsMarshaler.FromNative(IntPtr.Add(InNativeStruct, Proxy_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.ControlRig.ERigControlAxis>.ToNative(IntPtr.Add(Buffer, PrimaryAxis_Offset), 0, null, PrimaryAxis);
            UnrealSharp.ControlRig.RigUnit_HierarchyAddControlFloat_LimitSettingsMarshaler.ToNative(IntPtr.Add(Buffer, Limits_Offset), 0, null, Limits);
            UnrealSharp.ControlRig.RigUnit_HierarchyAddControl_ShapeSettingsMarshaler.ToNative(IntPtr.Add(Buffer, Shape_Offset), 0, null, Shape);
            UnrealSharp.ControlRig.RigUnit_HierarchyAddControl_ProxySettingsMarshaler.ToNative(IntPtr.Add(Buffer, Proxy_Offset), 0, null, Proxy);
        }
    }
}

public static class RigUnit_HierarchyAddControlFloat_SettingsMarshaler
{
    public static RigUnit_HierarchyAddControlFloat_Settings FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_HierarchyAddControlFloat_Settings(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_HierarchyAddControlFloat_Settings obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_HierarchyAddControlFloat_Settings.NativeDataSize;
    }
}