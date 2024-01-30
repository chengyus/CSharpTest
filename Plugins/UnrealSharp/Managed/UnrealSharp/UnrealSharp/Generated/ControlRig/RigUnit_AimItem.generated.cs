using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_AimItem
{
    // StructProperty /Script/ControlRig.RigUnit_AimItem:Item
    static readonly int Item_Offset;
    public UnrealSharp.ControlRig.RigElementKey Item;
    
    // StructProperty /Script/ControlRig.RigUnit_AimItem:Primary
    static readonly int Primary_Offset;
    public UnrealSharp.ControlRig.RigUnit_AimItem_Target Primary;
    
    // StructProperty /Script/ControlRig.RigUnit_AimItem:Secondary
    static readonly int Secondary_Offset;
    public UnrealSharp.ControlRig.RigUnit_AimItem_Target Secondary;
    
    // FloatProperty /Script/ControlRig.RigUnit_AimItem:Weight
    static readonly int Weight_Offset;
    public float Weight;
    
    // StructProperty /Script/ControlRig.RigUnit_AimItem:DebugSettings
    static readonly int DebugSettings_Offset;
    public UnrealSharp.ControlRig.RigUnit_AimBone_DebugSettings DebugSettings;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_AimItem()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_AimItem");
        
        Item_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Item");
        Primary_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Primary");
        Secondary_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Secondary");
        Weight_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Weight");
        DebugSettings_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DebugSettings");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_AimItem(IntPtr InNativeStruct)
    {
        unsafe
        {
            Item = UnrealSharp.ControlRig.RigElementKeyMarshaler.FromNative(IntPtr.Add(InNativeStruct, Item_Offset), 0, null);
            Primary = UnrealSharp.ControlRig.RigUnit_AimItem_TargetMarshaler.FromNative(IntPtr.Add(InNativeStruct, Primary_Offset), 0, null);
            Secondary = UnrealSharp.ControlRig.RigUnit_AimItem_TargetMarshaler.FromNative(IntPtr.Add(InNativeStruct, Secondary_Offset), 0, null);
            Weight = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Weight_Offset), 0, null);
            DebugSettings = UnrealSharp.ControlRig.RigUnit_AimBone_DebugSettingsMarshaler.FromNative(IntPtr.Add(InNativeStruct, DebugSettings_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.ControlRig.RigElementKeyMarshaler.ToNative(IntPtr.Add(Buffer, Item_Offset), 0, null, Item);
            UnrealSharp.ControlRig.RigUnit_AimItem_TargetMarshaler.ToNative(IntPtr.Add(Buffer, Primary_Offset), 0, null, Primary);
            UnrealSharp.ControlRig.RigUnit_AimItem_TargetMarshaler.ToNative(IntPtr.Add(Buffer, Secondary_Offset), 0, null, Secondary);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Weight_Offset), 0, null, Weight);
            UnrealSharp.ControlRig.RigUnit_AimBone_DebugSettingsMarshaler.ToNative(IntPtr.Add(Buffer, DebugSettings_Offset), 0, null, DebugSettings);
        }
    }
}

public static class RigUnit_AimItemMarshaler
{
    public static RigUnit_AimItem FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_AimItem(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_AimItem obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_AimItem.NativeDataSize;
    }
}