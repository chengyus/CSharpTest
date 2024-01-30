using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct WalkableSlopeOverride
{
    // ByteProperty /Script/Engine.WalkableSlopeOverride:WalkableSlopeBehavior
    static readonly int WalkableSlopeBehavior_Offset;
    public UnrealSharp.Engine.EWalkableSlopeBehavior WalkableSlopeBehavior;
    
    // FloatProperty /Script/Engine.WalkableSlopeOverride:WalkableSlopeAngle
    static readonly int WalkableSlopeAngle_Offset;
    public float WalkableSlopeAngle;
    
    
    public static readonly int NativeDataSize;
    static WalkableSlopeOverride()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("WalkableSlopeOverride");
        
        WalkableSlopeBehavior_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "WalkableSlopeBehavior");
        WalkableSlopeAngle_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "WalkableSlopeAngle");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public WalkableSlopeOverride(IntPtr InNativeStruct)
    {
        unsafe
        {
            WalkableSlopeBehavior = BlittableMarshaller<UnrealSharp.Engine.EWalkableSlopeBehavior>.FromNative(IntPtr.Add(InNativeStruct, WalkableSlopeBehavior_Offset), 0, null);
            WalkableSlopeAngle = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, WalkableSlopeAngle_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.Engine.EWalkableSlopeBehavior>.ToNative(IntPtr.Add(Buffer, WalkableSlopeBehavior_Offset), 0, null, WalkableSlopeBehavior);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, WalkableSlopeAngle_Offset), 0, null, WalkableSlopeAngle);
        }
    }
}

public static class WalkableSlopeOverrideMarshaler
{
    public static WalkableSlopeOverride FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new WalkableSlopeOverride(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, WalkableSlopeOverride obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return WalkableSlopeOverride.NativeDataSize;
    }
}