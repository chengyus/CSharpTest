using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AnimGraphRuntime;

[UStruct]
public partial struct AnimNode_ModifyCurve
{
    // StructProperty /Script/AnimGraphRuntime.AnimNode_ModifyCurve:SourcePose
    static readonly int SourcePose_Offset;
    public UnrealSharp.Engine.PoseLink SourcePose;
    
    // FloatProperty /Script/AnimGraphRuntime.AnimNode_ModifyCurve:Alpha
    static readonly int Alpha_Offset;
    public float Alpha;
    
    // EnumProperty /Script/AnimGraphRuntime.AnimNode_ModifyCurve:ApplyMode
    static readonly int ApplyMode_Offset;
    public UnrealSharp.AnimGraphRuntime.EModifyCurveApplyMode ApplyMode;
    
    
    public static readonly int NativeDataSize;
    static AnimNode_ModifyCurve()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("AnimNode_ModifyCurve");
        
        SourcePose_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SourcePose");
        Alpha_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Alpha");
        ApplyMode_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ApplyMode");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public AnimNode_ModifyCurve(IntPtr InNativeStruct)
    {
        unsafe
        {
            SourcePose = UnrealSharp.Engine.PoseLinkMarshaler.FromNative(IntPtr.Add(InNativeStruct, SourcePose_Offset), 0, null);
            Alpha = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Alpha_Offset), 0, null);
            ApplyMode = BlittableMarshaller<UnrealSharp.AnimGraphRuntime.EModifyCurveApplyMode>.FromNative(IntPtr.Add(InNativeStruct, ApplyMode_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.Engine.PoseLinkMarshaler.ToNative(IntPtr.Add(Buffer, SourcePose_Offset), 0, null, SourcePose);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Alpha_Offset), 0, null, Alpha);
            BlittableMarshaller<UnrealSharp.AnimGraphRuntime.EModifyCurveApplyMode>.ToNative(IntPtr.Add(Buffer, ApplyMode_Offset), 0, null, ApplyMode);
        }
    }
}

public static class AnimNode_ModifyCurveMarshaler
{
    public static AnimNode_ModifyCurve FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new AnimNode_ModifyCurve(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, AnimNode_ModifyCurve obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return AnimNode_ModifyCurve.NativeDataSize;
    }
}