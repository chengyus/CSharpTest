using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.DataValidation;

[UStruct]
public partial struct ValidateAssetsResults
{
    // IntProperty /Script/DataValidation.ValidateAssetsResults:NumChecked
    static readonly int NumChecked_Offset;
    public int NumChecked;
    
    // IntProperty /Script/DataValidation.ValidateAssetsResults:NumValid
    static readonly int NumValid_Offset;
    public int NumValid;
    
    // IntProperty /Script/DataValidation.ValidateAssetsResults:NumInvalid
    static readonly int NumInvalid_Offset;
    public int NumInvalid;
    
    // IntProperty /Script/DataValidation.ValidateAssetsResults:NumSkipped
    static readonly int NumSkipped_Offset;
    public int NumSkipped;
    
    // IntProperty /Script/DataValidation.ValidateAssetsResults:NumWarnings
    static readonly int NumWarnings_Offset;
    public int NumWarnings;
    
    // IntProperty /Script/DataValidation.ValidateAssetsResults:NumUnableToValidate
    static readonly int NumUnableToValidate_Offset;
    public int NumUnableToValidate;
    
    
    public static readonly int NativeDataSize;
    static ValidateAssetsResults()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("ValidateAssetsResults");
        
        NumChecked_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "NumChecked");
        NumValid_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "NumValid");
        NumInvalid_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "NumInvalid");
        NumSkipped_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "NumSkipped");
        NumWarnings_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "NumWarnings");
        NumUnableToValidate_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "NumUnableToValidate");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public ValidateAssetsResults(IntPtr InNativeStruct)
    {
        unsafe
        {
            NumChecked = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, NumChecked_Offset), 0, null);
            NumValid = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, NumValid_Offset), 0, null);
            NumInvalid = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, NumInvalid_Offset), 0, null);
            NumSkipped = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, NumSkipped_Offset), 0, null);
            NumWarnings = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, NumWarnings_Offset), 0, null);
            NumUnableToValidate = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, NumUnableToValidate_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, NumChecked_Offset), 0, null, NumChecked);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, NumValid_Offset), 0, null, NumValid);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, NumInvalid_Offset), 0, null, NumInvalid);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, NumSkipped_Offset), 0, null, NumSkipped);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, NumWarnings_Offset), 0, null, NumWarnings);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, NumUnableToValidate_Offset), 0, null, NumUnableToValidate);
        }
    }
}

public static class ValidateAssetsResultsMarshaler
{
    public static ValidateAssetsResults FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new ValidateAssetsResults(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, ValidateAssetsResults obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return ValidateAssetsResults.NativeDataSize;
    }
}