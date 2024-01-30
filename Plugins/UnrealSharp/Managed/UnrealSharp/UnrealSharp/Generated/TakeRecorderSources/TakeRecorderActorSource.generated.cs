// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.TakeRecorderSources;

[UClass]
public partial class TakeRecorderActorSource : UnrealSharp.TakesCore.TakeRecorderSource
{
    
    static readonly IntPtr NativeClassPtr;
    static TakeRecorderActorSource()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("TakeRecorderActorSource");
        
        Target_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Target");
        RecordType_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "RecordType");
        bRecordParentHierarchy_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bRecordParentHierarchy");
        bReduceKeys_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bReduceKeys");
        RecordedProperties_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "RecordedProperties");
        
        SetSourceActor_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetSourceActor");
        SetSourceActor_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetSourceActor_NativeFunction);
        SetSourceActor_InTarget_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetSourceActor_NativeFunction, "InTarget");
        RemoveActorFromSources_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "RemoveActorFromSources");
        RemoveActorFromSources_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(RemoveActorFromSources_NativeFunction);
        RemoveActorFromSources_InActor_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(RemoveActorFromSources_NativeFunction, "InActor");
        RemoveActorFromSources_InSources_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(RemoveActorFromSources_NativeFunction, "InSources");
        GetSourceActor_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetSourceActor");
        GetSourceActor_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetSourceActor_NativeFunction);
        GetSourceActor_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetSourceActor_NativeFunction, "ReturnValue");
        AddSourceForActor_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "AddSourceForActor");
        AddSourceForActor_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(AddSourceForActor_NativeFunction);
        AddSourceForActor_InActor_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AddSourceForActor_NativeFunction, "InActor");
        AddSourceForActor_InSources_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AddSourceForActor_NativeFunction, "InSources");
        AddSourceForActor_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AddSourceForActor_NativeFunction, "ReturnValue");
        
        
    }
    
    protected TakeRecorderActorSource(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // SoftObjectProperty /Script/TakeRecorderSources.TakeRecorderActorSource:Target
    static readonly int Target_Offset;
    
    public SoftObject<UnrealSharp.Engine.Actor> Target
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<SoftObject<UnrealSharp.Engine.Actor>>.FromNative(IntPtr.Add(NativeObject, Target_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<SoftObject<UnrealSharp.Engine.Actor>>.ToNative(IntPtr.Add(NativeObject, Target_Offset), 0, this, value);
        }
    }
    
    // EnumProperty /Script/TakeRecorderSources.TakeRecorderActorSource:RecordType
    static readonly int RecordType_Offset;
    
    public UnrealSharp.TakeRecorderSources.ETakeRecorderActorRecordType RecordType
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<UnrealSharp.TakeRecorderSources.ETakeRecorderActorRecordType>.FromNative(IntPtr.Add(NativeObject, RecordType_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<UnrealSharp.TakeRecorderSources.ETakeRecorderActorRecordType>.ToNative(IntPtr.Add(NativeObject, RecordType_Offset), 0, this, value);
        }
    }
    
    // BoolProperty /Script/TakeRecorderSources.TakeRecorderActorSource:bRecordParentHierarchy
    static readonly int bRecordParentHierarchy_Offset;
    
    public bool bRecordParentHierarchy
    {
        get
        {
            CheckObjectForValidity();
            return BoolMarshaller.FromNative(IntPtr.Add(NativeObject, bRecordParentHierarchy_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BoolMarshaller.ToNative(IntPtr.Add(NativeObject, bRecordParentHierarchy_Offset), 0, this, value);
        }
    }
    
    // BoolProperty /Script/TakeRecorderSources.TakeRecorderActorSource:bReduceKeys
    static readonly int bReduceKeys_Offset;
    
    public bool bReduceKeys
    {
        get
        {
            CheckObjectForValidity();
            return BoolMarshaller.FromNative(IntPtr.Add(NativeObject, bReduceKeys_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BoolMarshaller.ToNative(IntPtr.Add(NativeObject, bReduceKeys_Offset), 0, this, value);
        }
    }
    
    // ObjectProperty /Script/TakeRecorderSources.TakeRecorderActorSource:RecordedProperties
    static readonly int RecordedProperties_Offset;
    
    public UnrealSharp.TakesCore.ActorRecorderPropertyMap RecordedProperties
    {
        get
        {
            CheckObjectForValidity();
            return ObjectMarshaller<UnrealSharp.TakesCore.ActorRecorderPropertyMap>.FromNative(IntPtr.Add(NativeObject, RecordedProperties_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            ObjectMarshaller<UnrealSharp.TakesCore.ActorRecorderPropertyMap>.ToNative(IntPtr.Add(NativeObject, RecordedProperties_Offset), 0, this, value);
        }
    }
    
    // Function /Script/TakeRecorderSources.TakeRecorderActorSource:SetSourceActor
    static readonly IntPtr SetSourceActor_NativeFunction;
    static readonly int SetSourceActor_ParamsSize;
    static readonly int SetSourceActor_InTarget_Offset;
    
    public void SetSourceActor(SoftObject<UnrealSharp.Engine.Actor> inTarget)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetSourceActor_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<SoftObject<UnrealSharp.Engine.Actor>>.ToNative(IntPtr.Add(ParamsBuffer, SetSourceActor_InTarget_Offset), 0, null, inTarget);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetSourceActor_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/TakeRecorderSources.TakeRecorderActorSource:RemoveActorFromSources
    static readonly IntPtr RemoveActorFromSources_NativeFunction;
    static readonly int RemoveActorFromSources_ParamsSize;
    static readonly int RemoveActorFromSources_InActor_Offset;
    static readonly int RemoveActorFromSources_InSources_Offset;
    
    public static void RemoveActorFromSources(UnrealSharp.Engine.Actor inActor, UnrealSharp.TakesCore.TakeRecorderSources inSources)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[RemoveActorFromSources_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.Engine.Actor>.ToNative(IntPtr.Add(ParamsBuffer, RemoveActorFromSources_InActor_Offset), 0, null, inActor);
            ObjectMarshaller<UnrealSharp.TakesCore.TakeRecorderSources>.ToNative(IntPtr.Add(ParamsBuffer, RemoveActorFromSources_InSources_Offset), 0, null, inSources);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, RemoveActorFromSources_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/TakeRecorderSources.TakeRecorderActorSource:GetSourceActor
    static readonly IntPtr GetSourceActor_NativeFunction;
    static readonly int GetSourceActor_ParamsSize;
    static readonly int GetSourceActor_ReturnValue_Offset;
    
    public SoftObject<UnrealSharp.Engine.Actor> GetSourceActor()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetSourceActor_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetSourceActor_NativeFunction, ParamsBuffer);
            
            SoftObject<UnrealSharp.Engine.Actor> returnValue;
            returnValue = BlittableMarshaller<SoftObject<UnrealSharp.Engine.Actor>>.FromNative(IntPtr.Add(ParamsBuffer, GetSourceActor_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/TakeRecorderSources.TakeRecorderActorSource:AddSourceForActor
    static readonly IntPtr AddSourceForActor_NativeFunction;
    static readonly int AddSourceForActor_ParamsSize;
    static readonly int AddSourceForActor_InActor_Offset;
    static readonly int AddSourceForActor_InSources_Offset;
    static readonly int AddSourceForActor_ReturnValue_Offset;
    
    public static UnrealSharp.TakesCore.TakeRecorderSource AddSourceForActor(UnrealSharp.Engine.Actor inActor, UnrealSharp.TakesCore.TakeRecorderSources inSources)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[AddSourceForActor_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.Engine.Actor>.ToNative(IntPtr.Add(ParamsBuffer, AddSourceForActor_InActor_Offset), 0, null, inActor);
            ObjectMarshaller<UnrealSharp.TakesCore.TakeRecorderSources>.ToNative(IntPtr.Add(ParamsBuffer, AddSourceForActor_InSources_Offset), 0, null, inSources);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, AddSourceForActor_NativeFunction, ParamsBuffer);
            
            UnrealSharp.TakesCore.TakeRecorderSource returnValue;
            returnValue = ObjectMarshaller<UnrealSharp.TakesCore.TakeRecorderSource>.FromNative(IntPtr.Add(ParamsBuffer, AddSourceForActor_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    
}