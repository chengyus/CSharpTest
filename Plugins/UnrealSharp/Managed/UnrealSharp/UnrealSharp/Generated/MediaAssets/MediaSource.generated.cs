// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.MediaAssets;

[UClass]
abstract public partial class MediaSource : UnrealSharp.CoreUObject.Object
{
    
    static MediaSource()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("MediaSource");
        
        
        Validate_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "Validate");
        Validate_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(Validate_NativeFunction);
        Validate_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(Validate_NativeFunction, "ReturnValue");
        SetMediaOptionString_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetMediaOptionString");
        SetMediaOptionString_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetMediaOptionString_NativeFunction);
        SetMediaOptionString_Key_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetMediaOptionString_NativeFunction, "Key");
        SetMediaOptionString_Value_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetMediaOptionString_NativeFunction, "Value");
        SetMediaOptionInt64_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetMediaOptionInt64");
        SetMediaOptionInt64_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetMediaOptionInt64_NativeFunction);
        SetMediaOptionInt64_Key_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetMediaOptionInt64_NativeFunction, "Key");
        SetMediaOptionInt64_Value_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetMediaOptionInt64_NativeFunction, "Value");
        SetMediaOptionFloat_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetMediaOptionFloat");
        SetMediaOptionFloat_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetMediaOptionFloat_NativeFunction);
        SetMediaOptionFloat_Key_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetMediaOptionFloat_NativeFunction, "Key");
        SetMediaOptionFloat_Value_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetMediaOptionFloat_NativeFunction, "Value");
        SetMediaOptionBool_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetMediaOptionBool");
        SetMediaOptionBool_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetMediaOptionBool_NativeFunction);
        SetMediaOptionBool_Key_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetMediaOptionBool_NativeFunction, "Key");
        SetMediaOptionBool_Value_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetMediaOptionBool_NativeFunction, "Value");
        GetUrl_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetUrl");
        GetUrl_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetUrl_NativeFunction);
        GetUrl_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetUrl_NativeFunction, "ReturnValue");
        
        
    }
    
    protected MediaSource(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // Function /Script/MediaAssets.MediaSource:Validate
    static readonly IntPtr Validate_NativeFunction;
    static readonly int Validate_ParamsSize;
    static readonly int Validate_ReturnValue_Offset;
    
    public bool Validate()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[Validate_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, Validate_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, Validate_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/MediaAssets.MediaSource:SetMediaOptionString
    static readonly IntPtr SetMediaOptionString_NativeFunction;
    static readonly int SetMediaOptionString_ParamsSize;
    static readonly int SetMediaOptionString_Key_Offset;
    static readonly int SetMediaOptionString_Value_Offset;
    
    public void SetMediaOptionString(Name key, string value)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetMediaOptionString_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(ParamsBuffer, SetMediaOptionString_Key_Offset), 0, null, key);
            IntPtr Value_NativePtr = IntPtr.Add(ParamsBuffer,SetMediaOptionString_Value_Offset);
            StringMarshaller.ToNative(Value_NativePtr,0,null,value);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetMediaOptionString_NativeFunction, ParamsBuffer);
            
            
            StringMarshaller.DestructInstance(Value_NativePtr, 0);
        }
    }
    
    // Function /Script/MediaAssets.MediaSource:SetMediaOptionInt64
    static readonly IntPtr SetMediaOptionInt64_NativeFunction;
    static readonly int SetMediaOptionInt64_ParamsSize;
    static readonly int SetMediaOptionInt64_Key_Offset;
    static readonly int SetMediaOptionInt64_Value_Offset;
    
    public void SetMediaOptionInt64(Name key, long value)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetMediaOptionInt64_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(ParamsBuffer, SetMediaOptionInt64_Key_Offset), 0, null, key);
            BlittableMarshaller<long>.ToNative(IntPtr.Add(ParamsBuffer, SetMediaOptionInt64_Value_Offset), 0, null, value);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetMediaOptionInt64_NativeFunction, ParamsBuffer);
            
            
        }
    }
    
    // Function /Script/MediaAssets.MediaSource:SetMediaOptionFloat
    static readonly IntPtr SetMediaOptionFloat_NativeFunction;
    static readonly int SetMediaOptionFloat_ParamsSize;
    static readonly int SetMediaOptionFloat_Key_Offset;
    static readonly int SetMediaOptionFloat_Value_Offset;
    
    public void SetMediaOptionFloat(Name key, float value)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetMediaOptionFloat_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(ParamsBuffer, SetMediaOptionFloat_Key_Offset), 0, null, key);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(ParamsBuffer, SetMediaOptionFloat_Value_Offset), 0, null, value);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetMediaOptionFloat_NativeFunction, ParamsBuffer);
            
            
        }
    }
    
    // Function /Script/MediaAssets.MediaSource:SetMediaOptionBool
    static readonly IntPtr SetMediaOptionBool_NativeFunction;
    static readonly int SetMediaOptionBool_ParamsSize;
    static readonly int SetMediaOptionBool_Key_Offset;
    static readonly int SetMediaOptionBool_Value_Offset;
    
    public void SetMediaOptionBool(Name key, bool value)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetMediaOptionBool_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(ParamsBuffer, SetMediaOptionBool_Key_Offset), 0, null, key);
            BoolMarshaller.ToNative(IntPtr.Add(ParamsBuffer, SetMediaOptionBool_Value_Offset), 0, null, value);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetMediaOptionBool_NativeFunction, ParamsBuffer);
            
            
        }
    }
    
    // Function /Script/MediaAssets.MediaSource:GetUrl
    static readonly IntPtr GetUrl_NativeFunction;
    static readonly int GetUrl_ParamsSize;
    static readonly int GetUrl_ReturnValue_Offset;
    
    public string GetUrl()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetUrl_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetUrl_NativeFunction, ParamsBuffer);
            
            string returnValue;
            IntPtr ReturnValue_NativePtr = IntPtr.Add(ParamsBuffer,GetUrl_ReturnValue_Offset);
            returnValue = StringMarshaller.FromNative(ReturnValue_NativePtr,0,null);
            StringMarshaller.DestructInstance(ReturnValue_NativePtr, 0);
            
            return returnValue;
        }
    }
    
    
}