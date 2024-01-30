// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ImgMedia;

[UClass]
public partial class ImgMediaSource : UnrealSharp.MediaAssets.BaseMediaSource
{
    
    static ImgMediaSource()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("ImgMediaSource");
        
        FrameRateOverride_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FrameRateOverride");
        ProxyOverride_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ProxyOverride");
        ProxyOverride_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "ProxyOverride");
        bFillGapsInSequence_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bFillGapsInSequence");
        SequencePath_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SequencePath");
        
        SetTokenizedSequencePath_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetTokenizedSequencePath");
        SetTokenizedSequencePath_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetTokenizedSequencePath_NativeFunction);
        SetTokenizedSequencePath_Path_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetTokenizedSequencePath_NativeFunction, "Path");
        SetSequencePath_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetSequencePath");
        SetSequencePath_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetSequencePath_NativeFunction);
        SetSequencePath_Path_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetSequencePath_NativeFunction, "Path");
        SetMipLevelDistance_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetMipLevelDistance");
        SetMipLevelDistance_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetMipLevelDistance_NativeFunction);
        SetMipLevelDistance_Distance_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetMipLevelDistance_NativeFunction, "Distance");
        RemoveTargetObject_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "RemoveTargetObject");
        RemoveTargetObject_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(RemoveTargetObject_NativeFunction);
        RemoveTargetObject_InActor_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(RemoveTargetObject_NativeFunction, "InActor");
        RemoveGlobalCamera_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "RemoveGlobalCamera");
        RemoveGlobalCamera_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(RemoveGlobalCamera_NativeFunction);
        RemoveGlobalCamera_InActor_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(RemoveGlobalCamera_NativeFunction, "InActor");
        GetSequencePath_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetSequencePath");
        GetSequencePath_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetSequencePath_NativeFunction);
        GetSequencePath_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetSequencePath_NativeFunction, "ReturnValue");
        AddTargetObject_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "AddTargetObject");
        AddTargetObject_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(AddTargetObject_NativeFunction);
        AddTargetObject_InActor_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AddTargetObject_NativeFunction, "InActor");
        AddGlobalCamera_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "AddGlobalCamera");
        AddGlobalCamera_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(AddGlobalCamera_NativeFunction);
        AddGlobalCamera_InActor_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AddGlobalCamera_NativeFunction, "InActor");
        
        
    }
    
    protected ImgMediaSource(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // StructProperty /Script/ImgMedia.ImgMediaSource:FrameRateOverride
    static readonly int FrameRateOverride_Offset;
    
    public UnrealSharp.CoreUObject.FrameRate FrameRateOverride
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<UnrealSharp.CoreUObject.FrameRate>.FromNative(IntPtr.Add(NativeObject, FrameRateOverride_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<UnrealSharp.CoreUObject.FrameRate>.ToNative(IntPtr.Add(NativeObject, FrameRateOverride_Offset), 0, this, value);
        }
    }
    
    // StrProperty /Script/ImgMedia.ImgMediaSource:ProxyOverride
    static readonly int ProxyOverride_Offset;
    static readonly IntPtr ProxyOverride_NativeProperty;
    
    public string ProxyOverride
    {
        get
        {
            CheckObjectForValidity();
            return StringMarshaller.FromNative(IntPtr.Add(NativeObject,ProxyOverride_Offset),0,this);
        }
        set
        {
            CheckObjectForValidity();
            StringMarshaller.ToNative(IntPtr.Add(NativeObject,ProxyOverride_Offset),0,this,value);
        }
    }
    
    // BoolProperty /Script/ImgMedia.ImgMediaSource:bFillGapsInSequence
    static readonly int bFillGapsInSequence_Offset;
    
    public bool bFillGapsInSequence
    {
        get
        {
            CheckObjectForValidity();
            return BoolMarshaller.FromNative(IntPtr.Add(NativeObject, bFillGapsInSequence_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BoolMarshaller.ToNative(IntPtr.Add(NativeObject, bFillGapsInSequence_Offset), 0, this, value);
        }
    }
    
    // StructProperty /Script/ImgMedia.ImgMediaSource:SequencePath
    static readonly int SequencePath_Offset;
    
    public UnrealSharp.CoreUObject.DirectoryPath SequencePath
    {
        get
        {
            CheckObjectForValidity();
            return UnrealSharp.CoreUObject.DirectoryPathMarshaler.FromNative(IntPtr.Add(NativeObject, SequencePath_Offset), 0, this);
        }
    }
    
    // Function /Script/ImgMedia.ImgMediaSource:SetTokenizedSequencePath
    static readonly IntPtr SetTokenizedSequencePath_NativeFunction;
    static readonly int SetTokenizedSequencePath_ParamsSize;
    static readonly int SetTokenizedSequencePath_Path_Offset;
    
    public void SetTokenizedSequencePath(string path)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetTokenizedSequencePath_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            IntPtr Path_NativePtr = IntPtr.Add(ParamsBuffer,SetTokenizedSequencePath_Path_Offset);
            StringMarshaller.ToNative(Path_NativePtr,0,null,path);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetTokenizedSequencePath_NativeFunction, ParamsBuffer);
            
            StringMarshaller.DestructInstance(Path_NativePtr, 0);
        }
    }
    
    // Function /Script/ImgMedia.ImgMediaSource:SetSequencePath
    static readonly IntPtr SetSequencePath_NativeFunction;
    static readonly int SetSequencePath_ParamsSize;
    static readonly int SetSequencePath_Path_Offset;
    
    public void SetSequencePath(string path)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetSequencePath_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            IntPtr Path_NativePtr = IntPtr.Add(ParamsBuffer,SetSequencePath_Path_Offset);
            StringMarshaller.ToNative(Path_NativePtr,0,null,path);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetSequencePath_NativeFunction, ParamsBuffer);
            
            StringMarshaller.DestructInstance(Path_NativePtr, 0);
        }
    }
    
    // Function /Script/ImgMedia.ImgMediaSource:SetMipLevelDistance
    static readonly IntPtr SetMipLevelDistance_NativeFunction;
    static readonly int SetMipLevelDistance_ParamsSize;
    static readonly int SetMipLevelDistance_Distance_Offset;
    
    [Obsolete("SetMipLevelDistance has been deprecated.")]
    public void SetMipLevelDistance(float distance)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetMipLevelDistance_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<float>.ToNative(IntPtr.Add(ParamsBuffer, SetMipLevelDistance_Distance_Offset), 0, null, distance);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetMipLevelDistance_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/ImgMedia.ImgMediaSource:RemoveTargetObject
    static readonly IntPtr RemoveTargetObject_NativeFunction;
    static readonly int RemoveTargetObject_ParamsSize;
    static readonly int RemoveTargetObject_InActor_Offset;
    
    public void RemoveTargetObject(UnrealSharp.Engine.Actor inActor)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[RemoveTargetObject_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.Engine.Actor>.ToNative(IntPtr.Add(ParamsBuffer, RemoveTargetObject_InActor_Offset), 0, null, inActor);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, RemoveTargetObject_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/ImgMedia.ImgMediaSource:RemoveGlobalCamera
    static readonly IntPtr RemoveGlobalCamera_NativeFunction;
    static readonly int RemoveGlobalCamera_ParamsSize;
    static readonly int RemoveGlobalCamera_InActor_Offset;
    
    [Obsolete("RemoveGlobalCamera has been deprecated.")]
    public void RemoveGlobalCamera(UnrealSharp.Engine.Actor inActor)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[RemoveGlobalCamera_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.Engine.Actor>.ToNative(IntPtr.Add(ParamsBuffer, RemoveGlobalCamera_InActor_Offset), 0, null, inActor);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, RemoveGlobalCamera_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/ImgMedia.ImgMediaSource:GetSequencePath
    static readonly IntPtr GetSequencePath_NativeFunction;
    static readonly int GetSequencePath_ParamsSize;
    static readonly int GetSequencePath_ReturnValue_Offset;
    
    public string GetSequencePath()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetSequencePath_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetSequencePath_NativeFunction, ParamsBuffer);
            
            string returnValue;
            IntPtr ReturnValue_NativePtr = IntPtr.Add(ParamsBuffer,GetSequencePath_ReturnValue_Offset);
            returnValue = StringMarshaller.FromNative(ReturnValue_NativePtr,0,null);
            StringMarshaller.DestructInstance(ReturnValue_NativePtr, 0);
            
            return returnValue;
        }
    }
    
    // Function /Script/ImgMedia.ImgMediaSource:AddTargetObject
    static readonly IntPtr AddTargetObject_NativeFunction;
    static readonly int AddTargetObject_ParamsSize;
    static readonly int AddTargetObject_InActor_Offset;
    
    public void AddTargetObject(UnrealSharp.Engine.Actor inActor)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[AddTargetObject_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.Engine.Actor>.ToNative(IntPtr.Add(ParamsBuffer, AddTargetObject_InActor_Offset), 0, null, inActor);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, AddTargetObject_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/ImgMedia.ImgMediaSource:AddGlobalCamera
    static readonly IntPtr AddGlobalCamera_NativeFunction;
    static readonly int AddGlobalCamera_ParamsSize;
    static readonly int AddGlobalCamera_InActor_Offset;
    
    [Obsolete("AddGlobalCamera has been deprecated.")]
    public void AddGlobalCamera(UnrealSharp.Engine.Actor inActor)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[AddGlobalCamera_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.Engine.Actor>.ToNative(IntPtr.Add(ParamsBuffer, AddGlobalCamera_InActor_Offset), 0, null, inActor);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, AddGlobalCamera_NativeFunction, ParamsBuffer);
            
        }
    }
    
    
}