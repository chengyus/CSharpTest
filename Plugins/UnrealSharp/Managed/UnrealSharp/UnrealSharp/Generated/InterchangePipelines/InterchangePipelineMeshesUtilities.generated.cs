// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.InterchangePipelines;

[UClass]
public partial class InterchangePipelineMeshesUtilities : UnrealSharp.CoreUObject.Object
{
    
    static readonly IntPtr NativeClassPtr;
    static InterchangePipelineMeshesUtilities()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("InterchangePipelineMeshesUtilities");
        
        
        SetContext_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetContext");
        SetContext_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetContext_NativeFunction);
        SetContext_Context_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetContext_NativeFunction, "Context");
        IsValidMeshInstanceUid_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "IsValidMeshInstanceUid");
        IsValidMeshInstanceUid_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(IsValidMeshInstanceUid_NativeFunction);
        IsValidMeshInstanceUid_MeshInstanceUid_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(IsValidMeshInstanceUid_NativeFunction, "MeshInstanceUid");
        IsValidMeshInstanceUid_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(IsValidMeshInstanceUid_NativeFunction, "ReturnValue");
        IsValidMeshGeometryUid_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "IsValidMeshGeometryUid");
        IsValidMeshGeometryUid_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(IsValidMeshGeometryUid_NativeFunction);
        IsValidMeshGeometryUid_MeshGeometryUid_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(IsValidMeshGeometryUid_NativeFunction, "MeshGeometryUid");
        IsValidMeshGeometryUid_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(IsValidMeshGeometryUid_NativeFunction, "ReturnValue");
        GetMeshInstanceSkeletonRootUid_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetMeshInstanceSkeletonRootUid");
        GetMeshInstanceSkeletonRootUid_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetMeshInstanceSkeletonRootUid_NativeFunction);
        GetMeshInstanceSkeletonRootUid_MeshInstanceUid_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetMeshInstanceSkeletonRootUid_NativeFunction, "MeshInstanceUid");
        GetMeshInstanceSkeletonRootUid_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetMeshInstanceSkeletonRootUid_NativeFunction, "ReturnValue");
        GetMeshInstanceByUid_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetMeshInstanceByUid");
        GetMeshInstanceByUid_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetMeshInstanceByUid_NativeFunction);
        GetMeshInstanceByUid_MeshInstanceUid_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetMeshInstanceByUid_NativeFunction, "MeshInstanceUid");
        GetMeshInstanceByUid_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetMeshInstanceByUid_NativeFunction, "ReturnValue");
        GetMeshGeometrySkeletonRootUid_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetMeshGeometrySkeletonRootUid");
        GetMeshGeometrySkeletonRootUid_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetMeshGeometrySkeletonRootUid_NativeFunction);
        GetMeshGeometrySkeletonRootUid_MeshGeometryUid_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetMeshGeometrySkeletonRootUid_NativeFunction, "MeshGeometryUid");
        GetMeshGeometrySkeletonRootUid_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetMeshGeometrySkeletonRootUid_NativeFunction, "ReturnValue");
        GetMeshGeometryByUid_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetMeshGeometryByUid");
        GetMeshGeometryByUid_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetMeshGeometryByUid_NativeFunction);
        GetMeshGeometryByUid_MeshGeometryUid_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetMeshGeometryByUid_NativeFunction, "MeshGeometryUid");
        GetMeshGeometryByUid_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetMeshGeometryByUid_NativeFunction, "ReturnValue");
        CreateInterchangePipelineMeshesUtilities_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "CreateInterchangePipelineMeshesUtilities");
        CreateInterchangePipelineMeshesUtilities_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(CreateInterchangePipelineMeshesUtilities_NativeFunction);
        CreateInterchangePipelineMeshesUtilities_BaseNodeContainer_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(CreateInterchangePipelineMeshesUtilities_NativeFunction, "BaseNodeContainer");
        CreateInterchangePipelineMeshesUtilities_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(CreateInterchangePipelineMeshesUtilities_NativeFunction, "ReturnValue");
        
        
    }
    
    protected InterchangePipelineMeshesUtilities(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // Function /Script/InterchangePipelines.InterchangePipelineMeshesUtilities:SetContext
    static readonly IntPtr SetContext_NativeFunction;
    static readonly int SetContext_ParamsSize;
    static readonly int SetContext_Context_Offset;
    
    public void SetContext(UnrealSharp.InterchangePipelines.InterchangePipelineMeshesUtilitiesContext context)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetContext_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            UnrealSharp.InterchangePipelines.InterchangePipelineMeshesUtilitiesContextMarshaler.ToNative(IntPtr.Add(ParamsBuffer, SetContext_Context_Offset), 0, null, context);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetContext_NativeFunction, ParamsBuffer);
            
            
        }
    }
    
    // Function /Script/InterchangePipelines.InterchangePipelineMeshesUtilities:IsValidMeshInstanceUid
    static readonly IntPtr IsValidMeshInstanceUid_NativeFunction;
    static readonly int IsValidMeshInstanceUid_ParamsSize;
    static readonly int IsValidMeshInstanceUid_MeshInstanceUid_Offset;
    static readonly int IsValidMeshInstanceUid_ReturnValue_Offset;
    
    public bool IsValidMeshInstanceUid(string meshInstanceUid)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[IsValidMeshInstanceUid_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            IntPtr MeshInstanceUid_NativePtr = IntPtr.Add(ParamsBuffer,IsValidMeshInstanceUid_MeshInstanceUid_Offset);
            StringMarshaller.ToNative(MeshInstanceUid_NativePtr,0,null,meshInstanceUid);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, IsValidMeshInstanceUid_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, IsValidMeshInstanceUid_ReturnValue_Offset), 0, null);
            
            StringMarshaller.DestructInstance(MeshInstanceUid_NativePtr, 0);
            return returnValue;
        }
    }
    
    // Function /Script/InterchangePipelines.InterchangePipelineMeshesUtilities:IsValidMeshGeometryUid
    static readonly IntPtr IsValidMeshGeometryUid_NativeFunction;
    static readonly int IsValidMeshGeometryUid_ParamsSize;
    static readonly int IsValidMeshGeometryUid_MeshGeometryUid_Offset;
    static readonly int IsValidMeshGeometryUid_ReturnValue_Offset;
    
    public bool IsValidMeshGeometryUid(string meshGeometryUid)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[IsValidMeshGeometryUid_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            IntPtr MeshGeometryUid_NativePtr = IntPtr.Add(ParamsBuffer,IsValidMeshGeometryUid_MeshGeometryUid_Offset);
            StringMarshaller.ToNative(MeshGeometryUid_NativePtr,0,null,meshGeometryUid);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, IsValidMeshGeometryUid_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, IsValidMeshGeometryUid_ReturnValue_Offset), 0, null);
            
            StringMarshaller.DestructInstance(MeshGeometryUid_NativePtr, 0);
            return returnValue;
        }
    }
    
    // Function /Script/InterchangePipelines.InterchangePipelineMeshesUtilities:GetMeshInstanceSkeletonRootUid
    static readonly IntPtr GetMeshInstanceSkeletonRootUid_NativeFunction;
    static readonly int GetMeshInstanceSkeletonRootUid_ParamsSize;
    static readonly int GetMeshInstanceSkeletonRootUid_MeshInstanceUid_Offset;
    static readonly int GetMeshInstanceSkeletonRootUid_ReturnValue_Offset;
    
    public string GetMeshInstanceSkeletonRootUid(string meshInstanceUid)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetMeshInstanceSkeletonRootUid_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            IntPtr MeshInstanceUid_NativePtr = IntPtr.Add(ParamsBuffer,GetMeshInstanceSkeletonRootUid_MeshInstanceUid_Offset);
            StringMarshaller.ToNative(MeshInstanceUid_NativePtr,0,null,meshInstanceUid);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetMeshInstanceSkeletonRootUid_NativeFunction, ParamsBuffer);
            
            string returnValue;
            IntPtr ReturnValue_NativePtr = IntPtr.Add(ParamsBuffer,GetMeshInstanceSkeletonRootUid_ReturnValue_Offset);
            returnValue = StringMarshaller.FromNative(ReturnValue_NativePtr,0,null);
            StringMarshaller.DestructInstance(ReturnValue_NativePtr, 0);
            
            StringMarshaller.DestructInstance(MeshInstanceUid_NativePtr, 0);
            return returnValue;
        }
    }
    
    // Function /Script/InterchangePipelines.InterchangePipelineMeshesUtilities:GetMeshInstanceByUid
    static readonly IntPtr GetMeshInstanceByUid_NativeFunction;
    static readonly int GetMeshInstanceByUid_ParamsSize;
    static readonly int GetMeshInstanceByUid_MeshInstanceUid_Offset;
    static readonly int GetMeshInstanceByUid_ReturnValue_Offset;
    
    public UnrealSharp.InterchangePipelines.InterchangeMeshInstance GetMeshInstanceByUid(string meshInstanceUid)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetMeshInstanceByUid_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            IntPtr MeshInstanceUid_NativePtr = IntPtr.Add(ParamsBuffer,GetMeshInstanceByUid_MeshInstanceUid_Offset);
            StringMarshaller.ToNative(MeshInstanceUid_NativePtr,0,null,meshInstanceUid);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetMeshInstanceByUid_NativeFunction, ParamsBuffer);
            
            UnrealSharp.InterchangePipelines.InterchangeMeshInstance returnValue;
            returnValue = UnrealSharp.InterchangePipelines.InterchangeMeshInstanceMarshaler.FromNative(IntPtr.Add(ParamsBuffer, GetMeshInstanceByUid_ReturnValue_Offset), 0, null);
            
            StringMarshaller.DestructInstance(MeshInstanceUid_NativePtr, 0);
            return returnValue;
        }
    }
    
    // Function /Script/InterchangePipelines.InterchangePipelineMeshesUtilities:GetMeshGeometrySkeletonRootUid
    static readonly IntPtr GetMeshGeometrySkeletonRootUid_NativeFunction;
    static readonly int GetMeshGeometrySkeletonRootUid_ParamsSize;
    static readonly int GetMeshGeometrySkeletonRootUid_MeshGeometryUid_Offset;
    static readonly int GetMeshGeometrySkeletonRootUid_ReturnValue_Offset;
    
    public string GetMeshGeometrySkeletonRootUid(string meshGeometryUid)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetMeshGeometrySkeletonRootUid_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            IntPtr MeshGeometryUid_NativePtr = IntPtr.Add(ParamsBuffer,GetMeshGeometrySkeletonRootUid_MeshGeometryUid_Offset);
            StringMarshaller.ToNative(MeshGeometryUid_NativePtr,0,null,meshGeometryUid);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetMeshGeometrySkeletonRootUid_NativeFunction, ParamsBuffer);
            
            string returnValue;
            IntPtr ReturnValue_NativePtr = IntPtr.Add(ParamsBuffer,GetMeshGeometrySkeletonRootUid_ReturnValue_Offset);
            returnValue = StringMarshaller.FromNative(ReturnValue_NativePtr,0,null);
            StringMarshaller.DestructInstance(ReturnValue_NativePtr, 0);
            
            StringMarshaller.DestructInstance(MeshGeometryUid_NativePtr, 0);
            return returnValue;
        }
    }
    
    // Function /Script/InterchangePipelines.InterchangePipelineMeshesUtilities:GetMeshGeometryByUid
    static readonly IntPtr GetMeshGeometryByUid_NativeFunction;
    static readonly int GetMeshGeometryByUid_ParamsSize;
    static readonly int GetMeshGeometryByUid_MeshGeometryUid_Offset;
    static readonly int GetMeshGeometryByUid_ReturnValue_Offset;
    
    public UnrealSharp.InterchangePipelines.InterchangeMeshGeometry GetMeshGeometryByUid(string meshGeometryUid)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetMeshGeometryByUid_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            IntPtr MeshGeometryUid_NativePtr = IntPtr.Add(ParamsBuffer,GetMeshGeometryByUid_MeshGeometryUid_Offset);
            StringMarshaller.ToNative(MeshGeometryUid_NativePtr,0,null,meshGeometryUid);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetMeshGeometryByUid_NativeFunction, ParamsBuffer);
            
            UnrealSharp.InterchangePipelines.InterchangeMeshGeometry returnValue;
            returnValue = UnrealSharp.InterchangePipelines.InterchangeMeshGeometryMarshaler.FromNative(IntPtr.Add(ParamsBuffer, GetMeshGeometryByUid_ReturnValue_Offset), 0, null);
            
            StringMarshaller.DestructInstance(MeshGeometryUid_NativePtr, 0);
            return returnValue;
        }
    }
    
    // Function /Script/InterchangePipelines.InterchangePipelineMeshesUtilities:CreateInterchangePipelineMeshesUtilities
    static readonly IntPtr CreateInterchangePipelineMeshesUtilities_NativeFunction;
    static readonly int CreateInterchangePipelineMeshesUtilities_ParamsSize;
    static readonly int CreateInterchangePipelineMeshesUtilities_BaseNodeContainer_Offset;
    static readonly int CreateInterchangePipelineMeshesUtilities_ReturnValue_Offset;
    
    public static UnrealSharp.InterchangePipelines.InterchangePipelineMeshesUtilities CreateInterchangePipelineMeshesUtilities(UnrealSharp.InterchangeCore.InterchangeBaseNodeContainer baseNodeContainer)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[CreateInterchangePipelineMeshesUtilities_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.InterchangeCore.InterchangeBaseNodeContainer>.ToNative(IntPtr.Add(ParamsBuffer, CreateInterchangePipelineMeshesUtilities_BaseNodeContainer_Offset), 0, null, baseNodeContainer);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, CreateInterchangePipelineMeshesUtilities_NativeFunction, ParamsBuffer);
            
            UnrealSharp.InterchangePipelines.InterchangePipelineMeshesUtilities returnValue;
            returnValue = ObjectMarshaller<UnrealSharp.InterchangePipelines.InterchangePipelineMeshesUtilities>.FromNative(IntPtr.Add(ParamsBuffer, CreateInterchangePipelineMeshesUtilities_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    
}