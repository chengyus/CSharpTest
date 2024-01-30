// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AIModule;

[UClass]
public partial class PawnActionsComponent : UnrealSharp.Engine.ActorComponent
{
    
    static readonly IntPtr NativeClassPtr;
    static PawnActionsComponent()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("PawnActionsComponent");
        
        ControlledPawn_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ControlledPawn");
        
        K2_PushAction_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "K2_PushAction");
        K2_PushAction_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(K2_PushAction_NativeFunction);
        K2_PushAction_NewAction_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(K2_PushAction_NativeFunction, "NewAction");
        K2_PushAction_Priority_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(K2_PushAction_NativeFunction, "Priority");
        K2_PushAction_Instigator_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(K2_PushAction_NativeFunction, "Instigator");
        K2_PushAction_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(K2_PushAction_NativeFunction, "ReturnValue");
        K2_PerformAction_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "K2_PerformAction");
        K2_PerformAction_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(K2_PerformAction_NativeFunction);
        K2_PerformAction_Pawn_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(K2_PerformAction_NativeFunction, "Pawn");
        K2_PerformAction_Action_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(K2_PerformAction_NativeFunction, "Action");
        K2_PerformAction_Priority_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(K2_PerformAction_NativeFunction, "Priority");
        K2_PerformAction_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(K2_PerformAction_NativeFunction, "ReturnValue");
        K2_ForceAbortAction_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "K2_ForceAbortAction");
        K2_ForceAbortAction_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(K2_ForceAbortAction_NativeFunction);
        K2_ForceAbortAction_ActionToAbort_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(K2_ForceAbortAction_NativeFunction, "ActionToAbort");
        K2_ForceAbortAction_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(K2_ForceAbortAction_NativeFunction, "ReturnValue");
        K2_AbortAction_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "K2_AbortAction");
        K2_AbortAction_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(K2_AbortAction_NativeFunction);
        K2_AbortAction_ActionToAbort_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(K2_AbortAction_NativeFunction, "ActionToAbort");
        K2_AbortAction_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(K2_AbortAction_NativeFunction, "ReturnValue");
        
        
    }
    
    protected PawnActionsComponent(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // ObjectProperty /Script/AIModule.PawnActionsComponent:ControlledPawn
    static readonly int ControlledPawn_Offset;
    
    public UnrealSharp.Engine.Pawn ControlledPawn
    {
        get
        {
            CheckObjectForValidity();
            return ObjectMarshaller<UnrealSharp.Engine.Pawn>.FromNative(IntPtr.Add(NativeObject, ControlledPawn_Offset), 0, this);
        }
    }
    
    // Function /Script/AIModule.PawnActionsComponent:K2_PushAction
    static readonly IntPtr K2_PushAction_NativeFunction;
    static readonly int K2_PushAction_ParamsSize;
    static readonly int K2_PushAction_NewAction_Offset;
    static readonly int K2_PushAction_Priority_Offset;
    static readonly int K2_PushAction_Instigator_Offset;
    static readonly int K2_PushAction_ReturnValue_Offset;
    
    [Obsolete("PawnActions have been deprecated and are no longer being supported. It will get removed in following UE5 releases. Use GameplayTasks or AITasks instead.")]
    public bool PushAction(UnrealSharp.AIModule.PawnAction newAction, UnrealSharp.AIModule.EAIRequestPriority priority, UnrealSharp.CoreUObject.Object instigator = default(UnrealSharp.CoreUObject.Object))
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[K2_PushAction_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.AIModule.PawnAction>.ToNative(IntPtr.Add(ParamsBuffer, K2_PushAction_NewAction_Offset), 0, null, newAction);
            BlittableMarshaller<UnrealSharp.AIModule.EAIRequestPriority>.ToNative(IntPtr.Add(ParamsBuffer, K2_PushAction_Priority_Offset), 0, null, priority);
            ObjectMarshaller<UnrealSharp.CoreUObject.Object>.ToNative(IntPtr.Add(ParamsBuffer, K2_PushAction_Instigator_Offset), 0, null, instigator);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, K2_PushAction_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, K2_PushAction_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/AIModule.PawnActionsComponent:K2_PerformAction
    static readonly IntPtr K2_PerformAction_NativeFunction;
    static readonly int K2_PerformAction_ParamsSize;
    static readonly int K2_PerformAction_Pawn_Offset;
    static readonly int K2_PerformAction_Action_Offset;
    static readonly int K2_PerformAction_Priority_Offset;
    static readonly int K2_PerformAction_ReturnValue_Offset;
    
    [Obsolete("PawnActions have been deprecated and are no longer being supported. It will get removed in following UE5 releases. Use GameplayTasks or AITasks instead.")]
    public static bool PerformAction(UnrealSharp.Engine.Pawn pawn, UnrealSharp.AIModule.PawnAction action, UnrealSharp.AIModule.EAIRequestPriority priority = UnrealSharp.AIModule.EAIRequestPriority.HardScript)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[K2_PerformAction_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.Engine.Pawn>.ToNative(IntPtr.Add(ParamsBuffer, K2_PerformAction_Pawn_Offset), 0, null, pawn);
            ObjectMarshaller<UnrealSharp.AIModule.PawnAction>.ToNative(IntPtr.Add(ParamsBuffer, K2_PerformAction_Action_Offset), 0, null, action);
            BlittableMarshaller<UnrealSharp.AIModule.EAIRequestPriority>.ToNative(IntPtr.Add(ParamsBuffer, K2_PerformAction_Priority_Offset), 0, null, priority);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, K2_PerformAction_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, K2_PerformAction_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/AIModule.PawnActionsComponent:K2_ForceAbortAction
    static readonly IntPtr K2_ForceAbortAction_NativeFunction;
    static readonly int K2_ForceAbortAction_ParamsSize;
    static readonly int K2_ForceAbortAction_ActionToAbort_Offset;
    static readonly int K2_ForceAbortAction_ReturnValue_Offset;
    
    [Obsolete("PawnActions have been deprecated and are no longer being supported. It will get removed in following UE5 releases. Use GameplayTasks or AITasks instead.")]
    public UnrealSharp.AIModule.EPawnActionAbortState ForceAbortAction(UnrealSharp.AIModule.PawnAction actionToAbort)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[K2_ForceAbortAction_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.AIModule.PawnAction>.ToNative(IntPtr.Add(ParamsBuffer, K2_ForceAbortAction_ActionToAbort_Offset), 0, null, actionToAbort);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, K2_ForceAbortAction_NativeFunction, ParamsBuffer);
            
            UnrealSharp.AIModule.EPawnActionAbortState returnValue;
            returnValue = BlittableMarshaller<UnrealSharp.AIModule.EPawnActionAbortState>.FromNative(IntPtr.Add(ParamsBuffer, K2_ForceAbortAction_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/AIModule.PawnActionsComponent:K2_AbortAction
    static readonly IntPtr K2_AbortAction_NativeFunction;
    static readonly int K2_AbortAction_ParamsSize;
    static readonly int K2_AbortAction_ActionToAbort_Offset;
    static readonly int K2_AbortAction_ReturnValue_Offset;
    
    [Obsolete("PawnActions have been deprecated and are no longer being supported. It will get removed in following UE5 releases. Use GameplayTasks or AITasks instead.")]
    public UnrealSharp.AIModule.EPawnActionAbortState AbortAction(UnrealSharp.AIModule.PawnAction actionToAbort)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[K2_AbortAction_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.AIModule.PawnAction>.ToNative(IntPtr.Add(ParamsBuffer, K2_AbortAction_ActionToAbort_Offset), 0, null, actionToAbort);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, K2_AbortAction_NativeFunction, ParamsBuffer);
            
            UnrealSharp.AIModule.EPawnActionAbortState returnValue;
            returnValue = BlittableMarshaller<UnrealSharp.AIModule.EPawnActionAbortState>.FromNative(IntPtr.Add(ParamsBuffer, K2_AbortAction_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    
}