using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.DataValidation;

[UStruct]
public partial struct ValidateAssetsSettings
{
    // BoolProperty /Script/DataValidation.ValidateAssetsSettings:bSkipExcludedDirectories
    static readonly int bSkipExcludedDirectories_Offset;
    public bool SkipExcludedDirectories;
    
    // BoolProperty /Script/DataValidation.ValidateAssetsSettings:bShowIfNoFailures
    static readonly int bShowIfNoFailures_Offset;
    public bool ShowIfNoFailures;
    
    // BoolProperty /Script/DataValidation.ValidateAssetsSettings:bCollectPerAssetDetails
    static readonly int bCollectPerAssetDetails_Offset;
    public bool CollectPerAssetDetails;
    
    // EnumProperty /Script/DataValidation.ValidateAssetsSettings:ValidationUsecase
    static readonly int ValidationUsecase_Offset;
    public UnrealSharp.DataValidation.EDataValidationUsecase ValidationUsecase;
    
    
    public static readonly int NativeDataSize;
    static ValidateAssetsSettings()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("ValidateAssetsSettings");
        
        bSkipExcludedDirectories_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bSkipExcludedDirectories");
        bShowIfNoFailures_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bShowIfNoFailures");
        bCollectPerAssetDetails_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bCollectPerAssetDetails");
        ValidationUsecase_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ValidationUsecase");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public ValidateAssetsSettings(IntPtr InNativeStruct)
    {
        unsafe
        {
            SkipExcludedDirectories = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bSkipExcludedDirectories_Offset), 0, null);
            ShowIfNoFailures = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bShowIfNoFailures_Offset), 0, null);
            CollectPerAssetDetails = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bCollectPerAssetDetails_Offset), 0, null);
            ValidationUsecase = BlittableMarshaller<UnrealSharp.DataValidation.EDataValidationUsecase>.FromNative(IntPtr.Add(InNativeStruct, ValidationUsecase_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bSkipExcludedDirectories_Offset), 0, null, SkipExcludedDirectories);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bShowIfNoFailures_Offset), 0, null, ShowIfNoFailures);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bCollectPerAssetDetails_Offset), 0, null, CollectPerAssetDetails);
            BlittableMarshaller<UnrealSharp.DataValidation.EDataValidationUsecase>.ToNative(IntPtr.Add(Buffer, ValidationUsecase_Offset), 0, null, ValidationUsecase);
        }
    }
}

public static class ValidateAssetsSettingsMarshaler
{
    public static ValidateAssetsSettings FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new ValidateAssetsSettings(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, ValidateAssetsSettings obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return ValidateAssetsSettings.NativeDataSize;
    }
}