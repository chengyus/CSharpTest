// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.MovieSceneTracks;

[UClass]
public partial class MovieSceneCinematicShotSection : UnrealSharp.MovieScene.MovieSceneSubSection
{
    
    static MovieSceneCinematicShotSection()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("MovieSceneCinematicShotSection");
        
        
        SetShotDisplayName_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetShotDisplayName");
        SetShotDisplayName_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetShotDisplayName_NativeFunction);
        SetShotDisplayName_InShotDisplayName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetShotDisplayName_NativeFunction, "InShotDisplayName");
        GetShotDisplayName_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetShotDisplayName");
        GetShotDisplayName_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetShotDisplayName_NativeFunction);
        GetShotDisplayName_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetShotDisplayName_NativeFunction, "ReturnValue");
        
        
    }
    
    protected MovieSceneCinematicShotSection(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // Function /Script/MovieSceneTracks.MovieSceneCinematicShotSection:SetShotDisplayName
    static readonly IntPtr SetShotDisplayName_NativeFunction;
    static readonly int SetShotDisplayName_ParamsSize;
    static readonly int SetShotDisplayName_InShotDisplayName_Offset;
    
    public void SetShotDisplayName(string inShotDisplayName)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetShotDisplayName_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            IntPtr InShotDisplayName_NativePtr = IntPtr.Add(ParamsBuffer,SetShotDisplayName_InShotDisplayName_Offset);
            StringMarshaller.ToNative(InShotDisplayName_NativePtr,0,null,inShotDisplayName);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetShotDisplayName_NativeFunction, ParamsBuffer);
            
            StringMarshaller.DestructInstance(InShotDisplayName_NativePtr, 0);
        }
    }
    
    // Function /Script/MovieSceneTracks.MovieSceneCinematicShotSection:GetShotDisplayName
    static readonly IntPtr GetShotDisplayName_NativeFunction;
    static readonly int GetShotDisplayName_ParamsSize;
    static readonly int GetShotDisplayName_ReturnValue_Offset;
    
    public string GetShotDisplayName()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetShotDisplayName_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetShotDisplayName_NativeFunction, ParamsBuffer);
            
            string returnValue;
            IntPtr ReturnValue_NativePtr = IntPtr.Add(ParamsBuffer,GetShotDisplayName_ReturnValue_Offset);
            returnValue = StringMarshaller.FromNative(ReturnValue_NativePtr,0,null);
            StringMarshaller.DestructInstance(ReturnValue_NativePtr, 0);
            
            return returnValue;
        }
    }
    
    
}