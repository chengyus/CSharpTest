// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UClass]
public partial class MaterialLibrary : UnrealSharp.Engine.BlueprintFunctionLibrary
{
    
    static readonly IntPtr NativeClassPtr;
    static MaterialLibrary()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("KismetMaterialLibrary");
        
        
        SetVectorParameterValue_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetVectorParameterValue");
        SetVectorParameterValue_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetVectorParameterValue_NativeFunction);
        SetVectorParameterValue_WorldContextObject_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetVectorParameterValue_NativeFunction, "WorldContextObject");
        SetVectorParameterValue_Collection_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetVectorParameterValue_NativeFunction, "Collection");
        SetVectorParameterValue_ParameterName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetVectorParameterValue_NativeFunction, "ParameterName");
        SetVectorParameterValue_ParameterValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetVectorParameterValue_NativeFunction, "ParameterValue");
        SetScalarParameterValue_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetScalarParameterValue");
        SetScalarParameterValue_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetScalarParameterValue_NativeFunction);
        SetScalarParameterValue_WorldContextObject_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetScalarParameterValue_NativeFunction, "WorldContextObject");
        SetScalarParameterValue_Collection_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetScalarParameterValue_NativeFunction, "Collection");
        SetScalarParameterValue_ParameterName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetScalarParameterValue_NativeFunction, "ParameterName");
        SetScalarParameterValue_ParameterValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetScalarParameterValue_NativeFunction, "ParameterValue");
        GetVectorParameterValue_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetVectorParameterValue");
        GetVectorParameterValue_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetVectorParameterValue_NativeFunction);
        GetVectorParameterValue_WorldContextObject_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetVectorParameterValue_NativeFunction, "WorldContextObject");
        GetVectorParameterValue_Collection_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetVectorParameterValue_NativeFunction, "Collection");
        GetVectorParameterValue_ParameterName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetVectorParameterValue_NativeFunction, "ParameterName");
        GetVectorParameterValue_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetVectorParameterValue_NativeFunction, "ReturnValue");
        GetScalarParameterValue_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetScalarParameterValue");
        GetScalarParameterValue_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetScalarParameterValue_NativeFunction);
        GetScalarParameterValue_WorldContextObject_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetScalarParameterValue_NativeFunction, "WorldContextObject");
        GetScalarParameterValue_Collection_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetScalarParameterValue_NativeFunction, "Collection");
        GetScalarParameterValue_ParameterName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetScalarParameterValue_NativeFunction, "ParameterName");
        GetScalarParameterValue_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetScalarParameterValue_NativeFunction, "ReturnValue");
        CreateDynamicMaterialInstance_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "CreateDynamicMaterialInstance");
        CreateDynamicMaterialInstance_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(CreateDynamicMaterialInstance_NativeFunction);
        CreateDynamicMaterialInstance_WorldContextObject_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(CreateDynamicMaterialInstance_NativeFunction, "WorldContextObject");
        CreateDynamicMaterialInstance_Parent_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(CreateDynamicMaterialInstance_NativeFunction, "Parent");
        CreateDynamicMaterialInstance_OptionalName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(CreateDynamicMaterialInstance_NativeFunction, "OptionalName");
        CreateDynamicMaterialInstance_CreationFlags_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(CreateDynamicMaterialInstance_NativeFunction, "CreationFlags");
        CreateDynamicMaterialInstance_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(CreateDynamicMaterialInstance_NativeFunction, "ReturnValue");
        
        
    }
    
    protected MaterialLibrary(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // Function /Script/Engine.KismetMaterialLibrary:SetVectorParameterValue
    static readonly IntPtr SetVectorParameterValue_NativeFunction;
    static readonly int SetVectorParameterValue_ParamsSize;
    static readonly int SetVectorParameterValue_WorldContextObject_Offset;
    static readonly int SetVectorParameterValue_Collection_Offset;
    static readonly int SetVectorParameterValue_ParameterName_Offset;
    static readonly int SetVectorParameterValue_ParameterValue_Offset;
    
    public static void SetVectorParameterValue(UnrealSharp.CoreUObject.Object worldContextObject, UnrealSharp.Engine.MaterialParameterCollection collection, Name parameterName, UnrealSharp.CoreUObject.LinearColor parameterValue)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetVectorParameterValue_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.CoreUObject.Object>.ToNative(IntPtr.Add(ParamsBuffer, SetVectorParameterValue_WorldContextObject_Offset), 0, null, worldContextObject);
            ObjectMarshaller<UnrealSharp.Engine.MaterialParameterCollection>.ToNative(IntPtr.Add(ParamsBuffer, SetVectorParameterValue_Collection_Offset), 0, null, collection);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(ParamsBuffer, SetVectorParameterValue_ParameterName_Offset), 0, null, parameterName);
            BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.ToNative(IntPtr.Add(ParamsBuffer, SetVectorParameterValue_ParameterValue_Offset), 0, null, parameterValue);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, SetVectorParameterValue_NativeFunction, ParamsBuffer);
            
            
        }
    }
    
    // Function /Script/Engine.KismetMaterialLibrary:SetScalarParameterValue
    static readonly IntPtr SetScalarParameterValue_NativeFunction;
    static readonly int SetScalarParameterValue_ParamsSize;
    static readonly int SetScalarParameterValue_WorldContextObject_Offset;
    static readonly int SetScalarParameterValue_Collection_Offset;
    static readonly int SetScalarParameterValue_ParameterName_Offset;
    static readonly int SetScalarParameterValue_ParameterValue_Offset;
    
    public static void SetScalarParameterValue(UnrealSharp.CoreUObject.Object worldContextObject, UnrealSharp.Engine.MaterialParameterCollection collection, Name parameterName, float parameterValue)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetScalarParameterValue_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.CoreUObject.Object>.ToNative(IntPtr.Add(ParamsBuffer, SetScalarParameterValue_WorldContextObject_Offset), 0, null, worldContextObject);
            ObjectMarshaller<UnrealSharp.Engine.MaterialParameterCollection>.ToNative(IntPtr.Add(ParamsBuffer, SetScalarParameterValue_Collection_Offset), 0, null, collection);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(ParamsBuffer, SetScalarParameterValue_ParameterName_Offset), 0, null, parameterName);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(ParamsBuffer, SetScalarParameterValue_ParameterValue_Offset), 0, null, parameterValue);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, SetScalarParameterValue_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/Engine.KismetMaterialLibrary:GetVectorParameterValue
    static readonly IntPtr GetVectorParameterValue_NativeFunction;
    static readonly int GetVectorParameterValue_ParamsSize;
    static readonly int GetVectorParameterValue_WorldContextObject_Offset;
    static readonly int GetVectorParameterValue_Collection_Offset;
    static readonly int GetVectorParameterValue_ParameterName_Offset;
    static readonly int GetVectorParameterValue_ReturnValue_Offset;
    
    public static UnrealSharp.CoreUObject.LinearColor GetVectorParameterValue(UnrealSharp.CoreUObject.Object worldContextObject, UnrealSharp.Engine.MaterialParameterCollection collection, Name parameterName)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetVectorParameterValue_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.CoreUObject.Object>.ToNative(IntPtr.Add(ParamsBuffer, GetVectorParameterValue_WorldContextObject_Offset), 0, null, worldContextObject);
            ObjectMarshaller<UnrealSharp.Engine.MaterialParameterCollection>.ToNative(IntPtr.Add(ParamsBuffer, GetVectorParameterValue_Collection_Offset), 0, null, collection);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(ParamsBuffer, GetVectorParameterValue_ParameterName_Offset), 0, null, parameterName);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, GetVectorParameterValue_NativeFunction, ParamsBuffer);
            
            UnrealSharp.CoreUObject.LinearColor returnValue;
            returnValue = BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.FromNative(IntPtr.Add(ParamsBuffer, GetVectorParameterValue_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/Engine.KismetMaterialLibrary:GetScalarParameterValue
    static readonly IntPtr GetScalarParameterValue_NativeFunction;
    static readonly int GetScalarParameterValue_ParamsSize;
    static readonly int GetScalarParameterValue_WorldContextObject_Offset;
    static readonly int GetScalarParameterValue_Collection_Offset;
    static readonly int GetScalarParameterValue_ParameterName_Offset;
    static readonly int GetScalarParameterValue_ReturnValue_Offset;
    
    public static float GetScalarParameterValue(UnrealSharp.CoreUObject.Object worldContextObject, UnrealSharp.Engine.MaterialParameterCollection collection, Name parameterName)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetScalarParameterValue_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.CoreUObject.Object>.ToNative(IntPtr.Add(ParamsBuffer, GetScalarParameterValue_WorldContextObject_Offset), 0, null, worldContextObject);
            ObjectMarshaller<UnrealSharp.Engine.MaterialParameterCollection>.ToNative(IntPtr.Add(ParamsBuffer, GetScalarParameterValue_Collection_Offset), 0, null, collection);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(ParamsBuffer, GetScalarParameterValue_ParameterName_Offset), 0, null, parameterName);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, GetScalarParameterValue_NativeFunction, ParamsBuffer);
            
            float returnValue;
            returnValue = BlittableMarshaller<float>.FromNative(IntPtr.Add(ParamsBuffer, GetScalarParameterValue_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/Engine.KismetMaterialLibrary:CreateDynamicMaterialInstance
    static readonly IntPtr CreateDynamicMaterialInstance_NativeFunction;
    static readonly int CreateDynamicMaterialInstance_ParamsSize;
    static readonly int CreateDynamicMaterialInstance_WorldContextObject_Offset;
    static readonly int CreateDynamicMaterialInstance_Parent_Offset;
    static readonly int CreateDynamicMaterialInstance_OptionalName_Offset;
    static readonly int CreateDynamicMaterialInstance_CreationFlags_Offset;
    static readonly int CreateDynamicMaterialInstance_ReturnValue_Offset;
    
    public static UnrealSharp.Engine.MaterialInstanceDynamic CreateDynamicMaterialInstance(UnrealSharp.CoreUObject.Object worldContextObject, UnrealSharp.Engine.MaterialInterface parent, Name optionalName = default(Name), UnrealSharp.Engine.EMIDCreationFlags creationFlags = default(UnrealSharp.Engine.EMIDCreationFlags))
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[CreateDynamicMaterialInstance_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.CoreUObject.Object>.ToNative(IntPtr.Add(ParamsBuffer, CreateDynamicMaterialInstance_WorldContextObject_Offset), 0, null, worldContextObject);
            ObjectMarshaller<UnrealSharp.Engine.MaterialInterface>.ToNative(IntPtr.Add(ParamsBuffer, CreateDynamicMaterialInstance_Parent_Offset), 0, null, parent);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(ParamsBuffer, CreateDynamicMaterialInstance_OptionalName_Offset), 0, null, optionalName);
            BlittableMarshaller<UnrealSharp.Engine.EMIDCreationFlags>.ToNative(IntPtr.Add(ParamsBuffer, CreateDynamicMaterialInstance_CreationFlags_Offset), 0, null, creationFlags);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, CreateDynamicMaterialInstance_NativeFunction, ParamsBuffer);
            
            UnrealSharp.Engine.MaterialInstanceDynamic returnValue;
            returnValue = ObjectMarshaller<UnrealSharp.Engine.MaterialInstanceDynamic>.FromNative(IntPtr.Add(ParamsBuffer, CreateDynamicMaterialInstance_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    
}