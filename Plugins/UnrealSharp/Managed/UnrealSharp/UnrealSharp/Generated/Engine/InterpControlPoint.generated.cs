using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct InterpControlPoint
{
    // StructProperty /Script/Engine.InterpControlPoint:PositionControlPoint
    static readonly int PositionControlPoint_Offset;
    public System.DoubleNumerics.Vector3 PositionControlPoint;
    
    // BoolProperty /Script/Engine.InterpControlPoint:bPositionIsRelative
    static readonly int bPositionIsRelative_Offset;
    public bool PositionIsRelative;
    
    
    public static readonly int NativeDataSize;
    static InterpControlPoint()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("InterpControlPoint");
        
        PositionControlPoint_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PositionControlPoint");
        bPositionIsRelative_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bPositionIsRelative");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public InterpControlPoint(IntPtr InNativeStruct)
    {
        unsafe
        {
            PositionControlPoint = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, PositionControlPoint_Offset), 0, null);
            PositionIsRelative = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bPositionIsRelative_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, PositionControlPoint_Offset), 0, null, PositionControlPoint);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bPositionIsRelative_Offset), 0, null, PositionIsRelative);
        }
    }
}

public static class InterpControlPointMarshaler
{
    public static InterpControlPoint FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new InterpControlPoint(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, InterpControlPoint obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return InterpControlPoint.NativeDataSize;
    }
}