// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.StructUtilsEngine;

[UClass]
public partial class StructUtilsFunctionLibrary : UnrealSharp.Engine.BlueprintFunctionLibrary
{
    
    static readonly IntPtr NativeClassPtr;
    static StructUtilsFunctionLibrary()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("StructUtilsFunctionLibrary");
        
        
        Reset_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "Reset");
        Reset_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(Reset_NativeFunction);
        Reset_InstancedStruct_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(Reset_NativeFunction, "InstancedStruct");
        Reset_StructType_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(Reset_NativeFunction, "StructType");
        NotEqual_InstancedStruct_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "NotEqual_InstancedStruct");
        NotEqual_InstancedStruct_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(NotEqual_InstancedStruct_NativeFunction);
        NotEqual_InstancedStruct_A_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NotEqual_InstancedStruct_NativeFunction, "A");
        NotEqual_InstancedStruct_B_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NotEqual_InstancedStruct_NativeFunction, "B");
        NotEqual_InstancedStruct_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NotEqual_InstancedStruct_NativeFunction, "ReturnValue");
        IsValid_InstancedStruct_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "IsValid_InstancedStruct");
        IsValid_InstancedStruct_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(IsValid_InstancedStruct_NativeFunction);
        IsValid_InstancedStruct_InstancedStruct_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(IsValid_InstancedStruct_NativeFunction, "InstancedStruct");
        IsValid_InstancedStruct_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(IsValid_InstancedStruct_NativeFunction, "ReturnValue");
        IsInstancedStructValid_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "IsInstancedStructValid");
        IsInstancedStructValid_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(IsInstancedStructValid_NativeFunction);
        IsInstancedStructValid_InstancedStruct_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(IsInstancedStructValid_NativeFunction, "InstancedStruct");
        IsInstancedStructValid_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(IsInstancedStructValid_NativeFunction, "ReturnValue");
        EqualEqual_InstancedStruct_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "EqualEqual_InstancedStruct");
        EqualEqual_InstancedStruct_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(EqualEqual_InstancedStruct_NativeFunction);
        EqualEqual_InstancedStruct_A_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(EqualEqual_InstancedStruct_NativeFunction, "A");
        EqualEqual_InstancedStruct_B_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(EqualEqual_InstancedStruct_NativeFunction, "B");
        EqualEqual_InstancedStruct_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(EqualEqual_InstancedStruct_NativeFunction, "ReturnValue");
        
        
    }
    
    protected StructUtilsFunctionLibrary(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // Function /Script/StructUtilsEngine.StructUtilsFunctionLibrary:Reset
    static readonly IntPtr Reset_NativeFunction;
    static readonly int Reset_ParamsSize;
    static readonly int Reset_InstancedStruct_Offset;
    static readonly int Reset_StructType_Offset;
    
    public static void Reset(ref UnrealSharp.StructUtils.InstancedStruct instancedStruct, UnrealSharp.CoreUObject.ScriptStruct structType = default(UnrealSharp.CoreUObject.ScriptStruct))
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[Reset_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            UnrealSharp.StructUtils.InstancedStructMarshaler.ToNative(IntPtr.Add(ParamsBuffer, Reset_InstancedStruct_Offset), 0, null, instancedStruct);
            ObjectMarshaller<UnrealSharp.CoreUObject.ScriptStruct>.ToNative(IntPtr.Add(ParamsBuffer, Reset_StructType_Offset), 0, null, structType);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, Reset_NativeFunction, ParamsBuffer);
            
            instancedStruct = UnrealSharp.StructUtils.InstancedStructMarshaler.FromNative(IntPtr.Add(ParamsBuffer, Reset_InstancedStruct_Offset), 0, null);
            
        }
    }
    
    // Function /Script/StructUtilsEngine.StructUtilsFunctionLibrary:NotEqual_InstancedStruct
    static readonly IntPtr NotEqual_InstancedStruct_NativeFunction;
    static readonly int NotEqual_InstancedStruct_ParamsSize;
    static readonly int NotEqual_InstancedStruct_A_Offset;
    static readonly int NotEqual_InstancedStruct_B_Offset;
    static readonly int NotEqual_InstancedStruct_ReturnValue_Offset;
    
    public static bool NotEqual_InstancedStruct(UnrealSharp.StructUtils.InstancedStruct a, UnrealSharp.StructUtils.InstancedStruct b)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[NotEqual_InstancedStruct_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            UnrealSharp.StructUtils.InstancedStructMarshaler.ToNative(IntPtr.Add(ParamsBuffer, NotEqual_InstancedStruct_A_Offset), 0, null, a);
            UnrealSharp.StructUtils.InstancedStructMarshaler.ToNative(IntPtr.Add(ParamsBuffer, NotEqual_InstancedStruct_B_Offset), 0, null, b);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, NotEqual_InstancedStruct_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, NotEqual_InstancedStruct_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/StructUtilsEngine.StructUtilsFunctionLibrary:IsValid_InstancedStruct
    static readonly IntPtr IsValid_InstancedStruct_NativeFunction;
    static readonly int IsValid_InstancedStruct_ParamsSize;
    static readonly int IsValid_InstancedStruct_InstancedStruct_Offset;
    static readonly int IsValid_InstancedStruct_ReturnValue_Offset;
    
    public static bool IsValid_InstancedStruct(UnrealSharp.StructUtils.InstancedStruct instancedStruct)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[IsValid_InstancedStruct_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            UnrealSharp.StructUtils.InstancedStructMarshaler.ToNative(IntPtr.Add(ParamsBuffer, IsValid_InstancedStruct_InstancedStruct_Offset), 0, null, instancedStruct);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, IsValid_InstancedStruct_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, IsValid_InstancedStruct_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/StructUtilsEngine.StructUtilsFunctionLibrary:IsInstancedStructValid
    static readonly IntPtr IsInstancedStructValid_NativeFunction;
    static readonly int IsInstancedStructValid_ParamsSize;
    static readonly int IsInstancedStructValid_InstancedStruct_Offset;
    static readonly int IsInstancedStructValid_ReturnValue_Offset;
    
    public static UnrealSharp.StructUtilsEngine.EStructUtilsResult IsInstancedStructValid(UnrealSharp.StructUtils.InstancedStruct instancedStruct)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[IsInstancedStructValid_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            UnrealSharp.StructUtils.InstancedStructMarshaler.ToNative(IntPtr.Add(ParamsBuffer, IsInstancedStructValid_InstancedStruct_Offset), 0, null, instancedStruct);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, IsInstancedStructValid_NativeFunction, ParamsBuffer);
            
            UnrealSharp.StructUtilsEngine.EStructUtilsResult returnValue;
            returnValue = BlittableMarshaller<UnrealSharp.StructUtilsEngine.EStructUtilsResult>.FromNative(IntPtr.Add(ParamsBuffer, IsInstancedStructValid_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/StructUtilsEngine.StructUtilsFunctionLibrary:EqualEqual_InstancedStruct
    static readonly IntPtr EqualEqual_InstancedStruct_NativeFunction;
    static readonly int EqualEqual_InstancedStruct_ParamsSize;
    static readonly int EqualEqual_InstancedStruct_A_Offset;
    static readonly int EqualEqual_InstancedStruct_B_Offset;
    static readonly int EqualEqual_InstancedStruct_ReturnValue_Offset;
    
    public static bool EqualEqual_InstancedStruct(UnrealSharp.StructUtils.InstancedStruct a, UnrealSharp.StructUtils.InstancedStruct b)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[EqualEqual_InstancedStruct_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            UnrealSharp.StructUtils.InstancedStructMarshaler.ToNative(IntPtr.Add(ParamsBuffer, EqualEqual_InstancedStruct_A_Offset), 0, null, a);
            UnrealSharp.StructUtils.InstancedStructMarshaler.ToNative(IntPtr.Add(ParamsBuffer, EqualEqual_InstancedStruct_B_Offset), 0, null, b);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, EqualEqual_InstancedStruct_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, EqualEqual_InstancedStruct_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    
}