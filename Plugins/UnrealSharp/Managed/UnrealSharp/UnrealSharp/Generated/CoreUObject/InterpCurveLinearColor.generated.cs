using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.CoreUObject;

[UStruct]
public partial struct InterpCurveLinearColor
{
    // BoolProperty /Script/CoreUObject.InterpCurveLinearColor:bIsLooped
    static readonly int bIsLooped_Offset;
    public bool IsLooped;
    
    // FloatProperty /Script/CoreUObject.InterpCurveLinearColor:LoopKeyOffset
    static readonly int LoopKeyOffset_Offset;
    public float LoopKeyOffset;
    
    
    public static readonly int NativeDataSize;
    static InterpCurveLinearColor()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("InterpCurveLinearColor");
        
        bIsLooped_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bIsLooped");
        LoopKeyOffset_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LoopKeyOffset");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public InterpCurveLinearColor(IntPtr InNativeStruct)
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

public static class InterpCurveLinearColorMarshaler
{
    public static InterpCurveLinearColor FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new InterpCurveLinearColor(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, InterpCurveLinearColor obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return InterpCurveLinearColor.NativeDataSize;
    }
}