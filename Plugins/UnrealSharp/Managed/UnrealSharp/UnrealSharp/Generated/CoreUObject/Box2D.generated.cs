using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.CoreUObject;

[UStruct]
public partial struct Box2D
{
    // StructProperty /Script/CoreUObject.Box2D:Min
    static readonly int Min_Offset;
    public System.DoubleNumerics.Vector2 Min;
    
    // StructProperty /Script/CoreUObject.Box2D:Max
    static readonly int Max_Offset;
    public System.DoubleNumerics.Vector2 Max;
    
    // BoolProperty /Script/CoreUObject.Box2D:bIsValid
    static readonly int bIsValid_Offset;
    public bool IsValid;
    
    
    public static readonly int NativeDataSize;
    static Box2D()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("Box2D");
        
        Min_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Min");
        Max_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Max");
        bIsValid_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bIsValid");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public Box2D(IntPtr InNativeStruct)
    {
        unsafe
        {
            Min = BlittableMarshaller<System.DoubleNumerics.Vector2>.FromNative(IntPtr.Add(InNativeStruct, Min_Offset), 0, null);
            Max = BlittableMarshaller<System.DoubleNumerics.Vector2>.FromNative(IntPtr.Add(InNativeStruct, Max_Offset), 0, null);
            IsValid = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bIsValid_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<System.DoubleNumerics.Vector2>.ToNative(IntPtr.Add(Buffer, Min_Offset), 0, null, Min);
            BlittableMarshaller<System.DoubleNumerics.Vector2>.ToNative(IntPtr.Add(Buffer, Max_Offset), 0, null, Max);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bIsValid_Offset), 0, null, IsValid);
        }
    }
}

public static class Box2DMarshaler
{
    public static Box2D FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new Box2D(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, Box2D obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return Box2D.NativeDataSize;
    }
}