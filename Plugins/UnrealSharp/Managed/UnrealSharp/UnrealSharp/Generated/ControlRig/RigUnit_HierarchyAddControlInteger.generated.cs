using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_HierarchyAddControlInteger
{
    // IntProperty /Script/ControlRig.RigUnit_HierarchyAddControlInteger:InitialValue
    static readonly int InitialValue_Offset;
    public int InitialValue;
    
    // StructProperty /Script/ControlRig.RigUnit_HierarchyAddControlInteger:Settings
    static readonly int Settings_Offset;
    public UnrealSharp.ControlRig.RigUnit_HierarchyAddControlInteger_Settings Settings;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_HierarchyAddControlInteger()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_HierarchyAddControlInteger");
        
        InitialValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "InitialValue");
        Settings_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Settings");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_HierarchyAddControlInteger(IntPtr InNativeStruct)
    {
        unsafe
        {
            InitialValue = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, InitialValue_Offset), 0, null);
            Settings = UnrealSharp.ControlRig.RigUnit_HierarchyAddControlInteger_SettingsMarshaler.FromNative(IntPtr.Add(InNativeStruct, Settings_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, InitialValue_Offset), 0, null, InitialValue);
            UnrealSharp.ControlRig.RigUnit_HierarchyAddControlInteger_SettingsMarshaler.ToNative(IntPtr.Add(Buffer, Settings_Offset), 0, null, Settings);
        }
    }
}

public static class RigUnit_HierarchyAddControlIntegerMarshaler
{
    public static RigUnit_HierarchyAddControlInteger FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_HierarchyAddControlInteger(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_HierarchyAddControlInteger obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_HierarchyAddControlInteger.NativeDataSize;
    }
}