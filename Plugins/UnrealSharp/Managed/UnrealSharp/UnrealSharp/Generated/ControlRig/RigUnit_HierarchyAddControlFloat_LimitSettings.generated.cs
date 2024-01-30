using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_HierarchyAddControlFloat_LimitSettings
{
    // StructProperty /Script/ControlRig.RigUnit_HierarchyAddControlFloat_LimitSettings:Limit
    static readonly int Limit_Offset;
    public UnrealSharp.ControlRig.RigControlLimitEnabled Limit;
    
    // FloatProperty /Script/ControlRig.RigUnit_HierarchyAddControlFloat_LimitSettings:MinValue
    static readonly int MinValue_Offset;
    public float MinValue;
    
    // FloatProperty /Script/ControlRig.RigUnit_HierarchyAddControlFloat_LimitSettings:MaxValue
    static readonly int MaxValue_Offset;
    public float MaxValue;
    
    // BoolProperty /Script/ControlRig.RigUnit_HierarchyAddControlFloat_LimitSettings:bDrawLimits
    static readonly int bDrawLimits_Offset;
    public bool DrawLimits;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_HierarchyAddControlFloat_LimitSettings()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_HierarchyAddControlFloat_LimitSettings");
        
        Limit_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Limit");
        MinValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MinValue");
        MaxValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MaxValue");
        bDrawLimits_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bDrawLimits");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_HierarchyAddControlFloat_LimitSettings(IntPtr InNativeStruct)
    {
        unsafe
        {
            Limit = UnrealSharp.ControlRig.RigControlLimitEnabledMarshaler.FromNative(IntPtr.Add(InNativeStruct, Limit_Offset), 0, null);
            MinValue = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, MinValue_Offset), 0, null);
            MaxValue = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, MaxValue_Offset), 0, null);
            DrawLimits = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bDrawLimits_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.ControlRig.RigControlLimitEnabledMarshaler.ToNative(IntPtr.Add(Buffer, Limit_Offset), 0, null, Limit);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, MinValue_Offset), 0, null, MinValue);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, MaxValue_Offset), 0, null, MaxValue);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bDrawLimits_Offset), 0, null, DrawLimits);
        }
    }
}

public static class RigUnit_HierarchyAddControlFloat_LimitSettingsMarshaler
{
    public static RigUnit_HierarchyAddControlFloat_LimitSettings FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_HierarchyAddControlFloat_LimitSettings(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_HierarchyAddControlFloat_LimitSettings obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_HierarchyAddControlFloat_LimitSettings.NativeDataSize;
    }
}