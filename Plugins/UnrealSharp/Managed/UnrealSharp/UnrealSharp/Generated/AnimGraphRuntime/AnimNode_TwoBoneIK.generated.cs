using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AnimGraphRuntime;

[UStruct]
public partial struct AnimNode_TwoBoneIK
{
    // StructProperty /Script/AnimGraphRuntime.AnimNode_TwoBoneIK:EffectorLocation
    static readonly int EffectorLocation_Offset;
    public System.DoubleNumerics.Vector3 EffectorLocation;
    
    // StructProperty /Script/AnimGraphRuntime.AnimNode_TwoBoneIK:JointTargetLocation
    static readonly int JointTargetLocation_Offset;
    public System.DoubleNumerics.Vector3 JointTargetLocation;
    
    
    public static readonly int NativeDataSize;
    static AnimNode_TwoBoneIK()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("AnimNode_TwoBoneIK");
        
        EffectorLocation_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "EffectorLocation");
        JointTargetLocation_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "JointTargetLocation");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public AnimNode_TwoBoneIK(IntPtr InNativeStruct)
    {
        unsafe
        {
            EffectorLocation = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, EffectorLocation_Offset), 0, null);
            JointTargetLocation = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, JointTargetLocation_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, EffectorLocation_Offset), 0, null, EffectorLocation);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, JointTargetLocation_Offset), 0, null, JointTargetLocation);
        }
    }
}

public static class AnimNode_TwoBoneIKMarshaler
{
    public static AnimNode_TwoBoneIK FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new AnimNode_TwoBoneIK(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, AnimNode_TwoBoneIK obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return AnimNode_TwoBoneIK.NativeDataSize;
    }
}