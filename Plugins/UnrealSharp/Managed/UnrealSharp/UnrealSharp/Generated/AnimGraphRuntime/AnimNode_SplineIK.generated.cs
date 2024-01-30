using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AnimGraphRuntime;

[UStruct]
public partial struct AnimNode_SplineIK
{
    // FloatProperty /Script/AnimGraphRuntime.AnimNode_SplineIK:Roll
    static readonly int Roll_Offset;
    public float Roll;
    
    // FloatProperty /Script/AnimGraphRuntime.AnimNode_SplineIK:TwistStart
    static readonly int TwistStart_Offset;
    public float TwistStart;
    
    // FloatProperty /Script/AnimGraphRuntime.AnimNode_SplineIK:TwistEnd
    static readonly int TwistEnd_Offset;
    public float TwistEnd;
    
    // FloatProperty /Script/AnimGraphRuntime.AnimNode_SplineIK:Stretch
    static readonly int Stretch_Offset;
    public float Stretch;
    
    // FloatProperty /Script/AnimGraphRuntime.AnimNode_SplineIK:Offset
    static readonly int Offset_Offset;
    public float Offset;
    
    
    public static readonly int NativeDataSize;
    static AnimNode_SplineIK()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("AnimNode_SplineIK");
        
        Roll_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Roll");
        TwistStart_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "TwistStart");
        TwistEnd_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "TwistEnd");
        Stretch_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Stretch");
        Offset_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Offset");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public AnimNode_SplineIK(IntPtr InNativeStruct)
    {
        unsafe
        {
            Roll = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Roll_Offset), 0, null);
            TwistStart = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, TwistStart_Offset), 0, null);
            TwistEnd = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, TwistEnd_Offset), 0, null);
            Stretch = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Stretch_Offset), 0, null);
            Offset = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Offset_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Roll_Offset), 0, null, Roll);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, TwistStart_Offset), 0, null, TwistStart);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, TwistEnd_Offset), 0, null, TwistEnd);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Stretch_Offset), 0, null, Stretch);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Offset_Offset), 0, null, Offset);
        }
    }
}

public static class AnimNode_SplineIKMarshaler
{
    public static AnimNode_SplineIK FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new AnimNode_SplineIK(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, AnimNode_SplineIK obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return AnimNode_SplineIK.NativeDataSize;
    }
}