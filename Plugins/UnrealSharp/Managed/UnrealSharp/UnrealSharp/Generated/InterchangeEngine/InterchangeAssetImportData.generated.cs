// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.InterchangeEngine;

[UClass]
public partial class InterchangeAssetImportData : UnrealSharp.Engine.AssetImportData
{
    
    static InterchangeAssetImportData()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("InterchangeAssetImportData");
        
        
        SetPipelines_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetPipelines");
        SetPipelines_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetPipelines_NativeFunction);
        SetPipelines_InPipelines_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetPipelines_NativeFunction, "InPipelines");
        SetPipelines_InPipelines_ElementSize = FArrayPropertyExporter.CallGetArrayElementSize(SetPipelines_NativeFunction, "InPipelines");
        SetNodeContainer_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetNodeContainer");
        SetNodeContainer_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetNodeContainer_NativeFunction);
        SetNodeContainer_InNodeContainer_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetNodeContainer_NativeFunction, "InNodeContainer");
        ScriptGetFirstFilename_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "ScriptGetFirstFilename");
        ScriptGetFirstFilename_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(ScriptGetFirstFilename_NativeFunction);
        ScriptGetFirstFilename_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ScriptGetFirstFilename_NativeFunction, "ReturnValue");
        GetStoredNode_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetStoredNode");
        GetStoredNode_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetStoredNode_NativeFunction);
        GetStoredNode_InNodeUniqueId_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetStoredNode_NativeFunction, "InNodeUniqueId");
        GetStoredNode_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetStoredNode_NativeFunction, "ReturnValue");
        GetStoredFactoryNode_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetStoredFactoryNode");
        GetStoredFactoryNode_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetStoredFactoryNode_NativeFunction);
        GetStoredFactoryNode_InNodeUniqueId_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetStoredFactoryNode_NativeFunction, "InNodeUniqueId");
        GetStoredFactoryNode_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetStoredFactoryNode_NativeFunction, "ReturnValue");
        GetPipelines_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetPipelines");
        GetPipelines_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetPipelines_NativeFunction);
        GetPipelines_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetPipelines_NativeFunction, "ReturnValue");
        GetPipelines_ReturnValue_ElementSize = FArrayPropertyExporter.CallGetArrayElementSize(GetPipelines_NativeFunction, "ReturnValue");
        GetNumberOfPipelines_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetNumberOfPipelines");
        GetNumberOfPipelines_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetNumberOfPipelines_NativeFunction);
        GetNumberOfPipelines_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetNumberOfPipelines_NativeFunction, "ReturnValue");
        GetNodeContainer_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetNodeContainer");
        GetNodeContainer_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetNodeContainer_NativeFunction);
        GetNodeContainer_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetNodeContainer_NativeFunction, "ReturnValue");
        
        
    }
    
    protected InterchangeAssetImportData(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // Function /Script/InterchangeEngine.InterchangeAssetImportData:SetPipelines
    static readonly IntPtr SetPipelines_NativeFunction;
    static readonly int SetPipelines_ParamsSize;
    static readonly int SetPipelines_InPipelines_Offset;
    static readonly int SetPipelines_InPipelines_ElementSize;
    
    public void SetPipelines(System.Collections.Generic.IList<UnrealSharp.CoreUObject.Object> inPipelines)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetPipelines_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            IntPtr InPipelines_NativeBuffer = IntPtr.Add(ParamsBuffer, SetPipelines_InPipelines_Offset);
            UnrealArrayCopyMarshaler<UnrealSharp.CoreUObject.Object> InPipelines_Marshaler = new UnrealArrayCopyMarshaler<UnrealSharp.CoreUObject.Object>(1, ObjectMarshaller<UnrealSharp.CoreUObject.Object>.ToNative, ObjectMarshaller<UnrealSharp.CoreUObject.Object>.FromNative, SetPipelines_InPipelines_ElementSize);
            InPipelines_Marshaler.ToNative(InPipelines_NativeBuffer, 0, null, inPipelines);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetPipelines_NativeFunction, ParamsBuffer);
            
            
        }
    }
    
    // Function /Script/InterchangeEngine.InterchangeAssetImportData:SetNodeContainer
    static readonly IntPtr SetNodeContainer_NativeFunction;
    static readonly int SetNodeContainer_ParamsSize;
    static readonly int SetNodeContainer_InNodeContainer_Offset;
    
    public void SetNodeContainer(UnrealSharp.InterchangeCore.InterchangeBaseNodeContainer inNodeContainer)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetNodeContainer_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.InterchangeCore.InterchangeBaseNodeContainer>.ToNative(IntPtr.Add(ParamsBuffer, SetNodeContainer_InNodeContainer_Offset), 0, null, inNodeContainer);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetNodeContainer_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/InterchangeEngine.InterchangeAssetImportData:ScriptGetFirstFilename
    static readonly IntPtr ScriptGetFirstFilename_NativeFunction;
    static readonly int ScriptGetFirstFilename_ParamsSize;
    static readonly int ScriptGetFirstFilename_ReturnValue_Offset;
    
    public string ScriptGetFirstFilename()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[ScriptGetFirstFilename_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, ScriptGetFirstFilename_NativeFunction, ParamsBuffer);
            
            string returnValue;
            IntPtr ReturnValue_NativePtr = IntPtr.Add(ParamsBuffer,ScriptGetFirstFilename_ReturnValue_Offset);
            returnValue = StringMarshaller.FromNative(ReturnValue_NativePtr,0,null);
            StringMarshaller.DestructInstance(ReturnValue_NativePtr, 0);
            
            return returnValue;
        }
    }
    
    // Function /Script/InterchangeEngine.InterchangeAssetImportData:GetStoredNode
    static readonly IntPtr GetStoredNode_NativeFunction;
    static readonly int GetStoredNode_ParamsSize;
    static readonly int GetStoredNode_InNodeUniqueId_Offset;
    static readonly int GetStoredNode_ReturnValue_Offset;
    
    public UnrealSharp.InterchangeCore.InterchangeBaseNode GetStoredNode(string inNodeUniqueId)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetStoredNode_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            IntPtr InNodeUniqueId_NativePtr = IntPtr.Add(ParamsBuffer,GetStoredNode_InNodeUniqueId_Offset);
            StringMarshaller.ToNative(InNodeUniqueId_NativePtr,0,null,inNodeUniqueId);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetStoredNode_NativeFunction, ParamsBuffer);
            
            UnrealSharp.InterchangeCore.InterchangeBaseNode returnValue;
            returnValue = ObjectMarshaller<UnrealSharp.InterchangeCore.InterchangeBaseNode>.FromNative(IntPtr.Add(ParamsBuffer, GetStoredNode_ReturnValue_Offset), 0, null);
            
            StringMarshaller.DestructInstance(InNodeUniqueId_NativePtr, 0);
            return returnValue;
        }
    }
    
    // Function /Script/InterchangeEngine.InterchangeAssetImportData:GetStoredFactoryNode
    static readonly IntPtr GetStoredFactoryNode_NativeFunction;
    static readonly int GetStoredFactoryNode_ParamsSize;
    static readonly int GetStoredFactoryNode_InNodeUniqueId_Offset;
    static readonly int GetStoredFactoryNode_ReturnValue_Offset;
    
    public UnrealSharp.InterchangeCore.InterchangeFactoryBaseNode GetStoredFactoryNode(string inNodeUniqueId)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetStoredFactoryNode_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            IntPtr InNodeUniqueId_NativePtr = IntPtr.Add(ParamsBuffer,GetStoredFactoryNode_InNodeUniqueId_Offset);
            StringMarshaller.ToNative(InNodeUniqueId_NativePtr,0,null,inNodeUniqueId);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetStoredFactoryNode_NativeFunction, ParamsBuffer);
            
            UnrealSharp.InterchangeCore.InterchangeFactoryBaseNode returnValue;
            returnValue = ObjectMarshaller<UnrealSharp.InterchangeCore.InterchangeFactoryBaseNode>.FromNative(IntPtr.Add(ParamsBuffer, GetStoredFactoryNode_ReturnValue_Offset), 0, null);
            
            StringMarshaller.DestructInstance(InNodeUniqueId_NativePtr, 0);
            return returnValue;
        }
    }
    
    // Function /Script/InterchangeEngine.InterchangeAssetImportData:GetPipelines
    static readonly IntPtr GetPipelines_NativeFunction;
    static readonly int GetPipelines_ParamsSize;
    static readonly int GetPipelines_ReturnValue_Offset;
    static readonly int GetPipelines_ReturnValue_ElementSize;
    
    public System.Collections.Generic.IList<UnrealSharp.CoreUObject.Object> GetPipelines()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetPipelines_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetPipelines_NativeFunction, ParamsBuffer);
            
            System.Collections.Generic.IList<UnrealSharp.CoreUObject.Object> returnValue;
            IntPtr ReturnValue_NativeBuffer = IntPtr.Add(ParamsBuffer, GetPipelines_ReturnValue_Offset);
            UnrealArrayCopyMarshaler<UnrealSharp.CoreUObject.Object> ReturnValue_Marshaler = new UnrealArrayCopyMarshaler<UnrealSharp.CoreUObject.Object> (1, ObjectMarshaller<UnrealSharp.CoreUObject.Object>.ToNative, ObjectMarshaller<UnrealSharp.CoreUObject.Object>.FromNative, GetPipelines_ReturnValue_ElementSize);
            returnValue = ReturnValue_Marshaler.FromNative(ReturnValue_NativeBuffer, 0, null);
            UnrealArrayCopyMarshaler<UnrealSharp.CoreUObject.Object>.DestructInstance(ReturnValue_NativeBuffer, 0);
            
            return returnValue;
        }
    }
    
    // Function /Script/InterchangeEngine.InterchangeAssetImportData:GetNumberOfPipelines
    static readonly IntPtr GetNumberOfPipelines_NativeFunction;
    static readonly int GetNumberOfPipelines_ParamsSize;
    static readonly int GetNumberOfPipelines_ReturnValue_Offset;
    
    public int GetNumberOfPipelines()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetNumberOfPipelines_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetNumberOfPipelines_NativeFunction, ParamsBuffer);
            
            int returnValue;
            returnValue = BlittableMarshaller<int>.FromNative(IntPtr.Add(ParamsBuffer, GetNumberOfPipelines_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/InterchangeEngine.InterchangeAssetImportData:GetNodeContainer
    static readonly IntPtr GetNodeContainer_NativeFunction;
    static readonly int GetNodeContainer_ParamsSize;
    static readonly int GetNodeContainer_ReturnValue_Offset;
    
    public UnrealSharp.InterchangeCore.InterchangeBaseNodeContainer GetNodeContainer()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetNodeContainer_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetNodeContainer_NativeFunction, ParamsBuffer);
            
            UnrealSharp.InterchangeCore.InterchangeBaseNodeContainer returnValue;
            returnValue = ObjectMarshaller<UnrealSharp.InterchangeCore.InterchangeBaseNodeContainer>.FromNative(IntPtr.Add(ParamsBuffer, GetNodeContainer_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    
}