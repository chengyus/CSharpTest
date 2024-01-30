using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.CoreUObject;

[UStruct]
public partial struct InterpCurveTwoVectors
{
    // BoolProperty /Script/CoreUObject.InterpCurveTwoVectors:bIsLooped
    static readonly int bIsLooped_Offset;
    public bool IsLooped;
    
    // FloatProperty /Script/CoreUObject.InterpCurveTwoVectors:LoopKeyOffset
    static readonly int LoopKeyOffset_Offset;
    public float LoopKeyOffset;
    
    
    public static readonly int NativeDataSize;
    static InterpCurveTwoVectors()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("InterpCurveTwoVectors");
        
        bIsLooped_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bIsLooped");
        LoopKeyOffset_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LoopKeyOffset");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public InterpCurveTwoVectors(IntPtr InNativeStruct)
    {
        unsafe
        {
            IsLooped = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bIsLooped_Offset), 0, null);
            LoopKeyOffset = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, LoopKeyOffset_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bIsLooped_Offset), 0, null, IsLooped);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, LoopKeyOffset_Offset), 0, null, LoopKeyOffset);
        }
    }
}

public static class InterpCurveTwoVectorsMarshaler
{
    public static InterpCurveTwoVectors FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new InterpCurveTwoVectors(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, InterpCurveTwoVectors obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return InterpCurveTwoVectors.NativeDataSize;
    }
}