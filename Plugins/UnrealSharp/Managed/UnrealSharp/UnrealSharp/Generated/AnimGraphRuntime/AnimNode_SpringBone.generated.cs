using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AnimGraphRuntime;

[UStruct]
public partial struct AnimNode_SpringBone
{
    // DoubleProperty /Script/AnimGraphRuntime.AnimNode_SpringBone:MaxDisplacement
    static readonly int MaxDisplacement_Offset;
    public double MaxDisplacement;
    
    
    public static readonly int NativeDataSize;
    static AnimNode_SpringBone()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("AnimNode_SpringBone");
        
        MaxDisplacement_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MaxDisplacement");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public AnimNode_SpringBone(IntPtr InNativeStruct)
    {
        unsafe
        {
            MaxDisplacement = BlittableMarshaller<double>.FromNative(IntPtr.Add(InNativeStruct, MaxDisplacement_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<double>.ToNative(IntPtr.Add(Buffer, MaxDisplacement_Offset), 0, null, MaxDisplacement);
        }
    }
}

public static class AnimNode_SpringBoneMarshaler
{
    public static AnimNode_SpringBone FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new AnimNode_SpringBone(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, AnimNode_SpringBone obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return AnimNode_SpringBone.NativeDataSize;
    }
}