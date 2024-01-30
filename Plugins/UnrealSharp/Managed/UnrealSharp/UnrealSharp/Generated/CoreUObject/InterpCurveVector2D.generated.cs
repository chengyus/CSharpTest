using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.CoreUObject;

[UStruct]
public partial struct InterpCurveVector2D
{
    // BoolProperty /Script/CoreUObject.InterpCurveVector2D:bIsLooped
    static readonly int bIsLooped_Offset;
    public bool IsLooped;
    
    // FloatProperty /Script/CoreUObject.InterpCurveVector2D:LoopKeyOffset
    static readonly int LoopKeyOffset_Offset;
    public float LoopKeyOffset;
    
    
    public static readonly int NativeDataSize;
    static InterpCurveVector2D()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("InterpCurveVector2D");
        
        bIsLooped_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bIsLooped");
        LoopKeyOffset_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LoopKeyOffset");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public InterpCurveVector2D(IntPtr InNativeStruct)
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

public static class InterpCurveVector2DMarshaler
{
    public static InterpCurveVector2D FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new InterpCurveVector2D(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, InterpCurveVector2D obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return InterpCurveVector2D.NativeDataSize;
    }
}