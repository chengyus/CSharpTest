using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AnimGraphRuntime;

[UStruct]
public partial struct AnimNode_Trail
{
    // FloatProperty /Script/AnimGraphRuntime.AnimNode_Trail:RelaxationSpeedScale
    static readonly int RelaxationSpeedScale_Offset;
    public float RelaxationSpeedScale;
    
    // StructProperty /Script/AnimGraphRuntime.AnimNode_Trail:RelaxationSpeedScaleInputProcessor
    static readonly int RelaxationSpeedScaleInputProcessor_Offset;
    public UnrealSharp.Engine.InputScaleBiasClamp RelaxationSpeedScaleInputProcessor;
    
    
    public static readonly int NativeDataSize;
    static AnimNode_Trail()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("AnimNode_Trail");
        
        RelaxationSpeedScale_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "RelaxationSpeedScale");
        RelaxationSpeedScaleInputProcessor_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "RelaxationSpeedScaleInputProcessor");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public AnimNode_Trail(IntPtr InNativeStruct)
    {
        unsafe
        {
            RelaxationSpeedScale = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, RelaxationSpeedScale_Offset), 0, null);
            RelaxationSpeedScaleInputProcessor = UnrealSharp.Engine.InputScaleBiasClampMarshaler.FromNative(IntPtr.Add(InNativeStruct, RelaxationSpeedScaleInputProcessor_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, RelaxationSpeedScale_Offset), 0, null, RelaxationSpeedScale);
            UnrealSharp.Engine.InputScaleBiasClampMarshaler.ToNative(IntPtr.Add(Buffer, RelaxationSpeedScaleInputProcessor_Offset), 0, null, RelaxationSpeedScaleInputProcessor);
        }
    }
}

public static class AnimNode_TrailMarshaler
{
    public static AnimNode_Trail FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new AnimNode_Trail(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, AnimNode_Trail obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return AnimNode_Trail.NativeDataSize;
    }
}