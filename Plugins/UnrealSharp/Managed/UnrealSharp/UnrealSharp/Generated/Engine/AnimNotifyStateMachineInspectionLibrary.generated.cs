// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UClass]
public partial class UAnimNotifyStateMachineInspectionLibrary : UnrealSharp.Engine.BlueprintFunctionLibrary
{
    
    static readonly IntPtr NativeClassPtr;
    static UAnimNotifyStateMachineInspectionLibrary()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("AnimNotifyStateMachineInspectionLibrary");
        
        
        IsTriggeredByStateMachine_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "IsTriggeredByStateMachine");
        IsTriggeredByStateMachine_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(IsTriggeredByStateMachine_NativeFunction);
        IsTriggeredByStateMachine_EventReference_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(IsTriggeredByStateMachine_NativeFunction, "EventReference");
        IsTriggeredByStateMachine_AnimInstance_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(IsTriggeredByStateMachine_NativeFunction, "AnimInstance");
        IsTriggeredByStateMachine_StateMachineName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(IsTriggeredByStateMachine_NativeFunction, "StateMachineName");
        IsTriggeredByStateMachine_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(IsTriggeredByStateMachine_NativeFunction, "ReturnValue");
        IsTriggeredByStateInStateMachine_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "IsTriggeredByStateInStateMachine");
        IsTriggeredByStateInStateMachine_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(IsTriggeredByStateInStateMachine_NativeFunction);
        IsTriggeredByStateInStateMachine_EventReference_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(IsTriggeredByStateInStateMachine_NativeFunction, "EventReference");
        IsTriggeredByStateInStateMachine_AnimInstance_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(IsTriggeredByStateInStateMachine_NativeFunction, "AnimInstance");
        IsTriggeredByStateInStateMachine_StateMachineName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(IsTriggeredByStateInStateMachine_NativeFunction, "StateMachineName");
        IsTriggeredByStateInStateMachine_StateName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(IsTriggeredByStateInStateMachine_NativeFunction, "StateName");
        IsTriggeredByStateInStateMachine_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(IsTriggeredByStateInStateMachine_NativeFunction, "ReturnValue");
        IsTriggeredByState_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "IsTriggeredByState");
        IsTriggeredByState_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(IsTriggeredByState_NativeFunction);
        IsTriggeredByState_EventReference_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(IsTriggeredByState_NativeFunction, "EventReference");
        IsTriggeredByState_AnimInstance_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(IsTriggeredByState_NativeFunction, "AnimInstance");
        IsTriggeredByState_StateName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(IsTriggeredByState_NativeFunction, "StateName");
        IsTriggeredByState_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(IsTriggeredByState_NativeFunction, "ReturnValue");
        
        
    }
    
    protected UAnimNotifyStateMachineInspectionLibrary(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // Function /Script/Engine.AnimNotifyStateMachineInspectionLibrary:IsTriggeredByStateMachine
    static readonly IntPtr IsTriggeredByStateMachine_NativeFunction;
    static readonly int IsTriggeredByStateMachine_ParamsSize;
    static readonly int IsTriggeredByStateMachine_EventReference_Offset;
    static readonly int IsTriggeredByStateMachine_AnimInstance_Offset;
    static readonly int IsTriggeredByStateMachine_StateMachineName_Offset;
    static readonly int IsTriggeredByStateMachine_ReturnValue_Offset;
    
    public static bool IsTriggeredByStateMachine(UnrealSharp.Engine.AnimNotifyEventReference eventReference, UnrealSharp.Engine.AnimInstance animInstance, Name stateMachineName)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[IsTriggeredByStateMachine_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            UnrealSharp.Engine.AnimNotifyEventReferenceMarshaler.ToNative(IntPtr.Add(ParamsBuffer, IsTriggeredByStateMachine_EventReference_Offset), 0, null, eventReference);
            ObjectMarshaller<UnrealSharp.Engine.AnimInstance>.ToNative(IntPtr.Add(ParamsBuffer, IsTriggeredByStateMachine_AnimInstance_Offset), 0, null, animInstance);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(ParamsBuffer, IsTriggeredByStateMachine_StateMachineName_Offset), 0, null, stateMachineName);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, IsTriggeredByStateMachine_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, IsTriggeredByStateMachine_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/Engine.AnimNotifyStateMachineInspectionLibrary:IsTriggeredByStateInStateMachine
    static readonly IntPtr IsTriggeredByStateInStateMachine_NativeFunction;
    static readonly int IsTriggeredByStateInStateMachine_ParamsSize;
    static readonly int IsTriggeredByStateInStateMachine_EventReference_Offset;
    static readonly int IsTriggeredByStateInStateMachine_AnimInstance_Offset;
    static readonly int IsTriggeredByStateInStateMachine_StateMachineName_Offset;
    static readonly int IsTriggeredByStateInStateMachine_StateName_Offset;
    static readonly int IsTriggeredByStateInStateMachine_ReturnValue_Offset;
    
    public static bool IsTriggeredByStateInStateMachine(UnrealSharp.Engine.AnimNotifyEventReference eventReference, UnrealSharp.Engine.AnimInstance animInstance, Name stateMachineName, Name stateName)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[IsTriggeredByStateInStateMachine_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            UnrealSharp.Engine.AnimNotifyEventReferenceMarshaler.ToNative(IntPtr.Add(ParamsBuffer, IsTriggeredByStateInStateMachine_EventReference_Offset), 0, null, eventReference);
            ObjectMarshaller<UnrealSharp.Engine.AnimInstance>.ToNative(IntPtr.Add(ParamsBuffer, IsTriggeredByStateInStateMachine_AnimInstance_Offset), 0, null, animInstance);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(ParamsBuffer, IsTriggeredByStateInStateMachine_StateMachineName_Offset), 0, null, stateMachineName);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(ParamsBuffer, IsTriggeredByStateInStateMachine_StateName_Offset), 0, null, stateName);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, IsTriggeredByStateInStateMachine_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, IsTriggeredByStateInStateMachine_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/Engine.AnimNotifyStateMachineInspectionLibrary:IsTriggeredByState
    static readonly IntPtr IsTriggeredByState_NativeFunction;
    static readonly int IsTriggeredByState_ParamsSize;
    static readonly int IsTriggeredByState_EventReference_Offset;
    static readonly int IsTriggeredByState_AnimInstance_Offset;
    static readonly int IsTriggeredByState_StateName_Offset;
    static readonly int IsTriggeredByState_ReturnValue_Offset;
    
    public static bool IsTriggeredByState(UnrealSharp.Engine.AnimNotifyEventReference eventReference, UnrealSharp.Engine.AnimInstance animInstance, Name stateName)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[IsTriggeredByState_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            UnrealSharp.Engine.AnimNotifyEventReferenceMarshaler.ToNative(IntPtr.Add(ParamsBuffer, IsTriggeredByState_EventReference_Offset), 0, null, eventReference);
            ObjectMarshaller<UnrealSharp.Engine.AnimInstance>.ToNative(IntPtr.Add(ParamsBuffer, IsTriggeredByState_AnimInstance_Offset), 0, null, animInstance);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(ParamsBuffer, IsTriggeredByState_StateName_Offset), 0, null, stateName);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, IsTriggeredByState_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, IsTriggeredByState_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    
}