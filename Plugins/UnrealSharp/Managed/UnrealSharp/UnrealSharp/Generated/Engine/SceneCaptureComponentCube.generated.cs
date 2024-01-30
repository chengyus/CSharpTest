// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UClass]
public partial class SceneCaptureComponentCube : UnrealSharp.Engine.SceneCaptureComponent
{
    
    static SceneCaptureComponentCube()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("SceneCaptureComponentCube");
        
        TextureTarget_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "TextureTarget");
        bCaptureRotation_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bCaptureRotation");
        
        CaptureScene_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "CaptureScene");
        
        
    }
    
    protected SceneCaptureComponentCube(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // ObjectProperty /Script/Engine.SceneCaptureComponentCube:TextureTarget
    static readonly int TextureTarget_Offset;
    
    public UnrealSharp.Engine.TextureRenderTargetCube TextureTarget
    {
        get
        {
            CheckObjectForValidity();
            return ObjectMarshaller<UnrealSharp.Engine.TextureRenderTargetCube>.FromNative(IntPtr.Add(NativeObject, TextureTarget_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            ObjectMarshaller<UnrealSharp.Engine.TextureRenderTargetCube>.ToNative(IntPtr.Add(NativeObject, TextureTarget_Offset), 0, this, value);
        }
    }
    
    // BoolProperty /Script/Engine.SceneCaptureComponentCube:bCaptureRotation
    static readonly int bCaptureRotation_Offset;
    
    public bool bCaptureRotation
    {
        get
        {
            CheckObjectForValidity();
            return BoolMarshaller.FromNative(IntPtr.Add(NativeObject, bCaptureRotation_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BoolMarshaller.ToNative(IntPtr.Add(NativeObject, bCaptureRotation_Offset), 0, this, value);
        }
    }
    
    // Function /Script/Engine.SceneCaptureComponentCube:CaptureScene
    static readonly IntPtr CaptureScene_NativeFunction;
    
    public void CaptureScene()
    {
        unsafe
        {
            UObjectExporter.CallInvokeNativeFunction(NativeObject, CaptureScene_NativeFunction, IntPtr.Zero);
        }
    }
    
    
}