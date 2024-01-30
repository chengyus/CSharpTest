// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UClass]
public partial class DataLayerManager : UnrealSharp.CoreUObject.Object
{
    
    static DataLayerManager()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("DataLayerManager");
        
        
        SetDataLayerRuntimeState_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetDataLayerRuntimeState");
        SetDataLayerRuntimeState_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetDataLayerRuntimeState_NativeFunction);
        SetDataLayerRuntimeState_InDataLayerAsset_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetDataLayerRuntimeState_NativeFunction, "InDataLayerAsset");
        SetDataLayerRuntimeState_InState_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetDataLayerRuntimeState_NativeFunction, "InState");
        SetDataLayerRuntimeState_bInIsRecursive_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetDataLayerRuntimeState_NativeFunction, "bInIsRecursive");
        SetDataLayerRuntimeState_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetDataLayerRuntimeState_NativeFunction, "ReturnValue");
        SetDataLayerInstanceRuntimeState_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetDataLayerInstanceRuntimeState");
        SetDataLayerInstanceRuntimeState_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetDataLayerInstanceRuntimeState_NativeFunction);
        SetDataLayerInstanceRuntimeState_InDataLayerInstance_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetDataLayerInstanceRuntimeState_NativeFunction, "InDataLayerInstance");
        SetDataLayerInstanceRuntimeState_InState_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetDataLayerInstanceRuntimeState_NativeFunction, "InState");
        SetDataLayerInstanceRuntimeState_bInIsRecursive_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetDataLayerInstanceRuntimeState_NativeFunction, "bInIsRecursive");
        SetDataLayerInstanceRuntimeState_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetDataLayerInstanceRuntimeState_NativeFunction, "ReturnValue");
        GetDataLayerInstanceRuntimeState_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetDataLayerInstanceRuntimeState");
        GetDataLayerInstanceRuntimeState_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetDataLayerInstanceRuntimeState_NativeFunction);
        GetDataLayerInstanceRuntimeState_InDataLayerInstance_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetDataLayerInstanceRuntimeState_NativeFunction, "InDataLayerInstance");
        GetDataLayerInstanceRuntimeState_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetDataLayerInstanceRuntimeState_NativeFunction, "ReturnValue");
        GetDataLayerInstanceFromName_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetDataLayerInstanceFromName");
        GetDataLayerInstanceFromName_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetDataLayerInstanceFromName_NativeFunction);
        GetDataLayerInstanceFromName_InDataLayerInstanceName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetDataLayerInstanceFromName_NativeFunction, "InDataLayerInstanceName");
        GetDataLayerInstanceFromName_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetDataLayerInstanceFromName_NativeFunction, "ReturnValue");
        GetDataLayerInstanceFromAsset_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetDataLayerInstanceFromAsset");
        GetDataLayerInstanceFromAsset_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetDataLayerInstanceFromAsset_NativeFunction);
        GetDataLayerInstanceFromAsset_InDataLayerAsset_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetDataLayerInstanceFromAsset_NativeFunction, "InDataLayerAsset");
        GetDataLayerInstanceFromAsset_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetDataLayerInstanceFromAsset_NativeFunction, "ReturnValue");
        GetDataLayerInstanceEffectiveRuntimeState_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetDataLayerInstanceEffectiveRuntimeState");
        GetDataLayerInstanceEffectiveRuntimeState_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetDataLayerInstanceEffectiveRuntimeState_NativeFunction);
        GetDataLayerInstanceEffectiveRuntimeState_InDataLayerInstance_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetDataLayerInstanceEffectiveRuntimeState_NativeFunction, "InDataLayerInstance");
        GetDataLayerInstanceEffectiveRuntimeState_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetDataLayerInstanceEffectiveRuntimeState_NativeFunction, "ReturnValue");
        
        
    }
    
    protected DataLayerManager(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // Function /Script/Engine.DataLayerManager:SetDataLayerRuntimeState
    static readonly IntPtr SetDataLayerRuntimeState_NativeFunction;
    static readonly int SetDataLayerRuntimeState_ParamsSize;
    static readonly int SetDataLayerRuntimeState_InDataLayerAsset_Offset;
    static readonly int SetDataLayerRuntimeState_InState_Offset;
    static readonly int SetDataLayerRuntimeState_bInIsRecursive_Offset;
    static readonly int SetDataLayerRuntimeState_ReturnValue_Offset;
    
    public bool SetDataLayerRuntimeState(UnrealSharp.Engine.DataLayerAsset inDataLayerAsset, UnrealSharp.Engine.EDataLayerRuntimeState inState, bool bInIsRecursive = false)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetDataLayerRuntimeState_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.Engine.DataLayerAsset>.ToNative(IntPtr.Add(ParamsBuffer, SetDataLayerRuntimeState_InDataLayerAsset_Offset), 0, null, inDataLayerAsset);
            BlittableMarshaller<UnrealSharp.Engine.EDataLayerRuntimeState>.ToNative(IntPtr.Add(ParamsBuffer, SetDataLayerRuntimeState_InState_Offset), 0, null, inState);
            BoolMarshaller.ToNative(IntPtr.Add(ParamsBuffer, SetDataLayerRuntimeState_bInIsRecursive_Offset), 0, null, bInIsRecursive);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetDataLayerRuntimeState_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, SetDataLayerRuntimeState_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/Engine.DataLayerManager:SetDataLayerInstanceRuntimeState
    static readonly IntPtr SetDataLayerInstanceRuntimeState_NativeFunction;
    static readonly int SetDataLayerInstanceRuntimeState_ParamsSize;
    static readonly int SetDataLayerInstanceRuntimeState_InDataLayerInstance_Offset;
    static readonly int SetDataLayerInstanceRuntimeState_InState_Offset;
    static readonly int SetDataLayerInstanceRuntimeState_bInIsRecursive_Offset;
    static readonly int SetDataLayerInstanceRuntimeState_ReturnValue_Offset;
    
    public bool SetDataLayerInstanceRuntimeState(UnrealSharp.Engine.DataLayerInstance inDataLayerInstance, UnrealSharp.Engine.EDataLayerRuntimeState inState, bool bInIsRecursive = false)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetDataLayerInstanceRuntimeState_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.Engine.DataLayerInstance>.ToNative(IntPtr.Add(ParamsBuffer, SetDataLayerInstanceRuntimeState_InDataLayerInstance_Offset), 0, null, inDataLayerInstance);
            BlittableMarshaller<UnrealSharp.Engine.EDataLayerRuntimeState>.ToNative(IntPtr.Add(ParamsBuffer, SetDataLayerInstanceRuntimeState_InState_Offset), 0, null, inState);
            BoolMarshaller.ToNative(IntPtr.Add(ParamsBuffer, SetDataLayerInstanceRuntimeState_bInIsRecursive_Offset), 0, null, bInIsRecursive);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetDataLayerInstanceRuntimeState_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, SetDataLayerInstanceRuntimeState_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/Engine.DataLayerManager:GetDataLayerInstanceRuntimeState
    static readonly IntPtr GetDataLayerInstanceRuntimeState_NativeFunction;
    static readonly int GetDataLayerInstanceRuntimeState_ParamsSize;
    static readonly int GetDataLayerInstanceRuntimeState_InDataLayerInstance_Offset;
    static readonly int GetDataLayerInstanceRuntimeState_ReturnValue_Offset;
    
    public UnrealSharp.Engine.EDataLayerRuntimeState GetDataLayerInstanceRuntimeState(UnrealSharp.Engine.DataLayerInstance inDataLayerInstance)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetDataLayerInstanceRuntimeState_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.Engine.DataLayerInstance>.ToNative(IntPtr.Add(ParamsBuffer, GetDataLayerInstanceRuntimeState_InDataLayerInstance_Offset), 0, null, inDataLayerInstance);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetDataLayerInstanceRuntimeState_NativeFunction, ParamsBuffer);
            
            UnrealSharp.Engine.EDataLayerRuntimeState returnValue;
            returnValue = BlittableMarshaller<UnrealSharp.Engine.EDataLayerRuntimeState>.FromNative(IntPtr.Add(ParamsBuffer, GetDataLayerInstanceRuntimeState_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/Engine.DataLayerManager:GetDataLayerInstanceFromName
    static readonly IntPtr GetDataLayerInstanceFromName_NativeFunction;
    static readonly int GetDataLayerInstanceFromName_ParamsSize;
    static readonly int GetDataLayerInstanceFromName_InDataLayerInstanceName_Offset;
    static readonly int GetDataLayerInstanceFromName_ReturnValue_Offset;
    
    public UnrealSharp.Engine.DataLayerInstance GetDataLayerInstanceFromName(Name inDataLayerInstanceName)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetDataLayerInstanceFromName_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(ParamsBuffer, GetDataLayerInstanceFromName_InDataLayerInstanceName_Offset), 0, null, inDataLayerInstanceName);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetDataLayerInstanceFromName_NativeFunction, ParamsBuffer);
            
            UnrealSharp.Engine.DataLayerInstance returnValue;
            returnValue = ObjectMarshaller<UnrealSharp.Engine.DataLayerInstance>.FromNative(IntPtr.Add(ParamsBuffer, GetDataLayerInstanceFromName_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/Engine.DataLayerManager:GetDataLayerInstanceFromAsset
    static readonly IntPtr GetDataLayerInstanceFromAsset_NativeFunction;
    static readonly int GetDataLayerInstanceFromAsset_ParamsSize;
    static readonly int GetDataLayerInstanceFromAsset_InDataLayerAsset_Offset;
    static readonly int GetDataLayerInstanceFromAsset_ReturnValue_Offset;
    
    public UnrealSharp.Engine.DataLayerInstance GetDataLayerInstanceFromAsset(UnrealSharp.Engine.DataLayerAsset inDataLayerAsset)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetDataLayerInstanceFromAsset_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.Engine.DataLayerAsset>.ToNative(IntPtr.Add(ParamsBuffer, GetDataLayerInstanceFromAsset_InDataLayerAsset_Offset), 0, null, inDataLayerAsset);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetDataLayerInstanceFromAsset_NativeFunction, ParamsBuffer);
            
            UnrealSharp.Engine.DataLayerInstance returnValue;
            returnValue = ObjectMarshaller<UnrealSharp.Engine.DataLayerInstance>.FromNative(IntPtr.Add(ParamsBuffer, GetDataLayerInstanceFromAsset_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/Engine.DataLayerManager:GetDataLayerInstanceEffectiveRuntimeState
    static readonly IntPtr GetDataLayerInstanceEffectiveRuntimeState_NativeFunction;
    static readonly int GetDataLayerInstanceEffectiveRuntimeState_ParamsSize;
    static readonly int GetDataLayerInstanceEffectiveRuntimeState_InDataLayerInstance_Offset;
    static readonly int GetDataLayerInstanceEffectiveRuntimeState_ReturnValue_Offset;
    
    public UnrealSharp.Engine.EDataLayerRuntimeState GetDataLayerInstanceEffectiveRuntimeState(UnrealSharp.Engine.DataLayerInstance inDataLayerInstance)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetDataLayerInstanceEffectiveRuntimeState_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.Engine.DataLayerInstance>.ToNative(IntPtr.Add(ParamsBuffer, GetDataLayerInstanceEffectiveRuntimeState_InDataLayerInstance_Offset), 0, null, inDataLayerInstance);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetDataLayerInstanceEffectiveRuntimeState_NativeFunction, ParamsBuffer);
            
            UnrealSharp.Engine.EDataLayerRuntimeState returnValue;
            returnValue = BlittableMarshaller<UnrealSharp.Engine.EDataLayerRuntimeState>.FromNative(IntPtr.Add(ParamsBuffer, GetDataLayerInstanceEffectiveRuntimeState_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    
}