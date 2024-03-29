// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AIModule;

[UClass]
abstract public partial class BTService_BlueprintBase : UnrealSharp.AIModule.BTService
{
    
    static BTService_BlueprintBase()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("BTService_BlueprintBase");
        
        CustomDescription_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "CustomDescription");
        CustomDescription_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "CustomDescription");
        
        IsServiceActive_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "IsServiceActive");
        IsServiceActive_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(IsServiceActive_NativeFunction);
        IsServiceActive_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(IsServiceActive_NativeFunction, "ReturnValue");
        
        IntPtr ReceiveTickAI_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "ReceiveTickAI");
        ReceiveTickAI_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(ReceiveTickAI_NativeFunction);
        ReceiveTickAI_OwnerController_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ReceiveTickAI_NativeFunction, "OwnerController");
        ReceiveTickAI_ControlledPawn_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ReceiveTickAI_NativeFunction, "ControlledPawn");
        ReceiveTickAI_DeltaSeconds_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ReceiveTickAI_NativeFunction, "DeltaSeconds");
        
        IntPtr ReceiveTick_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "ReceiveTick");
        ReceiveTick_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(ReceiveTick_NativeFunction);
        ReceiveTick_OwnerActor_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ReceiveTick_NativeFunction, "OwnerActor");
        ReceiveTick_DeltaSeconds_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ReceiveTick_NativeFunction, "DeltaSeconds");
        
        IntPtr ReceiveSearchStartAI_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "ReceiveSearchStartAI");
        ReceiveSearchStartAI_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(ReceiveSearchStartAI_NativeFunction);
        ReceiveSearchStartAI_OwnerController_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ReceiveSearchStartAI_NativeFunction, "OwnerController");
        ReceiveSearchStartAI_ControlledPawn_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ReceiveSearchStartAI_NativeFunction, "ControlledPawn");
        
        IntPtr ReceiveSearchStart_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "ReceiveSearchStart");
        ReceiveSearchStart_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(ReceiveSearchStart_NativeFunction);
        ReceiveSearchStart_OwnerActor_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ReceiveSearchStart_NativeFunction, "OwnerActor");
        
        IntPtr ReceiveDeactivationAI_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "ReceiveDeactivationAI");
        ReceiveDeactivationAI_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(ReceiveDeactivationAI_NativeFunction);
        ReceiveDeactivationAI_OwnerController_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ReceiveDeactivationAI_NativeFunction, "OwnerController");
        ReceiveDeactivationAI_ControlledPawn_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ReceiveDeactivationAI_NativeFunction, "ControlledPawn");
        
        IntPtr ReceiveDeactivation_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "ReceiveDeactivation");
        ReceiveDeactivation_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(ReceiveDeactivation_NativeFunction);
        ReceiveDeactivation_OwnerActor_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ReceiveDeactivation_NativeFunction, "OwnerActor");
        
        IntPtr ReceiveActivationAI_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "ReceiveActivationAI");
        ReceiveActivationAI_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(ReceiveActivationAI_NativeFunction);
        ReceiveActivationAI_OwnerController_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ReceiveActivationAI_NativeFunction, "OwnerController");
        ReceiveActivationAI_ControlledPawn_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ReceiveActivationAI_NativeFunction, "ControlledPawn");
        
        IntPtr ReceiveActivation_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "ReceiveActivation");
        ReceiveActivation_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(ReceiveActivation_NativeFunction);
        ReceiveActivation_OwnerActor_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ReceiveActivation_NativeFunction, "OwnerActor");
        
        
    }
    
    protected BTService_BlueprintBase(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // StrProperty /Script/AIModule.BTService_BlueprintBase:CustomDescription
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
    
    // Function /Script/AIModule.BTService_BlueprintBase:IsServiceActive
    static readonly IntPtr IsServiceActive_NativeFunction;
    static readonly int IsServiceActive_ParamsSize;
    static readonly int IsServiceActive_ReturnValue_Offset;
    
    protected bool IsServiceActive()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[IsServiceActive_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, IsServiceActive_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, IsServiceActive_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/AIModule.BTService_BlueprintBase:ReceiveTickAI
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
    
    // Function /Script/AIModule.BTService_BlueprintBase:ReceiveTick
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
    
    // Function /Script/AIModule.BTService_BlueprintBase:ReceiveSearchStartAI
    IntPtr ReceiveSearchStartAI_NativeFunction;
    static readonly int ReceiveSearchStartAI_ParamsSize;
    static readonly int ReceiveSearchStartAI_OwnerController_Offset;
    static readonly int ReceiveSearchStartAI_ControlledPawn_Offset;
    
    [UFunction(FunctionFlags.BlueprintEvent)]
    protected virtual void ReceiveSearchStartAI(UnrealSharp.AIModule.AIController ownerController, UnrealSharp.Engine.Pawn controlledPawn)
    {
        unsafe
        {
            if (ReceiveSearchStartAI_NativeFunction == IntPtr.Zero)
            {
                ReceiveSearchStartAI_NativeFunction = UClassExporter.CallGetNativeFunctionFromInstanceAndName(NativeObject, "ReceiveSearchStartAI");
            }
            byte* ParamsBufferAllocation = stackalloc byte[ReceiveSearchStartAI_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.AIModule.AIController>.ToNative(IntPtr.Add(ParamsBuffer, ReceiveSearchStartAI_OwnerController_Offset), 0, null, ownerController);
            ObjectMarshaller<UnrealSharp.Engine.Pawn>.ToNative(IntPtr.Add(ParamsBuffer, ReceiveSearchStartAI_ControlledPawn_Offset), 0, null, controlledPawn);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, ReceiveSearchStartAI_NativeFunction, ParamsBuffer);
            
        }
    }
    
    //Hide implementation function from Intellisense/ReSharper
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    protected virtual void ReceiveSearchStartAI_Implementation(UnrealSharp.AIModule.AIController ownerController, UnrealSharp.Engine.Pawn controlledPawn)
    {
    }
    void Invoke_ReceiveSearchStartAI(IntPtr buffer, IntPtr returnBuffer)
    {
        unsafe
        {
            UnrealSharp.AIModule.AIController ownerController = ObjectMarshaller<UnrealSharp.AIModule.AIController>.FromNative(IntPtr.Add(buffer, ReceiveSearchStartAI_OwnerController_Offset), 0, null);
            UnrealSharp.Engine.Pawn controlledPawn = ObjectMarshaller<UnrealSharp.Engine.Pawn>.FromNative(IntPtr.Add(buffer, ReceiveSearchStartAI_ControlledPawn_Offset), 0, null);
            ReceiveSearchStartAI_Implementation(ownerController, controlledPawn);
        }
    }
    
    // Function /Script/AIModule.BTService_BlueprintBase:ReceiveSearchStart
    IntPtr ReceiveSearchStart_NativeFunction;
    static readonly int ReceiveSearchStart_ParamsSize;
    static readonly int ReceiveSearchStart_OwnerActor_Offset;
    
    [UFunction(FunctionFlags.BlueprintEvent)]
    protected virtual void ReceiveSearchStart(UnrealSharp.Engine.Actor ownerActor)
    {
        unsafe
        {
            if (ReceiveSearchStart_NativeFunction == IntPtr.Zero)
            {
                ReceiveSearchStart_NativeFunction = UClassExporter.CallGetNativeFunctionFromInstanceAndName(NativeObject, "ReceiveSearchStart");
            }
            byte* ParamsBufferAllocation = stackalloc byte[ReceiveSearchStart_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.Engine.Actor>.ToNative(IntPtr.Add(ParamsBuffer, ReceiveSearchStart_OwnerActor_Offset), 0, null, ownerActor);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, ReceiveSearchStart_NativeFunction, ParamsBuffer);
            
        }
    }
    
    //Hide implementation function from Intellisense/ReSharper
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    protected virtual void ReceiveSearchStart_Implementation(UnrealSharp.Engine.Actor ownerActor)
    {
    }
    void Invoke_ReceiveSearchStart(IntPtr buffer, IntPtr returnBuffer)
    {
        unsafe
        {
            UnrealSharp.Engine.Actor ownerActor = ObjectMarshaller<UnrealSharp.Engine.Actor>.FromNative(IntPtr.Add(buffer, ReceiveSearchStart_OwnerActor_Offset), 0, null);
            ReceiveSearchStart_Implementation(ownerActor);
        }
    }
    
    // Function /Script/AIModule.BTService_BlueprintBase:ReceiveDeactivationAI
    IntPtr ReceiveDeactivationAI_NativeFunction;
    static readonly int ReceiveDeactivationAI_ParamsSize;
    static readonly int ReceiveDeactivationAI_OwnerController_Offset;
    static readonly int ReceiveDeactivationAI_ControlledPawn_Offset;
    
    [UFunction(FunctionFlags.BlueprintEvent)]
    protected virtual void ReceiveDeactivationAI(UnrealSharp.AIModule.AIController ownerController, UnrealSharp.Engine.Pawn controlledPawn)
    {
        unsafe
        {
            if (ReceiveDeactivationAI_NativeFunction == IntPtr.Zero)
            {
                ReceiveDeactivationAI_NativeFunction = UClassExporter.CallGetNativeFunctionFromInstanceAndName(NativeObject, "ReceiveDeactivationAI");
            }
            byte* ParamsBufferAllocation = stackalloc byte[ReceiveDeactivationAI_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.AIModule.AIController>.ToNative(IntPtr.Add(ParamsBuffer, ReceiveDeactivationAI_OwnerController_Offset), 0, null, ownerController);
            ObjectMarshaller<UnrealSharp.Engine.Pawn>.ToNative(IntPtr.Add(ParamsBuffer, ReceiveDeactivationAI_ControlledPawn_Offset), 0, null, controlledPawn);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, ReceiveDeactivationAI_NativeFunction, ParamsBuffer);
            
        }
    }
    
    //Hide implementation function from Intellisense/ReSharper
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    protected virtual void ReceiveDeactivationAI_Implementation(UnrealSharp.AIModule.AIController ownerController, UnrealSharp.Engine.Pawn controlledPawn)
    {
    }
    void Invoke_ReceiveDeactivationAI(IntPtr buffer, IntPtr returnBuffer)
    {
        unsafe
        {
            UnrealSharp.AIModule.AIController ownerController = ObjectMarshaller<UnrealSharp.AIModule.AIController>.FromNative(IntPtr.Add(buffer, ReceiveDeactivationAI_OwnerController_Offset), 0, null);
            UnrealSharp.Engine.Pawn controlledPawn = ObjectMarshaller<UnrealSharp.Engine.Pawn>.FromNative(IntPtr.Add(buffer, ReceiveDeactivationAI_ControlledPawn_Offset), 0, null);
            ReceiveDeactivationAI_Implementation(ownerController, controlledPawn);
        }
    }
    
    // Function /Script/AIModule.BTService_BlueprintBase:ReceiveDeactivation
    IntPtr ReceiveDeactivation_NativeFunction;
    static readonly int ReceiveDeactivation_ParamsSize;
    static readonly int ReceiveDeactivation_OwnerActor_Offset;
    
    [UFunction(FunctionFlags.BlueprintEvent)]
    protected virtual void ReceiveDeactivation(UnrealSharp.Engine.Actor ownerActor)
    {
        unsafe
        {
            if (ReceiveDeactivation_NativeFunction == IntPtr.Zero)
            {
                ReceiveDeactivation_NativeFunction = UClassExporter.CallGetNativeFunctionFromInstanceAndName(NativeObject, "ReceiveDeactivation");
            }
            byte* ParamsBufferAllocation = stackalloc byte[ReceiveDeactivation_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.Engine.Actor>.ToNative(IntPtr.Add(ParamsBuffer, ReceiveDeactivation_OwnerActor_Offset), 0, null, ownerActor);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, ReceiveDeactivation_NativeFunction, ParamsBuffer);
            
        }
    }
    
    //Hide implementation function from Intellisense/ReSharper
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    protected virtual void ReceiveDeactivation_Implementation(UnrealSharp.Engine.Actor ownerActor)
    {
    }
    void Invoke_ReceiveDeactivation(IntPtr buffer, IntPtr returnBuffer)
    {
        unsafe
        {
            UnrealSharp.Engine.Actor ownerActor = ObjectMarshaller<UnrealSharp.Engine.Actor>.FromNative(IntPtr.Add(buffer, ReceiveDeactivation_OwnerActor_Offset), 0, null);
            ReceiveDeactivation_Implementation(ownerActor);
        }
    }
    
    // Function /Script/AIModule.BTService_BlueprintBase:ReceiveActivationAI
    IntPtr ReceiveActivationAI_NativeFunction;
    static readonly int ReceiveActivationAI_ParamsSize;
    static readonly int ReceiveActivationAI_OwnerController_Offset;
    static readonly int ReceiveActivationAI_ControlledPawn_Offset;
    
    [UFunction(FunctionFlags.BlueprintEvent)]
    protected virtual void ReceiveActivationAI(UnrealSharp.AIModule.AIController ownerController, UnrealSharp.Engine.Pawn controlledPawn)
    {
        unsafe
        {
            if (ReceiveActivationAI_NativeFunction == IntPtr.Zero)
            {
                ReceiveActivationAI_NativeFunction = UClassExporter.CallGetNativeFunctionFromInstanceAndName(NativeObject, "ReceiveActivationAI");
            }
            byte* ParamsBufferAllocation = stackalloc byte[ReceiveActivationAI_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.AIModule.AIController>.ToNative(IntPtr.Add(ParamsBuffer, ReceiveActivationAI_OwnerController_Offset), 0, null, ownerController);
            ObjectMarshaller<UnrealSharp.Engine.Pawn>.ToNative(IntPtr.Add(ParamsBuffer, ReceiveActivationAI_ControlledPawn_Offset), 0, null, controlledPawn);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, ReceiveActivationAI_NativeFunction, ParamsBuffer);
            
        }
    }
    
    //Hide implementation function from Intellisense/ReSharper
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    protected virtual void ReceiveActivationAI_Implementation(UnrealSharp.AIModule.AIController ownerController, UnrealSharp.Engine.Pawn controlledPawn)
    {
    }
    void Invoke_ReceiveActivationAI(IntPtr buffer, IntPtr returnBuffer)
    {
        unsafe
        {
            UnrealSharp.AIModule.AIController ownerController = ObjectMarshaller<UnrealSharp.AIModule.AIController>.FromNative(IntPtr.Add(buffer, ReceiveActivationAI_OwnerController_Offset), 0, null);
            UnrealSharp.Engine.Pawn controlledPawn = ObjectMarshaller<UnrealSharp.Engine.Pawn>.FromNative(IntPtr.Add(buffer, ReceiveActivationAI_ControlledPawn_Offset), 0, null);
            ReceiveActivationAI_Implementation(ownerController, controlledPawn);
        }
    }
    
    // Function /Script/AIModule.BTService_BlueprintBase:ReceiveActivation
    IntPtr ReceiveActivation_NativeFunction;
    static readonly int ReceiveActivation_ParamsSize;
    static readonly int ReceiveActivation_OwnerActor_Offset;
    
    [UFunction(FunctionFlags.BlueprintEvent)]
    protected virtual void ReceiveActivation(UnrealSharp.Engine.Actor ownerActor)
    {
        unsafe
        {
            if (ReceiveActivation_NativeFunction == IntPtr.Zero)
            {
                ReceiveActivation_NativeFunction = UClassExporter.CallGetNativeFunctionFromInstanceAndName(NativeObject, "ReceiveActivation");
            }
            byte* ParamsBufferAllocation = stackalloc byte[ReceiveActivation_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.Engine.Actor>.ToNative(IntPtr.Add(ParamsBuffer, ReceiveActivation_OwnerActor_Offset), 0, null, ownerActor);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, ReceiveActivation_NativeFunction, ParamsBuffer);
            
        }
    }
    
    //Hide implementation function from Intellisense/ReSharper
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    protected virtual void ReceiveActivation_Implementation(UnrealSharp.Engine.Actor ownerActor)
    {
    }
    void Invoke_ReceiveActivation(IntPtr buffer, IntPtr returnBuffer)
    {
        unsafe
        {
            UnrealSharp.Engine.Actor ownerActor = ObjectMarshaller<UnrealSharp.Engine.Actor>.FromNative(IntPtr.Add(buffer, ReceiveActivation_OwnerActor_Offset), 0, null);
            ReceiveActivation_Implementation(ownerActor);
        }
    }
    
    
}