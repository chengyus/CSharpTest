using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AnimGraphRuntime;

[UStruct]
public partial struct AnimNode_RotationMultiplier
{
    // FloatProperty /Script/AnimGraphRuntime.AnimNode_RotationMultiplier:Multiplier
    static readonly int Multiplier_Offset;
    public float Multiplier;
    
    
    public static readonly int NativeDataSize;
    static AnimNode_RotationMultiplier()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("AnimNode_RotationMultiplier");
        
        Multiplier_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Multiplier");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public AnimNode_RotationMultiplier(IntPtr InNativeStruct)
    {
        unsafe
        {
            Multiplier = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Multiplier_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Multiplier_Offset), 0, null, Multiplier);
        }
    }
}

public static class AnimNode_RotationMultiplierMarshaler
{
    public static AnimNode_RotationMultiplier FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new AnimNode_RotationMultiplier(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, AnimNode_RotationMultiplier obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return AnimNode_RotationMultiplier.NativeDataSize;
    }
}