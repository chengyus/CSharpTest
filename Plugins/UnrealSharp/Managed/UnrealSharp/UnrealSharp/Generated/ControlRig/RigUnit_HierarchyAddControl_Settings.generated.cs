using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_HierarchyAddControl_Settings
{
    // NameProperty /Script/ControlRig.RigUnit_HierarchyAddControl_Settings:DisplayName
    static readonly int DisplayName_Offset;
    public Name DisplayName;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_HierarchyAddControl_Settings()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_HierarchyAddControl_Settings");
        
        DisplayName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DisplayName");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_HierarchyAddControl_Settings(IntPtr InNativeStruct)
    {
        unsafe
        {
            DisplayName = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, DisplayName_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, DisplayName_Offset), 0, null, DisplayName);
        }
    }
}

public static class RigUnit_HierarchyAddControl_SettingsMarshaler
{
    public static RigUnit_HierarchyAddControl_Settings FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_HierarchyAddControl_Settings(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_HierarchyAddControl_Settings obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_HierarchyAddControl_Settings.NativeDataSize;
    }
}