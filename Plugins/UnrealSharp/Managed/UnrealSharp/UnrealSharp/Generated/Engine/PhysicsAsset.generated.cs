// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UClass]
public partial class PhysicsAsset : UnrealSharp.CoreUObject.Object
{
    
    static PhysicsAsset()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("PhysicsAsset");
        
        
        GetConstraints_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetConstraints");
        GetConstraints_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetConstraints_NativeFunction);
        GetConstraints_bIncludesTerminated_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetConstraints_NativeFunction, "bIncludesTerminated");
        GetConstraints_OutConstraints_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetConstraints_NativeFunction, "OutConstraints");
        GetConstraints_OutConstraints_ElementSize = FArrayPropertyExporter.CallGetArrayElementSize(GetConstraints_NativeFunction, "OutConstraints");
        GetConstraintByName_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetConstraintByName");
        GetConstraintByName_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetConstraintByName_NativeFunction);
        GetConstraintByName_ConstraintName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetConstraintByName_NativeFunction, "ConstraintName");
        GetConstraintByName_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetConstraintByName_NativeFunction, "ReturnValue");
        GetConstraintByBoneNames_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetConstraintByBoneNames");
        GetConstraintByBoneNames_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetConstraintByBoneNames_NativeFunction);
        GetConstraintByBoneNames_Bone1Name_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetConstraintByBoneNames_NativeFunction, "Bone1Name");
        GetConstraintByBoneNames_Bone2Name_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetConstraintByBoneNames_NativeFunction, "Bone2Name");
        GetConstraintByBoneNames_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetConstraintByBoneNames_NativeFunction, "ReturnValue");
        
        
    }
    
    protected PhysicsAsset(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // Function /Script/Engine.PhysicsAsset:GetConstraints
    static readonly IntPtr GetConstraints_NativeFunction;
    static readonly int GetConstraints_ParamsSize;
    static readonly int GetConstraints_bIncludesTerminated_Offset;
    static readonly int GetConstraints_OutConstraints_Offset;
    static readonly int GetConstraints_OutConstraints_ElementSize;
    
    public void GetConstraints(bool bIncludesTerminated, out System.Collections.Generic.IList<UnrealSharp.Engine.ConstraintInstanceAccessor> outConstraints)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetConstraints_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BoolMarshaller.ToNative(IntPtr.Add(ParamsBuffer, GetConstraints_bIncludesTerminated_Offset), 0, null, bIncludesTerminated);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetConstraints_NativeFunction, ParamsBuffer);
            
            IntPtr OutConstraints_NativeBuffer = IntPtr.Add(ParamsBuffer, GetConstraints_OutConstraints_Offset);
            UnrealArrayCopyMarshaler<UnrealSharp.Engine.ConstraintInstanceAccessor> OutConstraints_Marshaler = new UnrealArrayCopyMarshaler<UnrealSharp.Engine.ConstraintInstanceAccessor> (1, UnrealSharp.Engine.ConstraintInstanceAccessorMarshaler.ToNative, UnrealSharp.Engine.ConstraintInstanceAccessorMarshaler.FromNative, GetConstraints_OutConstraints_ElementSize);
            outConstraints = OutConstraints_Marshaler.FromNative(OutConstraints_NativeBuffer, 0, null);
            UnrealArrayCopyMarshaler<UnrealSharp.Engine.ConstraintInstanceAccessor>.DestructInstance(OutConstraints_NativeBuffer, 0);
            
        }
    }
    
    // Function /Script/Engine.PhysicsAsset:GetConstraintByName
    static readonly IntPtr GetConstraintByName_NativeFunction;
    static readonly int GetConstraintByName_ParamsSize;
    static readonly int GetConstraintByName_ConstraintName_Offset;
    static readonly int GetConstraintByName_ReturnValue_Offset;
    
    public UnrealSharp.Engine.ConstraintInstanceAccessor GetConstraintByName(Name constraintName)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetConstraintByName_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(ParamsBuffer, GetConstraintByName_ConstraintName_Offset), 0, null, constraintName);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetConstraintByName_NativeFunction, ParamsBuffer);
            
            UnrealSharp.Engine.ConstraintInstanceAccessor returnValue;
            returnValue = UnrealSharp.Engine.ConstraintInstanceAccessorMarshaler.FromNative(IntPtr.Add(ParamsBuffer, GetConstraintByName_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/Engine.PhysicsAsset:GetConstraintByBoneNames
    static readonly IntPtr GetConstraintByBoneNames_NativeFunction;
    static readonly int GetConstraintByBoneNames_ParamsSize;
    static readonly int GetConstraintByBoneNames_Bone1Name_Offset;
    static readonly int GetConstraintByBoneNames_Bone2Name_Offset;
    static readonly int GetConstraintByBoneNames_ReturnValue_Offset;
    
    public UnrealSharp.Engine.ConstraintInstanceAccessor GetConstraintByBoneNames(Name bone1Name, Name bone2Name)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetConstraintByBoneNames_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(ParamsBuffer, GetConstraintByBoneNames_Bone1Name_Offset), 0, null, bone1Name);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(ParamsBuffer, GetConstraintByBoneNames_Bone2Name_Offset), 0, null, bone2Name);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetConstraintByBoneNames_NativeFunction, ParamsBuffer);
            
            UnrealSharp.Engine.ConstraintInstanceAccessor returnValue;
            returnValue = UnrealSharp.Engine.ConstraintInstanceAccessorMarshaler.FromNative(IntPtr.Add(ParamsBuffer, GetConstraintByBoneNames_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    
}