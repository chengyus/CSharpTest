// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UClass]
abstract public partial class StreamableRenderAsset : UnrealSharp.CoreUObject.Object
{
    
    static StreamableRenderAsset()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("StreamableRenderAsset");
        
        NumCinematicMipLevels_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "NumCinematicMipLevels");
        NeverStream_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "NeverStream");
        NeverStream_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "NeverStream");
        bGlobalForceMipLevelsToBeResident_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bGlobalForceMipLevelsToBeResident");
        bGlobalForceMipLevelsToBeResident_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bGlobalForceMipLevelsToBeResident");
        
        SetForceMipLevelsToBeResident_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetForceMipLevelsToBeResident");
        SetForceMipLevelsToBeResident_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetForceMipLevelsToBeResident_NativeFunction);
        SetForceMipLevelsToBeResident_Seconds_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetForceMipLevelsToBeResident_NativeFunction, "Seconds");
        SetForceMipLevelsToBeResident_CinematicLODGroupMask_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetForceMipLevelsToBeResident_NativeFunction, "CinematicLODGroupMask");
        
        
    }
    
    protected StreamableRenderAsset(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // IntProperty /Script/Engine.StreamableRenderAsset:NumCinematicMipLevels
    static readonly int NumCinematicMipLevels_Offset;
    
    public int NumCinematicMipLevels
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<int>.FromNative(IntPtr.Add(NativeObject, NumCinematicMipLevels_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<int>.ToNative(IntPtr.Add(NativeObject, NumCinematicMipLevels_Offset), 0, this, value);
        }
    }
    
    // BoolProperty /Script/Engine.StreamableRenderAsset:NeverStream
    static readonly int NeverStream_Offset;
    static readonly IntPtr NeverStream_NativeProperty;
    
    public bool NeverStream
    {
        get
        {
            CheckObjectForValidity();
            return FBoolPropertyExporter.CallGetBitfieldValueFromProperty(NativeObject, NeverStream_NativeProperty, NeverStream_Offset);
        }
        set
        {
            CheckObjectForValidity();
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(NativeObject, NeverStream_NativeProperty, NeverStream_Offset, value);
        }
    }
    
    // BoolProperty /Script/Engine.StreamableRenderAsset:bGlobalForceMipLevelsToBeResident
    static readonly int bGlobalForceMipLevelsToBeResident_Offset;
    static readonly IntPtr bGlobalForceMipLevelsToBeResident_NativeProperty;
    
    public bool bGlobalForceMipLevelsToBeResident
    {
        get
        {
            CheckObjectForValidity();
            return FBoolPropertyExporter.CallGetBitfieldValueFromProperty(NativeObject, bGlobalForceMipLevelsToBeResident_NativeProperty, bGlobalForceMipLevelsToBeResident_Offset);
        }
    }
    
    // Function /Script/Engine.StreamableRenderAsset:SetForceMipLevelsToBeResident
    static readonly IntPtr SetForceMipLevelsToBeResident_NativeFunction;
    static readonly int SetForceMipLevelsToBeResident_ParamsSize;
    static readonly int SetForceMipLevelsToBeResident_Seconds_Offset;
    static readonly int SetForceMipLevelsToBeResident_CinematicLODGroupMask_Offset;
    
    public void SetForceMipLevelsToBeResident(float seconds, int cinematicLODGroupMask = 0)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetForceMipLevelsToBeResident_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<float>.ToNative(IntPtr.Add(ParamsBuffer, SetForceMipLevelsToBeResident_Seconds_Offset), 0, null, seconds);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(ParamsBuffer, SetForceMipLevelsToBeResident_CinematicLODGroupMask_Offset), 0, null, cinematicLODGroupMask);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetForceMipLevelsToBeResident_NativeFunction, ParamsBuffer);
            
        }
    }
    
    
}