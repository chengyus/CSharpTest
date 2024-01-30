// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.InterchangeCore;

[UClass]
public partial class InterchangeBaseNodeContainer : UnrealSharp.CoreUObject.Object
{
    
    static InterchangeBaseNodeContainer()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("InterchangeBaseNodeContainer");
        
        
        SetNodeParentUid_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetNodeParentUid");
        SetNodeParentUid_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetNodeParentUid_NativeFunction);
        SetNodeParentUid_NodeUniqueID_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetNodeParentUid_NativeFunction, "NodeUniqueID");
        SetNodeParentUid_NewParentNodeUid_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetNodeParentUid_NativeFunction, "NewParentNodeUid");
        SetNodeParentUid_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetNodeParentUid_NativeFunction, "ReturnValue");
        SaveToFile_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SaveToFile");
        SaveToFile_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SaveToFile_NativeFunction);
        SaveToFile_Filename_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SaveToFile_NativeFunction, "Filename");
        ResetChildrenCache_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "ResetChildrenCache");
        ReplaceNode_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "ReplaceNode");
        ReplaceNode_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(ReplaceNode_NativeFunction);
        ReplaceNode_NodeUniqueID_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ReplaceNode_NativeFunction, "NodeUniqueID");
        ReplaceNode_NewNode_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ReplaceNode_NativeFunction, "NewNode");
        LoadFromFile_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "LoadFromFile");
        LoadFromFile_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(LoadFromFile_NativeFunction);
        LoadFromFile_Filename_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(LoadFromFile_NativeFunction, "Filename");
        IsNodeUidValid_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "IsNodeUidValid");
        IsNodeUidValid_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(IsNodeUidValid_NativeFunction);
        IsNodeUidValid_NodeUniqueID_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(IsNodeUidValid_NativeFunction, "NodeUniqueID");
        IsNodeUidValid_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(IsNodeUidValid_NativeFunction, "ReturnValue");
        GetNodeChildrenCount_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetNodeChildrenCount");
        GetNodeChildrenCount_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetNodeChildrenCount_NativeFunction);
        GetNodeChildrenCount_NodeUniqueID_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetNodeChildrenCount_NativeFunction, "NodeUniqueID");
        GetNodeChildrenCount_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetNodeChildrenCount_NativeFunction, "ReturnValue");
        GetNodeChildren_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetNodeChildren");
        GetNodeChildren_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetNodeChildren_NativeFunction);
        GetNodeChildren_NodeUniqueID_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetNodeChildren_NativeFunction, "NodeUniqueID");
        GetNodeChildren_ChildIndex_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetNodeChildren_NativeFunction, "ChildIndex");
        GetNodeChildren_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetNodeChildren_NativeFunction, "ReturnValue");
        GetNode_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetNode");
        GetNode_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetNode_NativeFunction);
        GetNode_NodeUniqueID_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetNode_NativeFunction, "NodeUniqueID");
        GetNode_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetNode_NativeFunction, "ReturnValue");
        GetFactoryNode_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetFactoryNode");
        GetFactoryNode_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetFactoryNode_NativeFunction);
        GetFactoryNode_NodeUniqueID_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetFactoryNode_NativeFunction, "NodeUniqueID");
        GetFactoryNode_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetFactoryNode_NativeFunction, "ReturnValue");
        ComputeChildrenCache_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "ComputeChildrenCache");
        AddNode_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "AddNode");
        AddNode_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(AddNode_NativeFunction);
        AddNode_Node_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AddNode_NativeFunction, "Node");
        AddNode_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AddNode_NativeFunction, "ReturnValue");
        
        
    }
    
    protected InterchangeBaseNodeContainer(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // Function /Script/InterchangeCore.InterchangeBaseNodeContainer:SetNodeParentUid
    static readonly IntPtr SetNodeParentUid_NativeFunction;
    static readonly int SetNodeParentUid_ParamsSize;
    static readonly int SetNodeParentUid_NodeUniqueID_Offset;
    static readonly int SetNodeParentUid_NewParentNodeUid_Offset;
    static readonly int SetNodeParentUid_ReturnValue_Offset;
    
    public bool SetNodeParentUid(string nodeUniqueID, string newParentNodeUid)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetNodeParentUid_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            IntPtr NodeUniqueID_NativePtr = IntPtr.Add(ParamsBuffer,SetNodeParentUid_NodeUniqueID_Offset);
            StringMarshaller.ToNative(NodeUniqueID_NativePtr,0,null,nodeUniqueID);
            IntPtr NewParentNodeUid_NativePtr = IntPtr.Add(ParamsBuffer,SetNodeParentUid_NewParentNodeUid_Offset);
            StringMarshaller.ToNative(NewParentNodeUid_NativePtr,0,null,newParentNodeUid);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetNodeParentUid_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, SetNodeParentUid_ReturnValue_Offset), 0, null);
            
            StringMarshaller.DestructInstance(NodeUniqueID_NativePtr, 0);
            StringMarshaller.DestructInstance(NewParentNodeUid_NativePtr, 0);
            return returnValue;
        }
    }
    
    // Function /Script/InterchangeCore.InterchangeBaseNodeContainer:SaveToFile
    static readonly IntPtr SaveToFile_NativeFunction;
    static readonly int SaveToFile_ParamsSize;
    static readonly int SaveToFile_Filename_Offset;
    
    public void SaveToFile(string filename)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SaveToFile_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            IntPtr Filename_NativePtr = IntPtr.Add(ParamsBuffer,SaveToFile_Filename_Offset);
            StringMarshaller.ToNative(Filename_NativePtr,0,null,filename);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SaveToFile_NativeFunction, ParamsBuffer);
            
            StringMarshaller.DestructInstance(Filename_NativePtr, 0);
        }
    }
    
    // Function /Script/InterchangeCore.InterchangeBaseNodeContainer:ResetChildrenCache
    static readonly IntPtr ResetChildrenCache_NativeFunction;
    
    public void ResetChildrenCache()
    {
        unsafe
        {
            UObjectExporter.CallInvokeNativeFunction(NativeObject, ResetChildrenCache_NativeFunction, IntPtr.Zero);
        }
    }
    
    // Function /Script/InterchangeCore.InterchangeBaseNodeContainer:ReplaceNode
    static readonly IntPtr ReplaceNode_NativeFunction;
    static readonly int ReplaceNode_ParamsSize;
    static readonly int ReplaceNode_NodeUniqueID_Offset;
    static readonly int ReplaceNode_NewNode_Offset;
    
    public void ReplaceNode(string nodeUniqueID, UnrealSharp.InterchangeCore.InterchangeFactoryBaseNode newNode)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[ReplaceNode_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            IntPtr NodeUniqueID_NativePtr = IntPtr.Add(ParamsBuffer,ReplaceNode_NodeUniqueID_Offset);
            StringMarshaller.ToNative(NodeUniqueID_NativePtr,0,null,nodeUniqueID);
            ObjectMarshaller<UnrealSharp.InterchangeCore.InterchangeFactoryBaseNode>.ToNative(IntPtr.Add(ParamsBuffer, ReplaceNode_NewNode_Offset), 0, null, newNode);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, ReplaceNode_NativeFunction, ParamsBuffer);
            
            StringMarshaller.DestructInstance(NodeUniqueID_NativePtr, 0);
        }
    }
    
    // Function /Script/InterchangeCore.InterchangeBaseNodeContainer:LoadFromFile
    static readonly IntPtr LoadFromFile_NativeFunction;
    static readonly int LoadFromFile_ParamsSize;
    static readonly int LoadFromFile_Filename_Offset;
    
    public void LoadFromFile(string filename)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[LoadFromFile_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            IntPtr Filename_NativePtr = IntPtr.Add(ParamsBuffer,LoadFromFile_Filename_Offset);
            StringMarshaller.ToNative(Filename_NativePtr,0,null,filename);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, LoadFromFile_NativeFunction, ParamsBuffer);
            
            StringMarshaller.DestructInstance(Filename_NativePtr, 0);
        }
    }
    
    // Function /Script/InterchangeCore.InterchangeBaseNodeContainer:IsNodeUidValid
    static readonly IntPtr IsNodeUidValid_NativeFunction;
    static readonly int IsNodeUidValid_ParamsSize;
    static readonly int IsNodeUidValid_NodeUniqueID_Offset;
    static readonly int IsNodeUidValid_ReturnValue_Offset;
    
    public bool IsNodeUidValid(string nodeUniqueID)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[IsNodeUidValid_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            IntPtr NodeUniqueID_NativePtr = IntPtr.Add(ParamsBuffer,IsNodeUidValid_NodeUniqueID_Offset);
            StringMarshaller.ToNative(NodeUniqueID_NativePtr,0,null,nodeUniqueID);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, IsNodeUidValid_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, IsNodeUidValid_ReturnValue_Offset), 0, null);
            
            StringMarshaller.DestructInstance(NodeUniqueID_NativePtr, 0);
            return returnValue;
        }
    }
    
    // Function /Script/InterchangeCore.InterchangeBaseNodeContainer:GetNodeChildrenCount
    static readonly IntPtr GetNodeChildrenCount_NativeFunction;
    static readonly int GetNodeChildrenCount_ParamsSize;
    static readonly int GetNodeChildrenCount_NodeUniqueID_Offset;
    static readonly int GetNodeChildrenCount_ReturnValue_Offset;
    
    public int GetNodeChildrenCount(string nodeUniqueID)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetNodeChildrenCount_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            IntPtr NodeUniqueID_NativePtr = IntPtr.Add(ParamsBuffer,GetNodeChildrenCount_NodeUniqueID_Offset);
            StringMarshaller.ToNative(NodeUniqueID_NativePtr,0,null,nodeUniqueID);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetNodeChildrenCount_NativeFunction, ParamsBuffer);
            
            int returnValue;
            returnValue = BlittableMarshaller<int>.FromNative(IntPtr.Add(ParamsBuffer, GetNodeChildrenCount_ReturnValue_Offset), 0, null);
            
            StringMarshaller.DestructInstance(NodeUniqueID_NativePtr, 0);
            return returnValue;
        }
    }
    
    // Function /Script/InterchangeCore.InterchangeBaseNodeContainer:GetNodeChildren
    static readonly IntPtr GetNodeChildren_NativeFunction;
    static readonly int GetNodeChildren_ParamsSize;
    static readonly int GetNodeChildren_NodeUniqueID_Offset;
    static readonly int GetNodeChildren_ChildIndex_Offset;
    static readonly int GetNodeChildren_ReturnValue_Offset;
    
    public UnrealSharp.InterchangeCore.InterchangeBaseNode GetNodeChildren(string nodeUniqueID, int childIndex)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetNodeChildren_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            IntPtr NodeUniqueID_NativePtr = IntPtr.Add(ParamsBuffer,GetNodeChildren_NodeUniqueID_Offset);
            StringMarshaller.ToNative(NodeUniqueID_NativePtr,0,null,nodeUniqueID);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(ParamsBuffer, GetNodeChildren_ChildIndex_Offset), 0, null, childIndex);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetNodeChildren_NativeFunction, ParamsBuffer);
            
            UnrealSharp.InterchangeCore.InterchangeBaseNode returnValue;
            returnValue = ObjectMarshaller<UnrealSharp.InterchangeCore.InterchangeBaseNode>.FromNative(IntPtr.Add(ParamsBuffer, GetNodeChildren_ReturnValue_Offset), 0, null);
            
            StringMarshaller.DestructInstance(NodeUniqueID_NativePtr, 0);
            return returnValue;
        }
    }
    
    // Function /Script/InterchangeCore.InterchangeBaseNodeContainer:GetNode
    static readonly IntPtr GetNode_NativeFunction;
    static readonly int GetNode_ParamsSize;
    static readonly int GetNode_NodeUniqueID_Offset;
    static readonly int GetNode_ReturnValue_Offset;
    
    public UnrealSharp.InterchangeCore.InterchangeBaseNode GetNode(string nodeUniqueID)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetNode_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            IntPtr NodeUniqueID_NativePtr = IntPtr.Add(ParamsBuffer,GetNode_NodeUniqueID_Offset);
            StringMarshaller.ToNative(NodeUniqueID_NativePtr,0,null,nodeUniqueID);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetNode_NativeFunction, ParamsBuffer);
            
            UnrealSharp.InterchangeCore.InterchangeBaseNode returnValue;
            returnValue = ObjectMarshaller<UnrealSharp.InterchangeCore.InterchangeBaseNode>.FromNative(IntPtr.Add(ParamsBuffer, GetNode_ReturnValue_Offset), 0, null);
            
            StringMarshaller.DestructInstance(NodeUniqueID_NativePtr, 0);
            return returnValue;
        }
    }
    
    // Function /Script/InterchangeCore.InterchangeBaseNodeContainer:GetFactoryNode
    static readonly IntPtr GetFactoryNode_NativeFunction;
    static readonly int GetFactoryNode_ParamsSize;
    static readonly int GetFactoryNode_NodeUniqueID_Offset;
    static readonly int GetFactoryNode_ReturnValue_Offset;
    
    public UnrealSharp.InterchangeCore.InterchangeFactoryBaseNode GetFactoryNode(string nodeUniqueID)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetFactoryNode_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            IntPtr NodeUniqueID_NativePtr = IntPtr.Add(ParamsBuffer,GetFactoryNode_NodeUniqueID_Offset);
            StringMarshaller.ToNative(NodeUniqueID_NativePtr,0,null,nodeUniqueID);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetFactoryNode_NativeFunction, ParamsBuffer);
            
            UnrealSharp.InterchangeCore.InterchangeFactoryBaseNode returnValue;
            returnValue = ObjectMarshaller<UnrealSharp.InterchangeCore.InterchangeFactoryBaseNode>.FromNative(IntPtr.Add(ParamsBuffer, GetFactoryNode_ReturnValue_Offset), 0, null);
            
            StringMarshaller.DestructInstance(NodeUniqueID_NativePtr, 0);
            return returnValue;
        }
    }
    
    // Function /Script/InterchangeCore.InterchangeBaseNodeContainer:ComputeChildrenCache
    static readonly IntPtr ComputeChildrenCache_NativeFunction;
    
    public void ComputeChildrenCache()
    {
        unsafe
        {
            UObjectExporter.CallInvokeNativeFunction(NativeObject, ComputeChildrenCache_NativeFunction, IntPtr.Zero);
        }
    }
    
    // Function /Script/InterchangeCore.InterchangeBaseNodeContainer:AddNode
    static readonly IntPtr AddNode_NativeFunction;
    static readonly int AddNode_ParamsSize;
    static readonly int AddNode_Node_Offset;
    static readonly int AddNode_ReturnValue_Offset;
    
    public string AddNode(UnrealSharp.InterchangeCore.InterchangeBaseNode node)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[AddNode_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.InterchangeCore.InterchangeBaseNode>.ToNative(IntPtr.Add(ParamsBuffer, AddNode_Node_Offset), 0, null, node);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, AddNode_NativeFunction, ParamsBuffer);
            
            string returnValue;
            IntPtr ReturnValue_NativePtr = IntPtr.Add(ParamsBuffer,AddNode_ReturnValue_Offset);
            returnValue = StringMarshaller.FromNative(ReturnValue_NativePtr,0,null);
            StringMarshaller.DestructInstance(ReturnValue_NativePtr, 0);
            
            return returnValue;
        }
    }
    
    
}