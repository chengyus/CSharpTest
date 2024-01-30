// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.GeometryCollectionEngine;

[UClass]
public partial class ChaosDestructionListener : UnrealSharp.Engine.SceneComponent
{
    
    static ChaosDestructionListener()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("ChaosDestructionListener");
        
        bIsCollisionEventListeningEnabled_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bIsCollisionEventListeningEnabled");
        bIsCollisionEventListeningEnabled_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bIsCollisionEventListeningEnabled");
        bIsBreakingEventListeningEnabled_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bIsBreakingEventListeningEnabled");
        bIsBreakingEventListeningEnabled_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bIsBreakingEventListeningEnabled");
        bIsTrailingEventListeningEnabled_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bIsTrailingEventListeningEnabled");
        bIsTrailingEventListeningEnabled_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bIsTrailingEventListeningEnabled");
        bIsRemovalEventListeningEnabled_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bIsRemovalEventListeningEnabled");
        bIsRemovalEventListeningEnabled_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bIsRemovalEventListeningEnabled");
        CollisionEventRequestSettings_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "CollisionEventRequestSettings");
        BreakingEventRequestSettings_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BreakingEventRequestSettings");
        TrailingEventRequestSettings_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "TrailingEventRequestSettings");
        RemovalEventRequestSettings_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "RemovalEventRequestSettings");
        
        SortTrailingEvents_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SortTrailingEvents");
        SortTrailingEvents_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SortTrailingEvents_NativeFunction);
        SortTrailingEvents_TrailingEvents_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SortTrailingEvents_NativeFunction, "TrailingEvents");
        SortTrailingEvents_TrailingEvents_ElementSize = FArrayPropertyExporter.CallGetArrayElementSize(SortTrailingEvents_NativeFunction, "TrailingEvents");
        SortTrailingEvents_SortMethod_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SortTrailingEvents_NativeFunction, "SortMethod");
        SortRemovalEvents_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SortRemovalEvents");
        SortRemovalEvents_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SortRemovalEvents_NativeFunction);
        SortRemovalEvents_RemovalEvents_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SortRemovalEvents_NativeFunction, "RemovalEvents");
        SortRemovalEvents_RemovalEvents_ElementSize = FArrayPropertyExporter.CallGetArrayElementSize(SortRemovalEvents_NativeFunction, "RemovalEvents");
        SortRemovalEvents_SortMethod_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SortRemovalEvents_NativeFunction, "SortMethod");
        SortCollisionEvents_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SortCollisionEvents");
        SortCollisionEvents_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SortCollisionEvents_NativeFunction);
        SortCollisionEvents_CollisionEvents_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SortCollisionEvents_NativeFunction, "CollisionEvents");
        SortCollisionEvents_CollisionEvents_ElementSize = FArrayPropertyExporter.CallGetArrayElementSize(SortCollisionEvents_NativeFunction, "CollisionEvents");
        SortCollisionEvents_SortMethod_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SortCollisionEvents_NativeFunction, "SortMethod");
        SortBreakingEvents_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SortBreakingEvents");
        SortBreakingEvents_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SortBreakingEvents_NativeFunction);
        SortBreakingEvents_BreakingEvents_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SortBreakingEvents_NativeFunction, "BreakingEvents");
        SortBreakingEvents_BreakingEvents_ElementSize = FArrayPropertyExporter.CallGetArrayElementSize(SortBreakingEvents_NativeFunction, "BreakingEvents");
        SortBreakingEvents_SortMethod_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SortBreakingEvents_NativeFunction, "SortMethod");
        SetTrailingEventRequestSettings_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetTrailingEventRequestSettings");
        SetTrailingEventRequestSettings_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetTrailingEventRequestSettings_NativeFunction);
        SetTrailingEventRequestSettings_InSettings_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetTrailingEventRequestSettings_NativeFunction, "InSettings");
        SetTrailingEventEnabled_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetTrailingEventEnabled");
        SetTrailingEventEnabled_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetTrailingEventEnabled_NativeFunction);
        SetTrailingEventEnabled_bIsEnabled_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetTrailingEventEnabled_NativeFunction, "bIsEnabled");
        SetRemovalEventRequestSettings_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetRemovalEventRequestSettings");
        SetRemovalEventRequestSettings_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetRemovalEventRequestSettings_NativeFunction);
        SetRemovalEventRequestSettings_InSettings_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetRemovalEventRequestSettings_NativeFunction, "InSettings");
        SetRemovalEventEnabled_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetRemovalEventEnabled");
        SetRemovalEventEnabled_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetRemovalEventEnabled_NativeFunction);
        SetRemovalEventEnabled_bIsEnabled_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetRemovalEventEnabled_NativeFunction, "bIsEnabled");
        SetCollisionEventRequestSettings_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetCollisionEventRequestSettings");
        SetCollisionEventRequestSettings_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetCollisionEventRequestSettings_NativeFunction);
        SetCollisionEventRequestSettings_InSettings_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetCollisionEventRequestSettings_NativeFunction, "InSettings");
        SetCollisionEventEnabled_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetCollisionEventEnabled");
        SetCollisionEventEnabled_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetCollisionEventEnabled_NativeFunction);
        SetCollisionEventEnabled_bIsEnabled_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetCollisionEventEnabled_NativeFunction, "bIsEnabled");
        SetBreakingEventRequestSettings_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetBreakingEventRequestSettings");
        SetBreakingEventRequestSettings_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetBreakingEventRequestSettings_NativeFunction);
        SetBreakingEventRequestSettings_InSettings_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetBreakingEventRequestSettings_NativeFunction, "InSettings");
        SetBreakingEventEnabled_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetBreakingEventEnabled");
        SetBreakingEventEnabled_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetBreakingEventEnabled_NativeFunction);
        SetBreakingEventEnabled_bIsEnabled_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetBreakingEventEnabled_NativeFunction, "bIsEnabled");
        RemoveGeometryCollectionActor_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "RemoveGeometryCollectionActor");
        RemoveGeometryCollectionActor_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(RemoveGeometryCollectionActor_NativeFunction);
        RemoveGeometryCollectionActor_GeometryCollectionActor_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(RemoveGeometryCollectionActor_NativeFunction, "GeometryCollectionActor");
        RemoveChaosSolverActor_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "RemoveChaosSolverActor");
        RemoveChaosSolverActor_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(RemoveChaosSolverActor_NativeFunction);
        RemoveChaosSolverActor_ChaosSolverActor_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(RemoveChaosSolverActor_NativeFunction, "ChaosSolverActor");
        IsEventListening_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "IsEventListening");
        IsEventListening_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(IsEventListening_NativeFunction);
        IsEventListening_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(IsEventListening_NativeFunction, "ReturnValue");
        AddGeometryCollectionActor_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "AddGeometryCollectionActor");
        AddGeometryCollectionActor_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(AddGeometryCollectionActor_NativeFunction);
        AddGeometryCollectionActor_GeometryCollectionActor_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AddGeometryCollectionActor_NativeFunction, "GeometryCollectionActor");
        AddChaosSolverActor_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "AddChaosSolverActor");
        AddChaosSolverActor_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(AddChaosSolverActor_NativeFunction);
        AddChaosSolverActor_ChaosSolverActor_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AddChaosSolverActor_NativeFunction, "ChaosSolverActor");
        
        
    }
    
    protected ChaosDestructionListener(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // BoolProperty /Script/GeometryCollectionEngine.ChaosDestructionListener:bIsCollisionEventListeningEnabled
    static readonly int bIsCollisionEventListeningEnabled_Offset;
    static readonly IntPtr bIsCollisionEventListeningEnabled_NativeProperty;
    
    public bool bIsCollisionEventListeningEnabled
    {
        get
        {
            CheckObjectForValidity();
            return FBoolPropertyExporter.CallGetBitfieldValueFromProperty(NativeObject, bIsCollisionEventListeningEnabled_NativeProperty, bIsCollisionEventListeningEnabled_Offset);
        }
    }
    
    // BoolProperty /Script/GeometryCollectionEngine.ChaosDestructionListener:bIsBreakingEventListeningEnabled
    static readonly int bIsBreakingEventListeningEnabled_Offset;
    static readonly IntPtr bIsBreakingEventListeningEnabled_NativeProperty;
    
    public bool bIsBreakingEventListeningEnabled
    {
        get
        {
            CheckObjectForValidity();
            return FBoolPropertyExporter.CallGetBitfieldValueFromProperty(NativeObject, bIsBreakingEventListeningEnabled_NativeProperty, bIsBreakingEventListeningEnabled_Offset);
        }
    }
    
    // BoolProperty /Script/GeometryCollectionEngine.ChaosDestructionListener:bIsTrailingEventListeningEnabled
    static readonly int bIsTrailingEventListeningEnabled_Offset;
    static readonly IntPtr bIsTrailingEventListeningEnabled_NativeProperty;
    
    public bool bIsTrailingEventListeningEnabled
    {
        get
        {
            CheckObjectForValidity();
            return FBoolPropertyExporter.CallGetBitfieldValueFromProperty(NativeObject, bIsTrailingEventListeningEnabled_NativeProperty, bIsTrailingEventListeningEnabled_Offset);
        }
    }
    
    // BoolProperty /Script/GeometryCollectionEngine.ChaosDestructionListener:bIsRemovalEventListeningEnabled
    static readonly int bIsRemovalEventListeningEnabled_Offset;
    static readonly IntPtr bIsRemovalEventListeningEnabled_NativeProperty;
    
    public bool bIsRemovalEventListeningEnabled
    {
        get
        {
            CheckObjectForValidity();
            return FBoolPropertyExporter.CallGetBitfieldValueFromProperty(NativeObject, bIsRemovalEventListeningEnabled_NativeProperty, bIsRemovalEventListeningEnabled_Offset);
        }
    }
    
    // StructProperty /Script/GeometryCollectionEngine.ChaosDestructionListener:CollisionEventRequestSettings
    static readonly int CollisionEventRequestSettings_Offset;
    
    public UnrealSharp.GeometryCollectionEngine.ChaosCollisionEventRequestSettings CollisionEventRequestSettings
    {
        get
        {
            CheckObjectForValidity();
            return UnrealSharp.GeometryCollectionEngine.ChaosCollisionEventRequestSettingsMarshaler.FromNative(IntPtr.Add(NativeObject, CollisionEventRequestSettings_Offset), 0, this);
        }
    }
    
    // StructProperty /Script/GeometryCollectionEngine.ChaosDestructionListener:BreakingEventRequestSettings
    static readonly int BreakingEventRequestSettings_Offset;
    
    public UnrealSharp.GeometryCollectionEngine.ChaosBreakingEventRequestSettings BreakingEventRequestSettings
    {
        get
        {
            CheckObjectForValidity();
            return UnrealSharp.GeometryCollectionEngine.ChaosBreakingEventRequestSettingsMarshaler.FromNative(IntPtr.Add(NativeObject, BreakingEventRequestSettings_Offset), 0, this);
        }
    }
    
    // StructProperty /Script/GeometryCollectionEngine.ChaosDestructionListener:TrailingEventRequestSettings
    static readonly int TrailingEventRequestSettings_Offset;
    
    public UnrealSharp.GeometryCollectionEngine.ChaosTrailingEventRequestSettings TrailingEventRequestSettings
    {
        get
        {
            CheckObjectForValidity();
            return UnrealSharp.GeometryCollectionEngine.ChaosTrailingEventRequestSettingsMarshaler.FromNative(IntPtr.Add(NativeObject, TrailingEventRequestSettings_Offset), 0, this);
        }
    }
    
    // StructProperty /Script/GeometryCollectionEngine.ChaosDestructionListener:RemovalEventRequestSettings
    static readonly int RemovalEventRequestSettings_Offset;
    
    public UnrealSharp.GeometryCollectionEngine.ChaosRemovalEventRequestSettings RemovalEventRequestSettings
    {
        get
        {
            CheckObjectForValidity();
            return UnrealSharp.GeometryCollectionEngine.ChaosRemovalEventRequestSettingsMarshaler.FromNative(IntPtr.Add(NativeObject, RemovalEventRequestSettings_Offset), 0, this);
        }
    }
    
    // Function /Script/GeometryCollectionEngine.ChaosDestructionListener:SortTrailingEvents
    static readonly IntPtr SortTrailingEvents_NativeFunction;
    static readonly int SortTrailingEvents_ParamsSize;
    static readonly int SortTrailingEvents_TrailingEvents_Offset;
    static readonly int SortTrailingEvents_TrailingEvents_ElementSize;
    static readonly int SortTrailingEvents_SortMethod_Offset;
    
    public void SortTrailingEvents(ref System.Collections.Generic.IList<UnrealSharp.GeometryCollectionEngine.ChaosTrailingEventData> trailingEvents, UnrealSharp.GeometryCollectionEngine.EChaosTrailingSortMethod sortMethod)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SortTrailingEvents_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            IntPtr TrailingEvents_NativeBuffer = IntPtr.Add(ParamsBuffer, SortTrailingEvents_TrailingEvents_Offset);
            UnrealArrayCopyMarshaler<UnrealSharp.GeometryCollectionEngine.ChaosTrailingEventData> TrailingEvents_Marshaler = new UnrealArrayCopyMarshaler<UnrealSharp.GeometryCollectionEngine.ChaosTrailingEventData>(1, BlittableMarshaller<UnrealSharp.GeometryCollectionEngine.ChaosTrailingEventData>.ToNative, BlittableMarshaller<UnrealSharp.GeometryCollectionEngine.ChaosTrailingEventData>.FromNative, SortTrailingEvents_TrailingEvents_ElementSize);
            TrailingEvents_Marshaler.ToNative(TrailingEvents_NativeBuffer, 0, null, trailingEvents);
            BlittableMarshaller<UnrealSharp.GeometryCollectionEngine.EChaosTrailingSortMethod>.ToNative(IntPtr.Add(ParamsBuffer, SortTrailingEvents_SortMethod_Offset), 0, null, sortMethod);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SortTrailingEvents_NativeFunction, ParamsBuffer);
            
            trailingEvents = TrailingEvents_Marshaler.FromNative(TrailingEvents_NativeBuffer, 0, null);
            UnrealArrayCopyMarshaler<UnrealSharp.GeometryCollectionEngine.ChaosTrailingEventData>.DestructInstance(TrailingEvents_NativeBuffer, 0);
            
        }
    }
    
    // Function /Script/GeometryCollectionEngine.ChaosDestructionListener:SortRemovalEvents
    static readonly IntPtr SortRemovalEvents_NativeFunction;
    static readonly int SortRemovalEvents_ParamsSize;
    static readonly int SortRemovalEvents_RemovalEvents_Offset;
    static readonly int SortRemovalEvents_RemovalEvents_ElementSize;
    static readonly int SortRemovalEvents_SortMethod_Offset;
    
    public void SortRemovalEvents(ref System.Collections.Generic.IList<UnrealSharp.GeometryCollectionEngine.ChaosRemovalEventData> removalEvents, UnrealSharp.GeometryCollectionEngine.EChaosRemovalSortMethod sortMethod)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SortRemovalEvents_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            IntPtr RemovalEvents_NativeBuffer = IntPtr.Add(ParamsBuffer, SortRemovalEvents_RemovalEvents_Offset);
            UnrealArrayCopyMarshaler<UnrealSharp.GeometryCollectionEngine.ChaosRemovalEventData> RemovalEvents_Marshaler = new UnrealArrayCopyMarshaler<UnrealSharp.GeometryCollectionEngine.ChaosRemovalEventData>(1, BlittableMarshaller<UnrealSharp.GeometryCollectionEngine.ChaosRemovalEventData>.ToNative, BlittableMarshaller<UnrealSharp.GeometryCollectionEngine.ChaosRemovalEventData>.FromNative, SortRemovalEvents_RemovalEvents_ElementSize);
            RemovalEvents_Marshaler.ToNative(RemovalEvents_NativeBuffer, 0, null, removalEvents);
            BlittableMarshaller<UnrealSharp.GeometryCollectionEngine.EChaosRemovalSortMethod>.ToNative(IntPtr.Add(ParamsBuffer, SortRemovalEvents_SortMethod_Offset), 0, null, sortMethod);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SortRemovalEvents_NativeFunction, ParamsBuffer);
            
            removalEvents = RemovalEvents_Marshaler.FromNative(RemovalEvents_NativeBuffer, 0, null);
            UnrealArrayCopyMarshaler<UnrealSharp.GeometryCollectionEngine.ChaosRemovalEventData>.DestructInstance(RemovalEvents_NativeBuffer, 0);
            
        }
    }
    
    // Function /Script/GeometryCollectionEngine.ChaosDestructionListener:SortCollisionEvents
    static readonly IntPtr SortCollisionEvents_NativeFunction;
    static readonly int SortCollisionEvents_ParamsSize;
    static readonly int SortCollisionEvents_CollisionEvents_Offset;
    static readonly int SortCollisionEvents_CollisionEvents_ElementSize;
    static readonly int SortCollisionEvents_SortMethod_Offset;
    
    public void SortCollisionEvents(ref System.Collections.Generic.IList<UnrealSharp.GeometryCollectionEngine.ChaosCollisionEventData> collisionEvents, UnrealSharp.GeometryCollectionEngine.EChaosCollisionSortMethod sortMethod)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SortCollisionEvents_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            IntPtr CollisionEvents_NativeBuffer = IntPtr.Add(ParamsBuffer, SortCollisionEvents_CollisionEvents_Offset);
            UnrealArrayCopyMarshaler<UnrealSharp.GeometryCollectionEngine.ChaosCollisionEventData> CollisionEvents_Marshaler = new UnrealArrayCopyMarshaler<UnrealSharp.GeometryCollectionEngine.ChaosCollisionEventData>(1, BlittableMarshaller<UnrealSharp.GeometryCollectionEngine.ChaosCollisionEventData>.ToNative, BlittableMarshaller<UnrealSharp.GeometryCollectionEngine.ChaosCollisionEventData>.FromNative, SortCollisionEvents_CollisionEvents_ElementSize);
            CollisionEvents_Marshaler.ToNative(CollisionEvents_NativeBuffer, 0, null, collisionEvents);
            BlittableMarshaller<UnrealSharp.GeometryCollectionEngine.EChaosCollisionSortMethod>.ToNative(IntPtr.Add(ParamsBuffer, SortCollisionEvents_SortMethod_Offset), 0, null, sortMethod);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SortCollisionEvents_NativeFunction, ParamsBuffer);
            
            collisionEvents = CollisionEvents_Marshaler.FromNative(CollisionEvents_NativeBuffer, 0, null);
            UnrealArrayCopyMarshaler<UnrealSharp.GeometryCollectionEngine.ChaosCollisionEventData>.DestructInstance(CollisionEvents_NativeBuffer, 0);
            
        }
    }
    
    // Function /Script/GeometryCollectionEngine.ChaosDestructionListener:SortBreakingEvents
    static readonly IntPtr SortBreakingEvents_NativeFunction;
    static readonly int SortBreakingEvents_ParamsSize;
    static readonly int SortBreakingEvents_BreakingEvents_Offset;
    static readonly int SortBreakingEvents_BreakingEvents_ElementSize;
    static readonly int SortBreakingEvents_SortMethod_Offset;
    
    public void SortBreakingEvents(ref System.Collections.Generic.IList<UnrealSharp.GeometryCollectionEngine.ChaosBreakingEventData> breakingEvents, UnrealSharp.GeometryCollectionEngine.EChaosBreakingSortMethod sortMethod)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SortBreakingEvents_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            IntPtr BreakingEvents_NativeBuffer = IntPtr.Add(ParamsBuffer, SortBreakingEvents_BreakingEvents_Offset);
            UnrealArrayCopyMarshaler<UnrealSharp.GeometryCollectionEngine.ChaosBreakingEventData> BreakingEvents_Marshaler = new UnrealArrayCopyMarshaler<UnrealSharp.GeometryCollectionEngine.ChaosBreakingEventData>(1, UnrealSharp.GeometryCollectionEngine.ChaosBreakingEventDataMarshaler.ToNative, UnrealSharp.GeometryCollectionEngine.ChaosBreakingEventDataMarshaler.FromNative, SortBreakingEvents_BreakingEvents_ElementSize);
            BreakingEvents_Marshaler.ToNative(BreakingEvents_NativeBuffer, 0, null, breakingEvents);
            BlittableMarshaller<UnrealSharp.GeometryCollectionEngine.EChaosBreakingSortMethod>.ToNative(IntPtr.Add(ParamsBuffer, SortBreakingEvents_SortMethod_Offset), 0, null, sortMethod);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SortBreakingEvents_NativeFunction, ParamsBuffer);
            
            breakingEvents = BreakingEvents_Marshaler.FromNative(BreakingEvents_NativeBuffer, 0, null);
            UnrealArrayCopyMarshaler<UnrealSharp.GeometryCollectionEngine.ChaosBreakingEventData>.DestructInstance(BreakingEvents_NativeBuffer, 0);
            
        }
    }
    
    // Function /Script/GeometryCollectionEngine.ChaosDestructionListener:SetTrailingEventRequestSettings
    static readonly IntPtr SetTrailingEventRequestSettings_NativeFunction;
    static readonly int SetTrailingEventRequestSettings_ParamsSize;
    static readonly int SetTrailingEventRequestSettings_InSettings_Offset;
    
    public void SetTrailingEventRequestSettings(UnrealSharp.GeometryCollectionEngine.ChaosTrailingEventRequestSettings inSettings)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetTrailingEventRequestSettings_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            UnrealSharp.GeometryCollectionEngine.ChaosTrailingEventRequestSettingsMarshaler.ToNative(IntPtr.Add(ParamsBuffer, SetTrailingEventRequestSettings_InSettings_Offset), 0, null, inSettings);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetTrailingEventRequestSettings_NativeFunction, ParamsBuffer);
            
            
        }
    }
    
    // Function /Script/GeometryCollectionEngine.ChaosDestructionListener:SetTrailingEventEnabled
    static readonly IntPtr SetTrailingEventEnabled_NativeFunction;
    static readonly int SetTrailingEventEnabled_ParamsSize;
    static readonly int SetTrailingEventEnabled_bIsEnabled_Offset;
    
    public void SetTrailingEventEnabled(bool bIsEnabled)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetTrailingEventEnabled_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BoolMarshaller.ToNative(IntPtr.Add(ParamsBuffer, SetTrailingEventEnabled_bIsEnabled_Offset), 0, null, bIsEnabled);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetTrailingEventEnabled_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/GeometryCollectionEngine.ChaosDestructionListener:SetRemovalEventRequestSettings
    static readonly IntPtr SetRemovalEventRequestSettings_NativeFunction;
    static readonly int SetRemovalEventRequestSettings_ParamsSize;
    static readonly int SetRemovalEventRequestSettings_InSettings_Offset;
    
    public void SetRemovalEventRequestSettings(UnrealSharp.GeometryCollectionEngine.ChaosRemovalEventRequestSettings inSettings)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetRemovalEventRequestSettings_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            UnrealSharp.GeometryCollectionEngine.ChaosRemovalEventRequestSettingsMarshaler.ToNative(IntPtr.Add(ParamsBuffer, SetRemovalEventRequestSettings_InSettings_Offset), 0, null, inSettings);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetRemovalEventRequestSettings_NativeFunction, ParamsBuffer);
            
            
        }
    }
    
    // Function /Script/GeometryCollectionEngine.ChaosDestructionListener:SetRemovalEventEnabled
    static readonly IntPtr SetRemovalEventEnabled_NativeFunction;
    static readonly int SetRemovalEventEnabled_ParamsSize;
    static readonly int SetRemovalEventEnabled_bIsEnabled_Offset;
    
    public void SetRemovalEventEnabled(bool bIsEnabled)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetRemovalEventEnabled_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BoolMarshaller.ToNative(IntPtr.Add(ParamsBuffer, SetRemovalEventEnabled_bIsEnabled_Offset), 0, null, bIsEnabled);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetRemovalEventEnabled_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/GeometryCollectionEngine.ChaosDestructionListener:SetCollisionEventRequestSettings
    static readonly IntPtr SetCollisionEventRequestSettings_NativeFunction;
    static readonly int SetCollisionEventRequestSettings_ParamsSize;
    static readonly int SetCollisionEventRequestSettings_InSettings_Offset;
    
    public void SetCollisionEventRequestSettings(UnrealSharp.GeometryCollectionEngine.ChaosCollisionEventRequestSettings inSettings)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetCollisionEventRequestSettings_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            UnrealSharp.GeometryCollectionEngine.ChaosCollisionEventRequestSettingsMarshaler.ToNative(IntPtr.Add(ParamsBuffer, SetCollisionEventRequestSettings_InSettings_Offset), 0, null, inSettings);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetCollisionEventRequestSettings_NativeFunction, ParamsBuffer);
            
            
        }
    }
    
    // Function /Script/GeometryCollectionEngine.ChaosDestructionListener:SetCollisionEventEnabled
    static readonly IntPtr SetCollisionEventEnabled_NativeFunction;
    static readonly int SetCollisionEventEnabled_ParamsSize;
    static readonly int SetCollisionEventEnabled_bIsEnabled_Offset;
    
    public void SetCollisionEventEnabled(bool bIsEnabled)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetCollisionEventEnabled_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BoolMarshaller.ToNative(IntPtr.Add(ParamsBuffer, SetCollisionEventEnabled_bIsEnabled_Offset), 0, null, bIsEnabled);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetCollisionEventEnabled_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/GeometryCollectionEngine.ChaosDestructionListener:SetBreakingEventRequestSettings
    static readonly IntPtr SetBreakingEventRequestSettings_NativeFunction;
    static readonly int SetBreakingEventRequestSettings_ParamsSize;
    static readonly int SetBreakingEventRequestSettings_InSettings_Offset;
    
    public void SetBreakingEventRequestSettings(UnrealSharp.GeometryCollectionEngine.ChaosBreakingEventRequestSettings inSettings)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetBreakingEventRequestSettings_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            UnrealSharp.GeometryCollectionEngine.ChaosBreakingEventRequestSettingsMarshaler.ToNative(IntPtr.Add(ParamsBuffer, SetBreakingEventRequestSettings_InSettings_Offset), 0, null, inSettings);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetBreakingEventRequestSettings_NativeFunction, ParamsBuffer);
            
            
        }
    }
    
    // Function /Script/GeometryCollectionEngine.ChaosDestructionListener:SetBreakingEventEnabled
    static readonly IntPtr SetBreakingEventEnabled_NativeFunction;
    static readonly int SetBreakingEventEnabled_ParamsSize;
    static readonly int SetBreakingEventEnabled_bIsEnabled_Offset;
    
    public void SetBreakingEventEnabled(bool bIsEnabled)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetBreakingEventEnabled_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BoolMarshaller.ToNative(IntPtr.Add(ParamsBuffer, SetBreakingEventEnabled_bIsEnabled_Offset), 0, null, bIsEnabled);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetBreakingEventEnabled_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/GeometryCollectionEngine.ChaosDestructionListener:RemoveGeometryCollectionActor
    static readonly IntPtr RemoveGeometryCollectionActor_NativeFunction;
    static readonly int RemoveGeometryCollectionActor_ParamsSize;
    static readonly int RemoveGeometryCollectionActor_GeometryCollectionActor_Offset;
    
    public void RemoveGeometryCollectionActor(UnrealSharp.GeometryCollectionEngine.GeometryCollectionActor geometryCollectionActor)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[RemoveGeometryCollectionActor_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.GeometryCollectionEngine.GeometryCollectionActor>.ToNative(IntPtr.Add(ParamsBuffer, RemoveGeometryCollectionActor_GeometryCollectionActor_Offset), 0, null, geometryCollectionActor);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, RemoveGeometryCollectionActor_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/GeometryCollectionEngine.ChaosDestructionListener:RemoveChaosSolverActor
    static readonly IntPtr RemoveChaosSolverActor_NativeFunction;
    static readonly int RemoveChaosSolverActor_ParamsSize;
    static readonly int RemoveChaosSolverActor_ChaosSolverActor_Offset;
    
    public void RemoveChaosSolverActor(UnrealSharp.ChaosSolverEngine.ChaosSolverActor chaosSolverActor)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[RemoveChaosSolverActor_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.ChaosSolverEngine.ChaosSolverActor>.ToNative(IntPtr.Add(ParamsBuffer, RemoveChaosSolverActor_ChaosSolverActor_Offset), 0, null, chaosSolverActor);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, RemoveChaosSolverActor_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/GeometryCollectionEngine.ChaosDestructionListener:IsEventListening
    static readonly IntPtr IsEventListening_NativeFunction;
    static readonly int IsEventListening_ParamsSize;
    static readonly int IsEventListening_ReturnValue_Offset;
    
    public bool IsEventListening()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[IsEventListening_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, IsEventListening_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, IsEventListening_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/GeometryCollectionEngine.ChaosDestructionListener:AddGeometryCollectionActor
    static readonly IntPtr AddGeometryCollectionActor_NativeFunction;
    static readonly int AddGeometryCollectionActor_ParamsSize;
    static readonly int AddGeometryCollectionActor_GeometryCollectionActor_Offset;
    
    public void AddGeometryCollectionActor(UnrealSharp.GeometryCollectionEngine.GeometryCollectionActor geometryCollectionActor)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[AddGeometryCollectionActor_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.GeometryCollectionEngine.GeometryCollectionActor>.ToNative(IntPtr.Add(ParamsBuffer, AddGeometryCollectionActor_GeometryCollectionActor_Offset), 0, null, geometryCollectionActor);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, AddGeometryCollectionActor_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/GeometryCollectionEngine.ChaosDestructionListener:AddChaosSolverActor
    static readonly IntPtr AddChaosSolverActor_NativeFunction;
    static readonly int AddChaosSolverActor_ParamsSize;
    static readonly int AddChaosSolverActor_ChaosSolverActor_Offset;
    
    public void AddChaosSolverActor(UnrealSharp.ChaosSolverEngine.ChaosSolverActor chaosSolverActor)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[AddChaosSolverActor_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.ChaosSolverEngine.ChaosSolverActor>.ToNative(IntPtr.Add(ParamsBuffer, AddChaosSolverActor_ChaosSolverActor_Offset), 0, null, chaosSolverActor);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, AddChaosSolverActor_NativeFunction, ParamsBuffer);
            
        }
    }
    
    
}