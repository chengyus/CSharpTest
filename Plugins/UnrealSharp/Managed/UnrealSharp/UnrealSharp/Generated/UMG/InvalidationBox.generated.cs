// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.UMG;

[UClass]
public partial class InvalidationBox : UnrealSharp.UMG.ContentWidget
{
    
    static InvalidationBox()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("InvalidationBox");
        
        bCanCache_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bCanCache");
        
        SetCanCache_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetCanCache");
        SetCanCache_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetCanCache_NativeFunction);
        SetCanCache_CanCache_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetCanCache_NativeFunction, "CanCache");
        InvalidateCache_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "InvalidateCache");
        GetCanCache_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetCanCache");
        GetCanCache_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetCanCache_NativeFunction);
        GetCanCache_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetCanCache_NativeFunction, "ReturnValue");
        
        
    }
    
    protected InvalidationBox(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // BoolProperty /Script/UMG.InvalidationBox:bCanCache
    static readonly int bCanCache_Offset;
    
    public bool bCanCache
    {
        get
        {
            CheckObjectForValidity();
            return BoolMarshaller.FromNative(IntPtr.Add(NativeObject, bCanCache_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BoolMarshaller.ToNative(IntPtr.Add(NativeObject, bCanCache_Offset), 0, this, value);
        }
    }
    
    // Function /Script/UMG.InvalidationBox:SetCanCache
    static readonly IntPtr SetCanCache_NativeFunction;
    static readonly int SetCanCache_ParamsSize;
    static readonly int SetCanCache_CanCache_Offset;
    
    public void SetCanCache(bool canCache)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetCanCache_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BoolMarshaller.ToNative(IntPtr.Add(ParamsBuffer, SetCanCache_CanCache_Offset), 0, null, canCache);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetCanCache_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/UMG.InvalidationBox:InvalidateCache
    static readonly IntPtr InvalidateCache_NativeFunction;
    
    [Obsolete("This function is obsolete")]
    public void InvalidateCache()
    {
        unsafe
        {
            UObjectExporter.CallInvokeNativeFunction(NativeObject, InvalidateCache_NativeFunction, IntPtr.Zero);
        }
    }
    
    // Function /Script/UMG.InvalidationBox:GetCanCache
    static readonly IntPtr GetCanCache_NativeFunction;
    static readonly int GetCanCache_ParamsSize;
    static readonly int GetCanCache_ReturnValue_Offset;
    
    public bool GetCanCache()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetCanCache_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetCanCache_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, GetCanCache_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    
}