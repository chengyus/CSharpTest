// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.SequencerScripting;

[UClass]
public partial class MovieSceneEventTrackExtensions : UnrealSharp.Engine.BlueprintFunctionLibrary
{
    
    static readonly IntPtr NativeClassPtr;
    static MovieSceneEventTrackExtensions()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("MovieSceneEventTrackExtensions");
        
        
        GetBoundObjectPropertyClass_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetBoundObjectPropertyClass");
        GetBoundObjectPropertyClass_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetBoundObjectPropertyClass_NativeFunction);
        GetBoundObjectPropertyClass_EventKey_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetBoundObjectPropertyClass_NativeFunction, "EventKey");
        GetBoundObjectPropertyClass_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetBoundObjectPropertyClass_NativeFunction, "ReturnValue");
        AddEventTriggerSection_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "AddEventTriggerSection");
        AddEventTriggerSection_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(AddEventTriggerSection_NativeFunction);
        AddEventTriggerSection_InTrack_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AddEventTriggerSection_NativeFunction, "InTrack");
        AddEventTriggerSection_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AddEventTriggerSection_NativeFunction, "ReturnValue");
        AddEventRepeaterSection_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "AddEventRepeaterSection");
        AddEventRepeaterSection_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(AddEventRepeaterSection_NativeFunction);
        AddEventRepeaterSection_InTrack_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AddEventRepeaterSection_NativeFunction, "InTrack");
        AddEventRepeaterSection_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AddEventRepeaterSection_NativeFunction, "ReturnValue");
        
        
    }
    
    protected MovieSceneEventTrackExtensions(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // Function /Script/SequencerScripting.MovieSceneEventTrackExtensions:GetBoundObjectPropertyClass
    static readonly IntPtr GetBoundObjectPropertyClass_NativeFunction;
    static readonly int GetBoundObjectPropertyClass_ParamsSize;
    static readonly int GetBoundObjectPropertyClass_EventKey_Offset;
    static readonly int GetBoundObjectPropertyClass_ReturnValue_Offset;
    
    public static SubclassOf<UnrealSharp.CoreUObject.Object> GetBoundObjectPropertyClass(UnrealSharp.MovieSceneTracks.MovieSceneEvent eventKey)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetBoundObjectPropertyClass_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            UnrealSharp.MovieSceneTracks.MovieSceneEventMarshaler.ToNative(IntPtr.Add(ParamsBuffer, GetBoundObjectPropertyClass_EventKey_Offset), 0, null, eventKey);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, GetBoundObjectPropertyClass_NativeFunction, ParamsBuffer);
            
            SubclassOf<UnrealSharp.CoreUObject.Object> returnValue;
            returnValue = SubclassOfMarshaller<UnrealSharp.CoreUObject.Object>.FromNative(IntPtr.Add(ParamsBuffer, GetBoundObjectPropertyClass_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/SequencerScripting.MovieSceneEventTrackExtensions:AddEventTriggerSection
    static readonly IntPtr AddEventTriggerSection_NativeFunction;
    static readonly int AddEventTriggerSection_ParamsSize;
    static readonly int AddEventTriggerSection_InTrack_Offset;
    static readonly int AddEventTriggerSection_ReturnValue_Offset;
    
    public static UnrealSharp.MovieSceneTracks.MovieSceneEventTriggerSection AddEventTriggerSection(UnrealSharp.MovieSceneTracks.MovieSceneEventTrack inTrack)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[AddEventTriggerSection_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.MovieSceneTracks.MovieSceneEventTrack>.ToNative(IntPtr.Add(ParamsBuffer, AddEventTriggerSection_InTrack_Offset), 0, null, inTrack);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, AddEventTriggerSection_NativeFunction, ParamsBuffer);
            
            UnrealSharp.MovieSceneTracks.MovieSceneEventTriggerSection returnValue;
            returnValue = ObjectMarshaller<UnrealSharp.MovieSceneTracks.MovieSceneEventTriggerSection>.FromNative(IntPtr.Add(ParamsBuffer, AddEventTriggerSection_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/SequencerScripting.MovieSceneEventTrackExtensions:AddEventRepeaterSection
    static readonly IntPtr AddEventRepeaterSection_NativeFunction;
    static readonly int AddEventRepeaterSection_ParamsSize;
    static readonly int AddEventRepeaterSection_InTrack_Offset;
    static readonly int AddEventRepeaterSection_ReturnValue_Offset;
    
    public static UnrealSharp.MovieSceneTracks.MovieSceneEventRepeaterSection AddEventRepeaterSection(UnrealSharp.MovieSceneTracks.MovieSceneEventTrack inTrack)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[AddEventRepeaterSection_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.MovieSceneTracks.MovieSceneEventTrack>.ToNative(IntPtr.Add(ParamsBuffer, AddEventRepeaterSection_InTrack_Offset), 0, null, inTrack);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, AddEventRepeaterSection_NativeFunction, ParamsBuffer);
            
            UnrealSharp.MovieSceneTracks.MovieSceneEventRepeaterSection returnValue;
            returnValue = ObjectMarshaller<UnrealSharp.MovieSceneTracks.MovieSceneEventRepeaterSection>.FromNative(IntPtr.Add(ParamsBuffer, AddEventRepeaterSection_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    
}