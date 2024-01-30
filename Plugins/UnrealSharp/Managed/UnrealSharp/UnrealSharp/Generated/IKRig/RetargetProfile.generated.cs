using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.IKRig;

[UStruct]
public partial struct RetargetProfile
{
    // BoolProperty /Script/IKRig.RetargetProfile:bApplyTargetRetargetPose
    static readonly int bApplyTargetRetargetPose_Offset;
    public bool ApplyTargetRetargetPose;
    
    // NameProperty /Script/IKRig.RetargetProfile:TargetRetargetPoseName
    static readonly int TargetRetargetPoseName_Offset;
    public Name TargetRetargetPoseName;
    
    // BoolProperty /Script/IKRig.RetargetProfile:bApplySourceRetargetPose
    static readonly int bApplySourceRetargetPose_Offset;
    public bool ApplySourceRetargetPose;
    
    // NameProperty /Script/IKRig.RetargetProfile:SourceRetargetPoseName
    static readonly int SourceRetargetPoseName_Offset;
    public Name SourceRetargetPoseName;
    
    // BoolProperty /Script/IKRig.RetargetProfile:bApplyChainSettings
    static readonly int bApplyChainSettings_Offset;
    public bool ApplyChainSettings;
    
    // BoolProperty /Script/IKRig.RetargetProfile:bApplyRootSettings
    static readonly int bApplyRootSettings_Offset;
    public bool ApplyRootSettings;
    
    // StructProperty /Script/IKRig.RetargetProfile:RootSettings
    static readonly int RootSettings_Offset;
    public UnrealSharp.IKRig.TargetRootSettings RootSettings;
    
    // BoolProperty /Script/IKRig.RetargetProfile:bApplyGlobalSettings
    static readonly int bApplyGlobalSettings_Offset;
    public bool ApplyGlobalSettings;
    
    // StructProperty /Script/IKRig.RetargetProfile:GlobalSettings
    static readonly int GlobalSettings_Offset;
    public UnrealSharp.IKRig.RetargetGlobalSettings GlobalSettings;
    
    
    public static readonly int NativeDataSize;
    static RetargetProfile()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RetargetProfile");
        
        bApplyTargetRetargetPose_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bApplyTargetRetargetPose");
        TargetRetargetPoseName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "TargetRetargetPoseName");
        bApplySourceRetargetPose_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bApplySourceRetargetPose");
        SourceRetargetPoseName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SourceRetargetPoseName");
        bApplyChainSettings_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bApplyChainSettings");
        bApplyRootSettings_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bApplyRootSettings");
        RootSettings_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "RootSettings");
        bApplyGlobalSettings_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bApplyGlobalSettings");
        GlobalSettings_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "GlobalSettings");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RetargetProfile(IntPtr InNativeStruct)
    {
        unsafe
        {
            ApplyTargetRetargetPose = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bApplyTargetRetargetPose_Offset), 0, null);
            TargetRetargetPoseName = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, TargetRetargetPoseName_Offset), 0, null);
            ApplySourceRetargetPose = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bApplySourceRetargetPose_Offset), 0, null);
            SourceRetargetPoseName = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, SourceRetargetPoseName_Offset), 0, null);
            ApplyChainSettings = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bApplyChainSettings_Offset), 0, null);
            ApplyRootSettings = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bApplyRootSettings_Offset), 0, null);
            RootSettings = UnrealSharp.IKRig.TargetRootSettingsMarshaler.FromNative(IntPtr.Add(InNativeStruct, RootSettings_Offset), 0, null);
            ApplyGlobalSettings = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bApplyGlobalSettings_Offset), 0, null);
            GlobalSettings = UnrealSharp.IKRig.RetargetGlobalSettingsMarshaler.FromNative(IntPtr.Add(InNativeStruct, GlobalSettings_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bApplyTargetRetargetPose_Offset), 0, null, ApplyTargetRetargetPose);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, TargetRetargetPoseName_Offset), 0, null, TargetRetargetPoseName);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bApplySourceRetargetPose_Offset), 0, null, ApplySourceRetargetPose);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, SourceRetargetPoseName_Offset), 0, null, SourceRetargetPoseName);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bApplyChainSettings_Offset), 0, null, ApplyChainSettings);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bApplyRootSettings_Offset), 0, null, ApplyRootSettings);
            UnrealSharp.IKRig.TargetRootSettingsMarshaler.ToNative(IntPtr.Add(Buffer, RootSettings_Offset), 0, null, RootSettings);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bApplyGlobalSettings_Offset), 0, null, ApplyGlobalSettings);
            UnrealSharp.IKRig.RetargetGlobalSettingsMarshaler.ToNative(IntPtr.Add(Buffer, GlobalSettings_Offset), 0, null, GlobalSettings);
        }
    }
}

public static class RetargetProfileMarshaler
{
    public static RetargetProfile FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RetargetProfile(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RetargetProfile obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RetargetProfile.NativeDataSize;
    }
}