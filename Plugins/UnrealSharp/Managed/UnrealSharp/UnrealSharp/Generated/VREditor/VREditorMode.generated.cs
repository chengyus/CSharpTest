// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.VREditor;

[UClass]
abstract public partial class VREditorMode : UnrealSharp.VREditor.VREditorModeBase
{
    
    static VREditorMode()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("VREditorMode");
        
        
        SetGameView_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetGameView");
        SetGameView_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetGameView_NativeFunction);
        SetGameView_bGameView_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetGameView_NativeFunction, "bGameView");
        IsInGameView_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "IsInGameView");
        IsInGameView_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(IsInGameView_NativeFunction);
        IsInGameView_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(IsInGameView_NativeFunction, "ReturnValue");
        GetWorldScaleFactor_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetWorldScaleFactor");
        GetWorldScaleFactor_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetWorldScaleFactor_NativeFunction);
        GetWorldScaleFactor_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetWorldScaleFactor_NativeFunction, "ReturnValue");
        
        
    }
    
    protected VREditorMode(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // Function /Script/VREditor.VREditorMode:SetGameView
    static readonly IntPtr SetGameView_NativeFunction;
    static readonly int SetGameView_ParamsSize;
    static readonly int SetGameView_bGameView_Offset;
    
    public void SetGameView(bool bGameView)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetGameView_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BoolMarshaller.ToNative(IntPtr.Add(ParamsBuffer, SetGameView_bGameView_Offset), 0, null, bGameView);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetGameView_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/VREditor.VREditorMode:IsInGameView
    static readonly IntPtr IsInGameView_NativeFunction;
    static readonly int IsInGameView_ParamsSize;
    static readonly int IsInGameView_ReturnValue_Offset;
    
    public bool IsInGameView()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[IsInGameView_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, IsInGameView_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, IsInGameView_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/VREditor.VREditorMode:GetWorldScaleFactor
    static readonly IntPtr GetWorldScaleFactor_NativeFunction;
    static readonly int GetWorldScaleFactor_ParamsSize;
    static readonly int GetWorldScaleFactor_ReturnValue_Offset;
    
    public float GetWorldScaleFactor()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetWorldScaleFactor_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetWorldScaleFactor_NativeFunction, ParamsBuffer);
            
            float returnValue;
            returnValue = BlittableMarshaller<float>.FromNative(IntPtr.Add(ParamsBuffer, GetWorldScaleFactor_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    
}