using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Overlay;

[UStruct]
public partial struct OverlayItem
{
    // StructProperty /Script/Overlay.OverlayItem:StartTime
    static readonly int StartTime_Offset;
    public UnrealSharp.CoreUObject.Timespan StartTime;
    
    // StructProperty /Script/Overlay.OverlayItem:EndTime
    static readonly int EndTime_Offset;
    public UnrealSharp.CoreUObject.Timespan EndTime;
    
    // StructProperty /Script/Overlay.OverlayItem:Position
    static readonly int Position_Offset;
    public System.DoubleNumerics.Vector2 Position;
    
    
    public static readonly int NativeDataSize;
    static OverlayItem()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("OverlayItem");
        
        StartTime_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "StartTime");
        EndTime_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "EndTime");
        Position_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Position");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public OverlayItem(IntPtr InNativeStruct)
    {
        unsafe
        {
            StartTime = UnrealSharp.CoreUObject.TimespanMarshaler.FromNative(IntPtr.Add(InNativeStruct, StartTime_Offset), 0, null);
            EndTime = UnrealSharp.CoreUObject.TimespanMarshaler.FromNative(IntPtr.Add(InNativeStruct, EndTime_Offset), 0, null);
            Position = BlittableMarshaller<System.DoubleNumerics.Vector2>.FromNative(IntPtr.Add(InNativeStruct, Position_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.CoreUObject.TimespanMarshaler.ToNative(IntPtr.Add(Buffer, StartTime_Offset), 0, null, StartTime);
            UnrealSharp.CoreUObject.TimespanMarshaler.ToNative(IntPtr.Add(Buffer, EndTime_Offset), 0, null, EndTime);
            BlittableMarshaller<System.DoubleNumerics.Vector2>.ToNative(IntPtr.Add(Buffer, Position_Offset), 0, null, Position);
        }
    }
}

public static class OverlayItemMarshaler
{
    public static OverlayItem FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new OverlayItem(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, OverlayItem obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return OverlayItem.NativeDataSize;
    }
}