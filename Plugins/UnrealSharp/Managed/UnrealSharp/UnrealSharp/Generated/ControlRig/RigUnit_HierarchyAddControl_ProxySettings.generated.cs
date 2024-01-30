using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_HierarchyAddControl_ProxySettings
{
    // BoolProperty /Script/ControlRig.RigUnit_HierarchyAddControl_ProxySettings:bIsProxy
    static readonly int bIsProxy_Offset;
    public bool IsProxy;
    
    // EnumProperty /Script/ControlRig.RigUnit_HierarchyAddControl_ProxySettings:ShapeVisibility
    static readonly int ShapeVisibility_Offset;
    public UnrealSharp.ControlRig.ERigControlVisibility ShapeVisibility;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_HierarchyAddControl_ProxySettings()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_HierarchyAddControl_ProxySettings");
        
        bIsProxy_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bIsProxy");
        ShapeVisibility_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ShapeVisibility");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_HierarchyAddControl_ProxySettings(IntPtr InNativeStruct)
    {
        unsafe
        {
            IsProxy = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bIsProxy_Offset), 0, null);
            ShapeVisibility = BlittableMarshaller<UnrealSharp.ControlRig.ERigControlVisibility>.FromNative(IntPtr.Add(InNativeStruct, ShapeVisibility_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bIsProxy_Offset), 0, null, IsProxy);
            BlittableMarshaller<UnrealSharp.ControlRig.ERigControlVisibility>.ToNative(IntPtr.Add(Buffer, ShapeVisibility_Offset), 0, null, ShapeVisibility);
        }
    }
}

public static class RigUnit_HierarchyAddControl_ProxySettingsMarshaler
{
    public static RigUnit_HierarchyAddControl_ProxySettings FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_HierarchyAddControl_ProxySettings(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_HierarchyAddControl_ProxySettings obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_HierarchyAddControl_ProxySettings.NativeDataSize;
    }
}