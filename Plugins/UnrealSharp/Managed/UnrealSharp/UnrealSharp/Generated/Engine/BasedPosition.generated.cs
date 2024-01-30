using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct BasedPosition
{
    // ObjectProperty /Script/Engine.BasedPosition:Base
    static readonly int Base_Offset;
    public UnrealSharp.Engine.Actor Base;
    
    // StructProperty /Script/Engine.BasedPosition:Position
    static readonly int Position_Offset;
    public System.DoubleNumerics.Vector3 Position;
    
    
    public static readonly int NativeDataSize;
    static BasedPosition()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("BasedPosition");
        
        Base_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Base");
        Position_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Position");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public BasedPosition(IntPtr InNativeStruct)
    {
        unsafe
        {
            Base = ObjectMarshaller<UnrealSharp.Engine.Actor>.FromNative(IntPtr.Add(InNativeStruct, Base_Offset), 0, null);
            Position = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Position_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            ObjectMarshaller<UnrealSharp.Engine.Actor>.ToNative(IntPtr.Add(Buffer, Base_Offset), 0, null, Base);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Position_Offset), 0, null, Position);
        }
    }
}

public static class BasedPositionMarshaler
{
    public static BasedPosition FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new BasedPosition(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, BasedPosition obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return BasedPosition.NativeDataSize;
    }
}