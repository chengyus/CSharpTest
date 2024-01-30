// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Paper2D;

[UClass]
public partial class PaperFlipbookComponent : UnrealSharp.Engine.MeshComponent
{
    
    static PaperFlipbookComponent()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("PaperFlipbookComponent");
        
        SpriteColor_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SpriteColor");
        
        Stop_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "Stop");
        SetSpriteColor_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetSpriteColor");
        SetSpriteColor_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetSpriteColor_NativeFunction);
        SetSpriteColor_NewColor_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetSpriteColor_NativeFunction, "NewColor");
        SetPlayRate_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetPlayRate");
        SetPlayRate_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetPlayRate_NativeFunction);
        SetPlayRate_NewRate_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetPlayRate_NativeFunction, "NewRate");
        SetPlaybackPositionInFrames_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetPlaybackPositionInFrames");
        SetPlaybackPositionInFrames_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetPlaybackPositionInFrames_NativeFunction);
        SetPlaybackPositionInFrames_NewFramePosition_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetPlaybackPositionInFrames_NativeFunction, "NewFramePosition");
        SetPlaybackPositionInFrames_bFireEvents_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetPlaybackPositionInFrames_NativeFunction, "bFireEvents");
        SetPlaybackPosition_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetPlaybackPosition");
        SetPlaybackPosition_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetPlaybackPosition_NativeFunction);
        SetPlaybackPosition_NewPosition_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetPlaybackPosition_NativeFunction, "NewPosition");
        SetPlaybackPosition_bFireEvents_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetPlaybackPosition_NativeFunction, "bFireEvents");
        SetNewTime_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetNewTime");
        SetNewTime_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetNewTime_NativeFunction);
        SetNewTime_NewTime_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetNewTime_NativeFunction, "NewTime");
        SetLooping_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetLooping");
        SetLooping_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetLooping_NativeFunction);
        SetLooping_bNewLooping_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetLooping_NativeFunction, "bNewLooping");
        SetFlipbook_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetFlipbook");
        SetFlipbook_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetFlipbook_NativeFunction);
        SetFlipbook_NewFlipbook_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetFlipbook_NativeFunction, "NewFlipbook");
        SetFlipbook_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetFlipbook_NativeFunction, "ReturnValue");
        ReverseFromEnd_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "ReverseFromEnd");
        Reverse_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "Reverse");
        PlayFromStart_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "PlayFromStart");
        Play_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "Play");
        IsReversing_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "IsReversing");
        IsReversing_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(IsReversing_NativeFunction);
        IsReversing_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(IsReversing_NativeFunction, "ReturnValue");
        IsPlaying_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "IsPlaying");
        IsPlaying_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(IsPlaying_NativeFunction);
        IsPlaying_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(IsPlaying_NativeFunction, "ReturnValue");
        IsLooping_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "IsLooping");
        IsLooping_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(IsLooping_NativeFunction);
        IsLooping_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(IsLooping_NativeFunction, "ReturnValue");
        GetSpriteColor_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetSpriteColor");
        GetSpriteColor_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetSpriteColor_NativeFunction);
        GetSpriteColor_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetSpriteColor_NativeFunction, "ReturnValue");
        GetPlayRate_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetPlayRate");
        GetPlayRate_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetPlayRate_NativeFunction);
        GetPlayRate_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetPlayRate_NativeFunction, "ReturnValue");
        GetPlaybackPositionInFrames_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetPlaybackPositionInFrames");
        GetPlaybackPositionInFrames_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetPlaybackPositionInFrames_NativeFunction);
        GetPlaybackPositionInFrames_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetPlaybackPositionInFrames_NativeFunction, "ReturnValue");
        GetPlaybackPosition_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetPlaybackPosition");
        GetPlaybackPosition_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetPlaybackPosition_NativeFunction);
        GetPlaybackPosition_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetPlaybackPosition_NativeFunction, "ReturnValue");
        GetFlipbookLengthInFrames_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetFlipbookLengthInFrames");
        GetFlipbookLengthInFrames_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetFlipbookLengthInFrames_NativeFunction);
        GetFlipbookLengthInFrames_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetFlipbookLengthInFrames_NativeFunction, "ReturnValue");
        GetFlipbookLength_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetFlipbookLength");
        GetFlipbookLength_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetFlipbookLength_NativeFunction);
        GetFlipbookLength_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetFlipbookLength_NativeFunction, "ReturnValue");
        GetFlipbookFramerate_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetFlipbookFramerate");
        GetFlipbookFramerate_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetFlipbookFramerate_NativeFunction);
        GetFlipbookFramerate_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetFlipbookFramerate_NativeFunction, "ReturnValue");
        GetFlipbook_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetFlipbook");
        GetFlipbook_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetFlipbook_NativeFunction);
        GetFlipbook_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetFlipbook_NativeFunction, "ReturnValue");
        
        
    }
    
    protected PaperFlipbookComponent(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // StructProperty /Script/Paper2D.PaperFlipbookComponent:SpriteColor
    static readonly int SpriteColor_Offset;
    
    public UnrealSharp.CoreUObject.LinearColor SpriteColor
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.FromNative(IntPtr.Add(NativeObject, SpriteColor_Offset), 0, this);
        }
    }
    
    // Function /Script/Paper2D.PaperFlipbookComponent:Stop
    static readonly IntPtr Stop_NativeFunction;
    
    public void Stop()
    {
        unsafe
        {
            UObjectExporter.CallInvokeNativeFunction(NativeObject, Stop_NativeFunction, IntPtr.Zero);
        }
    }
    
    // Function /Script/Paper2D.PaperFlipbookComponent:SetSpriteColor
    static readonly IntPtr SetSpriteColor_NativeFunction;
    static readonly int SetSpriteColor_ParamsSize;
    static readonly int SetSpriteColor_NewColor_Offset;
    
    public void SetSpriteColor(UnrealSharp.CoreUObject.LinearColor newColor)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetSpriteColor_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.ToNative(IntPtr.Add(ParamsBuffer, SetSpriteColor_NewColor_Offset), 0, null, newColor);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetSpriteColor_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/Paper2D.PaperFlipbookComponent:SetPlayRate
    static readonly IntPtr SetPlayRate_NativeFunction;
    static readonly int SetPlayRate_ParamsSize;
    static readonly int SetPlayRate_NewRate_Offset;
    
    public void SetPlayRate(float newRate)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetPlayRate_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<float>.ToNative(IntPtr.Add(ParamsBuffer, SetPlayRate_NewRate_Offset), 0, null, newRate);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetPlayRate_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/Paper2D.PaperFlipbookComponent:SetPlaybackPositionInFrames
    static readonly IntPtr SetPlaybackPositionInFrames_NativeFunction;
    static readonly int SetPlaybackPositionInFrames_ParamsSize;
    static readonly int SetPlaybackPositionInFrames_NewFramePosition_Offset;
    static readonly int SetPlaybackPositionInFrames_bFireEvents_Offset;
    
    public void SetPlaybackPositionInFrames(int newFramePosition, bool bFireEvents)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetPlaybackPositionInFrames_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<int>.ToNative(IntPtr.Add(ParamsBuffer, SetPlaybackPositionInFrames_NewFramePosition_Offset), 0, null, newFramePosition);
            BoolMarshaller.ToNative(IntPtr.Add(ParamsBuffer, SetPlaybackPositionInFrames_bFireEvents_Offset), 0, null, bFireEvents);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetPlaybackPositionInFrames_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/Paper2D.PaperFlipbookComponent:SetPlaybackPosition
    static readonly IntPtr SetPlaybackPosition_NativeFunction;
    static readonly int SetPlaybackPosition_ParamsSize;
    static readonly int SetPlaybackPosition_NewPosition_Offset;
    static readonly int SetPlaybackPosition_bFireEvents_Offset;
    
    public void SetPlaybackPosition(float newPosition, bool bFireEvents)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetPlaybackPosition_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<float>.ToNative(IntPtr.Add(ParamsBuffer, SetPlaybackPosition_NewPosition_Offset), 0, null, newPosition);
            BoolMarshaller.ToNative(IntPtr.Add(ParamsBuffer, SetPlaybackPosition_bFireEvents_Offset), 0, null, bFireEvents);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetPlaybackPosition_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/Paper2D.PaperFlipbookComponent:SetNewTime
    static readonly IntPtr SetNewTime_NativeFunction;
    static readonly int SetNewTime_ParamsSize;
    static readonly int SetNewTime_NewTime_Offset;
    
    public void SetNewTime(float newTime)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetNewTime_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<float>.ToNative(IntPtr.Add(ParamsBuffer, SetNewTime_NewTime_Offset), 0, null, newTime);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetNewTime_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/Paper2D.PaperFlipbookComponent:SetLooping
    static readonly IntPtr SetLooping_NativeFunction;
    static readonly int SetLooping_ParamsSize;
    static readonly int SetLooping_bNewLooping_Offset;
    
    public void SetLooping(bool bNewLooping)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetLooping_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BoolMarshaller.ToNative(IntPtr.Add(ParamsBuffer, SetLooping_bNewLooping_Offset), 0, null, bNewLooping);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetLooping_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/Paper2D.PaperFlipbookComponent:SetFlipbook
    static readonly IntPtr SetFlipbook_NativeFunction;
    static readonly int SetFlipbook_ParamsSize;
    static readonly int SetFlipbook_NewFlipbook_Offset;
    static readonly int SetFlipbook_ReturnValue_Offset;
    
    public bool SetFlipbook(UnrealSharp.Paper2D.PaperFlipbook newFlipbook)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetFlipbook_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.Paper2D.PaperFlipbook>.ToNative(IntPtr.Add(ParamsBuffer, SetFlipbook_NewFlipbook_Offset), 0, null, newFlipbook);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetFlipbook_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, SetFlipbook_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/Paper2D.PaperFlipbookComponent:ReverseFromEnd
    static readonly IntPtr ReverseFromEnd_NativeFunction;
    
    public void ReverseFromEnd()
    {
        unsafe
        {
            UObjectExporter.CallInvokeNativeFunction(NativeObject, ReverseFromEnd_NativeFunction, IntPtr.Zero);
        }
    }
    
    // Function /Script/Paper2D.PaperFlipbookComponent:Reverse
    static readonly IntPtr Reverse_NativeFunction;
    
    public void Reverse()
    {
        unsafe
        {
            UObjectExporter.CallInvokeNativeFunction(NativeObject, Reverse_NativeFunction, IntPtr.Zero);
        }
    }
    
    // Function /Script/Paper2D.PaperFlipbookComponent:PlayFromStart
    static readonly IntPtr PlayFromStart_NativeFunction;
    
    public void PlayFromStart()
    {
        unsafe
        {
            UObjectExporter.CallInvokeNativeFunction(NativeObject, PlayFromStart_NativeFunction, IntPtr.Zero);
        }
    }
    
    // Function /Script/Paper2D.PaperFlipbookComponent:Play
    static readonly IntPtr Play_NativeFunction;
    
    public void Play()
    {
        unsafe
        {
            UObjectExporter.CallInvokeNativeFunction(NativeObject, Play_NativeFunction, IntPtr.Zero);
        }
    }
    
    // Function /Script/Paper2D.PaperFlipbookComponent:IsReversing
    static readonly IntPtr IsReversing_NativeFunction;
    static readonly int IsReversing_ParamsSize;
    static readonly int IsReversing_ReturnValue_Offset;
    
    public bool IsReversing()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[IsReversing_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, IsReversing_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, IsReversing_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/Paper2D.PaperFlipbookComponent:IsPlaying
    static readonly IntPtr IsPlaying_NativeFunction;
    static readonly int IsPlaying_ParamsSize;
    static readonly int IsPlaying_ReturnValue_Offset;
    
    public bool IsPlaying()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[IsPlaying_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, IsPlaying_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, IsPlaying_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/Paper2D.PaperFlipbookComponent:IsLooping
    static readonly IntPtr IsLooping_NativeFunction;
    static readonly int IsLooping_ParamsSize;
    static readonly int IsLooping_ReturnValue_Offset;
    
    public bool IsLooping()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[IsLooping_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, IsLooping_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, IsLooping_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/Paper2D.PaperFlipbookComponent:GetSpriteColor
    static readonly IntPtr GetSpriteColor_NativeFunction;
    static readonly int GetSpriteColor_ParamsSize;
    static readonly int GetSpriteColor_ReturnValue_Offset;
    
    public UnrealSharp.CoreUObject.LinearColor GetSpriteColor()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetSpriteColor_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetSpriteColor_NativeFunction, ParamsBuffer);
            
            UnrealSharp.CoreUObject.LinearColor returnValue;
            returnValue = BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.FromNative(IntPtr.Add(ParamsBuffer, GetSpriteColor_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/Paper2D.PaperFlipbookComponent:GetPlayRate
    static readonly IntPtr GetPlayRate_NativeFunction;
    static readonly int GetPlayRate_ParamsSize;
    static readonly int GetPlayRate_ReturnValue_Offset;
    
    public float GetPlayRate()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetPlayRate_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetPlayRate_NativeFunction, ParamsBuffer);
            
            float returnValue;
            returnValue = BlittableMarshaller<float>.FromNative(IntPtr.Add(ParamsBuffer, GetPlayRate_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/Paper2D.PaperFlipbookComponent:GetPlaybackPositionInFrames
    static readonly IntPtr GetPlaybackPositionInFrames_NativeFunction;
    static readonly int GetPlaybackPositionInFrames_ParamsSize;
    static readonly int GetPlaybackPositionInFrames_ReturnValue_Offset;
    
    public int GetPlaybackPositionInFrames()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetPlaybackPositionInFrames_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetPlaybackPositionInFrames_NativeFunction, ParamsBuffer);
            
            int returnValue;
            returnValue = BlittableMarshaller<int>.FromNative(IntPtr.Add(ParamsBuffer, GetPlaybackPositionInFrames_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/Paper2D.PaperFlipbookComponent:GetPlaybackPosition
    static readonly IntPtr GetPlaybackPosition_NativeFunction;
    static readonly int GetPlaybackPosition_ParamsSize;
    static readonly int GetPlaybackPosition_ReturnValue_Offset;
    
    public float GetPlaybackPosition()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetPlaybackPosition_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetPlaybackPosition_NativeFunction, ParamsBuffer);
            
            float returnValue;
            returnValue = BlittableMarshaller<float>.FromNative(IntPtr.Add(ParamsBuffer, GetPlaybackPosition_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/Paper2D.PaperFlipbookComponent:GetFlipbookLengthInFrames
    static readonly IntPtr GetFlipbookLengthInFrames_NativeFunction;
    static readonly int GetFlipbookLengthInFrames_ParamsSize;
    static readonly int GetFlipbookLengthInFrames_ReturnValue_Offset;
    
    public int GetFlipbookLengthInFrames()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetFlipbookLengthInFrames_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetFlipbookLengthInFrames_NativeFunction, ParamsBuffer);
            
            int returnValue;
            returnValue = BlittableMarshaller<int>.FromNative(IntPtr.Add(ParamsBuffer, GetFlipbookLengthInFrames_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/Paper2D.PaperFlipbookComponent:GetFlipbookLength
    static readonly IntPtr GetFlipbookLength_NativeFunction;
    static readonly int GetFlipbookLength_ParamsSize;
    static readonly int GetFlipbookLength_ReturnValue_Offset;
    
    public float GetFlipbookLength()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetFlipbookLength_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetFlipbookLength_NativeFunction, ParamsBuffer);
            
            float returnValue;
            returnValue = BlittableMarshaller<float>.FromNative(IntPtr.Add(ParamsBuffer, GetFlipbookLength_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/Paper2D.PaperFlipbookComponent:GetFlipbookFramerate
    static readonly IntPtr GetFlipbookFramerate_NativeFunction;
    static readonly int GetFlipbookFramerate_ParamsSize;
    static readonly int GetFlipbookFramerate_ReturnValue_Offset;
    
    public float GetFlipbookFramerate()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetFlipbookFramerate_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetFlipbookFramerate_NativeFunction, ParamsBuffer);
            
            float returnValue;
            returnValue = BlittableMarshaller<float>.FromNative(IntPtr.Add(ParamsBuffer, GetFlipbookFramerate_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/Paper2D.PaperFlipbookComponent:GetFlipbook
    static readonly IntPtr GetFlipbook_NativeFunction;
    static readonly int GetFlipbook_ParamsSize;
    static readonly int GetFlipbook_ReturnValue_Offset;
    
    public UnrealSharp.Paper2D.PaperFlipbook GetFlipbook()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetFlipbook_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetFlipbook_NativeFunction, ParamsBuffer);
            
            UnrealSharp.Paper2D.PaperFlipbook returnValue;
            returnValue = ObjectMarshaller<UnrealSharp.Paper2D.PaperFlipbook>.FromNative(IntPtr.Add(ParamsBuffer, GetFlipbook_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    
}