using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.EnhancedInput;

[UStruct]
public partial struct InputComboStepData
{
    // ObjectProperty /Script/EnhancedInput.InputComboStepData:ComboStepAction
    static readonly int ComboStepAction_Offset;
    public UnrealSharp.EnhancedInput.InputAction ComboStepAction;
    
    // ByteProperty /Script/EnhancedInput.InputComboStepData:ComboStepCompletionStates
    static readonly int ComboStepCompletionStates_Offset;
    public byte ComboStepCompletionStates;
    
    // FloatProperty /Script/EnhancedInput.InputComboStepData:TimeToPressKey
    static readonly int TimeToPressKey_Offset;
    public float TimeToPressKey;
    
    
    public static readonly int NativeDataSize;
    static InputComboStepData()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("InputComboStepData");
        
        ComboStepAction_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ComboStepAction");
        ComboStepCompletionStates_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ComboStepCompletionStates");
        TimeToPressKey_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "TimeToPressKey");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public InputComboStepData(IntPtr InNativeStruct)
    {
        unsafe
        {
            ComboStepAction = ObjectMarshaller<UnrealSharp.EnhancedInput.InputAction>.FromNative(IntPtr.Add(InNativeStruct, ComboStepAction_Offset), 0, null);
            ComboStepCompletionStates = BlittableMarshaller<byte>.FromNative(IntPtr.Add(InNativeStruct, ComboStepCompletionStates_Offset), 0, null);
            TimeToPressKey = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, TimeToPressKey_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            ObjectMarshaller<UnrealSharp.EnhancedInput.InputAction>.ToNative(IntPtr.Add(Buffer, ComboStepAction_Offset), 0, null, ComboStepAction);
            BlittableMarshaller<byte>.ToNative(IntPtr.Add(Buffer, ComboStepCompletionStates_Offset), 0, null, ComboStepCompletionStates);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, TimeToPressKey_Offset), 0, null, TimeToPressKey);
        }
    }
}

public static class InputComboStepDataMarshaler
{
    public static InputComboStepData FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new InputComboStepData(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, InputComboStepData obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return InputComboStepData.NativeDataSize;
    }
}