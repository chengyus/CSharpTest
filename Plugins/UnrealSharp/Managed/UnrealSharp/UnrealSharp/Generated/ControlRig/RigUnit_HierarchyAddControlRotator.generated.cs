using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_HierarchyAddControlRotator
{
    // StructProperty /Script/ControlRig.RigUnit_HierarchyAddControlRotator:InitialValue
    static readonly int InitialValue_Offset;
    public UnrealSharp.Rotator InitialValue;
    
    // StructProperty /Script/ControlRig.RigUnit_HierarchyAddControlRotator:Settings
    static readonly int Settings_Offset;
    public UnrealSharp.ControlRig.RigUnit_HierarchyAddControlRotator_Settings Settings;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_HierarchyAddControlRotator()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_HierarchyAddControlRotator");
        
        InitialValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "InitialValue");
        Settings_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Settings");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_HierarchyAddControlRotator(IntPtr InNativeStruct)
    {
        unsafe
        {
            InitialValue = BlittableMarshaller<UnrealSharp.Rotator>.FromNative(IntPtr.Add(InNativeStruct, InitialValue_Offset), 0, null);
            Settings = UnrealSharp.ControlRig.RigUnit_HierarchyAddControlRotator_SettingsMarshaler.FromNative(IntPtr.Add(InNativeStruct, Settings_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.Rotator>.ToNative(IntPtr.Add(Buffer, InitialValue_Offset), 0, null, InitialValue);
            UnrealSharp.ControlRig.RigUnit_HierarchyAddControlRotator_SettingsMarshaler.ToNative(IntPtr.Add(Buffer, Settings_Offset), 0, null, Settings);
        }
    }
}

public static class RigUnit_HierarchyAddControlRotatorMarshaler
{
    public static RigUnit_HierarchyAddControlRotator FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_HierarchyAddControlRotator(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_HierarchyAddControlRotator obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_HierarchyAddControlRotator.NativeDataSize;
    }
}