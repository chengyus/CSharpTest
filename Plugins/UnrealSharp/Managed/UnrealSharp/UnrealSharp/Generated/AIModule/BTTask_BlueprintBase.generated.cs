// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AIModule;

[UClass]
abstract public partial class BTTask_BlueprintBase : UnrealSharp.AIModule.BTTaskNode
{
    
    static BTTask_BlueprintBase()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("BTTask_BlueprintBase");
        
        CustomDescription_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "CustomDescription");
        CustomDescription_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "CustomDescription");
        
        SetFinishOnMessageWithId_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetFinishOnMessageWithId");
        SetFinishOnMessageWithId_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetFinishOnMessageWithId_NativeFunction);
        SetFinishOnMessageWithId_MessageName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetFinishOnMessageWithId_NativeFunction, "MessageName");
        SetFinishOnMessageWithId_RequestID_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetFinishOnMessageWithId_NativeFunction, "RequestID");
        SetFinishOnMessage_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetFinishOnMessage");
        SetFinishOnMessage_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetFinishOnMessage_NativeFunction);
        SetFinishOnMessage_MessageName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetFinishOnMessage_NativeFunction, "MessageName");
        IsTaskExecuting_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "IsTaskExecuting");
        IsTaskExecuting_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(IsTaskExecuting_NativeFunction);
        IsTaskExecuting_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(IsTaskExecuting_NativeFunction, "ReturnValue");
        IsTaskAborting_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "IsTaskAborting");
        IsTaskAborting_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(IsTaskAborting_NativeFunction);
        IsTaskAborting_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(IsTaskAborting_NativeFunction, "ReturnValue");
        FinishExecute_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "FinishExecute");
        FinishExecute_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(FinishExecute_NativeFunction);
        FinishExecute_bSuccess_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(FinishExecute_NativeFunction, "bSuccess");
        FinishAbort_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "FinishAbort");
        
        IntPtr ReceiveTickAI_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "ReceiveTickAI");
        ReceiveTickAI_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(ReceiveTickAI_NativeFunction);
        ReceiveTickAI_OwnerController_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ReceiveTickAI_NativeFunction, "OwnerController");
        ReceiveTickAI_ControlledPawn_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ReceiveTickAI_NativeFunction, "ControlledPawn");
        ReceiveTickAI_DeltaSeconds_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ReceiveTickAI_NativeFunction, "DeltaSeconds");
        
        IntPtr ReceiveTick_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "ReceiveTick");
        ReceiveTick_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(ReceiveTick_NativeFunction);
        ReceiveTick_OwnerActor_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ReceiveTick_NativeFunction, "OwnerActor");
        ReceiveTick_DeltaSeconds_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ReceiveTick_NativeFunction, "DeltaSeconds");
        
        IntPtr ReceiveExecuteAI_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "ReceiveExecuteAI");
        ReceiveExecuteAI_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(ReceiveExecuteAI_NativeFunction);
        ReceiveExecuteAI_OwnerController_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ReceiveExecuteAI_NativeFunction, "OwnerController");
        ReceiveExecuteAI_ControlledPawn_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ReceiveExecuteAI_NativeFunction, "ControlledPawn");
        
        IntPtr ReceiveExecute_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "ReceiveExecute");
        ReceiveExecute_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(ReceiveExecute_NativeFunction);
        ReceiveExecute_OwnerActor_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ReceiveExecute_NativeFunction, "OwnerActor");
        
        IntPtr ReceiveAbortAI_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "ReceiveAbortAI");
        ReceiveAbortAI_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(ReceiveAbortAI_NativeFunction);
        ReceiveAbortAI_OwnerController_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ReceiveAbortAI_NativeFunction, "OwnerController");
        ReceiveAbortAI_ControlledPawn_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ReceiveAbortAI_NativeFunction, "ControlledPawn");
        
        IntPtr ReceiveAbort_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "ReceiveAbort");
        ReceiveAbort_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(ReceiveAbort_NativeFunction);
        ReceiveAbort_OwnerActor_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ReceiveAbort_NativeFunction, "OwnerActor");
        
        
    }
    
    protected BTTask_BlueprintBase(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // StrProperty /Script/AIModule.BTTask_BlueprintBase:CustomDescription
    static readonly int CustomDescription_Offset;
    static readonly IntPtr CustomDescription_NativeProperty;
    
    public string CustomDescription
    {
        get
        {
            CheckObjectForValidity();
            return StringMarshaller.FromNative(IntPtr.Add(NativeObject,CustomDescription_Offset),0,this);
        }
        set
        {
            CheckObjectForValidity();
            StringMarshaller.ToNative(IntPtr.Add(NativeObject,CustomDescription_Offset),0,this,value);
        }
    }
    
    // Function /Script/AIModule.BTTask_BlueprintBase:SetFinishOnMessageWithId
    static readonly IntPtr SetFinishOnMessageWithId_NativeFunction;
    static readonly int SetFinishOnMessageWithId_ParamsSize;
    static readonly int SetFinishOnMessageWithId_MessageName_Offset;
    static readonly int SetFinishOnMessageWithId_RequestID_Offset;
    
    protected void SetFinishOnMessageWithId(Name messageName, int requestID = -1)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetFinishOnMessageWithId_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(ParamsBuffer, SetFinishOnMessageWithId_MessageName_Offset), 0, null, messageName);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(ParamsBuffer, SetFinishOnMessageWithId_RequestID_Offset), 0, null, requestID);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetFinishOnMessageWithId_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/AIModule.BTTask_BlueprintBase:SetFinishOnMessage
    static readonly IntPtr SetFinishOnMessage_NativeFunction;
    static readonly int SetFinishOnMessage_ParamsSize;
    static readonly int SetFinishOnMessage_MessageName_Offset;
    
    protected void SetFinishOnMessage(Name messageName)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetFinishOnMessage_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(ParamsBuffer, SetFinishOnMessage_MessageName_Offset), 0, null, messageName);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetFinishOnMessage_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/AIModule.BTTask_BlueprintBase:IsTaskExecuting
    static readonly IntPtr IsTaskExecuting_NativeFunction;
    static readonly int IsTaskExecuting_ParamsSize;
    static readonly int IsTaskExecuting_ReturnValue_Offset;
    
    protected bool IsTaskExecuting()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[IsTaskExecuting_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, IsTaskExecuting_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, IsTaskExecuting_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/AIModule.BTTask_BlueprintBase:IsTaskAborting
    static readonly IntPtr IsTaskAborting_NativeFunction;
    static readonly int IsTaskAborting_ParamsSize;
    static readonly int IsTaskAborting_ReturnValue_Offset;
    
    protected bool IsTaskAborting()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[IsTaskAborting_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, IsTaskAborting_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, IsTaskAborting_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/AIModule.BTTask_BlueprintBase:FinishExecute
    static readonly IntPtr FinishExecute_NativeFunction;
    static readonly int FinishExecute_ParamsSize;
    static readonly int FinishExecute_bSuccess_Offset;
    
    protected void FinishExecute(bool bSuccess)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[FinishExecute_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BoolMarshaller.ToNative(IntPtr.Add(ParamsBuffer, FinishExecute_bSuccess_Offset), 0, null, bSuccess);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, FinishExecute_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/AIModule.BTTask_BlueprintBase:FinishAbort
    static readonly IntPtr FinishAbort_NativeFunction;
    
    protected void FinishAbort()
    {
        unsafe
        {
            UObjectExporter.CallInvokeNativeFunction(NativeObject, FinishAbort_NativeFunction, IntPtr.Zero);
        }
    }
    
    // Function /Script/AIModule.BTTask_BlueprintBase:ReceiveTickAI
    IntPtr ReceiveTickAI_NativeFunction;
    static readonly int ReceiveTickAI_ParamsSize;
    static readonly int ReceiveTickAI_OwnerController_Offset;
    static readonly int ReceiveTickAI_ControlledPawn_Offset;
    static readonly int ReceiveTickAI_DeltaSeconds_Offset;
    
    [UFunction(FunctionFlags.BlueprintEvent)]
    protected virtual void ReceiveTickAI(UnrealSharp.AIModule.AIController ownerController, UnrealSharp.Engine.Pawn controlledPawn, float deltaSeconds)
    {
        unsafe
        {
            if (ReceiveTickAI_NativeFunction == IntPtr.Zero)
            {
                ReceiveTickAI_NativeFunction = UClassExporter.CallGetNativeFunctionFromInstanceAndName(NativeObject, "ReceiveTickAI");
            }
            byte* ParamsBufferAllocation = stackalloc byte[ReceiveTickAI_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.AIModule.AIController>.ToNative(IntPtr.Add(ParamsBuffer, ReceiveTickAI_OwnerController_Offset), 0, null, ownerController);
            ObjectMarshaller<UnrealSharp.Engine.Pawn>.ToNative(IntPtr.Add(ParamsBuffer, ReceiveTickAI_ControlledPawn_Offset), 0, null, controlledPawn);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(ParamsBuffer, ReceiveTickAI_DeltaSeconds_Offset), 0, null, deltaSeconds);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, ReceiveTickAI_NativeFunction, ParamsBuffer);
            
        }
    }
    
    //Hide implementation function from Intellisense/ReSharper
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    protected virtual void ReceiveTickAI_Implementation(UnrealSharp.AIModule.AIController ownerController, UnrealSharp.Engine.Pawn controlledPawn, float deltaSeconds)
    {
    }
    void Invoke_ReceiveTickAI(IntPtr buffer, IntPtr returnBuffer)
    {
        unsafe
        {
            UnrealSharp.AIModule.AIController ownerController = ObjectMarshaller<UnrealSharp.AIModule.AIController>.FromNative(IntPtr.Add(buffer, ReceiveTickAI_OwnerController_Offset), 0, null);
            UnrealSharp.Engine.Pawn controlledPawn = ObjectMarshaller<UnrealSharp.Engine.Pawn>.FromNative(IntPtr.Add(buffer, ReceiveTickAI_ControlledPawn_Offset), 0, null);
            float deltaSeconds = BlittableMarshaller<float>.FromNative(IntPtr.Add(buffer, ReceiveTickAI_DeltaSeconds_Offset), 0, null);
            ReceiveTickAI_Implementation(ownerController, controlledPawn, deltaSeconds);
        }
    }
    
    // Function /Script/AIModule.BTTask_BlueprintBase:ReceiveTick
    IntPtr ReceiveTick_NativeFunction;
    static readonly int ReceiveTick_ParamsSize;
    static readonly int ReceiveTick_OwnerActor_Offset;
    static readonly int ReceiveTick_DeltaSeconds_Offset;
    
    [UFunction(FunctionFlags.BlueprintEvent)]
    protected virtual void ReceiveTick(UnrealSharp.Engine.Actor ownerActor, float deltaSeconds)
    {
        unsafe
        {
            if (ReceiveTick_NativeFunction == IntPtr.Zero)
            {
                ReceiveTick_NativeFunction = UClassExporter.CallGetNativeFunctionFromInstanceAndName(NativeObject, "ReceiveTick");
            }
            byte* ParamsBufferAllocation = stackalloc byte[ReceiveTick_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.Engine.Actor>.ToNative(IntPtr.Add(ParamsBuffer, ReceiveTick_OwnerActor_Offset), 0, null, ownerActor);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(ParamsBuffer, ReceiveTick_DeltaSeconds_Offset), 0, null, deltaSeconds);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, ReceiveTick_NativeFunction, ParamsBuffer);
            
        }
    }
    
    //Hide implementation function from Intellisense/ReSharper
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    protected virtual void ReceiveTick_Implementation(UnrealSharp.Engine.Actor ownerActor, float deltaSeconds)
    {
    }
    void Invoke_ReceiveTick(IntPtr buffer, IntPtr returnBuffer)
    {
        unsafe
        {
            UnrealSharp.Engine.Actor ownerActor = ObjectMarshaller<UnrealSharp.Engine.Actor>.FromNative(IntPtr.Add(buffer, ReceiveTick_OwnerActor_Offset), 0, null);
            float deltaSeconds = BlittableMarshaller<float>.FromNative(IntPtr.Add(buffer, ReceiveTick_DeltaSeconds_Offset), 0, null);
            ReceiveTick_Implementation(ownerActor, deltaSeconds);
        }
    }
    
    // Function /Script/AIModule.BTTask_BlueprintBase:ReceiveExecuteAI
    IntPtr ReceiveExecuteAI_NativeFunction;
    static readonly int ReceiveExecuteAI_ParamsSize;
    static readonly int ReceiveExecuteAI_OwnerController_Offset;
    static readonly int ReceiveExecuteAI_ControlledPawn_Offset;
    
    [UFunction(FunctionFlags.BlueprintEvent)]
    protected virtual void ReceiveExecuteAI(UnrealSharp.AIModule.AIController ownerController, UnrealSharp.Engine.Pawn controlledPawn)
    {
        unsafe
        {
            if (ReceiveExecuteAI_NativeFunction == IntPtr.Zero)
            {
                ReceiveExecuteAI_NativeFunction = UClassExporter.CallGetNativeFunctionFromInstanceAndName(NativeObject, "ReceiveExecuteAI");
            }
            byte* ParamsBufferAllocation = stackalloc byte[ReceiveExecuteAI_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.AIModule.AIController>.ToNative(IntPtr.Add(ParamsBuffer, ReceiveExecuteAI_OwnerController_Offset), 0, null, ownerController);
            ObjectMarshaller<UnrealSharp.Engine.Pawn>.ToNative(IntPtr.Add(ParamsBuffer, ReceiveExecuteAI_ControlledPawn_Offset), 0, null, controlledPawn);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, ReceiveExecuteAI_NativeFunction, ParamsBuffer);
            
        }
    }
    
    //Hide implementation function from Intellisense/ReSharper
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    protected virtual void ReceiveExecuteAI_Implementation(UnrealSharp.AIModule.AIController ownerController, UnrealSharp.Engine.Pawn controlledPawn)
    {
    }
    void Invoke_ReceiveExecuteAI(IntPtr buffer, IntPtr returnBuffer)
    {
        unsafe
        {
            UnrealSharp.AIModule.AIController ownerController = ObjectMarshaller<UnrealSharp.AIModule.AIController>.FromNative(IntPtr.Add(buffer, ReceiveExecuteAI_OwnerController_Offset), 0, null);
            UnrealSharp.Engine.Pawn controlledPawn = ObjectMarshaller<UnrealSharp.Engine.Pawn>.FromNative(IntPtr.Add(buffer, ReceiveExecuteAI_ControlledPawn_Offset), 0, null);
            ReceiveExecuteAI_Implementation(ownerController, controlledPawn);
        }
    }
    
    // Function /Script/AIModule.BTTask_BlueprintBase:ReceiveExecute
    IntPtr ReceiveExecute_NativeFunction;
    static readonly int ReceiveExecute_ParamsSize;
    static readonly int ReceiveExecute_OwnerActor_Offset;
    
    [UFunction(FunctionFlags.BlueprintEvent)]
    protected virtual void ReceiveExecute(UnrealSharp.Engine.Actor ownerActor)
    {
        unsafe
        {
            if (ReceiveExecute_NativeFunction == IntPtr.Zero)
            {
                ReceiveExecute_NativeFunction = UClassExporter.CallGetNativeFunctionFromInstanceAndName(NativeObject, "ReceiveExecute");
            }
            byte* ParamsBufferAllocation = stackalloc byte[ReceiveExecute_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.Engine.Actor>.ToNative(IntPtr.Add(ParamsBuffer, ReceiveExecute_OwnerActor_Offset), 0, null, ownerActor);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, ReceiveExecute_NativeFunction, ParamsBuffer);
            
        }
    }
    
    //Hide implementation function from Intellisense/ReSharper
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    protected virtual void ReceiveExecute_Implementation(UnrealSharp.Engine.Actor ownerActor)
    {
    }
    void Invoke_ReceiveExecute(IntPtr buffer, IntPtr returnBuffer)
    {
        unsafe
        {
            UnrealSharp.Engine.Actor ownerActor = ObjectMarshaller<UnrealSharp.Engine.Actor>.FromNative(IntPtr.Add(buffer, ReceiveExecute_OwnerActor_Offset), 0, null);
            ReceiveExecute_Implementation(ownerActor);
        }
    }
    
    // Function /Script/AIModule.BTTask_BlueprintBase:ReceiveAbortAI
    IntPtr ReceiveAbortAI_NativeFunction;
    static readonly int ReceiveAbortAI_ParamsSize;
    static readonly int ReceiveAbortAI_OwnerController_Offset;
    static readonly int ReceiveAbortAI_ControlledPawn_Offset;
    
    [UFunction(FunctionFlags.BlueprintEvent)]
    protected virtual void ReceiveAbortAI(UnrealSharp.AIModule.AIController ownerController, UnrealSharp.Engine.Pawn controlledPawn)
    {
        unsafe
        {
            if (ReceiveAbortAI_NativeFunction == IntPtr.Zero)
            {
                ReceiveAbortAI_NativeFunction = UClassExporter.CallGetNativeFunctionFromInstanceAndName(NativeObject, "ReceiveAbortAI");
            }
            byte* ParamsBufferAllocation = stackalloc byte[ReceiveAbortAI_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.AIModule.AIController>.ToNative(IntPtr.Add(ParamsBuffer, ReceiveAbortAI_OwnerController_Offset), 0, null, ownerController);
            ObjectMarshaller<UnrealSharp.Engine.Pawn>.ToNative(IntPtr.Add(ParamsBuffer, ReceiveAbortAI_ControlledPawn_Offset), 0, null, controlledPawn);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, ReceiveAbortAI_NativeFunction, ParamsBuffer);
            
        }
    }
    
    //Hide implementation function from Intellisense/ReSharper
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    protected virtual void ReceiveAbortAI_Implementation(UnrealSharp.AIModule.AIController ownerController, UnrealSharp.Engine.Pawn controlledPawn)
    {
    }
    void Invoke_ReceiveAbortAI(IntPtr buffer, IntPtr returnBuffer)
    {
        unsafe
        {
            UnrealSharp.AIModule.AIController ownerController = ObjectMarshaller<UnrealSharp.AIModule.AIController>.FromNative(IntPtr.Add(buffer, ReceiveAbortAI_OwnerController_Offset), 0, null);
            UnrealSharp.Engine.Pawn controlledPawn = ObjectMarshaller<UnrealSharp.Engine.Pawn>.FromNative(IntPtr.Add(buffer, ReceiveAbortAI_ControlledPawn_Offset), 0, null);
            ReceiveAbortAI_Implementation(ownerController, controlledPawn);
        }
    }
    
    // Function /Script/AIModule.BTTask_BlueprintBase:ReceiveAbort
    IntPtr ReceiveAbort_NativeFunction;
    static readonly int ReceiveAbort_ParamsSize;
    static readonly int ReceiveAbort_OwnerActor_Offset;
    
    [UFunction(FunctionFlags.BlueprintEvent)]
    protected virtual void ReceiveAbort(UnrealSharp.Engine.Actor ownerActor)
    {
        unsafe
        {
            if (ReceiveAbort_NativeFunction == IntPtr.Zero)
            {
                ReceiveAbort_NativeFunction = UClassExporter.CallGetNativeFunctionFromInstanceAndName(NativeObject, "ReceiveAbort");
            }
            byte* ParamsBufferAllocation = stackalloc byte[ReceiveAbort_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.Engine.Actor>.ToNative(IntPtr.Add(ParamsBuffer, ReceiveAbort_OwnerActor_Offset), 0, null, ownerActor);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, ReceiveAbort_NativeFunction, ParamsBuffer);
            
        }
    }
    
    //Hide implementation function from Intellisense/ReSharper
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    protected virtual void ReceiveAbort_Implementation(UnrealSharp.Engine.Actor ownerActor)
    {
    }
    void Invoke_ReceiveAbort(IntPtr buffer, IntPtr returnBuffer)
    {
        unsafe
        {
            UnrealSharp.Engine.Actor ownerActor = ObjectMarshaller<UnrealSharp.Engine.Actor>.FromNative(IntPtr.Add(buffer, ReceiveAbort_OwnerActor_Offset), 0, null);
            ReceiveAbort_Implementation(ownerActor);
        }
    }
    
    
}