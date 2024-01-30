// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Constraints;

[UClass]
public partial class ConstraintsScriptingLibrary : UnrealSharp.Engine.BlueprintFunctionLibrary
{
    
    static readonly IntPtr NativeClassPtr;
    static ConstraintsScriptingLibrary()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("ConstraintsScriptingLibrary");
        
        
        RemoveThisConstraint_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "RemoveThisConstraint");
        RemoveThisConstraint_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(RemoveThisConstraint_NativeFunction);
        RemoveThisConstraint_InWorld_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(RemoveThisConstraint_NativeFunction, "InWorld");
        RemoveThisConstraint_InTickableConstraint_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(RemoveThisConstraint_NativeFunction, "InTickableConstraint");
        RemoveThisConstraint_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(RemoveThisConstraint_NativeFunction, "ReturnValue");
        RemoveConstraint_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "RemoveConstraint");
        RemoveConstraint_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(RemoveConstraint_NativeFunction);
        RemoveConstraint_InWorld_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(RemoveConstraint_NativeFunction, "InWorld");
        RemoveConstraint_InIndex_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(RemoveConstraint_NativeFunction, "InIndex");
        RemoveConstraint_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(RemoveConstraint_NativeFunction, "ReturnValue");
        GetManager_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetManager");
        GetManager_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetManager_NativeFunction);
        GetManager_InWorld_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetManager_NativeFunction, "InWorld");
        GetManager_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetManager_NativeFunction, "ReturnValue");
        GetConstraintsArray_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetConstraintsArray");
        GetConstraintsArray_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetConstraintsArray_NativeFunction);
        GetConstraintsArray_InWorld_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetConstraintsArray_NativeFunction, "InWorld");
        GetConstraintsArray_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetConstraintsArray_NativeFunction, "ReturnValue");
        GetConstraintsArray_ReturnValue_ElementSize = FArrayPropertyExporter.CallGetArrayElementSize(GetConstraintsArray_NativeFunction, "ReturnValue");
        CreateTransformableHandle_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "CreateTransformableHandle");
        CreateTransformableHandle_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(CreateTransformableHandle_NativeFunction);
        CreateTransformableHandle_InWorld_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(CreateTransformableHandle_NativeFunction, "InWorld");
        CreateTransformableHandle_InObject_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(CreateTransformableHandle_NativeFunction, "InObject");
        CreateTransformableHandle_InAttachmentName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(CreateTransformableHandle_NativeFunction, "InAttachmentName");
        CreateTransformableHandle_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(CreateTransformableHandle_NativeFunction, "ReturnValue");
        CreateTransformableComponentHandle_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "CreateTransformableComponentHandle");
        CreateTransformableComponentHandle_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(CreateTransformableComponentHandle_NativeFunction);
        CreateTransformableComponentHandle_InWorld_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(CreateTransformableComponentHandle_NativeFunction, "InWorld");
        CreateTransformableComponentHandle_InSceneComponent_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(CreateTransformableComponentHandle_NativeFunction, "InSceneComponent");
        CreateTransformableComponentHandle_InSocketName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(CreateTransformableComponentHandle_NativeFunction, "InSocketName");
        CreateTransformableComponentHandle_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(CreateTransformableComponentHandle_NativeFunction, "ReturnValue");
        CreateFromType_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "CreateFromType");
        CreateFromType_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(CreateFromType_NativeFunction);
        CreateFromType_InWorld_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(CreateFromType_NativeFunction, "InWorld");
        CreateFromType_InType_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(CreateFromType_NativeFunction, "InType");
        CreateFromType_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(CreateFromType_NativeFunction, "ReturnValue");
        AddConstraint_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "AddConstraint");
        AddConstraint_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(AddConstraint_NativeFunction);
        AddConstraint_InWorld_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AddConstraint_NativeFunction, "InWorld");
        AddConstraint_InParentHandle_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AddConstraint_NativeFunction, "InParentHandle");
        AddConstraint_InChildHandle_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AddConstraint_NativeFunction, "InChildHandle");
        AddConstraint_InConstraint_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AddConstraint_NativeFunction, "InConstraint");
        AddConstraint_bMaintainOffset_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AddConstraint_NativeFunction, "bMaintainOffset");
        AddConstraint_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AddConstraint_NativeFunction, "ReturnValue");
        
        
    }
    
    protected ConstraintsScriptingLibrary(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // Function /Script/Constraints.ConstraintsScriptingLibrary:RemoveThisConstraint
    static readonly IntPtr RemoveThisConstraint_NativeFunction;
    static readonly int RemoveThisConstraint_ParamsSize;
    static readonly int RemoveThisConstraint_InWorld_Offset;
    static readonly int RemoveThisConstraint_InTickableConstraint_Offset;
    static readonly int RemoveThisConstraint_ReturnValue_Offset;
    
    public static bool RemoveThisConstraint(UnrealSharp.Engine.World inWorld, UnrealSharp.Constraints.TickableConstraint inTickableConstraint)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[RemoveThisConstraint_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.Engine.World>.ToNative(IntPtr.Add(ParamsBuffer, RemoveThisConstraint_InWorld_Offset), 0, null, inWorld);
            ObjectMarshaller<UnrealSharp.Constraints.TickableConstraint>.ToNative(IntPtr.Add(ParamsBuffer, RemoveThisConstraint_InTickableConstraint_Offset), 0, null, inTickableConstraint);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, RemoveThisConstraint_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, RemoveThisConstraint_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/Constraints.ConstraintsScriptingLibrary:RemoveConstraint
    static readonly IntPtr RemoveConstraint_NativeFunction;
    static readonly int RemoveConstraint_ParamsSize;
    static readonly int RemoveConstraint_InWorld_Offset;
    static readonly int RemoveConstraint_InIndex_Offset;
    static readonly int RemoveConstraint_ReturnValue_Offset;
    
    public static bool RemoveConstraint(UnrealSharp.Engine.World inWorld, int inIndex)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[RemoveConstraint_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.Engine.World>.ToNative(IntPtr.Add(ParamsBuffer, RemoveConstraint_InWorld_Offset), 0, null, inWorld);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(ParamsBuffer, RemoveConstraint_InIndex_Offset), 0, null, inIndex);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, RemoveConstraint_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, RemoveConstraint_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/Constraints.ConstraintsScriptingLibrary:GetManager
    static readonly IntPtr GetManager_NativeFunction;
    static readonly int GetManager_ParamsSize;
    static readonly int GetManager_InWorld_Offset;
    static readonly int GetManager_ReturnValue_Offset;
    
    public static UnrealSharp.Constraints.ConstraintsManager GetManager(UnrealSharp.Engine.World inWorld)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetManager_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.Engine.World>.ToNative(IntPtr.Add(ParamsBuffer, GetManager_InWorld_Offset), 0, null, inWorld);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, GetManager_NativeFunction, ParamsBuffer);
            
            UnrealSharp.Constraints.ConstraintsManager returnValue;
            returnValue = ObjectMarshaller<UnrealSharp.Constraints.ConstraintsManager>.FromNative(IntPtr.Add(ParamsBuffer, GetManager_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/Constraints.ConstraintsScriptingLibrary:GetConstraintsArray
    static readonly IntPtr GetConstraintsArray_NativeFunction;
    static readonly int GetConstraintsArray_ParamsSize;
    static readonly int GetConstraintsArray_InWorld_Offset;
    static readonly int GetConstraintsArray_ReturnValue_Offset;
    static readonly int GetConstraintsArray_ReturnValue_ElementSize;
    
    public static System.Collections.Generic.IList<UnrealSharp.Constraints.TickableConstraint> GetConstraintsArray(UnrealSharp.Engine.World inWorld)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetConstraintsArray_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.Engine.World>.ToNative(IntPtr.Add(ParamsBuffer, GetConstraintsArray_InWorld_Offset), 0, null, inWorld);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, GetConstraintsArray_NativeFunction, ParamsBuffer);
            
            System.Collections.Generic.IList<UnrealSharp.Constraints.TickableConstraint> returnValue;
            IntPtr ReturnValue_NativeBuffer = IntPtr.Add(ParamsBuffer, GetConstraintsArray_ReturnValue_Offset);
            UnrealArrayCopyMarshaler<UnrealSharp.Constraints.TickableConstraint> ReturnValue_Marshaler = new UnrealArrayCopyMarshaler<UnrealSharp.Constraints.TickableConstraint> (1, ObjectMarshaller<UnrealSharp.Constraints.TickableConstraint>.ToNative, ObjectMarshaller<UnrealSharp.Constraints.TickableConstraint>.FromNative, GetConstraintsArray_ReturnValue_ElementSize);
            returnValue = ReturnValue_Marshaler.FromNative(ReturnValue_NativeBuffer, 0, null);
            UnrealArrayCopyMarshaler<UnrealSharp.Constraints.TickableConstraint>.DestructInstance(ReturnValue_NativeBuffer, 0);
            
            return returnValue;
        }
    }
    
    // Function /Script/Constraints.ConstraintsScriptingLibrary:CreateTransformableHandle
    static readonly IntPtr CreateTransformableHandle_NativeFunction;
    static readonly int CreateTransformableHandle_ParamsSize;
    static readonly int CreateTransformableHandle_InWorld_Offset;
    static readonly int CreateTransformableHandle_InObject_Offset;
    static readonly int CreateTransformableHandle_InAttachmentName_Offset;
    static readonly int CreateTransformableHandle_ReturnValue_Offset;
    
    public static UnrealSharp.Constraints.TransformableHandle CreateTransformableHandle(UnrealSharp.Engine.World inWorld, UnrealSharp.CoreUObject.Object inObject, Name inAttachmentName = default(Name))
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[CreateTransformableHandle_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.Engine.World>.ToNative(IntPtr.Add(ParamsBuffer, CreateTransformableHandle_InWorld_Offset), 0, null, inWorld);
            ObjectMarshaller<UnrealSharp.CoreUObject.Object>.ToNative(IntPtr.Add(ParamsBuffer, CreateTransformableHandle_InObject_Offset), 0, null, inObject);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(ParamsBuffer, CreateTransformableHandle_InAttachmentName_Offset), 0, null, inAttachmentName);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, CreateTransformableHandle_NativeFunction, ParamsBuffer);
            
            UnrealSharp.Constraints.TransformableHandle returnValue;
            returnValue = ObjectMarshaller<UnrealSharp.Constraints.TransformableHandle>.FromNative(IntPtr.Add(ParamsBuffer, CreateTransformableHandle_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/Constraints.ConstraintsScriptingLibrary:CreateTransformableComponentHandle
    static readonly IntPtr CreateTransformableComponentHandle_NativeFunction;
    static readonly int CreateTransformableComponentHandle_ParamsSize;
    static readonly int CreateTransformableComponentHandle_InWorld_Offset;
    static readonly int CreateTransformableComponentHandle_InSceneComponent_Offset;
    static readonly int CreateTransformableComponentHandle_InSocketName_Offset;
    static readonly int CreateTransformableComponentHandle_ReturnValue_Offset;
    
    public static UnrealSharp.Constraints.TransformableComponentHandle CreateTransformableComponentHandle(UnrealSharp.Engine.World inWorld, UnrealSharp.Engine.SceneComponent inSceneComponent, Name inSocketName)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[CreateTransformableComponentHandle_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.Engine.World>.ToNative(IntPtr.Add(ParamsBuffer, CreateTransformableComponentHandle_InWorld_Offset), 0, null, inWorld);
            ObjectMarshaller<UnrealSharp.Engine.SceneComponent>.ToNative(IntPtr.Add(ParamsBuffer, CreateTransformableComponentHandle_InSceneComponent_Offset), 0, null, inSceneComponent);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(ParamsBuffer, CreateTransformableComponentHandle_InSocketName_Offset), 0, null, inSocketName);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, CreateTransformableComponentHandle_NativeFunction, ParamsBuffer);
            
            UnrealSharp.Constraints.TransformableComponentHandle returnValue;
            returnValue = ObjectMarshaller<UnrealSharp.Constraints.TransformableComponentHandle>.FromNative(IntPtr.Add(ParamsBuffer, CreateTransformableComponentHandle_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/Constraints.ConstraintsScriptingLibrary:CreateFromType
    static readonly IntPtr CreateFromType_NativeFunction;
    static readonly int CreateFromType_ParamsSize;
    static readonly int CreateFromType_InWorld_Offset;
    static readonly int CreateFromType_InType_Offset;
    static readonly int CreateFromType_ReturnValue_Offset;
    
    public static UnrealSharp.Constraints.TickableTransformConstraint CreateFromType(UnrealSharp.Engine.World inWorld, UnrealSharp.AnimationCore.ETransformConstraintType inType)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[CreateFromType_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.Engine.World>.ToNative(IntPtr.Add(ParamsBuffer, CreateFromType_InWorld_Offset), 0, null, inWorld);
            BlittableMarshaller<UnrealSharp.AnimationCore.ETransformConstraintType>.ToNative(IntPtr.Add(ParamsBuffer, CreateFromType_InType_Offset), 0, null, inType);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, CreateFromType_NativeFunction, ParamsBuffer);
            
            UnrealSharp.Constraints.TickableTransformConstraint returnValue;
            returnValue = ObjectMarshaller<UnrealSharp.Constraints.TickableTransformConstraint>.FromNative(IntPtr.Add(ParamsBuffer, CreateFromType_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/Constraints.ConstraintsScriptingLibrary:AddConstraint
    static readonly IntPtr AddConstraint_NativeFunction;
    static readonly int AddConstraint_ParamsSize;
    static readonly int AddConstraint_InWorld_Offset;
    static readonly int AddConstraint_InParentHandle_Offset;
    static readonly int AddConstraint_InChildHandle_Offset;
    static readonly int AddConstraint_InConstraint_Offset;
    static readonly int AddConstraint_bMaintainOffset_Offset;
    static readonly int AddConstraint_ReturnValue_Offset;
    
    public static bool AddConstraint(UnrealSharp.Engine.World inWorld, UnrealSharp.Constraints.TransformableHandle inParentHandle, UnrealSharp.Constraints.TransformableHandle inChildHandle, UnrealSharp.Constraints.TickableTransformConstraint inConstraint, bool bMaintainOffset)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[AddConstraint_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.Engine.World>.ToNative(IntPtr.Add(ParamsBuffer, AddConstraint_InWorld_Offset), 0, null, inWorld);
            ObjectMarshaller<UnrealSharp.Constraints.TransformableHandle>.ToNative(IntPtr.Add(ParamsBuffer, AddConstraint_InParentHandle_Offset), 0, null, inParentHandle);
            ObjectMarshaller<UnrealSharp.Constraints.TransformableHandle>.ToNative(IntPtr.Add(ParamsBuffer, AddConstraint_InChildHandle_Offset), 0, null, inChildHandle);
            ObjectMarshaller<UnrealSharp.Constraints.TickableTransformConstraint>.ToNative(IntPtr.Add(ParamsBuffer, AddConstraint_InConstraint_Offset), 0, null, inConstraint);
            BoolMarshaller.ToNative(IntPtr.Add(ParamsBuffer, AddConstraint_bMaintainOffset_Offset), 0, null, bMaintainOffset);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, AddConstraint_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, AddConstraint_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    
}