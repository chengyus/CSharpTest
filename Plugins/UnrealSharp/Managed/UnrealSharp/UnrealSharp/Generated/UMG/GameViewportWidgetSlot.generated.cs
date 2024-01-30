using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.UMG;

[UStruct]
public partial struct GameViewportWidgetSlot
{
    // StructProperty /Script/UMG.GameViewportWidgetSlot:Anchors
    static readonly int Anchors_Offset;
    public UnrealSharp.Slate.Anchors Anchors;
    
    // StructProperty /Script/UMG.GameViewportWidgetSlot:Offsets
    static readonly int Offsets_Offset;
    public UnrealSharp.SlateCore.Margin Offsets;
    
    // StructProperty /Script/UMG.GameViewportWidgetSlot:Alignment
    static readonly int Alignment_Offset;
    public System.DoubleNumerics.Vector2 Alignment;
    
    // IntProperty /Script/UMG.GameViewportWidgetSlot:ZOrder
    static readonly int ZOrder_Offset;
    public int ZOrder;
    
    
    public static readonly int NativeDataSize;
    static GameViewportWidgetSlot()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("GameViewportWidgetSlot");
        
        Anchors_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Anchors");
        Offsets_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Offsets");
        Alignment_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Alignment");
        ZOrder_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ZOrder");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public GameViewportWidgetSlot(IntPtr InNativeStruct)
    {
        unsafe
        {
            Anchors = BlittableMarshaller<UnrealSharp.Slate.Anchors>.FromNative(IntPtr.Add(InNativeStruct, Anchors_Offset), 0, null);
            Offsets = BlittableMarshaller<UnrealSharp.SlateCore.Margin>.FromNative(IntPtr.Add(InNativeStruct, Offsets_Offset), 0, null);
            Alignment = BlittableMarshaller<System.DoubleNumerics.Vector2>.FromNative(IntPtr.Add(InNativeStruct, Alignment_Offset), 0, null);
            ZOrder = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, ZOrder_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.Slate.Anchors>.ToNative(IntPtr.Add(Buffer, Anchors_Offset), 0, null, Anchors);
            BlittableMarshaller<UnrealSharp.SlateCore.Margin>.ToNative(IntPtr.Add(Buffer, Offsets_Offset), 0, null, Offsets);
            BlittableMarshaller<System.DoubleNumerics.Vector2>.ToNative(IntPtr.Add(Buffer, Alignment_Offset), 0, null, Alignment);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, ZOrder_Offset), 0, null, ZOrder);
        }
    }
}

public static class GameViewportWidgetSlotMarshaler
{
    public static GameViewportWidgetSlot FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new GameViewportWidgetSlot(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, GameViewportWidgetSlot obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return GameViewportWidgetSlot.NativeDataSize;
    }
}