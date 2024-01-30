using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_HierarchyAddControlVector
{
    // StructProperty /Script/ControlRig.RigUnit_HierarchyAddControlVector:InitialValue
    static readonly int InitialValue_Offset;
    public System.DoubleNumerics.Vector3 InitialValue;
    
    // StructProperty /Script/ControlRig.RigUnit_HierarchyAddControlVector:Settings
    static readonly int Settings_Offset;
    public UnrealSharp.ControlRig.RigUnit_HierarchyAddControlVector_Settings Settings;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_HierarchyAddControlVector()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_HierarchyAddControlVector");
        
        InitialValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "InitialValue");
        Settings_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Settings");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_HierarchyAddControlVector(IntPtr InNativeStruct)
    {
        unsafe
        {
            InitialValue = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, InitialValue_Offset), 0, null);
            Settings = UnrealSharp.ControlRig.RigUnit_HierarchyAddControlVector_SettingsMarshaler.FromNative(IntPtr.Add(InNativeStruct, Settings_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, InitialValue_Offset), 0, null, InitialValue);
            UnrealSharp.ControlRig.RigUnit_HierarchyAddControlVector_SettingsMarshaler.ToNative(IntPtr.Add(Buffer, Settings_Offset), 0, null, Settings);
        }
    }
}

public static class RigUnit_HierarchyAddControlVectorMarshaler
{
    public static RigUnit_HierarchyAddControlVector FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_HierarchyAddControlVector(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_HierarchyAddControlVector obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_HierarchyAddControlVector.NativeDataSize;
    }
}