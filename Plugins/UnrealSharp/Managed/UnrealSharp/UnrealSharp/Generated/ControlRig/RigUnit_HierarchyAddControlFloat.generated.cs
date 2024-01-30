using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_HierarchyAddControlFloat
{
    // FloatProperty /Script/ControlRig.RigUnit_HierarchyAddControlFloat:InitialValue
    static readonly int InitialValue_Offset;
    public float InitialValue;
    
    // StructProperty /Script/ControlRig.RigUnit_HierarchyAddControlFloat:Settings
    static readonly int Settings_Offset;
    public UnrealSharp.ControlRig.RigUnit_HierarchyAddControlFloat_Settings Settings;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_HierarchyAddControlFloat()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_HierarchyAddControlFloat");
        
        InitialValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "InitialValue");
        Settings_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Settings");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_HierarchyAddControlFloat(IntPtr InNativeStruct)
    {
        unsafe
        {
            InitialValue = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, InitialValue_Offset), 0, null);
            Settings = UnrealSharp.ControlRig.RigUnit_HierarchyAddControlFloat_SettingsMarshaler.FromNative(IntPtr.Add(InNativeStruct, Settings_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, InitialValue_Offset), 0, null, InitialValue);
            UnrealSharp.ControlRig.RigUnit_HierarchyAddControlFloat_SettingsMarshaler.ToNative(IntPtr.Add(Buffer, Settings_Offset), 0, null, Settings);
        }
    }
}

public static class RigUnit_HierarchyAddControlFloatMarshaler
{
    public static RigUnit_HierarchyAddControlFloat FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_HierarchyAddControlFloat(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_HierarchyAddControlFloat obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_HierarchyAddControlFloat.NativeDataSize;
    }
}