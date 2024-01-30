using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ViewportInteraction;

[UStruct]
public partial struct ViewportActionKeyInput
{
    // NameProperty /Script/ViewportInteraction.ViewportActionKeyInput:ActionType
    static readonly int ActionType_Offset;
    public Name ActionType;
    
    // ByteProperty /Script/ViewportInteraction.ViewportActionKeyInput:Event
    static readonly int Event_Offset;
    public UnrealSharp.Engine.EInputEvent Event;
    
    
    public static readonly int NativeDataSize;
    static ViewportActionKeyInput()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("ViewportActionKeyInput");
        
        ActionType_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ActionType");
        Event_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Event");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public ViewportActionKeyInput(IntPtr InNativeStruct)
    {
        unsafe
        {
            ActionType = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, ActionType_Offset), 0, null);
            Event = BlittableMarshaller<UnrealSharp.Engine.EInputEvent>.FromNative(IntPtr.Add(InNativeStruct, Event_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, ActionType_Offset), 0, null, ActionType);
            BlittableMarshaller<UnrealSharp.Engine.EInputEvent>.ToNative(IntPtr.Add(Buffer, Event_Offset), 0, null, Event);
        }
    }
}

public static class ViewportActionKeyInputMarshaler
{
    public static ViewportActionKeyInput FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new ViewportActionKeyInput(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, ViewportActionKeyInput obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return ViewportActionKeyInput.NativeDataSize;
    }
}