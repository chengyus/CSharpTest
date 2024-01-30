using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AnimGraphRuntime;

[UStruct]
public partial struct AnimNode_LookAt
{
    // StructProperty /Script/AnimGraphRuntime.AnimNode_LookAt:LookAtLocation
    static readonly int LookAtLocation_Offset;
    public System.DoubleNumerics.Vector3 LookAtLocation;
    
    // ByteProperty /Script/AnimGraphRuntime.AnimNode_LookAt:InterpolationType
    static readonly int InterpolationType_Offset;
    public UnrealSharp.AnimGraphRuntime.EInterpolationBlend InterpolationType;
    
    // FloatProperty /Script/AnimGraphRuntime.AnimNode_LookAt:LookAtClamp
    static readonly int LookAtClamp_Offset;
    public float LookAtClamp;
    
    // FloatProperty /Script/AnimGraphRuntime.AnimNode_LookAt:InterpolationTime
    static readonly int InterpolationTime_Offset;
    public float InterpolationTime;
    
    // FloatProperty /Script/AnimGraphRuntime.AnimNode_LookAt:InterpolationTriggerThreashold
    static readonly int InterpolationTriggerThreashold_Offset;
    public float InterpolationTriggerThreashold;
    
    
    public static readonly int NativeDataSize;
    static AnimNode_LookAt()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("AnimNode_LookAt");
        
        LookAtLocation_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LookAtLocation");
        InterpolationType_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "InterpolationType");
        LookAtClamp_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LookAtClamp");
        InterpolationTime_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "InterpolationTime");
        InterpolationTriggerThreashold_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "InterpolationTriggerThreashold");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public AnimNode_LookAt(IntPtr InNativeStruct)
    {
        unsafe
        {
            LookAtLocation = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, LookAtLocation_Offset), 0, null);
            InterpolationType = BlittableMarshaller<UnrealSharp.AnimGraphRuntime.EInterpolationBlend>.FromNative(IntPtr.Add(InNativeStruct, InterpolationType_Offset), 0, null);
            LookAtClamp = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, LookAtClamp_Offset), 0, null);
            InterpolationTime = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, InterpolationTime_Offset), 0, null);
            InterpolationTriggerThreashold = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, InterpolationTriggerThreashold_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, LookAtLocation_Offset), 0, null, LookAtLocation);
            BlittableMarshaller<UnrealSharp.AnimGraphRuntime.EInterpolationBlend>.ToNative(IntPtr.Add(Buffer, InterpolationType_Offset), 0, null, InterpolationType);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, LookAtClamp_Offset), 0, null, LookAtClamp);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, InterpolationTime_Offset), 0, null, InterpolationTime);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, InterpolationTriggerThreashold_Offset), 0, null, InterpolationTriggerThreashold);
        }
    }
}

public static class AnimNode_LookAtMarshaler
{
    public static AnimNode_LookAt FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new AnimNode_LookAt(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, AnimNode_LookAt obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return AnimNode_LookAt.NativeDataSize;
    }
}