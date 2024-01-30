using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_HierarchyAddControlVector2D_LimitSettings
{
    // StructProperty /Script/ControlRig.RigUnit_HierarchyAddControlVector2D_LimitSettings:LimitX
    static readonly int LimitX_Offset;
    public UnrealSharp.ControlRig.RigControlLimitEnabled LimitX;
    
    // StructProperty /Script/ControlRig.RigUnit_HierarchyAddControlVector2D_LimitSettings:LimitY
    static readonly int LimitY_Offset;
    public UnrealSharp.ControlRig.RigControlLimitEnabled LimitY;
    
    // StructProperty /Script/ControlRig.RigUnit_HierarchyAddControlVector2D_LimitSettings:MinValue
    static readonly int MinValue_Offset;
    public System.DoubleNumerics.Vector2 MinValue;
    
    // StructProperty /Script/ControlRig.RigUnit_HierarchyAddControlVector2D_LimitSettings:MaxValue
    static readonly int MaxValue_Offset;
    public System.DoubleNumerics.Vector2 MaxValue;
    
    // BoolProperty /Script/ControlRig.RigUnit_HierarchyAddControlVector2D_LimitSettings:bDrawLimits
    static readonly int bDrawLimits_Offset;
    public bool DrawLimits;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_HierarchyAddControlVector2D_LimitSettings()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_HierarchyAddControlVector2D_LimitSettings");
        
        LimitX_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LimitX");
        LimitY_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LimitY");
        MinValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MinValue");
        MaxValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MaxValue");
        bDrawLimits_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bDrawLimits");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_HierarchyAddControlVector2D_LimitSettings(IntPtr InNativeStruct)
    {
        unsafe
        {
            LimitX = UnrealSharp.ControlRig.RigControlLimitEnabledMarshaler.FromNative(IntPtr.Add(InNativeStruct, LimitX_Offset), 0, null);
            LimitY = UnrealSharp.ControlRig.RigControlLimitEnabledMarshaler.FromNative(IntPtr.Add(InNativeStruct, LimitY_Offset), 0, null);
            MinValue = BlittableMarshaller<System.DoubleNumerics.Vector2>.FromNative(IntPtr.Add(InNativeStruct, MinValue_Offset), 0, null);
            MaxValue = BlittableMarshaller<System.DoubleNumerics.Vector2>.FromNative(IntPtr.Add(InNativeStruct, MaxValue_Offset), 0, null);
            DrawLimits = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bDrawLimits_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.ControlRig.RigControlLimitEnabledMarshaler.ToNative(IntPtr.Add(Buffer, LimitX_Offset), 0, null, LimitX);
            UnrealSharp.ControlRig.RigControlLimitEnabledMarshaler.ToNative(IntPtr.Add(Buffer, LimitY_Offset), 0, null, LimitY);
            BlittableMarshaller<System.DoubleNumerics.Vector2>.ToNative(IntPtr.Add(Buffer, MinValue_Offset), 0, null, MinValue);
            BlittableMarshaller<System.DoubleNumerics.Vector2>.ToNative(IntPtr.Add(Buffer, MaxValue_Offset), 0, null, MaxValue);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bDrawLimits_Offset), 0, null, DrawLimits);
        }
    }
}

public static class RigUnit_HierarchyAddControlVector2D_LimitSettingsMarshaler
{
    public static RigUnit_HierarchyAddControlVector2D_LimitSettings FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_HierarchyAddControlVector2D_LimitSettings(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_HierarchyAddControlVector2D_LimitSettings obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_HierarchyAddControlVector2D_LimitSettings.NativeDataSize;
    }
}