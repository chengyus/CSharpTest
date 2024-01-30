using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.CoreUObject;

[UStruct]
public partial struct DoubleRangeBound
{
    // ByteProperty /Script/CoreUObject.DoubleRangeBound:Type
    static readonly int Type_Offset;
    public UnrealSharp.CoreUObject.ERangeBoundTypes Type;
    
    // DoubleProperty /Script/CoreUObject.DoubleRangeBound:Value
    static readonly int Value_Offset;
    public double Value;
    
    
    public static readonly int NativeDataSize;
    static DoubleRangeBound()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("DoubleRangeBound");
        
        Type_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Type");
        Value_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Value");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public DoubleRangeBound(IntPtr InNativeStruct)
    {
        unsafe
        {
            Type = BlittableMarshaller<UnrealSharp.CoreUObject.ERangeBoundTypes>.FromNative(IntPtr.Add(InNativeStruct, Type_Offset), 0, null);
            Value = BlittableMarshaller<double>.FromNative(IntPtr.Add(InNativeStruct, Value_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.CoreUObject.ERangeBoundTypes>.ToNative(IntPtr.Add(Buffer, Type_Offset), 0, null, Type);
            BlittableMarshaller<double>.ToNative(IntPtr.Add(Buffer, Value_Offset), 0, null, Value);
        }
    }
}

public static class DoubleRangeBoundMarshaler
{
    public static DoubleRangeBound FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new DoubleRangeBound(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, DoubleRangeBound obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return DoubleRangeBound.NativeDataSize;
    }
}