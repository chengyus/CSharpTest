using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.EnhancedInput;

[UStruct]
public partial struct InputActionInstance
{
    // ObjectProperty /Script/EnhancedInput.InputActionInstance:SourceAction
    static readonly int SourceAction_Offset;
    public UnrealSharp.EnhancedInput.InputAction SourceAction;
    
    // EnumProperty /Script/EnhancedInput.InputActionInstance:TriggerEvent
    static readonly int TriggerEvent_Offset;
    public UnrealSharp.EnhancedInput.ETriggerEvent TriggerEvent;
    
    // FloatProperty /Script/EnhancedInput.InputActionInstance:LastTriggeredWorldTime
    static readonly int LastTriggeredWorldTime_Offset;
    public float LastTriggeredWorldTime;
    
    // FloatProperty /Script/EnhancedInput.InputActionInstance:ElapsedProcessedTime
    static readonly int ElapsedProcessedTime_Offset;
    public float ElapsedProcessedTime;
    
    // FloatProperty /Script/EnhancedInput.InputActionInstance:ElapsedTriggeredTime
    static readonly int ElapsedTriggeredTime_Offset;
    public float ElapsedTriggeredTime;
    
    
    public static readonly int NativeDataSize;
    static InputActionInstance()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("InputActionInstance");
        
        SourceAction_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SourceAction");
        TriggerEvent_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "TriggerEvent");
        LastTriggeredWorldTime_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LastTriggeredWorldTime");
        ElapsedProcessedTime_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ElapsedProcessedTime");
        ElapsedTriggeredTime_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ElapsedTriggeredTime");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public InputActionInstance(IntPtr InNativeStruct)
    {
        unsafe
        {
            SourceAction = ObjectMarshaller<UnrealSharp.EnhancedInput.InputAction>.FromNative(IntPtr.Add(InNativeStruct, SourceAction_Offset), 0, null);
            TriggerEvent = BlittableMarshaller<UnrealSharp.EnhancedInput.ETriggerEvent>.FromNative(IntPtr.Add(InNativeStruct, TriggerEvent_Offset), 0, null);
            LastTriggeredWorldTime = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, LastTriggeredWorldTime_Offset), 0, null);
            ElapsedProcessedTime = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, ElapsedProcessedTime_Offset), 0, null);
            ElapsedTriggeredTime = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, ElapsedTriggeredTime_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            ObjectMarshaller<UnrealSharp.EnhancedInput.InputAction>.ToNative(IntPtr.Add(Buffer, SourceAction_Offset), 0, null, SourceAction);
            BlittableMarshaller<UnrealSharp.EnhancedInput.ETriggerEvent>.ToNative(IntPtr.Add(Buffer, TriggerEvent_Offset), 0, null, TriggerEvent);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, LastTriggeredWorldTime_Offset), 0, null, LastTriggeredWorldTime);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, ElapsedProcessedTime_Offset), 0, null, ElapsedProcessedTime);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, ElapsedTriggeredTime_Offset), 0, null, ElapsedTriggeredTime);
        }
    }
}

public static class InputActionInstanceMarshaler
{
    public static InputActionInstance FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new InputActionInstance(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, InputActionInstance obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return InputActionInstance.NativeDataSize;
    }
}