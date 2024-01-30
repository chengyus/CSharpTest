using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct WeightedBlendable
{
    // FloatProperty /Script/Engine.WeightedBlendable:Weight
    static readonly int Weight_Offset;
    public float Weight;
    
    // ObjectProperty /Script/Engine.WeightedBlendable:Object
    static readonly int Object_Offset;
    public UnrealSharp.CoreUObject.Object Object;
    
    
    public static readonly int NativeDataSize;
    static WeightedBlendable()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("WeightedBlendable");
        
        Weight_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Weight");
        Object_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Object");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public WeightedBlendable(IntPtr InNativeStruct)
    {
        unsafe
        {
            Weight = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Weight_Offset), 0, null);
            Object = ObjectMarshaller<UnrealSharp.CoreUObject.Object>.FromNative(IntPtr.Add(InNativeStruct, Object_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Weight_Offset), 0, null, Weight);
            ObjectMarshaller<UnrealSharp.CoreUObject.Object>.ToNative(IntPtr.Add(Buffer, Object_Offset), 0, null, Object);
        }
    }
}

public static class WeightedBlendableMarshaler
{
    public static WeightedBlendable FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new WeightedBlendable(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, WeightedBlendable obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return WeightedBlendable.NativeDataSize;
    }
}