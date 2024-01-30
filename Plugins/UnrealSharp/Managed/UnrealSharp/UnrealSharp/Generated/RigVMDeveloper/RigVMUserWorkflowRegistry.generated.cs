// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVMDeveloper;

[UClass]
public partial class RigVMUserWorkflowRegistry : UnrealSharp.CoreUObject.Object
{
    
    static readonly IntPtr NativeClassPtr;
    static RigVMUserWorkflowRegistry()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("RigVMUserWorkflowRegistry");
        
        
        UnregisterProvider_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "UnregisterProvider");
        UnregisterProvider_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(UnregisterProvider_NativeFunction);
        UnregisterProvider_InHandle_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(UnregisterProvider_NativeFunction, "InHandle");
        GetWorkflows_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetWorkflows");
        GetWorkflows_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetWorkflows_NativeFunction);
        GetWorkflows_InType_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetWorkflows_NativeFunction, "InType");
        GetWorkflows_InStruct_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetWorkflows_NativeFunction, "InStruct");
        GetWorkflows_InSubject_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetWorkflows_NativeFunction, "InSubject");
        GetWorkflows_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetWorkflows_NativeFunction, "ReturnValue");
        GetWorkflows_ReturnValue_ElementSize = FArrayPropertyExporter.CallGetArrayElementSize(GetWorkflows_NativeFunction, "ReturnValue");
        Get_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "Get");
        Get_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(Get_NativeFunction);
        Get_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(Get_NativeFunction, "ReturnValue");
        
        
    }
    
    protected RigVMUserWorkflowRegistry(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // Function /Script/RigVMDeveloper.RigVMUserWorkflowRegistry:UnregisterProvider
    static readonly IntPtr UnregisterProvider_NativeFunction;
    static readonly int UnregisterProvider_ParamsSize;
    static readonly int UnregisterProvider_InHandle_Offset;
    
    public void UnregisterProvider(int inHandle)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[UnregisterProvider_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<int>.ToNative(IntPtr.Add(ParamsBuffer, UnregisterProvider_InHandle_Offset), 0, null, inHandle);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, UnregisterProvider_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/RigVMDeveloper.RigVMUserWorkflowRegistry:GetWorkflows
    static readonly IntPtr GetWorkflows_NativeFunction;
    static readonly int GetWorkflows_ParamsSize;
    static readonly int GetWorkflows_InType_Offset;
    static readonly int GetWorkflows_InStruct_Offset;
    static readonly int GetWorkflows_InSubject_Offset;
    static readonly int GetWorkflows_ReturnValue_Offset;
    static readonly int GetWorkflows_ReturnValue_ElementSize;
    
    public System.Collections.Generic.IList<UnrealSharp.RigVM.RigVMUserWorkflow> GetWorkflows(UnrealSharp.RigVM.ERigVMUserWorkflowType inType, UnrealSharp.CoreUObject.ScriptStruct inStruct, UnrealSharp.CoreUObject.Object inSubject)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetWorkflows_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<UnrealSharp.RigVM.ERigVMUserWorkflowType>.ToNative(IntPtr.Add(ParamsBuffer, GetWorkflows_InType_Offset), 0, null, inType);
            ObjectMarshaller<UnrealSharp.CoreUObject.ScriptStruct>.ToNative(IntPtr.Add(ParamsBuffer, GetWorkflows_InStruct_Offset), 0, null, inStruct);
            ObjectMarshaller<UnrealSharp.CoreUObject.Object>.ToNative(IntPtr.Add(ParamsBuffer, GetWorkflows_InSubject_Offset), 0, null, inSubject);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetWorkflows_NativeFunction, ParamsBuffer);
            
            System.Collections.Generic.IList<UnrealSharp.RigVM.RigVMUserWorkflow> returnValue;
            IntPtr ReturnValue_NativeBuffer = IntPtr.Add(ParamsBuffer, GetWorkflows_ReturnValue_Offset);
            UnrealArrayCopyMarshaler<UnrealSharp.RigVM.RigVMUserWorkflow> ReturnValue_Marshaler = new UnrealArrayCopyMarshaler<UnrealSharp.RigVM.RigVMUserWorkflow> (1, UnrealSharp.RigVM.RigVMUserWorkflowMarshaler.ToNative, UnrealSharp.RigVM.RigVMUserWorkflowMarshaler.FromNative, GetWorkflows_ReturnValue_ElementSize);
            returnValue = ReturnValue_Marshaler.FromNative(ReturnValue_NativeBuffer, 0, null);
            UnrealArrayCopyMarshaler<UnrealSharp.RigVM.RigVMUserWorkflow>.DestructInstance(ReturnValue_NativeBuffer, 0);
            
            return returnValue;
        }
    }
    
    // Function /Script/RigVMDeveloper.RigVMUserWorkflowRegistry:Get
    static readonly IntPtr Get_NativeFunction;
    static readonly int Get_ParamsSize;
    static readonly int Get_ReturnValue_Offset;
    
    public static UnrealSharp.RigVMDeveloper.RigVMUserWorkflowRegistry Get()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[Get_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, Get_NativeFunction, ParamsBuffer);
            
            UnrealSharp.RigVMDeveloper.RigVMUserWorkflowRegistry returnValue;
            returnValue = ObjectMarshaller<UnrealSharp.RigVMDeveloper.RigVMUserWorkflowRegistry>.FromNative(IntPtr.Add(ParamsBuffer, Get_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    
}