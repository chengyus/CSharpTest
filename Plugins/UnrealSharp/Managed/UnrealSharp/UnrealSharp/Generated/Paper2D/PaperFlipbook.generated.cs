// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Paper2D;

[UClass]
public partial class PaperFlipbook : UnrealSharp.CoreUObject.Object
{
    
    static PaperFlipbook()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("PaperFlipbook");
        
        FramesPerSecond_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FramesPerSecond");
        DefaultMaterial_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DefaultMaterial");
        CollisionSource_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "CollisionSource");
        
        IsValidKeyFrameIndex_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "IsValidKeyFrameIndex");
        IsValidKeyFrameIndex_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(IsValidKeyFrameIndex_NativeFunction);
        IsValidKeyFrameIndex_Index_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(IsValidKeyFrameIndex_NativeFunction, "Index");
        IsValidKeyFrameIndex_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(IsValidKeyFrameIndex_NativeFunction, "ReturnValue");
        GetTotalDuration_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetTotalDuration");
        GetTotalDuration_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetTotalDuration_NativeFunction);
        GetTotalDuration_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetTotalDuration_NativeFunction, "ReturnValue");
        GetSpriteAtTime_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetSpriteAtTime");
        GetSpriteAtTime_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetSpriteAtTime_NativeFunction);
        GetSpriteAtTime_Time_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetSpriteAtTime_NativeFunction, "Time");
        GetSpriteAtTime_bClampToEnds_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetSpriteAtTime_NativeFunction, "bClampToEnds");
        GetSpriteAtTime_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetSpriteAtTime_NativeFunction, "ReturnValue");
        GetSpriteAtFrame_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetSpriteAtFrame");
        GetSpriteAtFrame_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetSpriteAtFrame_NativeFunction);
        GetSpriteAtFrame_FrameIndex_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetSpriteAtFrame_NativeFunction, "FrameIndex");
        GetSpriteAtFrame_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetSpriteAtFrame_NativeFunction, "ReturnValue");
        GetNumKeyFrames_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetNumKeyFrames");
        GetNumKeyFrames_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetNumKeyFrames_NativeFunction);
        GetNumKeyFrames_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetNumKeyFrames_NativeFunction, "ReturnValue");
        GetNumFrames_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetNumFrames");
        GetNumFrames_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetNumFrames_NativeFunction);
        GetNumFrames_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetNumFrames_NativeFunction, "ReturnValue");
        GetKeyFrameIndexAtTime_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetKeyFrameIndexAtTime");
        GetKeyFrameIndexAtTime_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetKeyFrameIndexAtTime_NativeFunction);
        GetKeyFrameIndexAtTime_Time_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetKeyFrameIndexAtTime_NativeFunction, "Time");
        GetKeyFrameIndexAtTime_bClampToEnds_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetKeyFrameIndexAtTime_NativeFunction, "bClampToEnds");
        GetKeyFrameIndexAtTime_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetKeyFrameIndexAtTime_NativeFunction, "ReturnValue");
        
        
    }
    
    protected PaperFlipbook(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // FloatProperty /Script/Paper2D.PaperFlipbook:FramesPerSecond
    static readonly int FramesPerSecond_Offset;
    
    public float FramesPerSecond
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, FramesPerSecond_Offset), 0, this);
        }
    }
    
    // ObjectProperty /Script/Paper2D.PaperFlipbook:DefaultMaterial
    static readonly int DefaultMaterial_Offset;
    
    public UnrealSharp.Engine.MaterialInterface DefaultMaterial
    {
        get
        {
            CheckObjectForValidity();
            return ObjectMarshaller<UnrealSharp.Engine.MaterialInterface>.FromNative(IntPtr.Add(NativeObject, DefaultMaterial_Offset), 0, this);
        }
    }
    
    // ByteProperty /Script/Paper2D.PaperFlipbook:CollisionSource
    static readonly int CollisionSource_Offset;
    
    public UnrealSharp.Paper2D.EFlipbookCollisionMode CollisionSource
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<UnrealSharp.Paper2D.EFlipbookCollisionMode>.FromNative(IntPtr.Add(NativeObject, CollisionSource_Offset), 0, this);
        }
    }
    
    // Function /Script/Paper2D.PaperFlipbook:IsValidKeyFrameIndex
    static readonly IntPtr IsValidKeyFrameIndex_NativeFunction;
    static readonly int IsValidKeyFrameIndex_ParamsSize;
    static readonly int IsValidKeyFrameIndex_Index_Offset;
    static readonly int IsValidKeyFrameIndex_ReturnValue_Offset;
    
    public bool IsValidKeyFrameIndex(int index)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[IsValidKeyFrameIndex_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<int>.ToNative(IntPtr.Add(ParamsBuffer, IsValidKeyFrameIndex_Index_Offset), 0, null, index);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, IsValidKeyFrameIndex_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, IsValidKeyFrameIndex_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/Paper2D.PaperFlipbook:GetTotalDuration
    static readonly IntPtr GetTotalDuration_NativeFunction;
    static readonly int GetTotalDuration_ParamsSize;
    static readonly int GetTotalDuration_ReturnValue_Offset;
    
    public float GetTotalDuration()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetTotalDuration_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetTotalDuration_NativeFunction, ParamsBuffer);
            
            float returnValue;
            returnValue = BlittableMarshaller<float>.FromNative(IntPtr.Add(ParamsBuffer, GetTotalDuration_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/Paper2D.PaperFlipbook:GetSpriteAtTime
    static readonly IntPtr GetSpriteAtTime_NativeFunction;
    static readonly int GetSpriteAtTime_ParamsSize;
    static readonly int GetSpriteAtTime_Time_Offset;
    static readonly int GetSpriteAtTime_bClampToEnds_Offset;
    static readonly int GetSpriteAtTime_ReturnValue_Offset;
    
    public UnrealSharp.Paper2D.PaperSprite GetSpriteAtTime(float time, bool bClampToEnds = false)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetSpriteAtTime_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<float>.ToNative(IntPtr.Add(ParamsBuffer, GetSpriteAtTime_Time_Offset), 0, null, time);
            BoolMarshaller.ToNative(IntPtr.Add(ParamsBuffer, GetSpriteAtTime_bClampToEnds_Offset), 0, null, bClampToEnds);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetSpriteAtTime_NativeFunction, ParamsBuffer);
            
            UnrealSharp.Paper2D.PaperSprite returnValue;
            returnValue = ObjectMarshaller<UnrealSharp.Paper2D.PaperSprite>.FromNative(IntPtr.Add(ParamsBuffer, GetSpriteAtTime_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/Paper2D.PaperFlipbook:GetSpriteAtFrame
    static readonly IntPtr GetSpriteAtFrame_NativeFunction;
    static readonly int GetSpriteAtFrame_ParamsSize;
    static readonly int GetSpriteAtFrame_FrameIndex_Offset;
    static readonly int GetSpriteAtFrame_ReturnValue_Offset;
    
    public UnrealSharp.Paper2D.PaperSprite GetSpriteAtFrame(int frameIndex)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetSpriteAtFrame_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<int>.ToNative(IntPtr.Add(ParamsBuffer, GetSpriteAtFrame_FrameIndex_Offset), 0, null, frameIndex);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetSpriteAtFrame_NativeFunction, ParamsBuffer);
            
            UnrealSharp.Paper2D.PaperSprite returnValue;
            returnValue = ObjectMarshaller<UnrealSharp.Paper2D.PaperSprite>.FromNative(IntPtr.Add(ParamsBuffer, GetSpriteAtFrame_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/Paper2D.PaperFlipbook:GetNumKeyFrames
    static readonly IntPtr GetNumKeyFrames_NativeFunction;
    static readonly int GetNumKeyFrames_ParamsSize;
    static readonly int GetNumKeyFrames_ReturnValue_Offset;
    
    public int GetNumKeyFrames()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetNumKeyFrames_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetNumKeyFrames_NativeFunction, ParamsBuffer);
            
            int returnValue;
            returnValue = BlittableMarshaller<int>.FromNative(IntPtr.Add(ParamsBuffer, GetNumKeyFrames_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/Paper2D.PaperFlipbook:GetNumFrames
    static readonly IntPtr GetNumFrames_NativeFunction;
    static readonly int GetNumFrames_ParamsSize;
    static readonly int GetNumFrames_ReturnValue_Offset;
    
    public int GetNumFrames()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetNumFrames_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetNumFrames_NativeFunction, ParamsBuffer);
            
            int returnValue;
            returnValue = BlittableMarshaller<int>.FromNative(IntPtr.Add(ParamsBuffer, GetNumFrames_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/Paper2D.PaperFlipbook:GetKeyFrameIndexAtTime
    static readonly IntPtr GetKeyFrameIndexAtTime_NativeFunction;
    static readonly int GetKeyFrameIndexAtTime_ParamsSize;
    static readonly int GetKeyFrameIndexAtTime_Time_Offset;
    static readonly int GetKeyFrameIndexAtTime_bClampToEnds_Offset;
    static readonly int GetKeyFrameIndexAtTime_ReturnValue_Offset;
    
    public int GetKeyFrameIndexAtTime(float time, bool bClampToEnds = false)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetKeyFrameIndexAtTime_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<float>.ToNative(IntPtr.Add(ParamsBuffer, GetKeyFrameIndexAtTime_Time_Offset), 0, null, time);
            BoolMarshaller.ToNative(IntPtr.Add(ParamsBuffer, GetKeyFrameIndexAtTime_bClampToEnds_Offset), 0, null, bClampToEnds);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetKeyFrameIndexAtTime_NativeFunction, ParamsBuffer);
            
            int returnValue;
            returnValue = BlittableMarshaller<int>.FromNative(IntPtr.Add(ParamsBuffer, GetKeyFrameIndexAtTime_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    
}