using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.CoreUObject;

[UStruct]
public partial struct FrameNumberRangeBound
{
    // ByteProperty /Script/CoreUObject.FrameNumberRangeBound:Type
    static readonly int Type_Offset;
    public UnrealSharp.CoreUObject.ERangeBoundTypes Type;
    
    // StructProperty /Script/CoreUObject.FrameNumberRangeBound:Value
    static readonly int Value_Offset;
    public UnrealSharp.CoreUObject.FrameNumber Value;
    
    
    public static readonly int NativeDataSize;
    static FrameNumberRangeBound()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("FrameNumberRangeBound");
        
        Type_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Type");
        Value_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Value");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public FrameNumberRangeBound(IntPtr InNativeStruct)
    {
        unsafe
        {
            Type = BlittableMarshaller<UnrealSharp.CoreUObject.ERangeBoundTypes>.FromNative(IntPtr.Add(InNativeStruct, Type_Offset), 0, null);
            Value = BlittableMarshaller<UnrealSharp.CoreUObject.FrameNumber>.FromNative(IntPtr.Add(InNativeStruct, Value_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.CoreUObject.ERangeBoundTypes>.ToNative(IntPtr.Add(Buffer, Type_Offset), 0, null, Type);
            BlittableMarshaller<UnrealSharp.CoreUObject.FrameNumber>.ToNative(IntPtr.Add(Buffer, Value_Offset), 0, null, Value);
        }
    }
}

public static class FrameNumberRangeBoundMarshaler
{
    public static FrameNumberRangeBound FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new FrameNumberRangeBound(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, FrameNumberRangeBound obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return FrameNumberRangeBound.NativeDataSize;
    }
}