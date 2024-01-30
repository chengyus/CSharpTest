using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_HierarchySetShapeSettings
{
    // StructProperty /Script/ControlRig.RigUnit_HierarchySetShapeSettings:Item
    static readonly int Item_Offset;
    public UnrealSharp.ControlRig.RigElementKey Item;
    
    // StructProperty /Script/ControlRig.RigUnit_HierarchySetShapeSettings:Settings
    static readonly int Settings_Offset;
    public UnrealSharp.ControlRig.RigUnit_HierarchyAddControl_ShapeSettings Settings;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_HierarchySetShapeSettings()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_HierarchySetShapeSettings");
        
        Item_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Item");
        Settings_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Settings");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_HierarchySetShapeSettings(IntPtr InNativeStruct)
    {
        unsafe
        {
            Item = UnrealSharp.ControlRig.RigElementKeyMarshaler.FromNative(IntPtr.Add(InNativeStruct, Item_Offset), 0, null);
            Settings = UnrealSharp.ControlRig.RigUnit_HierarchyAddControl_ShapeSettingsMarshaler.FromNative(IntPtr.Add(InNativeStruct, Settings_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.ControlRig.RigElementKeyMarshaler.ToNative(IntPtr.Add(Buffer, Item_Offset), 0, null, Item);
            UnrealSharp.ControlRig.RigUnit_HierarchyAddControl_ShapeSettingsMarshaler.ToNative(IntPtr.Add(Buffer, Settings_Offset), 0, null, Settings);
        }
    }
}

public static class RigUnit_HierarchySetShapeSettingsMarshaler
{
    public static RigUnit_HierarchySetShapeSettings FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_HierarchySetShapeSettings(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_HierarchySetShapeSettings obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_HierarchySetShapeSettings.NativeDataSize;
    }
}