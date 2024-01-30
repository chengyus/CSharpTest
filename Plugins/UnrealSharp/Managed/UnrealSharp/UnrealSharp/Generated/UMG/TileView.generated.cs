// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.UMG;

[UClass]
public partial class TileView : UnrealSharp.UMG.ListView
{
    
    static TileView()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("TileView");
        
        
        SetEntryWidth_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetEntryWidth");
        SetEntryWidth_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetEntryWidth_NativeFunction);
        SetEntryWidth_NewWidth_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetEntryWidth_NativeFunction, "NewWidth");
        SetEntryHeight_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetEntryHeight");
        SetEntryHeight_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetEntryHeight_NativeFunction);
        SetEntryHeight_NewHeight_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetEntryHeight_NativeFunction, "NewHeight");
        GetEntryWidth_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetEntryWidth");
        GetEntryWidth_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetEntryWidth_NativeFunction);
        GetEntryWidth_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetEntryWidth_NativeFunction, "ReturnValue");
        GetEntryHeight_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetEntryHeight");
        GetEntryHeight_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetEntryHeight_NativeFunction);
        GetEntryHeight_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetEntryHeight_NativeFunction, "ReturnValue");
        
        
    }
    
    protected TileView(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // Function /Script/UMG.TileView:SetEntryWidth
    static readonly IntPtr SetEntryWidth_NativeFunction;
    static readonly int SetEntryWidth_ParamsSize;
    static readonly int SetEntryWidth_NewWidth_Offset;
    
    public void SetEntryWidth(float newWidth)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetEntryWidth_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<float>.ToNative(IntPtr.Add(ParamsBuffer, SetEntryWidth_NewWidth_Offset), 0, null, newWidth);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetEntryWidth_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/UMG.TileView:SetEntryHeight
    static readonly IntPtr SetEntryHeight_NativeFunction;
    static readonly int SetEntryHeight_ParamsSize;
    static readonly int SetEntryHeight_NewHeight_Offset;
    
    public void SetEntryHeight(float newHeight)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetEntryHeight_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<float>.ToNative(IntPtr.Add(ParamsBuffer, SetEntryHeight_NewHeight_Offset), 0, null, newHeight);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetEntryHeight_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/UMG.TileView:GetEntryWidth
    static readonly IntPtr GetEntryWidth_NativeFunction;
    static readonly int GetEntryWidth_ParamsSize;
    static readonly int GetEntryWidth_ReturnValue_Offset;
    
    public float GetEntryWidth()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetEntryWidth_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetEntryWidth_NativeFunction, ParamsBuffer);
            
            float returnValue;
            returnValue = BlittableMarshaller<float>.FromNative(IntPtr.Add(ParamsBuffer, GetEntryWidth_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/UMG.TileView:GetEntryHeight
    static readonly IntPtr GetEntryHeight_NativeFunction;
    static readonly int GetEntryHeight_ParamsSize;
    static readonly int GetEntryHeight_ReturnValue_Offset;
    
    public float GetEntryHeight()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetEntryHeight_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetEntryHeight_NativeFunction, ParamsBuffer);
            
            float returnValue;
            returnValue = BlittableMarshaller<float>.FromNative(IntPtr.Add(ParamsBuffer, GetEntryHeight_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    
}