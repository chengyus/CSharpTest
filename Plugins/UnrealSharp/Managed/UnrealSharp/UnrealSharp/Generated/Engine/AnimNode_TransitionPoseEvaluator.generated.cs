using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct AnimNode_TransitionPoseEvaluator
{
    // IntProperty /Script/Engine.AnimNode_TransitionPoseEvaluator:FramesToCachePose
    static readonly int FramesToCachePose_Offset;
    public int FramesToCachePose;
    
    // ByteProperty /Script/Engine.AnimNode_TransitionPoseEvaluator:DataSource
    static readonly int DataSource_Offset;
    public UnrealSharp.Engine.EEvaluatorDataSource DataSource;
    
    // ByteProperty /Script/Engine.AnimNode_TransitionPoseEvaluator:EvaluatorMode
    static readonly int EvaluatorMode_Offset;
    public UnrealSharp.Engine.EEvaluatorMode EvaluatorMode;
    
    
    public static readonly int NativeDataSize;
    static AnimNode_TransitionPoseEvaluator()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("AnimNode_TransitionPoseEvaluator");
        
        FramesToCachePose_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FramesToCachePose");
        DataSource_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DataSource");
        EvaluatorMode_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "EvaluatorMode");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public AnimNode_TransitionPoseEvaluator(IntPtr InNativeStruct)
    {
        unsafe
        {
            FramesToCachePose = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, FramesToCachePose_Offset), 0, null);
            DataSource = BlittableMarshaller<UnrealSharp.Engine.EEvaluatorDataSource>.FromNative(IntPtr.Add(InNativeStruct, DataSource_Offset), 0, null);
            EvaluatorMode = BlittableMarshaller<UnrealSharp.Engine.EEvaluatorMode>.FromNative(IntPtr.Add(InNativeStruct, EvaluatorMode_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, FramesToCachePose_Offset), 0, null, FramesToCachePose);
            BlittableMarshaller<UnrealSharp.Engine.EEvaluatorDataSource>.ToNative(IntPtr.Add(Buffer, DataSource_Offset), 0, null, DataSource);
            BlittableMarshaller<UnrealSharp.Engine.EEvaluatorMode>.ToNative(IntPtr.Add(Buffer, EvaluatorMode_Offset), 0, null, EvaluatorMode);
        }
    }
}

public static class AnimNode_TransitionPoseEvaluatorMarshaler
{
    public static AnimNode_TransitionPoseEvaluator FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new AnimNode_TransitionPoseEvaluator(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, AnimNode_TransitionPoseEvaluator obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return AnimNode_TransitionPoseEvaluator.NativeDataSize;
    }
}