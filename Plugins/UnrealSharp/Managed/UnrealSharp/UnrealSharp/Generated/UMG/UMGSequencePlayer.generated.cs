// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.UMG;

[UClass]
public partial class UMGSequencePlayer : UnrealSharp.CoreUObject.Object
{
    
    static UMGSequencePlayer()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("UMGSequencePlayer");
        
        
        SetUserTag_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetUserTag");
        SetUserTag_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetUserTag_NativeFunction);
        SetUserTag_InUserTag_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetUserTag_NativeFunction, "InUserTag");
        GetUserTag_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetUserTag");
        GetUserTag_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetUserTag_NativeFunction);
        GetUserTag_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetUserTag_NativeFunction, "ReturnValue");
        
        
    }
    
    protected UMGSequencePlayer(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // Function /Script/UMG.UMGSequencePlayer:SetUserTag
    static readonly IntPtr SetUserTag_NativeFunction;
    static readonly int SetUserTag_ParamsSize;
    static readonly int SetUserTag_InUserTag_Offset;
    
    public void SetUserTag(Name inUserTag)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetUserTag_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(ParamsBuffer, SetUserTag_InUserTag_Offset), 0, null, inUserTag);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetUserTag_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/UMG.UMGSequencePlayer:GetUserTag
    static readonly IntPtr GetUserTag_NativeFunction;
    static readonly int GetUserTag_ParamsSize;
    static readonly int GetUserTag_ReturnValue_Offset;
    
    public Name GetUserTag()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetUserTag_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetUserTag_NativeFunction, ParamsBuffer);
            
            Name returnValue;
            returnValue = BlittableMarshaller<Name>.FromNative(IntPtr.Add(ParamsBuffer, GetUserTag_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    
}