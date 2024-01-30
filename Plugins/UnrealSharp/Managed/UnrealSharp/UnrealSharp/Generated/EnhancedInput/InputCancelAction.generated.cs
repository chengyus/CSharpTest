using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.EnhancedInput;

[UStruct]
public partial struct InputCancelAction
{
    // ObjectProperty /Script/EnhancedInput.InputCancelAction:CancelAction
    static readonly int CancelAction_Offset;
    public UnrealSharp.EnhancedInput.InputAction CancelAction;
    
    // ByteProperty /Script/EnhancedInput.InputCancelAction:CancellationStates
    static readonly int CancellationStates_Offset;
    public byte CancellationStates;
    
    
    public static readonly int NativeDataSize;
    static InputCancelAction()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("InputCancelAction");
        
        CancelAction_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "CancelAction");
        CancellationStates_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "CancellationStates");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public InputCancelAction(IntPtr InNativeStruct)
    {
        unsafe
        {
            CancelAction = ObjectMarshaller<UnrealSharp.EnhancedInput.InputAction>.FromNative(IntPtr.Add(InNativeStruct, CancelAction_Offset), 0, null);
            CancellationStates = BlittableMarshaller<byte>.FromNative(IntPtr.Add(InNativeStruct, CancellationStates_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            ObjectMarshaller<UnrealSharp.EnhancedInput.InputAction>.ToNative(IntPtr.Add(Buffer, CancelAction_Offset), 0, null, CancelAction);
            BlittableMarshaller<byte>.ToNative(IntPtr.Add(Buffer, CancellationStates_Offset), 0, null, CancellationStates);
        }
    }
}

public static class InputCancelActionMarshaler
{
    public static InputCancelAction FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new InputCancelAction(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, InputCancelAction obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return InputCancelAction.NativeDataSize;
    }
}