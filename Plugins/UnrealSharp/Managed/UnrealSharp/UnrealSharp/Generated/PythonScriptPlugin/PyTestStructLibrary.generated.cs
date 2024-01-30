// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.PythonScriptPlugin;

[UClass]
public partial class PyTestStructLibrary : UnrealSharp.Engine.BlueprintFunctionLibrary
{
    
    static readonly IntPtr NativeClassPtr;
    static PyTestStructLibrary()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("PyTestStructLibrary");
        
        
        SetBoolMutableViaRef_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetBoolMutableViaRef");
        SetBoolMutableViaRef_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetBoolMutableViaRef_NativeFunction);
        SetBoolMutableViaRef_InStruct_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetBoolMutableViaRef_NativeFunction, "InStruct");
        SetBoolMutable_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetBoolMutable");
        SetBoolMutable_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetBoolMutable_NativeFunction);
        SetBoolMutable_InStruct_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetBoolMutable_NativeFunction, "InStruct");
        LegacyIsBoolSet_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "LegacyIsBoolSet");
        LegacyIsBoolSet_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(LegacyIsBoolSet_NativeFunction);
        LegacyIsBoolSet_InStruct_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(LegacyIsBoolSet_NativeFunction, "InStruct");
        LegacyIsBoolSet_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(LegacyIsBoolSet_NativeFunction, "ReturnValue");
        IsBoolSet_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "IsBoolSet");
        IsBoolSet_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(IsBoolSet_NativeFunction);
        IsBoolSet_InStruct_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(IsBoolSet_NativeFunction, "InStruct");
        IsBoolSet_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(IsBoolSet_NativeFunction, "ReturnValue");
        GetConstantValue_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetConstantValue");
        GetConstantValue_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetConstantValue_NativeFunction);
        GetConstantValue_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetConstantValue_NativeFunction, "ReturnValue");
        ClearBoolMutableViaRef_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "ClearBoolMutableViaRef");
        ClearBoolMutableViaRef_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(ClearBoolMutableViaRef_NativeFunction);
        ClearBoolMutableViaRef_InStruct_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ClearBoolMutableViaRef_NativeFunction, "InStruct");
        ClearBoolMutable_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "ClearBoolMutable");
        ClearBoolMutable_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(ClearBoolMutable_NativeFunction);
        ClearBoolMutable_InStruct_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ClearBoolMutable_NativeFunction, "InStruct");
        AddStr_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "AddStr");
        AddStr_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(AddStr_NativeFunction);
        AddStr_InStruct_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AddStr_NativeFunction, "InStruct");
        AddStr_InValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AddStr_NativeFunction, "InValue");
        AddStr_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AddStr_NativeFunction, "ReturnValue");
        AddInt_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "AddInt");
        AddInt_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(AddInt_NativeFunction);
        AddInt_InStruct_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AddInt_NativeFunction, "InStruct");
        AddInt_InValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AddInt_NativeFunction, "InValue");
        AddInt_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AddInt_NativeFunction, "ReturnValue");
        AddFloat_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "AddFloat");
        AddFloat_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(AddFloat_NativeFunction);
        AddFloat_InStruct_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AddFloat_NativeFunction, "InStruct");
        AddFloat_InValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AddFloat_NativeFunction, "InValue");
        AddFloat_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AddFloat_NativeFunction, "ReturnValue");
        
        
    }
    
    protected PyTestStructLibrary(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // Function /Script/PythonScriptPlugin.PyTestStructLibrary:SetBoolMutableViaRef
    static readonly IntPtr SetBoolMutableViaRef_NativeFunction;
    static readonly int SetBoolMutableViaRef_ParamsSize;
    static readonly int SetBoolMutableViaRef_InStruct_Offset;
    
    public static void SetBoolMutableViaRef(ref UnrealSharp.PythonScriptPlugin.PyTestStruct inStruct)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetBoolMutableViaRef_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            UnrealSharp.PythonScriptPlugin.PyTestStructMarshaler.ToNative(IntPtr.Add(ParamsBuffer, SetBoolMutableViaRef_InStruct_Offset), 0, null, inStruct);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, SetBoolMutableViaRef_NativeFunction, ParamsBuffer);
            
            inStruct = UnrealSharp.PythonScriptPlugin.PyTestStructMarshaler.FromNative(IntPtr.Add(ParamsBuffer, SetBoolMutableViaRef_InStruct_Offset), 0, null);
            
        }
    }
    
    // Function /Script/PythonScriptPlugin.PyTestStructLibrary:SetBoolMutable
    static readonly IntPtr SetBoolMutable_NativeFunction;
    static readonly int SetBoolMutable_ParamsSize;
    static readonly int SetBoolMutable_InStruct_Offset;
    
    public static void SetBoolMutable(UnrealSharp.PythonScriptPlugin.PyTestStruct inStruct)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetBoolMutable_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            UnrealSharp.PythonScriptPlugin.PyTestStructMarshaler.ToNative(IntPtr.Add(ParamsBuffer, SetBoolMutable_InStruct_Offset), 0, null, inStruct);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, SetBoolMutable_NativeFunction, ParamsBuffer);
            
            
        }
    }
    
    // Function /Script/PythonScriptPlugin.PyTestStructLibrary:LegacyIsBoolSet
    static readonly IntPtr LegacyIsBoolSet_NativeFunction;
    static readonly int LegacyIsBoolSet_ParamsSize;
    static readonly int LegacyIsBoolSet_InStruct_Offset;
    static readonly int LegacyIsBoolSet_ReturnValue_Offset;
    
    [Obsolete("LegacyIsBoolSet is deprecated. Please use IsBoolSet instead.")]
    public static bool LegacyIsBoolSet(UnrealSharp.PythonScriptPlugin.PyTestStruct inStruct)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[LegacyIsBoolSet_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            UnrealSharp.PythonScriptPlugin.PyTestStructMarshaler.ToNative(IntPtr.Add(ParamsBuffer, LegacyIsBoolSet_InStruct_Offset), 0, null, inStruct);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, LegacyIsBoolSet_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, LegacyIsBoolSet_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/PythonScriptPlugin.PyTestStructLibrary:IsBoolSet
    static readonly IntPtr IsBoolSet_NativeFunction;
    static readonly int IsBoolSet_ParamsSize;
    static readonly int IsBoolSet_InStruct_Offset;
    static readonly int IsBoolSet_ReturnValue_Offset;
    
    public static bool IsBoolSet(UnrealSharp.PythonScriptPlugin.PyTestStruct inStruct)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[IsBoolSet_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            UnrealSharp.PythonScriptPlugin.PyTestStructMarshaler.ToNative(IntPtr.Add(ParamsBuffer, IsBoolSet_InStruct_Offset), 0, null, inStruct);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, IsBoolSet_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, IsBoolSet_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/PythonScriptPlugin.PyTestStructLibrary:GetConstantValue
    static readonly IntPtr GetConstantValue_NativeFunction;
    static readonly int GetConstantValue_ParamsSize;
    static readonly int GetConstantValue_ReturnValue_Offset;
    
    public static int GetConstantValue()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetConstantValue_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, GetConstantValue_NativeFunction, ParamsBuffer);
            
            int returnValue;
            returnValue = BlittableMarshaller<int>.FromNative(IntPtr.Add(ParamsBuffer, GetConstantValue_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/PythonScriptPlugin.PyTestStructLibrary:ClearBoolMutableViaRef
    static readonly IntPtr ClearBoolMutableViaRef_NativeFunction;
    static readonly int ClearBoolMutableViaRef_ParamsSize;
    static readonly int ClearBoolMutableViaRef_InStruct_Offset;
    
    public static void ClearBoolMutableViaRef(ref UnrealSharp.PythonScriptPlugin.PyTestStruct inStruct)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[ClearBoolMutableViaRef_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            UnrealSharp.PythonScriptPlugin.PyTestStructMarshaler.ToNative(IntPtr.Add(ParamsBuffer, ClearBoolMutableViaRef_InStruct_Offset), 0, null, inStruct);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, ClearBoolMutableViaRef_NativeFunction, ParamsBuffer);
            
            inStruct = UnrealSharp.PythonScriptPlugin.PyTestStructMarshaler.FromNative(IntPtr.Add(ParamsBuffer, ClearBoolMutableViaRef_InStruct_Offset), 0, null);
            
        }
    }
    
    // Function /Script/PythonScriptPlugin.PyTestStructLibrary:ClearBoolMutable
    static readonly IntPtr ClearBoolMutable_NativeFunction;
    static readonly int ClearBoolMutable_ParamsSize;
    static readonly int ClearBoolMutable_InStruct_Offset;
    
    public static void ClearBoolMutable(UnrealSharp.PythonScriptPlugin.PyTestStruct inStruct)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[ClearBoolMutable_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            UnrealSharp.PythonScriptPlugin.PyTestStructMarshaler.ToNative(IntPtr.Add(ParamsBuffer, ClearBoolMutable_InStruct_Offset), 0, null, inStruct);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, ClearBoolMutable_NativeFunction, ParamsBuffer);
            
            
        }
    }
    
    // Function /Script/PythonScriptPlugin.PyTestStructLibrary:AddStr
    static readonly IntPtr AddStr_NativeFunction;
    static readonly int AddStr_ParamsSize;
    static readonly int AddStr_InStruct_Offset;
    static readonly int AddStr_InValue_Offset;
    static readonly int AddStr_ReturnValue_Offset;
    
    public static UnrealSharp.PythonScriptPlugin.PyTestStruct AddStr(UnrealSharp.PythonScriptPlugin.PyTestStruct inStruct, string inValue)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[AddStr_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            UnrealSharp.PythonScriptPlugin.PyTestStructMarshaler.ToNative(IntPtr.Add(ParamsBuffer, AddStr_InStruct_Offset), 0, null, inStruct);
            IntPtr InValue_NativePtr = IntPtr.Add(ParamsBuffer,AddStr_InValue_Offset);
            StringMarshaller.ToNative(InValue_NativePtr,0,null,inValue);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, AddStr_NativeFunction, ParamsBuffer);
            
            UnrealSharp.PythonScriptPlugin.PyTestStruct returnValue;
            returnValue = UnrealSharp.PythonScriptPlugin.PyTestStructMarshaler.FromNative(IntPtr.Add(ParamsBuffer, AddStr_ReturnValue_Offset), 0, null);
            
            StringMarshaller.DestructInstance(InValue_NativePtr, 0);
            return returnValue;
        }
    }
    
    // Function /Script/PythonScriptPlugin.PyTestStructLibrary:AddInt
    static readonly IntPtr AddInt_NativeFunction;
    static readonly int AddInt_ParamsSize;
    static readonly int AddInt_InStruct_Offset;
    static readonly int AddInt_InValue_Offset;
    static readonly int AddInt_ReturnValue_Offset;
    
    public static UnrealSharp.PythonScriptPlugin.PyTestStruct AddInt(UnrealSharp.PythonScriptPlugin.PyTestStruct inStruct, int inValue)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[AddInt_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            UnrealSharp.PythonScriptPlugin.PyTestStructMarshaler.ToNative(IntPtr.Add(ParamsBuffer, AddInt_InStruct_Offset), 0, null, inStruct);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(ParamsBuffer, AddInt_InValue_Offset), 0, null, inValue);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, AddInt_NativeFunction, ParamsBuffer);
            
            UnrealSharp.PythonScriptPlugin.PyTestStruct returnValue;
            returnValue = UnrealSharp.PythonScriptPlugin.PyTestStructMarshaler.FromNative(IntPtr.Add(ParamsBuffer, AddInt_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/PythonScriptPlugin.PyTestStructLibrary:AddFloat
    static readonly IntPtr AddFloat_NativeFunction;
    static readonly int AddFloat_ParamsSize;
    static readonly int AddFloat_InStruct_Offset;
    static readonly int AddFloat_InValue_Offset;
    static readonly int AddFloat_ReturnValue_Offset;
    
    public static UnrealSharp.PythonScriptPlugin.PyTestStruct AddFloat(UnrealSharp.PythonScriptPlugin.PyTestStruct inStruct, float inValue)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[AddFloat_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            UnrealSharp.PythonScriptPlugin.PyTestStructMarshaler.ToNative(IntPtr.Add(ParamsBuffer, AddFloat_InStruct_Offset), 0, null, inStruct);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(ParamsBuffer, AddFloat_InValue_Offset), 0, null, inValue);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, AddFloat_NativeFunction, ParamsBuffer);
            
            UnrealSharp.PythonScriptPlugin.PyTestStruct returnValue;
            returnValue = UnrealSharp.PythonScriptPlugin.PyTestStructMarshaler.FromNative(IntPtr.Add(ParamsBuffer, AddFloat_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    
}