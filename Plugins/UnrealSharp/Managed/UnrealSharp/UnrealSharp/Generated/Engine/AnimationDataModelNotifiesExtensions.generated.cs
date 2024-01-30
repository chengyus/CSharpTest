// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UClass]
public partial class AnimationDataModelNotifiesExtensions : UnrealSharp.Engine.BlueprintFunctionLibrary
{
    
    static readonly IntPtr NativeClassPtr;
    static AnimationDataModelNotifiesExtensions()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("AnimationDataModelNotifiesExtensions");
        
        
        GetPayload_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetPayload");
        GetPayload_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetPayload_NativeFunction);
        GetPayload_Payload_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetPayload_NativeFunction, "Payload");
        GetPayload_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetPayload_NativeFunction, "ReturnValue");
        CopyPayload_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "CopyPayload");
        CopyPayload_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(CopyPayload_NativeFunction);
        CopyPayload_Payload_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(CopyPayload_NativeFunction, "Payload");
        CopyPayload_ExpectedStruct_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(CopyPayload_NativeFunction, "ExpectedStruct");
        CopyPayload_OutPayload_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(CopyPayload_NativeFunction, "OutPayload");
        
        
    }
    
    protected AnimationDataModelNotifiesExtensions(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // Function /Script/Engine.AnimationDataModelNotifiesExtensions:GetPayload
    static readonly IntPtr GetPayload_NativeFunction;
    static readonly int GetPayload_ParamsSize;
    static readonly int GetPayload_Payload_Offset;
    static readonly int GetPayload_ReturnValue_Offset;
    
    public static UnrealSharp.Engine.EmptyPayload GetPayload(UnrealSharp.Engine.AnimDataModelNotifPayload payload)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetPayload_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            UnrealSharp.Engine.AnimDataModelNotifPayloadMarshaler.ToNative(IntPtr.Add(ParamsBuffer, GetPayload_Payload_Offset), 0, null, payload);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, GetPayload_NativeFunction, ParamsBuffer);
            
            UnrealSharp.Engine.EmptyPayload returnValue;
            returnValue = UnrealSharp.Engine.EmptyPayloadMarshaler.FromNative(IntPtr.Add(ParamsBuffer, GetPayload_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/Engine.AnimationDataModelNotifiesExtensions:CopyPayload
    static readonly IntPtr CopyPayload_NativeFunction;
    static readonly int CopyPayload_ParamsSize;
    static readonly int CopyPayload_Payload_Offset;
    static readonly int CopyPayload_ExpectedStruct_Offset;
    static readonly int CopyPayload_OutPayload_Offset;
    
    public static void CopyPayload(UnrealSharp.Engine.AnimDataModelNotifPayload payload, UnrealSharp.CoreUObject.ScriptStruct expectedStruct, ref UnrealSharp.Engine.EmptyPayload outPayload)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[CopyPayload_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            UnrealSharp.Engine.AnimDataModelNotifPayloadMarshaler.ToNative(IntPtr.Add(ParamsBuffer, CopyPayload_Payload_Offset), 0, null, payload);
            ObjectMarshaller<UnrealSharp.CoreUObject.ScriptStruct>.ToNative(IntPtr.Add(ParamsBuffer, CopyPayload_ExpectedStruct_Offset), 0, null, expectedStruct);
            UnrealSharp.Engine.EmptyPayloadMarshaler.ToNative(IntPtr.Add(ParamsBuffer, CopyPayload_OutPayload_Offset), 0, null, outPayload);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, CopyPayload_NativeFunction, ParamsBuffer);
            
            outPayload = UnrealSharp.Engine.EmptyPayloadMarshaler.FromNative(IntPtr.Add(ParamsBuffer, CopyPayload_OutPayload_Offset), 0, null);
            
        }
    }
    
    
}