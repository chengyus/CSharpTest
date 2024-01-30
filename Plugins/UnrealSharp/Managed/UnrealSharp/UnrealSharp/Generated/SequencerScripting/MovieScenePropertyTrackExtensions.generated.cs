// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.SequencerScripting;

[UClass]
public partial class MovieScenePropertyTrackExtensions : UnrealSharp.Engine.BlueprintFunctionLibrary
{
    
    static readonly IntPtr NativeClassPtr;
    static MovieScenePropertyTrackExtensions()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("MovieScenePropertyTrackExtensions");
        
        
        SetPropertyNameAndPath_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetPropertyNameAndPath");
        SetPropertyNameAndPath_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetPropertyNameAndPath_NativeFunction);
        SetPropertyNameAndPath_Track_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetPropertyNameAndPath_NativeFunction, "Track");
        SetPropertyNameAndPath_InPropertyName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetPropertyNameAndPath_NativeFunction, "InPropertyName");
        SetPropertyNameAndPath_InPropertyPath_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetPropertyNameAndPath_NativeFunction, "InPropertyPath");
        SetObjectPropertyClass_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetObjectPropertyClass");
        SetObjectPropertyClass_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetObjectPropertyClass_NativeFunction);
        SetObjectPropertyClass_Track_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetObjectPropertyClass_NativeFunction, "Track");
        SetObjectPropertyClass_PropertyClass_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetObjectPropertyClass_NativeFunction, "PropertyClass");
        SetByteTrackEnum_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetByteTrackEnum");
        SetByteTrackEnum_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetByteTrackEnum_NativeFunction);
        SetByteTrackEnum_Track_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetByteTrackEnum_NativeFunction, "Track");
        SetByteTrackEnum_InEnum_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetByteTrackEnum_NativeFunction, "InEnum");
        GetUniqueTrackName_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetUniqueTrackName");
        GetUniqueTrackName_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetUniqueTrackName_NativeFunction);
        GetUniqueTrackName_Track_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetUniqueTrackName_NativeFunction, "Track");
        GetUniqueTrackName_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetUniqueTrackName_NativeFunction, "ReturnValue");
        GetPropertyPath_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetPropertyPath");
        GetPropertyPath_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetPropertyPath_NativeFunction);
        GetPropertyPath_Track_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetPropertyPath_NativeFunction, "Track");
        GetPropertyPath_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetPropertyPath_NativeFunction, "ReturnValue");
        GetPropertyName_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetPropertyName");
        GetPropertyName_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetPropertyName_NativeFunction);
        GetPropertyName_Track_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetPropertyName_NativeFunction, "Track");
        GetPropertyName_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetPropertyName_NativeFunction, "ReturnValue");
        GetObjectPropertyClass_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetObjectPropertyClass");
        GetObjectPropertyClass_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetObjectPropertyClass_NativeFunction);
        GetObjectPropertyClass_Track_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetObjectPropertyClass_NativeFunction, "Track");
        GetObjectPropertyClass_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetObjectPropertyClass_NativeFunction, "ReturnValue");
        GetByteTrackEnum_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetByteTrackEnum");
        GetByteTrackEnum_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetByteTrackEnum_NativeFunction);
        GetByteTrackEnum_Track_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetByteTrackEnum_NativeFunction, "Track");
        GetByteTrackEnum_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetByteTrackEnum_NativeFunction, "ReturnValue");
        
        
    }
    
    protected MovieScenePropertyTrackExtensions(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // Function /Script/SequencerScripting.MovieScenePropertyTrackExtensions:SetPropertyNameAndPath
    static readonly IntPtr SetPropertyNameAndPath_NativeFunction;
    static readonly int SetPropertyNameAndPath_ParamsSize;
    static readonly int SetPropertyNameAndPath_Track_Offset;
    static readonly int SetPropertyNameAndPath_InPropertyName_Offset;
    static readonly int SetPropertyNameAndPath_InPropertyPath_Offset;
    
    public static void SetPropertyNameAndPath(UnrealSharp.MovieSceneTracks.MovieScenePropertyTrack track, Name inPropertyName, string inPropertyPath)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetPropertyNameAndPath_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.MovieSceneTracks.MovieScenePropertyTrack>.ToNative(IntPtr.Add(ParamsBuffer, SetPropertyNameAndPath_Track_Offset), 0, null, track);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(ParamsBuffer, SetPropertyNameAndPath_InPropertyName_Offset), 0, null, inPropertyName);
            IntPtr InPropertyPath_NativePtr = IntPtr.Add(ParamsBuffer,SetPropertyNameAndPath_InPropertyPath_Offset);
            StringMarshaller.ToNative(InPropertyPath_NativePtr,0,null,inPropertyPath);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, SetPropertyNameAndPath_NativeFunction, ParamsBuffer);
            
            
            StringMarshaller.DestructInstance(InPropertyPath_NativePtr, 0);
        }
    }
    
    // Function /Script/SequencerScripting.MovieScenePropertyTrackExtensions:SetObjectPropertyClass
    static readonly IntPtr SetObjectPropertyClass_NativeFunction;
    static readonly int SetObjectPropertyClass_ParamsSize;
    static readonly int SetObjectPropertyClass_Track_Offset;
    static readonly int SetObjectPropertyClass_PropertyClass_Offset;
    
    public static void SetObjectPropertyClass(UnrealSharp.MovieSceneTracks.MovieSceneObjectPropertyTrack track, SubclassOf<UnrealSharp.CoreUObject.Object> propertyClass)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetObjectPropertyClass_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.MovieSceneTracks.MovieSceneObjectPropertyTrack>.ToNative(IntPtr.Add(ParamsBuffer, SetObjectPropertyClass_Track_Offset), 0, null, track);
            SubclassOfMarshaller<UnrealSharp.CoreUObject.Object>.ToNative(IntPtr.Add(ParamsBuffer, SetObjectPropertyClass_PropertyClass_Offset), 0, null, propertyClass);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, SetObjectPropertyClass_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/SequencerScripting.MovieScenePropertyTrackExtensions:SetByteTrackEnum
    static readonly IntPtr SetByteTrackEnum_NativeFunction;
    static readonly int SetByteTrackEnum_ParamsSize;
    static readonly int SetByteTrackEnum_Track_Offset;
    static readonly int SetByteTrackEnum_InEnum_Offset;
    
    public static void SetByteTrackEnum(UnrealSharp.MovieSceneTracks.MovieSceneByteTrack track, UnrealSharp.CoreUObject.Enum inEnum)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetByteTrackEnum_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.MovieSceneTracks.MovieSceneByteTrack>.ToNative(IntPtr.Add(ParamsBuffer, SetByteTrackEnum_Track_Offset), 0, null, track);
            ObjectMarshaller<UnrealSharp.CoreUObject.Enum>.ToNative(IntPtr.Add(ParamsBuffer, SetByteTrackEnum_InEnum_Offset), 0, null, inEnum);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, SetByteTrackEnum_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/SequencerScripting.MovieScenePropertyTrackExtensions:GetUniqueTrackName
    static readonly IntPtr GetUniqueTrackName_NativeFunction;
    static readonly int GetUniqueTrackName_ParamsSize;
    static readonly int GetUniqueTrackName_Track_Offset;
    static readonly int GetUniqueTrackName_ReturnValue_Offset;
    
    public static Name GetUniqueTrackName(UnrealSharp.MovieSceneTracks.MovieScenePropertyTrack track)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetUniqueTrackName_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.MovieSceneTracks.MovieScenePropertyTrack>.ToNative(IntPtr.Add(ParamsBuffer, GetUniqueTrackName_Track_Offset), 0, null, track);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, GetUniqueTrackName_NativeFunction, ParamsBuffer);
            
            Name returnValue;
            returnValue = BlittableMarshaller<Name>.FromNative(IntPtr.Add(ParamsBuffer, GetUniqueTrackName_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/SequencerScripting.MovieScenePropertyTrackExtensions:GetPropertyPath
    static readonly IntPtr GetPropertyPath_NativeFunction;
    static readonly int GetPropertyPath_ParamsSize;
    static readonly int GetPropertyPath_Track_Offset;
    static readonly int GetPropertyPath_ReturnValue_Offset;
    
    public static string GetPropertyPath(UnrealSharp.MovieSceneTracks.MovieScenePropertyTrack track)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetPropertyPath_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.MovieSceneTracks.MovieScenePropertyTrack>.ToNative(IntPtr.Add(ParamsBuffer, GetPropertyPath_Track_Offset), 0, null, track);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, GetPropertyPath_NativeFunction, ParamsBuffer);
            
            string returnValue;
            IntPtr ReturnValue_NativePtr = IntPtr.Add(ParamsBuffer,GetPropertyPath_ReturnValue_Offset);
            returnValue = StringMarshaller.FromNative(ReturnValue_NativePtr,0,null);
            StringMarshaller.DestructInstance(ReturnValue_NativePtr, 0);
            
            return returnValue;
        }
    }
    
    // Function /Script/SequencerScripting.MovieScenePropertyTrackExtensions:GetPropertyName
    static readonly IntPtr GetPropertyName_NativeFunction;
    static readonly int GetPropertyName_ParamsSize;
    static readonly int GetPropertyName_Track_Offset;
    static readonly int GetPropertyName_ReturnValue_Offset;
    
    public static Name GetPropertyName(UnrealSharp.MovieSceneTracks.MovieScenePropertyTrack track)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetPropertyName_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.MovieSceneTracks.MovieScenePropertyTrack>.ToNative(IntPtr.Add(ParamsBuffer, GetPropertyName_Track_Offset), 0, null, track);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, GetPropertyName_NativeFunction, ParamsBuffer);
            
            Name returnValue;
            returnValue = BlittableMarshaller<Name>.FromNative(IntPtr.Add(ParamsBuffer, GetPropertyName_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/SequencerScripting.MovieScenePropertyTrackExtensions:GetObjectPropertyClass
    static readonly IntPtr GetObjectPropertyClass_NativeFunction;
    static readonly int GetObjectPropertyClass_ParamsSize;
    static readonly int GetObjectPropertyClass_Track_Offset;
    static readonly int GetObjectPropertyClass_ReturnValue_Offset;
    
    public static SubclassOf<UnrealSharp.CoreUObject.Object> GetObjectPropertyClass(UnrealSharp.MovieSceneTracks.MovieSceneObjectPropertyTrack track)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetObjectPropertyClass_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.MovieSceneTracks.MovieSceneObjectPropertyTrack>.ToNative(IntPtr.Add(ParamsBuffer, GetObjectPropertyClass_Track_Offset), 0, null, track);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, GetObjectPropertyClass_NativeFunction, ParamsBuffer);
            
            SubclassOf<UnrealSharp.CoreUObject.Object> returnValue;
            returnValue = SubclassOfMarshaller<UnrealSharp.CoreUObject.Object>.FromNative(IntPtr.Add(ParamsBuffer, GetObjectPropertyClass_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/SequencerScripting.MovieScenePropertyTrackExtensions:GetByteTrackEnum
    static readonly IntPtr GetByteTrackEnum_NativeFunction;
    static readonly int GetByteTrackEnum_ParamsSize;
    static readonly int GetByteTrackEnum_Track_Offset;
    static readonly int GetByteTrackEnum_ReturnValue_Offset;
    
    public static UnrealSharp.CoreUObject.Enum GetByteTrackEnum(UnrealSharp.MovieSceneTracks.MovieSceneByteTrack track)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetByteTrackEnum_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.MovieSceneTracks.MovieSceneByteTrack>.ToNative(IntPtr.Add(ParamsBuffer, GetByteTrackEnum_Track_Offset), 0, null, track);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, GetByteTrackEnum_NativeFunction, ParamsBuffer);
            
            UnrealSharp.CoreUObject.Enum returnValue;
            returnValue = ObjectMarshaller<UnrealSharp.CoreUObject.Enum>.FromNative(IntPtr.Add(ParamsBuffer, GetByteTrackEnum_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    
}