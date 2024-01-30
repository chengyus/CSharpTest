using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_BlendTransform
{
    // StructProperty /Script/ControlRig.RigUnit_BlendTransform:Source
    static readonly int Source_Offset;
    public UnrealSharp.Transform Source;
    
    // StructProperty /Script/ControlRig.RigUnit_BlendTransform:Result
    static readonly int Result_Offset;
    public UnrealSharp.Transform Result;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_BlendTransform()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_BlendTransform");
        
        Source_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Source");
        Result_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Result");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_BlendTransform(IntPtr InNativeStruct)
    {
        unsafe
        {
            Source = BlittableMarshaller<UnrealSharp.Transform>.FromNative(IntPtr.Add(InNativeStruct, Source_Offset), 0, null);
            Result = BlittableMarshaller<UnrealSharp.Transform>.FromNative(IntPtr.Add(InNativeStruct, Result_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.Transform>.ToNative(IntPtr.Add(Buffer, Source_Offset), 0, null, Source);
            BlittableMarshaller<UnrealSharp.Transform>.ToNative(IntPtr.Add(Buffer, Result_Offset), 0, null, Result);
        }
    }
}

public static class RigUnit_BlendTransformMarshaler
{
    public static RigUnit_BlendTransform FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_BlendTransform(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_BlendTransform obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_BlendTransform.NativeDataSize;
    }
}