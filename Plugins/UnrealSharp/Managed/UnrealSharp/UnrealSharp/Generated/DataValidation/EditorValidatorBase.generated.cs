// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.DataValidation;

[UClass]
abstract public partial class EditorValidatorBase : UnrealSharp.CoreUObject.Object
{
    
    static EditorValidatorBase()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("EditorValidatorBase");
        
        
        GetValidationResult_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetValidationResult");
        GetValidationResult_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetValidationResult_NativeFunction);
        GetValidationResult_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetValidationResult_NativeFunction, "ReturnValue");
        AssetPasses_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "AssetPasses");
        AssetPasses_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(AssetPasses_NativeFunction);
        AssetPasses_InAsset_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AssetPasses_NativeFunction, "InAsset");
        
        IntPtr CanValidateAsset_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "CanValidateAsset");
        CanValidateAsset_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(CanValidateAsset_NativeFunction);
        CanValidateAsset_InAsset_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(CanValidateAsset_NativeFunction, "InAsset");
        CanValidateAsset_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(CanValidateAsset_NativeFunction, "ReturnValue");
        
        IntPtr CanValidate_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "CanValidate");
        CanValidate_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(CanValidate_NativeFunction);
        CanValidate_InUsecase_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(CanValidate_NativeFunction, "InUsecase");
        CanValidate_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(CanValidate_NativeFunction, "ReturnValue");
        
        
    }
    
    protected EditorValidatorBase(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // Function /Script/DataValidation.EditorValidatorBase:GetValidationResult
    static readonly IntPtr GetValidationResult_NativeFunction;
    static readonly int GetValidationResult_ParamsSize;
    static readonly int GetValidationResult_ReturnValue_Offset;
    
    public UnrealSharp.CoreUObject.EDataValidationResult GetValidationResult()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetValidationResult_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetValidationResult_NativeFunction, ParamsBuffer);
            
            UnrealSharp.CoreUObject.EDataValidationResult returnValue;
            returnValue = BlittableMarshaller<UnrealSharp.CoreUObject.EDataValidationResult>.FromNative(IntPtr.Add(ParamsBuffer, GetValidationResult_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/DataValidation.EditorValidatorBase:AssetPasses
    static readonly IntPtr AssetPasses_NativeFunction;
    static readonly int AssetPasses_ParamsSize;
    static readonly int AssetPasses_InAsset_Offset;
    
    public void AssetPasses(UnrealSharp.CoreUObject.Object inAsset)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[AssetPasses_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.CoreUObject.Object>.ToNative(IntPtr.Add(ParamsBuffer, AssetPasses_InAsset_Offset), 0, null, inAsset);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, AssetPasses_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/DataValidation.EditorValidatorBase:CanValidateAsset
    IntPtr CanValidateAsset_NativeFunction;
    static readonly int CanValidateAsset_ParamsSize;
    static readonly int CanValidateAsset_InAsset_Offset;
    static readonly int CanValidateAsset_ReturnValue_Offset;
    
    [UFunction(FunctionFlags.BlueprintEvent)]
    public virtual bool CanValidateAsset(UnrealSharp.CoreUObject.Object inAsset)
    {
        unsafe
        {
            if (CanValidateAsset_NativeFunction == IntPtr.Zero)
            {
                CanValidateAsset_NativeFunction = UClassExporter.CallGetNativeFunctionFromInstanceAndName(NativeObject, "CanValidateAsset");
            }
            byte* ParamsBufferAllocation = stackalloc byte[CanValidateAsset_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.CoreUObject.Object>.ToNative(IntPtr.Add(ParamsBuffer, CanValidateAsset_InAsset_Offset), 0, null, inAsset);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, CanValidateAsset_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, CanValidateAsset_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    //Hide implementation function from Intellisense/ReSharper
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    protected virtual bool CanValidateAsset_Implementation(UnrealSharp.CoreUObject.Object inAsset)
    {
        return default(bool);
    }
    void Invoke_CanValidateAsset(IntPtr buffer, IntPtr returnBuffer)
    {
        unsafe
        {
            UnrealSharp.CoreUObject.Object inAsset = ObjectMarshaller<UnrealSharp.CoreUObject.Object>.FromNative(IntPtr.Add(buffer, CanValidateAsset_InAsset_Offset), 0, null);
            bool returnValue = CanValidateAsset_Implementation(inAsset);
            BoolMarshaller.ToNative(IntPtr.Add(returnBuffer, 0), 0, null, returnValue);
        }
    }
    
    // Function /Script/DataValidation.EditorValidatorBase:CanValidate
    IntPtr CanValidate_NativeFunction;
    static readonly int CanValidate_ParamsSize;
    static readonly int CanValidate_InUsecase_Offset;
    static readonly int CanValidate_ReturnValue_Offset;
    
    [UFunction(FunctionFlags.BlueprintEvent)]
    public virtual bool CanValidate(UnrealSharp.DataValidation.EDataValidationUsecase inUsecase)
    {
        unsafe
        {
            if (CanValidate_NativeFunction == IntPtr.Zero)
            {
                CanValidate_NativeFunction = UClassExporter.CallGetNativeFunctionFromInstanceAndName(NativeObject, "CanValidate");
            }
            byte* ParamsBufferAllocation = stackalloc byte[CanValidate_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<UnrealSharp.DataValidation.EDataValidationUsecase>.ToNative(IntPtr.Add(ParamsBuffer, CanValidate_InUsecase_Offset), 0, null, inUsecase);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, CanValidate_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, CanValidate_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    //Hide implementation function from Intellisense/ReSharper
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    protected virtual bool CanValidate_Implementation(UnrealSharp.DataValidation.EDataValidationUsecase inUsecase)
    {
        return default(bool);
    }
    void Invoke_CanValidate(IntPtr buffer, IntPtr returnBuffer)
    {
        unsafe
        {
            UnrealSharp.DataValidation.EDataValidationUsecase inUsecase = BlittableMarshaller<UnrealSharp.DataValidation.EDataValidationUsecase>.FromNative(IntPtr.Add(buffer, CanValidate_InUsecase_Offset), 0, null);
            bool returnValue = CanValidate_Implementation(inUsecase);
            BoolMarshaller.ToNative(IntPtr.Add(returnBuffer, 0), 0, null, returnValue);
        }
    }
    
    
}