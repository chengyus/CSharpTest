// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UClass]
public partial class AnimationCurveIdentifierExtensions : UnrealSharp.Engine.BlueprintFunctionLibrary
{
    
    static readonly IntPtr NativeClassPtr;
    static AnimationCurveIdentifierExtensions()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("AnimationCurveIdentifierExtensions");
        
        
        SetCurveIdentifier_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetCurveIdentifier");
        SetCurveIdentifier_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetCurveIdentifier_NativeFunction);
        SetCurveIdentifier_InOutIdentifier_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetCurveIdentifier_NativeFunction, "InOutIdentifier");
        SetCurveIdentifier_Name_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetCurveIdentifier_NativeFunction, "Name");
        SetCurveIdentifier_CurveType_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetCurveIdentifier_NativeFunction, "CurveType");
        IsValid_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "IsValid");
        IsValid_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(IsValid_NativeFunction);
        IsValid_Identifier_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(IsValid_NativeFunction, "Identifier");
        IsValid_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(IsValid_NativeFunction, "ReturnValue");
        GetType_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetType");
        GetType_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetType_NativeFunction);
        GetType_Identifier_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetType_NativeFunction, "Identifier");
        GetType_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetType_NativeFunction, "ReturnValue");
        GetTransformChildCurveIdentifier_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetTransformChildCurveIdentifier");
        GetTransformChildCurveIdentifier_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetTransformChildCurveIdentifier_NativeFunction);
        GetTransformChildCurveIdentifier_InOutIdentifier_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetTransformChildCurveIdentifier_NativeFunction, "InOutIdentifier");
        GetTransformChildCurveIdentifier_Channel_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetTransformChildCurveIdentifier_NativeFunction, "Channel");
        GetTransformChildCurveIdentifier_Axis_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetTransformChildCurveIdentifier_NativeFunction, "Axis");
        GetTransformChildCurveIdentifier_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetTransformChildCurveIdentifier_NativeFunction, "ReturnValue");
        GetName_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetName");
        GetName_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetName_NativeFunction);
        GetName_Identifier_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetName_NativeFunction, "Identifier");
        GetName_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetName_NativeFunction, "ReturnValue");
        GetCurveIdentifiers_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetCurveIdentifiers");
        GetCurveIdentifiers_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetCurveIdentifiers_NativeFunction);
        GetCurveIdentifiers_InSkeleton_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetCurveIdentifiers_NativeFunction, "InSkeleton");
        GetCurveIdentifiers_CurveType_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetCurveIdentifiers_NativeFunction, "CurveType");
        GetCurveIdentifiers_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetCurveIdentifiers_NativeFunction, "ReturnValue");
        GetCurveIdentifiers_ReturnValue_ElementSize = FArrayPropertyExporter.CallGetArrayElementSize(GetCurveIdentifiers_NativeFunction, "ReturnValue");
        GetCurveIdentifier_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetCurveIdentifier");
        GetCurveIdentifier_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetCurveIdentifier_NativeFunction);
        GetCurveIdentifier_InSkeleton_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetCurveIdentifier_NativeFunction, "InSkeleton");
        GetCurveIdentifier_Name_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetCurveIdentifier_NativeFunction, "Name");
        GetCurveIdentifier_CurveType_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetCurveIdentifier_NativeFunction, "CurveType");
        GetCurveIdentifier_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetCurveIdentifier_NativeFunction, "ReturnValue");
        FindCurveIdentifier_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "FindCurveIdentifier");
        FindCurveIdentifier_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(FindCurveIdentifier_NativeFunction);
        FindCurveIdentifier_InSkeleton_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(FindCurveIdentifier_NativeFunction, "InSkeleton");
        FindCurveIdentifier_Name_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(FindCurveIdentifier_NativeFunction, "Name");
        FindCurveIdentifier_CurveType_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(FindCurveIdentifier_NativeFunction, "CurveType");
        FindCurveIdentifier_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(FindCurveIdentifier_NativeFunction, "ReturnValue");
        
        
    }
    
    protected AnimationCurveIdentifierExtensions(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // Function /Script/Engine.AnimationCurveIdentifierExtensions:SetCurveIdentifier
    static readonly IntPtr SetCurveIdentifier_NativeFunction;
    static readonly int SetCurveIdentifier_ParamsSize;
    static readonly int SetCurveIdentifier_InOutIdentifier_Offset;
    static readonly int SetCurveIdentifier_Name_Offset;
    static readonly int SetCurveIdentifier_CurveType_Offset;
    
    public static void SetCurveIdentifier(ref UnrealSharp.Engine.AnimationCurveIdentifier inOutIdentifier, Name name, UnrealSharp.Engine.ERawCurveTrackTypes curveType)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetCurveIdentifier_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            UnrealSharp.Engine.AnimationCurveIdentifierMarshaler.ToNative(IntPtr.Add(ParamsBuffer, SetCurveIdentifier_InOutIdentifier_Offset), 0, null, inOutIdentifier);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(ParamsBuffer, SetCurveIdentifier_Name_Offset), 0, null, name);
            BlittableMarshaller<UnrealSharp.Engine.ERawCurveTrackTypes>.ToNative(IntPtr.Add(ParamsBuffer, SetCurveIdentifier_CurveType_Offset), 0, null, curveType);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, SetCurveIdentifier_NativeFunction, ParamsBuffer);
            
            inOutIdentifier = UnrealSharp.Engine.AnimationCurveIdentifierMarshaler.FromNative(IntPtr.Add(ParamsBuffer, SetCurveIdentifier_InOutIdentifier_Offset), 0, null);
            
        }
    }
    
    // Function /Script/Engine.AnimationCurveIdentifierExtensions:IsValid
    static readonly IntPtr IsValid_NativeFunction;
    static readonly int IsValid_ParamsSize;
    static readonly int IsValid_Identifier_Offset;
    static readonly int IsValid_ReturnValue_Offset;
    
    public static bool IsValid(ref UnrealSharp.Engine.AnimationCurveIdentifier identifier)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[IsValid_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            UnrealSharp.Engine.AnimationCurveIdentifierMarshaler.ToNative(IntPtr.Add(ParamsBuffer, IsValid_Identifier_Offset), 0, null, identifier);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, IsValid_NativeFunction, ParamsBuffer);
            
            identifier = UnrealSharp.Engine.AnimationCurveIdentifierMarshaler.FromNative(IntPtr.Add(ParamsBuffer, IsValid_Identifier_Offset), 0, null);
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, IsValid_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/Engine.AnimationCurveIdentifierExtensions:GetType
    static readonly IntPtr GetType_NativeFunction;
    static readonly int GetType_ParamsSize;
    static readonly int GetType_Identifier_Offset;
    static readonly int GetType_ReturnValue_Offset;
    
    public static UnrealSharp.Engine.ERawCurveTrackTypes GetType(ref UnrealSharp.Engine.AnimationCurveIdentifier identifier)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetType_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            UnrealSharp.Engine.AnimationCurveIdentifierMarshaler.ToNative(IntPtr.Add(ParamsBuffer, GetType_Identifier_Offset), 0, null, identifier);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, GetType_NativeFunction, ParamsBuffer);
            
            identifier = UnrealSharp.Engine.AnimationCurveIdentifierMarshaler.FromNative(IntPtr.Add(ParamsBuffer, GetType_Identifier_Offset), 0, null);
            UnrealSharp.Engine.ERawCurveTrackTypes returnValue;
            returnValue = BlittableMarshaller<UnrealSharp.Engine.ERawCurveTrackTypes>.FromNative(IntPtr.Add(ParamsBuffer, GetType_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/Engine.AnimationCurveIdentifierExtensions:GetTransformChildCurveIdentifier
    static readonly IntPtr GetTransformChildCurveIdentifier_NativeFunction;
    static readonly int GetTransformChildCurveIdentifier_ParamsSize;
    static readonly int GetTransformChildCurveIdentifier_InOutIdentifier_Offset;
    static readonly int GetTransformChildCurveIdentifier_Channel_Offset;
    static readonly int GetTransformChildCurveIdentifier_Axis_Offset;
    static readonly int GetTransformChildCurveIdentifier_ReturnValue_Offset;
    
    public static bool GetTransformChildCurveIdentifier(ref UnrealSharp.Engine.AnimationCurveIdentifier inOutIdentifier, UnrealSharp.Engine.ETransformCurveChannel channel, UnrealSharp.Engine.EVectorCurveChannel axis)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetTransformChildCurveIdentifier_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            UnrealSharp.Engine.AnimationCurveIdentifierMarshaler.ToNative(IntPtr.Add(ParamsBuffer, GetTransformChildCurveIdentifier_InOutIdentifier_Offset), 0, null, inOutIdentifier);
            BlittableMarshaller<UnrealSharp.Engine.ETransformCurveChannel>.ToNative(IntPtr.Add(ParamsBuffer, GetTransformChildCurveIdentifier_Channel_Offset), 0, null, channel);
            BlittableMarshaller<UnrealSharp.Engine.EVectorCurveChannel>.ToNative(IntPtr.Add(ParamsBuffer, GetTransformChildCurveIdentifier_Axis_Offset), 0, null, axis);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, GetTransformChildCurveIdentifier_NativeFunction, ParamsBuffer);
            
            inOutIdentifier = UnrealSharp.Engine.AnimationCurveIdentifierMarshaler.FromNative(IntPtr.Add(ParamsBuffer, GetTransformChildCurveIdentifier_InOutIdentifier_Offset), 0, null);
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, GetTransformChildCurveIdentifier_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/Engine.AnimationCurveIdentifierExtensions:GetName
    static readonly IntPtr GetName_NativeFunction;
    static readonly int GetName_ParamsSize;
    static readonly int GetName_Identifier_Offset;
    static readonly int GetName_ReturnValue_Offset;
    
    public static Name GetName(ref UnrealSharp.Engine.AnimationCurveIdentifier identifier)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetName_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            UnrealSharp.Engine.AnimationCurveIdentifierMarshaler.ToNative(IntPtr.Add(ParamsBuffer, GetName_Identifier_Offset), 0, null, identifier);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, GetName_NativeFunction, ParamsBuffer);
            
            identifier = UnrealSharp.Engine.AnimationCurveIdentifierMarshaler.FromNative(IntPtr.Add(ParamsBuffer, GetName_Identifier_Offset), 0, null);
            Name returnValue;
            returnValue = BlittableMarshaller<Name>.FromNative(IntPtr.Add(ParamsBuffer, GetName_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/Engine.AnimationCurveIdentifierExtensions:GetCurveIdentifiers
    static readonly IntPtr GetCurveIdentifiers_NativeFunction;
    static readonly int GetCurveIdentifiers_ParamsSize;
    static readonly int GetCurveIdentifiers_InSkeleton_Offset;
    static readonly int GetCurveIdentifiers_CurveType_Offset;
    static readonly int GetCurveIdentifiers_ReturnValue_Offset;
    static readonly int GetCurveIdentifiers_ReturnValue_ElementSize;
    
    [Obsolete("Curve identifiers are no longer retrievable globally from the skeleton, they are specified per-animation.")]
    public static System.Collections.Generic.IList<UnrealSharp.Engine.AnimationCurveIdentifier> GetCurveIdentifiers(UnrealSharp.Engine.Skeleton inSkeleton, UnrealSharp.Engine.ERawCurveTrackTypes curveType)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetCurveIdentifiers_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.Engine.Skeleton>.ToNative(IntPtr.Add(ParamsBuffer, GetCurveIdentifiers_InSkeleton_Offset), 0, null, inSkeleton);
            BlittableMarshaller<UnrealSharp.Engine.ERawCurveTrackTypes>.ToNative(IntPtr.Add(ParamsBuffer, GetCurveIdentifiers_CurveType_Offset), 0, null, curveType);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, GetCurveIdentifiers_NativeFunction, ParamsBuffer);
            
            System.Collections.Generic.IList<UnrealSharp.Engine.AnimationCurveIdentifier> returnValue;
            IntPtr ReturnValue_NativeBuffer = IntPtr.Add(ParamsBuffer, GetCurveIdentifiers_ReturnValue_Offset);
            UnrealArrayCopyMarshaler<UnrealSharp.Engine.AnimationCurveIdentifier> ReturnValue_Marshaler = new UnrealArrayCopyMarshaler<UnrealSharp.Engine.AnimationCurveIdentifier> (1, UnrealSharp.Engine.AnimationCurveIdentifierMarshaler.ToNative, UnrealSharp.Engine.AnimationCurveIdentifierMarshaler.FromNative, GetCurveIdentifiers_ReturnValue_ElementSize);
            returnValue = ReturnValue_Marshaler.FromNative(ReturnValue_NativeBuffer, 0, null);
            UnrealArrayCopyMarshaler<UnrealSharp.Engine.AnimationCurveIdentifier>.DestructInstance(ReturnValue_NativeBuffer, 0);
            
            return returnValue;
        }
    }
    
    // Function /Script/Engine.AnimationCurveIdentifierExtensions:GetCurveIdentifier
    static readonly IntPtr GetCurveIdentifier_NativeFunction;
    static readonly int GetCurveIdentifier_ParamsSize;
    static readonly int GetCurveIdentifier_InSkeleton_Offset;
    static readonly int GetCurveIdentifier_Name_Offset;
    static readonly int GetCurveIdentifier_CurveType_Offset;
    static readonly int GetCurveIdentifier_ReturnValue_Offset;
    
    [Obsolete("Please use SetCurveIdentifier.")]
    public static UnrealSharp.Engine.AnimationCurveIdentifier GetCurveIdentifier(UnrealSharp.Engine.Skeleton inSkeleton, Name name, UnrealSharp.Engine.ERawCurveTrackTypes curveType)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetCurveIdentifier_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.Engine.Skeleton>.ToNative(IntPtr.Add(ParamsBuffer, GetCurveIdentifier_InSkeleton_Offset), 0, null, inSkeleton);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(ParamsBuffer, GetCurveIdentifier_Name_Offset), 0, null, name);
            BlittableMarshaller<UnrealSharp.Engine.ERawCurveTrackTypes>.ToNative(IntPtr.Add(ParamsBuffer, GetCurveIdentifier_CurveType_Offset), 0, null, curveType);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, GetCurveIdentifier_NativeFunction, ParamsBuffer);
            
            UnrealSharp.Engine.AnimationCurveIdentifier returnValue;
            returnValue = UnrealSharp.Engine.AnimationCurveIdentifierMarshaler.FromNative(IntPtr.Add(ParamsBuffer, GetCurveIdentifier_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/Engine.AnimationCurveIdentifierExtensions:FindCurveIdentifier
    static readonly IntPtr FindCurveIdentifier_NativeFunction;
    static readonly int FindCurveIdentifier_ParamsSize;
    static readonly int FindCurveIdentifier_InSkeleton_Offset;
    static readonly int FindCurveIdentifier_Name_Offset;
    static readonly int FindCurveIdentifier_CurveType_Offset;
    static readonly int FindCurveIdentifier_ReturnValue_Offset;
    
    [Obsolete("Curve identifiers are no longer retrievable globally from the skeleton, they are specified per-animation.")]
    public static UnrealSharp.Engine.AnimationCurveIdentifier FindCurveIdentifier(UnrealSharp.Engine.Skeleton inSkeleton, Name name, UnrealSharp.Engine.ERawCurveTrackTypes curveType)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[FindCurveIdentifier_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.Engine.Skeleton>.ToNative(IntPtr.Add(ParamsBuffer, FindCurveIdentifier_InSkeleton_Offset), 0, null, inSkeleton);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(ParamsBuffer, FindCurveIdentifier_Name_Offset), 0, null, name);
            BlittableMarshaller<UnrealSharp.Engine.ERawCurveTrackTypes>.ToNative(IntPtr.Add(ParamsBuffer, FindCurveIdentifier_CurveType_Offset), 0, null, curveType);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, FindCurveIdentifier_NativeFunction, ParamsBuffer);
            
            UnrealSharp.Engine.AnimationCurveIdentifier returnValue;
            returnValue = UnrealSharp.Engine.AnimationCurveIdentifierMarshaler.FromNative(IntPtr.Add(ParamsBuffer, FindCurveIdentifier_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    
}