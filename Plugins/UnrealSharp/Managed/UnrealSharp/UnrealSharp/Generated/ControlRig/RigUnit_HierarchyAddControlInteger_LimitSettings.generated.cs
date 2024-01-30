using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_HierarchyAddControlInteger_LimitSettings
{
    // StructProperty /Script/ControlRig.RigUnit_HierarchyAddControlInteger_LimitSettings:Limit
    static readonly int Limit_Offset;
    public UnrealSharp.ControlRig.RigControlLimitEnabled Limit;
    
    // IntProperty /Script/ControlRig.RigUnit_HierarchyAddControlInteger_LimitSettings:MinValue
    static readonly int MinValue_Offset;
    public int MinValue;
    
    // IntProperty /Script/ControlRig.RigUnit_HierarchyAddControlInteger_LimitSettings:MaxValue
    static readonly int MaxValue_Offset;
    public int MaxValue;
    
    // BoolProperty /Script/ControlRig.RigUnit_HierarchyAddControlInteger_LimitSettings:bDrawLimits
    static readonly int bDrawLimits_Offset;
    public bool DrawLimits;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_HierarchyAddControlInteger_LimitSettings()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_HierarchyAddControlInteger_LimitSettings");
        
        Limit_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Limit");
        MinValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MinValue");
        MaxValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MaxValue");
        bDrawLimits_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bDrawLimits");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_HierarchyAddControlInteger_LimitSettings(IntPtr InNativeStruct)
    {
        unsafe
        {
            Limit = UnrealSharp.ControlRig.RigControlLimitEnabledMarshaler.FromNative(IntPtr.Add(InNativeStruct, Limit_Offset), 0, null);
            MinValue = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, MinValue_Offset), 0, null);
            MaxValue = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, MaxValue_Offset), 0, null);
            DrawLimits = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bDrawLimits_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.ControlRig.RigControlLimitEnabledMarshaler.ToNative(IntPtr.Add(Buffer, Limit_Offset), 0, null, Limit);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, MinValue_Offset), 0, null, MinValue);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, MaxValue_Offset), 0, null, MaxValue);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bDrawLimits_Offset), 0, null, DrawLimits);
        }
    }
}

public static class RigUnit_HierarchyAddControlInteger_LimitSettingsMarshaler
{
    public static RigUnit_HierarchyAddControlInteger_LimitSettings FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_HierarchyAddControlInteger_LimitSettings(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_HierarchyAddControlInteger_LimitSettings obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_HierarchyAddControlInteger_LimitSettings.NativeDataSize;
    }
}