using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AnimGraphRuntime;

[UStruct]
public partial struct WarpingVectorValue
{
    // EnumProperty /Script/AnimGraphRuntime.WarpingVectorValue:Mode
    static readonly int Mode_Offset;
    public UnrealSharp.AnimGraphRuntime.EWarpingVectorMode Mode;
    
    // StructProperty /Script/AnimGraphRuntime.WarpingVectorValue:Value
    static readonly int Value_Offset;
    public System.DoubleNumerics.Vector3 Value;
    
    
    public static readonly int NativeDataSize;
    static WarpingVectorValue()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("WarpingVectorValue");
        
        Mode_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Mode");
        Value_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Value");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public WarpingVectorValue(IntPtr InNativeStruct)
    {
        unsafe
        {
            Mode = BlittableMarshaller<UnrealSharp.AnimGraphRuntime.EWarpingVectorMode>.FromNative(IntPtr.Add(InNativeStruct, Mode_Offset), 0, null);
            Value = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Value_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.AnimGraphRuntime.EWarpingVectorMode>.ToNative(IntPtr.Add(Buffer, Mode_Offset), 0, null, Mode);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Value_Offset), 0, null, Value);
        }
    }
}

public static class WarpingVectorValueMarshaler
{
    public static WarpingVectorValue FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new WarpingVectorValue(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, WarpingVectorValue obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return WarpingVectorValue.NativeDataSize;
    }
}