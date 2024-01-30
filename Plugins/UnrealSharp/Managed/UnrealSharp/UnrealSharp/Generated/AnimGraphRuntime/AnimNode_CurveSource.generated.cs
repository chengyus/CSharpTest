using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AnimGraphRuntime;

[UStruct]
public partial struct AnimNode_CurveSource
{
    // StructProperty /Script/AnimGraphRuntime.AnimNode_CurveSource:SourcePose
    static readonly int SourcePose_Offset;
    public UnrealSharp.Engine.PoseLink SourcePose;
    
    // NameProperty /Script/AnimGraphRuntime.AnimNode_CurveSource:SourceBinding
    static readonly int SourceBinding_Offset;
    public Name SourceBinding;
    
    // FloatProperty /Script/AnimGraphRuntime.AnimNode_CurveSource:Alpha
    static readonly int Alpha_Offset;
    public float Alpha;
    
    
    public static readonly int NativeDataSize;
    static AnimNode_CurveSource()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("AnimNode_CurveSource");
        
        SourcePose_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SourcePose");
        SourceBinding_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SourceBinding");
        Alpha_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Alpha");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public AnimNode_CurveSource(IntPtr InNativeStruct)
    {
        unsafe
        {
            SourcePose = UnrealSharp.Engine.PoseLinkMarshaler.FromNative(IntPtr.Add(InNativeStruct, SourcePose_Offset), 0, null);
            SourceBinding = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, SourceBinding_Offset), 0, null);
            Alpha = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Alpha_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.Engine.PoseLinkMarshaler.ToNative(IntPtr.Add(Buffer, SourcePose_Offset), 0, null, SourcePose);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, SourceBinding_Offset), 0, null, SourceBinding);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Alpha_Offset), 0, null, Alpha);
        }
    }
}

public static class AnimNode_CurveSourceMarshaler
{
    public static AnimNode_CurveSource FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new AnimNode_CurveSource(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, AnimNode_CurveSource obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return AnimNode_CurveSource.NativeDataSize;
    }
}