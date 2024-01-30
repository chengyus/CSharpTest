using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.CoreUObject;

[UStruct]
public partial struct RandomStream
{
    // IntProperty /Script/CoreUObject.RandomStream:InitialSeed
    static readonly int InitialSeed_Offset;
    public int InitialSeed;
    
    
    public static readonly int NativeDataSize;
    static RandomStream()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RandomStream");
        
        InitialSeed_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "InitialSeed");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RandomStream(IntPtr InNativeStruct)
    {
        unsafe
        {
            InitialSeed = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, InitialSeed_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, InitialSeed_Offset), 0, null, InitialSeed);
        }
    }
}

public static class RandomStreamMarshaler
{
    public static RandomStream FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RandomStream(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RandomStream obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RandomStream.NativeDataSize;
    }
}