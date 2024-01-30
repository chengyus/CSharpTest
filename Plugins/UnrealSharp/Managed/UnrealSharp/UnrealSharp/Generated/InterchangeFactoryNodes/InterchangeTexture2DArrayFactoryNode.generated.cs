// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.InterchangeFactoryNodes;

[UClass]
public partial class InterchangeTexture2DArrayFactoryNode : UnrealSharp.InterchangeFactoryNodes.InterchangeTextureFactoryNode
{
    
    static InterchangeTexture2DArrayFactoryNode()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("InterchangeTexture2DArrayFactoryNode");
        
        
        SetCustomAddressZ_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetCustomAddressZ");
        SetCustomAddressZ_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetCustomAddressZ_NativeFunction);
        SetCustomAddressZ_AttributeValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetCustomAddressZ_NativeFunction, "AttributeValue");
        SetCustomAddressZ_bAddApplyDelegate_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetCustomAddressZ_NativeFunction, "bAddApplyDelegate");
        SetCustomAddressZ_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetCustomAddressZ_NativeFunction, "ReturnValue");
        GetCustomAddressZ_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetCustomAddressZ");
        GetCustomAddressZ_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetCustomAddressZ_NativeFunction);
        GetCustomAddressZ_AttributeValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetCustomAddressZ_NativeFunction, "AttributeValue");
        GetCustomAddressZ_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetCustomAddressZ_NativeFunction, "ReturnValue");
        GetCustomAddressY_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetCustomAddressY");
        GetCustomAddressY_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetCustomAddressY_NativeFunction);
        GetCustomAddressY_AttributeValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetCustomAddressY_NativeFunction, "AttributeValue");
        GetCustomAddressY_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetCustomAddressY_NativeFunction, "ReturnValue");
        GetCustomAddressX_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetCustomAddressX");
        GetCustomAddressX_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetCustomAddressX_NativeFunction);
        GetCustomAddressX_AttributeValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetCustomAddressX_NativeFunction, "AttributeValue");
        GetCustomAddressX_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetCustomAddressX_NativeFunction, "ReturnValue");
        
        
    }
    
    protected InterchangeTexture2DArrayFactoryNode(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // Function /Script/InterchangeFactoryNodes.InterchangeTexture2DArrayFactoryNode:SetCustomAddressZ
    static readonly IntPtr SetCustomAddressZ_NativeFunction;
    static readonly int SetCustomAddressZ_ParamsSize;
    static readonly int SetCustomAddressZ_AttributeValue_Offset;
    static readonly int SetCustomAddressZ_bAddApplyDelegate_Offset;
    static readonly int SetCustomAddressZ_ReturnValue_Offset;
    
    public bool SetCustomAddressZ(byte attributeValue, bool bAddApplyDelegate = true)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetCustomAddressZ_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<byte>.ToNative(IntPtr.Add(ParamsBuffer, SetCustomAddressZ_AttributeValue_Offset), 0, null, attributeValue);
            BoolMarshaller.ToNative(IntPtr.Add(ParamsBuffer, SetCustomAddressZ_bAddApplyDelegate_Offset), 0, null, bAddApplyDelegate);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetCustomAddressZ_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, SetCustomAddressZ_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/InterchangeFactoryNodes.InterchangeTexture2DArrayFactoryNode:GetCustomAddressZ
    static readonly IntPtr GetCustomAddressZ_NativeFunction;
    static readonly int GetCustomAddressZ_ParamsSize;
    static readonly int GetCustomAddressZ_AttributeValue_Offset;
    static readonly int GetCustomAddressZ_ReturnValue_Offset;
    
    public bool GetCustomAddressZ(out byte attributeValue)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetCustomAddressZ_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetCustomAddressZ_NativeFunction, ParamsBuffer);
            
            attributeValue = BlittableMarshaller<byte>.FromNative(IntPtr.Add(ParamsBuffer, GetCustomAddressZ_AttributeValue_Offset), 0, null);
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, GetCustomAddressZ_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/InterchangeFactoryNodes.InterchangeTexture2DArrayFactoryNode:GetCustomAddressY
    static readonly IntPtr GetCustomAddressY_NativeFunction;
    static readonly int GetCustomAddressY_ParamsSize;
    static readonly int GetCustomAddressY_AttributeValue_Offset;
    static readonly int GetCustomAddressY_ReturnValue_Offset;
    
    public bool GetCustomAddressY(out byte attributeValue)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetCustomAddressY_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetCustomAddressY_NativeFunction, ParamsBuffer);
            
            attributeValue = BlittableMarshaller<byte>.FromNative(IntPtr.Add(ParamsBuffer, GetCustomAddressY_AttributeValue_Offset), 0, null);
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, GetCustomAddressY_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/InterchangeFactoryNodes.InterchangeTexture2DArrayFactoryNode:GetCustomAddressX
    static readonly IntPtr GetCustomAddressX_NativeFunction;
    static readonly int GetCustomAddressX_ParamsSize;
    static readonly int GetCustomAddressX_AttributeValue_Offset;
    static readonly int GetCustomAddressX_ReturnValue_Offset;
    
    public bool GetCustomAddressX(out byte attributeValue)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetCustomAddressX_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetCustomAddressX_NativeFunction, ParamsBuffer);
            
            attributeValue = BlittableMarshaller<byte>.FromNative(IntPtr.Add(ParamsBuffer, GetCustomAddressX_AttributeValue_Offset), 0, null);
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, GetCustomAddressX_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    
}