// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.TemplateSequence;

[UClass]
public partial class SequenceCameraShakeTestUtil : UnrealSharp.Engine.BlueprintFunctionLibrary
{
    
    static readonly IntPtr NativeClassPtr;
    static SequenceCameraShakeTestUtil()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("SequenceCameraShakeTestUtil");
        
        
        GetPostProcessBlendCache_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetPostProcessBlendCache");
        GetPostProcessBlendCache_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetPostProcessBlendCache_NativeFunction);
        GetPostProcessBlendCache_PlayerController_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetPostProcessBlendCache_NativeFunction, "PlayerController");
        GetPostProcessBlendCache_PPIndex_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetPostProcessBlendCache_NativeFunction, "PPIndex");
        GetPostProcessBlendCache_OutPPSettings_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetPostProcessBlendCache_NativeFunction, "OutPPSettings");
        GetPostProcessBlendCache_OutPPBlendWeight_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetPostProcessBlendCache_NativeFunction, "OutPPBlendWeight");
        GetPostProcessBlendCache_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetPostProcessBlendCache_NativeFunction, "ReturnValue");
        GetLastFrameCameraCachePOV_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetLastFrameCameraCachePOV");
        GetLastFrameCameraCachePOV_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetLastFrameCameraCachePOV_NativeFunction);
        GetLastFrameCameraCachePOV_PlayerController_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetLastFrameCameraCachePOV_NativeFunction, "PlayerController");
        GetLastFrameCameraCachePOV_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetLastFrameCameraCachePOV_NativeFunction, "ReturnValue");
        GetCameraCachePOV_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetCameraCachePOV");
        GetCameraCachePOV_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetCameraCachePOV_NativeFunction);
        GetCameraCachePOV_PlayerController_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetCameraCachePOV_NativeFunction, "PlayerController");
        GetCameraCachePOV_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetCameraCachePOV_NativeFunction, "ReturnValue");
        
        
    }
    
    protected SequenceCameraShakeTestUtil(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // Function /Script/TemplateSequence.SequenceCameraShakeTestUtil:GetPostProcessBlendCache
    static readonly IntPtr GetPostProcessBlendCache_NativeFunction;
    static readonly int GetPostProcessBlendCache_ParamsSize;
    static readonly int GetPostProcessBlendCache_PlayerController_Offset;
    static readonly int GetPostProcessBlendCache_PPIndex_Offset;
    static readonly int GetPostProcessBlendCache_OutPPSettings_Offset;
    static readonly int GetPostProcessBlendCache_OutPPBlendWeight_Offset;
    static readonly int GetPostProcessBlendCache_ReturnValue_Offset;
    
    public static bool GetPostProcessBlendCache(UnrealSharp.Engine.PlayerController playerController, int pPIndex, out UnrealSharp.Engine.PostProcessSettings outPPSettings, out float outPPBlendWeight)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetPostProcessBlendCache_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.Engine.PlayerController>.ToNative(IntPtr.Add(ParamsBuffer, GetPostProcessBlendCache_PlayerController_Offset), 0, null, playerController);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(ParamsBuffer, GetPostProcessBlendCache_PPIndex_Offset), 0, null, pPIndex);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, GetPostProcessBlendCache_NativeFunction, ParamsBuffer);
            
            outPPSettings = UnrealSharp.Engine.PostProcessSettingsMarshaler.FromNative(IntPtr.Add(ParamsBuffer, GetPostProcessBlendCache_OutPPSettings_Offset), 0, null);
            outPPBlendWeight = BlittableMarshaller<float>.FromNative(IntPtr.Add(ParamsBuffer, GetPostProcessBlendCache_OutPPBlendWeight_Offset), 0, null);
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, GetPostProcessBlendCache_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/TemplateSequence.SequenceCameraShakeTestUtil:GetLastFrameCameraCachePOV
    static readonly IntPtr GetLastFrameCameraCachePOV_NativeFunction;
    static readonly int GetLastFrameCameraCachePOV_ParamsSize;
    static readonly int GetLastFrameCameraCachePOV_PlayerController_Offset;
    static readonly int GetLastFrameCameraCachePOV_ReturnValue_Offset;
    
    public static UnrealSharp.Engine.MinimalViewInfo GetLastFrameCameraCachePOV(UnrealSharp.Engine.PlayerController playerController)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetLastFrameCameraCachePOV_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.Engine.PlayerController>.ToNative(IntPtr.Add(ParamsBuffer, GetLastFrameCameraCachePOV_PlayerController_Offset), 0, null, playerController);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, GetLastFrameCameraCachePOV_NativeFunction, ParamsBuffer);
            
            UnrealSharp.Engine.MinimalViewInfo returnValue;
            returnValue = UnrealSharp.Engine.MinimalViewInfoMarshaler.FromNative(IntPtr.Add(ParamsBuffer, GetLastFrameCameraCachePOV_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/TemplateSequence.SequenceCameraShakeTestUtil:GetCameraCachePOV
    static readonly IntPtr GetCameraCachePOV_NativeFunction;
    static readonly int GetCameraCachePOV_ParamsSize;
    static readonly int GetCameraCachePOV_PlayerController_Offset;
    static readonly int GetCameraCachePOV_ReturnValue_Offset;
    
    public static UnrealSharp.Engine.MinimalViewInfo GetCameraCachePOV(UnrealSharp.Engine.PlayerController playerController)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetCameraCachePOV_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.Engine.PlayerController>.ToNative(IntPtr.Add(ParamsBuffer, GetCameraCachePOV_PlayerController_Offset), 0, null, playerController);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, GetCameraCachePOV_NativeFunction, ParamsBuffer);
            
            UnrealSharp.Engine.MinimalViewInfo returnValue;
            returnValue = UnrealSharp.Engine.MinimalViewInfoMarshaler.FromNative(IntPtr.Add(ParamsBuffer, GetCameraCachePOV_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    
}