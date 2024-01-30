// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRigEditor;

[UClass]
public partial class ControlRigBlueprintLibrary : UnrealSharp.Engine.BlueprintFunctionLibrary
{
    
    static readonly IntPtr NativeClassPtr;
    static ControlRigBlueprintLibrary()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("ControlRigBlueprintEditorLibrary");
        
        
        SetupAllEditorMenus_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetupAllEditorMenus");
        SetPreviewMesh_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetPreviewMesh");
        SetPreviewMesh_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetPreviewMesh_NativeFunction);
        SetPreviewMesh_InRigBlueprint_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetPreviewMesh_NativeFunction, "InRigBlueprint");
        SetPreviewMesh_PreviewMesh_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetPreviewMesh_NativeFunction, "PreviewMesh");
        SetPreviewMesh_bMarkAsDirty_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetPreviewMesh_NativeFunction, "bMarkAsDirty");
        RequestControlRigInit_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "RequestControlRigInit");
        RequestControlRigInit_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(RequestControlRigInit_NativeFunction);
        RequestControlRigInit_InRigBlueprint_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(RequestControlRigInit_NativeFunction, "InRigBlueprint");
        RequestAutoVMRecompilation_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "RequestAutoVMRecompilation");
        RequestAutoVMRecompilation_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(RequestAutoVMRecompilation_NativeFunction);
        RequestAutoVMRecompilation_InRigBlueprint_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(RequestAutoVMRecompilation_NativeFunction, "InRigBlueprint");
        RecompileVMIfRequired_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "RecompileVMIfRequired");
        RecompileVMIfRequired_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(RecompileVMIfRequired_NativeFunction);
        RecompileVMIfRequired_InRigBlueprint_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(RecompileVMIfRequired_NativeFunction, "InRigBlueprint");
        RecompileVM_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "RecompileVM");
        RecompileVM_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(RecompileVM_NativeFunction);
        RecompileVM_InRigBlueprint_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(RecompileVM_NativeFunction, "InRigBlueprint");
        GetPreviewMesh_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetPreviewMesh");
        GetPreviewMesh_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetPreviewMesh_NativeFunction);
        GetPreviewMesh_InRigBlueprint_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetPreviewMesh_NativeFunction, "InRigBlueprint");
        GetPreviewMesh_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetPreviewMesh_NativeFunction, "ReturnValue");
        GetModel_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetModel");
        GetModel_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetModel_NativeFunction);
        GetModel_InRigBlueprint_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetModel_NativeFunction, "InRigBlueprint");
        GetModel_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetModel_NativeFunction, "ReturnValue");
        GetHierarchyController_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetHierarchyController");
        GetHierarchyController_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetHierarchyController_NativeFunction);
        GetHierarchyController_InRigBlueprint_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetHierarchyController_NativeFunction, "InRigBlueprint");
        GetHierarchyController_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetHierarchyController_NativeFunction, "ReturnValue");
        GetHierarchy_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetHierarchy");
        GetHierarchy_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetHierarchy_NativeFunction);
        GetHierarchy_InRigBlueprint_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetHierarchy_NativeFunction, "InRigBlueprint");
        GetHierarchy_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetHierarchy_NativeFunction, "ReturnValue");
        GetCurrentlyOpenRigBlueprints_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetCurrentlyOpenRigBlueprints");
        GetCurrentlyOpenRigBlueprints_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetCurrentlyOpenRigBlueprints_NativeFunction);
        GetCurrentlyOpenRigBlueprints_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetCurrentlyOpenRigBlueprints_NativeFunction, "ReturnValue");
        GetCurrentlyOpenRigBlueprints_ReturnValue_ElementSize = FArrayPropertyExporter.CallGetArrayElementSize(GetCurrentlyOpenRigBlueprints_NativeFunction, "ReturnValue");
        GetController_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetController");
        GetController_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetController_NativeFunction);
        GetController_InRigBlueprint_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetController_NativeFunction, "InRigBlueprint");
        GetController_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetController_NativeFunction, "ReturnValue");
        GetAvailableRigUnits_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetAvailableRigUnits");
        GetAvailableRigUnits_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetAvailableRigUnits_NativeFunction);
        GetAvailableRigUnits_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetAvailableRigUnits_NativeFunction, "ReturnValue");
        GetAvailableRigUnits_ReturnValue_ElementSize = FArrayPropertyExporter.CallGetArrayElementSize(GetAvailableRigUnits_NativeFunction, "ReturnValue");
        CastToControlRigBlueprint_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "CastToControlRigBlueprint");
        CastToControlRigBlueprint_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(CastToControlRigBlueprint_NativeFunction);
        CastToControlRigBlueprint_Object_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(CastToControlRigBlueprint_NativeFunction, "Object");
        CastToControlRigBlueprint_Branches_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(CastToControlRigBlueprint_NativeFunction, "Branches");
        CastToControlRigBlueprint_AsControlRigBlueprint_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(CastToControlRigBlueprint_NativeFunction, "AsControlRigBlueprint");
        
        
    }
    
    protected ControlRigBlueprintLibrary(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // Function /Script/ControlRigEditor.ControlRigBlueprintEditorLibrary:SetupAllEditorMenus
    static readonly IntPtr SetupAllEditorMenus_NativeFunction;
    
    public static void SetupAllEditorMenus()
    {
        unsafe
        {
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, SetupAllEditorMenus_NativeFunction, IntPtr.Zero);
        }
    }
    
    // Function /Script/ControlRigEditor.ControlRigBlueprintEditorLibrary:SetPreviewMesh
    static readonly IntPtr SetPreviewMesh_NativeFunction;
    static readonly int SetPreviewMesh_ParamsSize;
    static readonly int SetPreviewMesh_InRigBlueprint_Offset;
    static readonly int SetPreviewMesh_PreviewMesh_Offset;
    static readonly int SetPreviewMesh_bMarkAsDirty_Offset;
    
    public static void SetPreviewMesh(UnrealSharp.ControlRigDeveloper.ControlRigBlueprint inRigBlueprint, UnrealSharp.Engine.SkeletalMesh previewMesh, bool bMarkAsDirty = true)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetPreviewMesh_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.ControlRigDeveloper.ControlRigBlueprint>.ToNative(IntPtr.Add(ParamsBuffer, SetPreviewMesh_InRigBlueprint_Offset), 0, null, inRigBlueprint);
            ObjectMarshaller<UnrealSharp.Engine.SkeletalMesh>.ToNative(IntPtr.Add(ParamsBuffer, SetPreviewMesh_PreviewMesh_Offset), 0, null, previewMesh);
            BoolMarshaller.ToNative(IntPtr.Add(ParamsBuffer, SetPreviewMesh_bMarkAsDirty_Offset), 0, null, bMarkAsDirty);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, SetPreviewMesh_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/ControlRigEditor.ControlRigBlueprintEditorLibrary:RequestControlRigInit
    static readonly IntPtr RequestControlRigInit_NativeFunction;
    static readonly int RequestControlRigInit_ParamsSize;
    static readonly int RequestControlRigInit_InRigBlueprint_Offset;
    
    public static void RequestControlRigInit(UnrealSharp.ControlRigDeveloper.ControlRigBlueprint inRigBlueprint)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[RequestControlRigInit_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.ControlRigDeveloper.ControlRigBlueprint>.ToNative(IntPtr.Add(ParamsBuffer, RequestControlRigInit_InRigBlueprint_Offset), 0, null, inRigBlueprint);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, RequestControlRigInit_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/ControlRigEditor.ControlRigBlueprintEditorLibrary:RequestAutoVMRecompilation
    static readonly IntPtr RequestAutoVMRecompilation_NativeFunction;
    static readonly int RequestAutoVMRecompilation_ParamsSize;
    static readonly int RequestAutoVMRecompilation_InRigBlueprint_Offset;
    
    public static void RequestAutoVMRecompilation(UnrealSharp.ControlRigDeveloper.ControlRigBlueprint inRigBlueprint)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[RequestAutoVMRecompilation_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.ControlRigDeveloper.ControlRigBlueprint>.ToNative(IntPtr.Add(ParamsBuffer, RequestAutoVMRecompilation_InRigBlueprint_Offset), 0, null, inRigBlueprint);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, RequestAutoVMRecompilation_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/ControlRigEditor.ControlRigBlueprintEditorLibrary:RecompileVMIfRequired
    static readonly IntPtr RecompileVMIfRequired_NativeFunction;
    static readonly int RecompileVMIfRequired_ParamsSize;
    static readonly int RecompileVMIfRequired_InRigBlueprint_Offset;
    
    public static void RecompileVMIfRequired(UnrealSharp.ControlRigDeveloper.ControlRigBlueprint inRigBlueprint)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[RecompileVMIfRequired_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.ControlRigDeveloper.ControlRigBlueprint>.ToNative(IntPtr.Add(ParamsBuffer, RecompileVMIfRequired_InRigBlueprint_Offset), 0, null, inRigBlueprint);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, RecompileVMIfRequired_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/ControlRigEditor.ControlRigBlueprintEditorLibrary:RecompileVM
    static readonly IntPtr RecompileVM_NativeFunction;
    static readonly int RecompileVM_ParamsSize;
    static readonly int RecompileVM_InRigBlueprint_Offset;
    
    public static void RecompileVM(UnrealSharp.ControlRigDeveloper.ControlRigBlueprint inRigBlueprint)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[RecompileVM_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.ControlRigDeveloper.ControlRigBlueprint>.ToNative(IntPtr.Add(ParamsBuffer, RecompileVM_InRigBlueprint_Offset), 0, null, inRigBlueprint);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, RecompileVM_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/ControlRigEditor.ControlRigBlueprintEditorLibrary:GetPreviewMesh
    static readonly IntPtr GetPreviewMesh_NativeFunction;
    static readonly int GetPreviewMesh_ParamsSize;
    static readonly int GetPreviewMesh_InRigBlueprint_Offset;
    static readonly int GetPreviewMesh_ReturnValue_Offset;
    
    public static UnrealSharp.Engine.SkeletalMesh GetPreviewMesh(UnrealSharp.ControlRigDeveloper.ControlRigBlueprint inRigBlueprint)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetPreviewMesh_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.ControlRigDeveloper.ControlRigBlueprint>.ToNative(IntPtr.Add(ParamsBuffer, GetPreviewMesh_InRigBlueprint_Offset), 0, null, inRigBlueprint);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, GetPreviewMesh_NativeFunction, ParamsBuffer);
            
            UnrealSharp.Engine.SkeletalMesh returnValue;
            returnValue = ObjectMarshaller<UnrealSharp.Engine.SkeletalMesh>.FromNative(IntPtr.Add(ParamsBuffer, GetPreviewMesh_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/ControlRigEditor.ControlRigBlueprintEditorLibrary:GetModel
    static readonly IntPtr GetModel_NativeFunction;
    static readonly int GetModel_ParamsSize;
    static readonly int GetModel_InRigBlueprint_Offset;
    static readonly int GetModel_ReturnValue_Offset;
    
    public static UnrealSharp.RigVMDeveloper.RigVMGraph GetModel(UnrealSharp.ControlRigDeveloper.ControlRigBlueprint inRigBlueprint)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetModel_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.ControlRigDeveloper.ControlRigBlueprint>.ToNative(IntPtr.Add(ParamsBuffer, GetModel_InRigBlueprint_Offset), 0, null, inRigBlueprint);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, GetModel_NativeFunction, ParamsBuffer);
            
            UnrealSharp.RigVMDeveloper.RigVMGraph returnValue;
            returnValue = ObjectMarshaller<UnrealSharp.RigVMDeveloper.RigVMGraph>.FromNative(IntPtr.Add(ParamsBuffer, GetModel_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/ControlRigEditor.ControlRigBlueprintEditorLibrary:GetHierarchyController
    static readonly IntPtr GetHierarchyController_NativeFunction;
    static readonly int GetHierarchyController_ParamsSize;
    static readonly int GetHierarchyController_InRigBlueprint_Offset;
    static readonly int GetHierarchyController_ReturnValue_Offset;
    
    public static UnrealSharp.ControlRig.RigHierarchyController GetHierarchyController(UnrealSharp.ControlRigDeveloper.ControlRigBlueprint inRigBlueprint)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetHierarchyController_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.ControlRigDeveloper.ControlRigBlueprint>.ToNative(IntPtr.Add(ParamsBuffer, GetHierarchyController_InRigBlueprint_Offset), 0, null, inRigBlueprint);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, GetHierarchyController_NativeFunction, ParamsBuffer);
            
            UnrealSharp.ControlRig.RigHierarchyController returnValue;
            returnValue = ObjectMarshaller<UnrealSharp.ControlRig.RigHierarchyController>.FromNative(IntPtr.Add(ParamsBuffer, GetHierarchyController_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/ControlRigEditor.ControlRigBlueprintEditorLibrary:GetHierarchy
    static readonly IntPtr GetHierarchy_NativeFunction;
    static readonly int GetHierarchy_ParamsSize;
    static readonly int GetHierarchy_InRigBlueprint_Offset;
    static readonly int GetHierarchy_ReturnValue_Offset;
    
    public static UnrealSharp.ControlRig.RigHierarchy GetHierarchy(UnrealSharp.ControlRigDeveloper.ControlRigBlueprint inRigBlueprint)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetHierarchy_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.ControlRigDeveloper.ControlRigBlueprint>.ToNative(IntPtr.Add(ParamsBuffer, GetHierarchy_InRigBlueprint_Offset), 0, null, inRigBlueprint);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, GetHierarchy_NativeFunction, ParamsBuffer);
            
            UnrealSharp.ControlRig.RigHierarchy returnValue;
            returnValue = ObjectMarshaller<UnrealSharp.ControlRig.RigHierarchy>.FromNative(IntPtr.Add(ParamsBuffer, GetHierarchy_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/ControlRigEditor.ControlRigBlueprintEditorLibrary:GetCurrentlyOpenRigBlueprints
    static readonly IntPtr GetCurrentlyOpenRigBlueprints_NativeFunction;
    static readonly int GetCurrentlyOpenRigBlueprints_ParamsSize;
    static readonly int GetCurrentlyOpenRigBlueprints_ReturnValue_Offset;
    static readonly int GetCurrentlyOpenRigBlueprints_ReturnValue_ElementSize;
    
    public static System.Collections.Generic.IList<UnrealSharp.ControlRigDeveloper.ControlRigBlueprint> GetCurrentlyOpenRigBlueprints()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetCurrentlyOpenRigBlueprints_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, GetCurrentlyOpenRigBlueprints_NativeFunction, ParamsBuffer);
            
            System.Collections.Generic.IList<UnrealSharp.ControlRigDeveloper.ControlRigBlueprint> returnValue;
            IntPtr ReturnValue_NativeBuffer = IntPtr.Add(ParamsBuffer, GetCurrentlyOpenRigBlueprints_ReturnValue_Offset);
            UnrealArrayCopyMarshaler<UnrealSharp.ControlRigDeveloper.ControlRigBlueprint> ReturnValue_Marshaler = new UnrealArrayCopyMarshaler<UnrealSharp.ControlRigDeveloper.ControlRigBlueprint> (1, ObjectMarshaller<UnrealSharp.ControlRigDeveloper.ControlRigBlueprint>.ToNative, ObjectMarshaller<UnrealSharp.ControlRigDeveloper.ControlRigBlueprint>.FromNative, GetCurrentlyOpenRigBlueprints_ReturnValue_ElementSize);
            returnValue = ReturnValue_Marshaler.FromNative(ReturnValue_NativeBuffer, 0, null);
            UnrealArrayCopyMarshaler<UnrealSharp.ControlRigDeveloper.ControlRigBlueprint>.DestructInstance(ReturnValue_NativeBuffer, 0);
            
            return returnValue;
        }
    }
    
    // Function /Script/ControlRigEditor.ControlRigBlueprintEditorLibrary:GetController
    static readonly IntPtr GetController_NativeFunction;
    static readonly int GetController_ParamsSize;
    static readonly int GetController_InRigBlueprint_Offset;
    static readonly int GetController_ReturnValue_Offset;
    
    public static UnrealSharp.RigVMDeveloper.RigVMController GetController(UnrealSharp.ControlRigDeveloper.ControlRigBlueprint inRigBlueprint)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetController_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.ControlRigDeveloper.ControlRigBlueprint>.ToNative(IntPtr.Add(ParamsBuffer, GetController_InRigBlueprint_Offset), 0, null, inRigBlueprint);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, GetController_NativeFunction, ParamsBuffer);
            
            UnrealSharp.RigVMDeveloper.RigVMController returnValue;
            returnValue = ObjectMarshaller<UnrealSharp.RigVMDeveloper.RigVMController>.FromNative(IntPtr.Add(ParamsBuffer, GetController_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/ControlRigEditor.ControlRigBlueprintEditorLibrary:GetAvailableRigUnits
    static readonly IntPtr GetAvailableRigUnits_NativeFunction;
    static readonly int GetAvailableRigUnits_ParamsSize;
    static readonly int GetAvailableRigUnits_ReturnValue_Offset;
    static readonly int GetAvailableRigUnits_ReturnValue_ElementSize;
    
    public static System.Collections.Generic.IList<UnrealSharp.CoreUObject.Struct> GetAvailableRigUnits()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetAvailableRigUnits_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, GetAvailableRigUnits_NativeFunction, ParamsBuffer);
            
            System.Collections.Generic.IList<UnrealSharp.CoreUObject.Struct> returnValue;
            IntPtr ReturnValue_NativeBuffer = IntPtr.Add(ParamsBuffer, GetAvailableRigUnits_ReturnValue_Offset);
            UnrealArrayCopyMarshaler<UnrealSharp.CoreUObject.Struct> ReturnValue_Marshaler = new UnrealArrayCopyMarshaler<UnrealSharp.CoreUObject.Struct> (1, ObjectMarshaller<UnrealSharp.CoreUObject.Struct>.ToNative, ObjectMarshaller<UnrealSharp.CoreUObject.Struct>.FromNative, GetAvailableRigUnits_ReturnValue_ElementSize);
            returnValue = ReturnValue_Marshaler.FromNative(ReturnValue_NativeBuffer, 0, null);
            UnrealArrayCopyMarshaler<UnrealSharp.CoreUObject.Struct>.DestructInstance(ReturnValue_NativeBuffer, 0);
            
            return returnValue;
        }
    }
    
    // Function /Script/ControlRigEditor.ControlRigBlueprintEditorLibrary:CastToControlRigBlueprint
    static readonly IntPtr CastToControlRigBlueprint_NativeFunction;
    static readonly int CastToControlRigBlueprint_ParamsSize;
    static readonly int CastToControlRigBlueprint_Object_Offset;
    static readonly int CastToControlRigBlueprint_Branches_Offset;
    static readonly int CastToControlRigBlueprint_AsControlRigBlueprint_Offset;
    
    public static void CastToControlRigBlueprint(UnrealSharp.CoreUObject.Object @object, out UnrealSharp.ControlRigEditor.ECastToControlRigBlueprintCases branches, out UnrealSharp.ControlRigDeveloper.ControlRigBlueprint asControlRigBlueprint)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[CastToControlRigBlueprint_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.CoreUObject.Object>.ToNative(IntPtr.Add(ParamsBuffer, CastToControlRigBlueprint_Object_Offset), 0, null, @object);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, CastToControlRigBlueprint_NativeFunction, ParamsBuffer);
            
            branches = BlittableMarshaller<UnrealSharp.ControlRigEditor.ECastToControlRigBlueprintCases>.FromNative(IntPtr.Add(ParamsBuffer, CastToControlRigBlueprint_Branches_Offset), 0, null);
            asControlRigBlueprint = ObjectMarshaller<UnrealSharp.ControlRigDeveloper.ControlRigBlueprint>.FromNative(IntPtr.Add(ParamsBuffer, CastToControlRigBlueprint_AsControlRigBlueprint_Offset), 0, null);
            
        }
    }
    
    
}