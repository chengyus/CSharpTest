// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.FieldSystemEngine;

[UClass]
public partial class FieldSystemMetaDataProcessingResolution : UnrealSharp.FieldSystemEngine.FieldSystemMetaData
{
    
    static FieldSystemMetaDataProcessingResolution()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("FieldSystemMetaDataProcessingResolution");
        
        ResolutionType_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ResolutionType");
        
        SetMetaDataaProcessingResolutionType_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetMetaDataaProcessingResolutionType");
        SetMetaDataaProcessingResolutionType_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetMetaDataaProcessingResolutionType_NativeFunction);
        SetMetaDataaProcessingResolutionType_ResolutionType_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetMetaDataaProcessingResolutionType_NativeFunction, "ResolutionType");
        SetMetaDataaProcessingResolutionType_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetMetaDataaProcessingResolutionType_NativeFunction, "ReturnValue");
        
        
    }
    
    protected FieldSystemMetaDataProcessingResolution(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // ByteProperty /Script/FieldSystemEngine.FieldSystemMetaDataProcessingResolution:ResolutionType
    static readonly int ResolutionType_Offset;
    
    public UnrealSharp.Chaos.EFieldResolutionType ResolutionType
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<UnrealSharp.Chaos.EFieldResolutionType>.FromNative(IntPtr.Add(NativeObject, ResolutionType_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<UnrealSharp.Chaos.EFieldResolutionType>.ToNative(IntPtr.Add(NativeObject, ResolutionType_Offset), 0, this, value);
        }
    }
    
    // Function /Script/FieldSystemEngine.FieldSystemMetaDataProcessingResolution:SetMetaDataaProcessingResolutionType
    static readonly IntPtr SetMetaDataaProcessingResolutionType_NativeFunction;
    static readonly int SetMetaDataaProcessingResolutionType_ParamsSize;
    static readonly int SetMetaDataaProcessingResolutionType_ResolutionType_Offset;
    static readonly int SetMetaDataaProcessingResolutionType_ReturnValue_Offset;
    
    public UnrealSharp.FieldSystemEngine.FieldSystemMetaDataProcessingResolution SetMetaDataaProcessingResolutionType(UnrealSharp.Chaos.EFieldResolutionType resolutionType)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetMetaDataaProcessingResolutionType_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<UnrealSharp.Chaos.EFieldResolutionType>.ToNative(IntPtr.Add(ParamsBuffer, SetMetaDataaProcessingResolutionType_ResolutionType_Offset), 0, null, resolutionType);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetMetaDataaProcessingResolutionType_NativeFunction, ParamsBuffer);
            
            UnrealSharp.FieldSystemEngine.FieldSystemMetaDataProcessingResolution returnValue;
            returnValue = ObjectMarshaller<UnrealSharp.FieldSystemEngine.FieldSystemMetaDataProcessingResolution>.FromNative(IntPtr.Add(ParamsBuffer, SetMetaDataaProcessingResolutionType_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    
}