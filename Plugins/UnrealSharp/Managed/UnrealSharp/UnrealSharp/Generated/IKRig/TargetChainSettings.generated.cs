using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.IKRig;

[UStruct]
public partial struct TargetChainSettings
{
    // StructProperty /Script/IKRig.TargetChainSettings:FK
    static readonly int FK_Offset;
    public UnrealSharp.IKRig.TargetChainFKSettings FK;
    
    // StructProperty /Script/IKRig.TargetChainSettings:IK
    static readonly int IK_Offset;
    public UnrealSharp.IKRig.TargetChainIKSettings IK;
    
    // StructProperty /Script/IKRig.TargetChainSettings:SpeedPlanting
    static readonly int SpeedPlanting_Offset;
    public UnrealSharp.IKRig.TargetChainSpeedPlantSettings SpeedPlanting;
    
    
    public static readonly int NativeDataSize;
    static TargetChainSettings()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("TargetChainSettings");
        
        FK_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FK");
        IK_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "IK");
        SpeedPlanting_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SpeedPlanting");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public TargetChainSettings(IntPtr InNativeStruct)
    {
        unsafe
        {
            FK = UnrealSharp.IKRig.TargetChainFKSettingsMarshaler.FromNative(IntPtr.Add(InNativeStruct, FK_Offset), 0, null);
            IK = UnrealSharp.IKRig.TargetChainIKSettingsMarshaler.FromNative(IntPtr.Add(InNativeStruct, IK_Offset), 0, null);
            SpeedPlanting = UnrealSharp.IKRig.TargetChainSpeedPlantSettingsMarshaler.FromNative(IntPtr.Add(InNativeStruct, SpeedPlanting_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.IKRig.TargetChainFKSettingsMarshaler.ToNative(IntPtr.Add(Buffer, FK_Offset), 0, null, FK);
            UnrealSharp.IKRig.TargetChainIKSettingsMarshaler.ToNative(IntPtr.Add(Buffer, IK_Offset), 0, null, IK);
            UnrealSharp.IKRig.TargetChainSpeedPlantSettingsMarshaler.ToNative(IntPtr.Add(Buffer, SpeedPlanting_Offset), 0, null, SpeedPlanting);
        }
    }
}

public static class TargetChainSettingsMarshaler
{
    public static TargetChainSettings FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new TargetChainSettings(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, TargetChainSettings obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return TargetChainSettings.NativeDataSize;
    }
}