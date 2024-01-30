// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVMDeveloper;

[UClass]
public partial class RigVMLibraryNode : UnrealSharp.RigVMDeveloper.RigVMTemplateNode
{
    
    static RigVMLibraryNode()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("RigVMLibraryNode");
        
        
        GetLibrary_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetLibrary");
        GetLibrary_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetLibrary_NativeFunction);
        GetLibrary_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetLibrary_NativeFunction, "ReturnValue");
        GetContainedGraph_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetContainedGraph");
        GetContainedGraph_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetContainedGraph_NativeFunction);
        GetContainedGraph_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetContainedGraph_NativeFunction, "ReturnValue");
        
        
    }
    
    protected RigVMLibraryNode(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // Function /Script/RigVMDeveloper.RigVMLibraryNode:GetLibrary
    static readonly IntPtr GetLibrary_NativeFunction;
    static readonly int GetLibrary_ParamsSize;
    static readonly int GetLibrary_ReturnValue_Offset;
    
    public UnrealSharp.RigVMDeveloper.RigVMFunctionLibrary GetLibrary()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetLibrary_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetLibrary_NativeFunction, ParamsBuffer);
            
            UnrealSharp.RigVMDeveloper.RigVMFunctionLibrary returnValue;
            returnValue = ObjectMarshaller<UnrealSharp.RigVMDeveloper.RigVMFunctionLibrary>.FromNative(IntPtr.Add(ParamsBuffer, GetLibrary_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/RigVMDeveloper.RigVMLibraryNode:GetContainedGraph
    static readonly IntPtr GetContainedGraph_NativeFunction;
    static readonly int GetContainedGraph_ParamsSize;
    static readonly int GetContainedGraph_ReturnValue_Offset;
    
    public UnrealSharp.RigVMDeveloper.RigVMGraph GetContainedGraph()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetContainedGraph_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetContainedGraph_NativeFunction, ParamsBuffer);
            
            UnrealSharp.RigVMDeveloper.RigVMGraph returnValue;
            returnValue = ObjectMarshaller<UnrealSharp.RigVMDeveloper.RigVMGraph>.FromNative(IntPtr.Add(ParamsBuffer, GetContainedGraph_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    
}