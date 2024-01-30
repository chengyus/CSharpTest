using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVMDeveloper;

[UStruct]
public partial struct RigVMCompileSettings
{
    // BoolProperty /Script/RigVMDeveloper.RigVMCompileSettings:SurpressInfoMessages
    static readonly int SurpressInfoMessages_Offset;
    public bool SurpressInfoMessages;
    
    // BoolProperty /Script/RigVMDeveloper.RigVMCompileSettings:SurpressWarnings
    static readonly int SurpressWarnings_Offset;
    public bool SurpressWarnings;
    
    // BoolProperty /Script/RigVMDeveloper.RigVMCompileSettings:SurpressErrors
    static readonly int SurpressErrors_Offset;
    public bool SurpressErrors;
    
    // BoolProperty /Script/RigVMDeveloper.RigVMCompileSettings:EnablePinWatches
    static readonly int EnablePinWatches_Offset;
    public bool EnablePinWatches;
    
    // StructProperty /Script/RigVMDeveloper.RigVMCompileSettings:ASTSettings
    static readonly int ASTSettings_Offset;
    public UnrealSharp.RigVMDeveloper.RigVMParserASTSettings ASTSettings;
    
    
    public static readonly int NativeDataSize;
    static RigVMCompileSettings()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMCompileSettings");
        
        SurpressInfoMessages_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SurpressInfoMessages");
        SurpressWarnings_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SurpressWarnings");
        SurpressErrors_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SurpressErrors");
        EnablePinWatches_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "EnablePinWatches");
        ASTSettings_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ASTSettings");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMCompileSettings(IntPtr InNativeStruct)
    {
        unsafe
        {
            SurpressInfoMessages = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, SurpressInfoMessages_Offset), 0, null);
            SurpressWarnings = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, SurpressWarnings_Offset), 0, null);
            SurpressErrors = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, SurpressErrors_Offset), 0, null);
            EnablePinWatches = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, EnablePinWatches_Offset), 0, null);
            ASTSettings = UnrealSharp.RigVMDeveloper.RigVMParserASTSettingsMarshaler.FromNative(IntPtr.Add(InNativeStruct, ASTSettings_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, SurpressInfoMessages_Offset), 0, null, SurpressInfoMessages);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, SurpressWarnings_Offset), 0, null, SurpressWarnings);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, SurpressErrors_Offset), 0, null, SurpressErrors);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, EnablePinWatches_Offset), 0, null, EnablePinWatches);
            UnrealSharp.RigVMDeveloper.RigVMParserASTSettingsMarshaler.ToNative(IntPtr.Add(Buffer, ASTSettings_Offset), 0, null, ASTSettings);
        }
    }
}

public static class RigVMCompileSettingsMarshaler
{
    public static RigVMCompileSettings FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMCompileSettings(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMCompileSettings obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMCompileSettings.NativeDataSize;
    }
}