// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVMDeveloper;

[UClass]
public partial class RigVMVariableNode : UnrealSharp.RigVMDeveloper.RigVMNode
{
    
    static RigVMVariableNode()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("RigVMVariableNode");
        
        
        IsLocalVariable_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "IsLocalVariable");
        IsLocalVariable_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(IsLocalVariable_NativeFunction);
        IsLocalVariable_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(IsLocalVariable_NativeFunction, "ReturnValue");
        IsInputArgument_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "IsInputArgument");
        IsInputArgument_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(IsInputArgument_NativeFunction);
        IsInputArgument_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(IsInputArgument_NativeFunction, "ReturnValue");
        IsGetter_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "IsGetter");
        IsGetter_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(IsGetter_NativeFunction);
        IsGetter_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(IsGetter_NativeFunction, "ReturnValue");
        IsExternalVariable_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "IsExternalVariable");
        IsExternalVariable_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(IsExternalVariable_NativeFunction);
        IsExternalVariable_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(IsExternalVariable_NativeFunction, "ReturnValue");
        GetVariableName_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetVariableName");
        GetVariableName_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetVariableName_NativeFunction);
        GetVariableName_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetVariableName_NativeFunction, "ReturnValue");
        GetVariableDescription_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetVariableDescription");
        GetVariableDescription_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetVariableDescription_NativeFunction);
        GetVariableDescription_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetVariableDescription_NativeFunction, "ReturnValue");
        GetDefaultValue_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetDefaultValue");
        GetDefaultValue_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetDefaultValue_NativeFunction);
        GetDefaultValue_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetDefaultValue_NativeFunction, "ReturnValue");
        GetCPPTypeObject_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetCPPTypeObject");
        GetCPPTypeObject_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetCPPTypeObject_NativeFunction);
        GetCPPTypeObject_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetCPPTypeObject_NativeFunction, "ReturnValue");
        GetCPPType_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetCPPType");
        GetCPPType_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetCPPType_NativeFunction);
        GetCPPType_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetCPPType_NativeFunction, "ReturnValue");
        
        
    }
    
    protected RigVMVariableNode(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // Function /Script/RigVMDeveloper.RigVMVariableNode:IsLocalVariable
    static readonly IntPtr IsLocalVariable_NativeFunction;
    static readonly int IsLocalVariable_ParamsSize;
    static readonly int IsLocalVariable_ReturnValue_Offset;
    
    public bool IsLocalVariable()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[IsLocalVariable_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, IsLocalVariable_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, IsLocalVariable_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/RigVMDeveloper.RigVMVariableNode:IsInputArgument
    static readonly IntPtr IsInputArgument_NativeFunction;
    static readonly int IsInputArgument_ParamsSize;
    static readonly int IsInputArgument_ReturnValue_Offset;
    
    public bool IsInputArgument()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[IsInputArgument_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, IsInputArgument_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, IsInputArgument_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/RigVMDeveloper.RigVMVariableNode:IsGetter
    static readonly IntPtr IsGetter_NativeFunction;
    static readonly int IsGetter_ParamsSize;
    static readonly int IsGetter_ReturnValue_Offset;
    
    public bool IsGetter()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[IsGetter_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, IsGetter_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, IsGetter_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/RigVMDeveloper.RigVMVariableNode:IsExternalVariable
    static readonly IntPtr IsExternalVariable_NativeFunction;
    static readonly int IsExternalVariable_ParamsSize;
    static readonly int IsExternalVariable_ReturnValue_Offset;
    
    public bool IsExternalVariable()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[IsExternalVariable_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, IsExternalVariable_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, IsExternalVariable_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/RigVMDeveloper.RigVMVariableNode:GetVariableName
    static readonly IntPtr GetVariableName_NativeFunction;
    static readonly int GetVariableName_ParamsSize;
    static readonly int GetVariableName_ReturnValue_Offset;
    
    public Name GetVariableName()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetVariableName_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetVariableName_NativeFunction, ParamsBuffer);
            
            Name returnValue;
            returnValue = BlittableMarshaller<Name>.FromNative(IntPtr.Add(ParamsBuffer, GetVariableName_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/RigVMDeveloper.RigVMVariableNode:GetVariableDescription
    static readonly IntPtr GetVariableDescription_NativeFunction;
    static readonly int GetVariableDescription_ParamsSize;
    static readonly int GetVariableDescription_ReturnValue_Offset;
    
    public UnrealSharp.RigVMDeveloper.RigVMGraphVariableDescription GetVariableDescription()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetVariableDescription_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetVariableDescription_NativeFunction, ParamsBuffer);
            
            UnrealSharp.RigVMDeveloper.RigVMGraphVariableDescription returnValue;
            returnValue = UnrealSharp.RigVMDeveloper.RigVMGraphVariableDescriptionMarshaler.FromNative(IntPtr.Add(ParamsBuffer, GetVariableDescription_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/RigVMDeveloper.RigVMVariableNode:GetDefaultValue
    static readonly IntPtr GetDefaultValue_NativeFunction;
    static readonly int GetDefaultValue_ParamsSize;
    static readonly int GetDefaultValue_ReturnValue_Offset;
    
    public string GetDefaultValue()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetDefaultValue_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetDefaultValue_NativeFunction, ParamsBuffer);
            
            string returnValue;
            IntPtr ReturnValue_NativePtr = IntPtr.Add(ParamsBuffer,GetDefaultValue_ReturnValue_Offset);
            returnValue = StringMarshaller.FromNative(ReturnValue_NativePtr,0,null);
            StringMarshaller.DestructInstance(ReturnValue_NativePtr, 0);
            
            return returnValue;
        }
    }
    
    // Function /Script/RigVMDeveloper.RigVMVariableNode:GetCPPTypeObject
    static readonly IntPtr GetCPPTypeObject_NativeFunction;
    static readonly int GetCPPTypeObject_ParamsSize;
    static readonly int GetCPPTypeObject_ReturnValue_Offset;
    
    public UnrealSharp.CoreUObject.Object GetCPPTypeObject()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetCPPTypeObject_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetCPPTypeObject_NativeFunction, ParamsBuffer);
            
            UnrealSharp.CoreUObject.Object returnValue;
            returnValue = ObjectMarshaller<UnrealSharp.CoreUObject.Object>.FromNative(IntPtr.Add(ParamsBuffer, GetCPPTypeObject_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/RigVMDeveloper.RigVMVariableNode:GetCPPType
    static readonly IntPtr GetCPPType_NativeFunction;
    static readonly int GetCPPType_ParamsSize;
    static readonly int GetCPPType_ReturnValue_Offset;
    
    public string GetCPPType()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetCPPType_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetCPPType_NativeFunction, ParamsBuffer);
            
            string returnValue;
            IntPtr ReturnValue_NativePtr = IntPtr.Add(ParamsBuffer,GetCPPType_ReturnValue_Offset);
            returnValue = StringMarshaller.FromNative(ReturnValue_NativePtr,0,null);
            StringMarshaller.DestructInstance(ReturnValue_NativePtr, 0);
            
            return returnValue;
        }
    }
    
    
}