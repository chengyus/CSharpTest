// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.TraceUtilities;

[UClass]
public partial class TraceUtilLibrary : UnrealSharp.Engine.BlueprintFunctionLibrary
{
    
    static readonly IntPtr NativeClassPtr;
    static TraceUtilLibrary()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("TraceUtilLibrary");
        
        
        TraceMarkRegionStart_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "TraceMarkRegionStart");
        TraceMarkRegionStart_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(TraceMarkRegionStart_NativeFunction);
        TraceMarkRegionStart_Name_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(TraceMarkRegionStart_NativeFunction, "Name");
        TraceMarkRegionEnd_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "TraceMarkRegionEnd");
        TraceMarkRegionEnd_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(TraceMarkRegionEnd_NativeFunction);
        TraceMarkRegionEnd_Name_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(TraceMarkRegionEnd_NativeFunction, "Name");
        TraceBookmark_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "TraceBookmark");
        TraceBookmark_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(TraceBookmark_NativeFunction);
        TraceBookmark_Name_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(TraceBookmark_NativeFunction, "Name");
        ToggleChannel_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "ToggleChannel");
        ToggleChannel_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(ToggleChannel_NativeFunction);
        ToggleChannel_ChannelName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ToggleChannel_NativeFunction, "ChannelName");
        ToggleChannel_enabled_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ToggleChannel_NativeFunction, "enabled");
        ToggleChannel_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ToggleChannel_NativeFunction, "ReturnValue");
        StopTracing_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "StopTracing");
        StopTracing_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(StopTracing_NativeFunction);
        StopTracing_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(StopTracing_NativeFunction, "ReturnValue");
        ResumeTracing_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "ResumeTracing");
        ResumeTracing_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(ResumeTracing_NativeFunction);
        ResumeTracing_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ResumeTracing_NativeFunction, "ReturnValue");
        PauseTracing_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "PauseTracing");
        PauseTracing_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(PauseTracing_NativeFunction);
        PauseTracing_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(PauseTracing_NativeFunction, "ReturnValue");
        IsTracing_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "IsTracing");
        IsTracing_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(IsTracing_NativeFunction);
        IsTracing_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(IsTracing_NativeFunction, "ReturnValue");
        IsChannelEnabled_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "IsChannelEnabled");
        IsChannelEnabled_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(IsChannelEnabled_NativeFunction);
        IsChannelEnabled_ChannelName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(IsChannelEnabled_NativeFunction, "ChannelName");
        IsChannelEnabled_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(IsChannelEnabled_NativeFunction, "ReturnValue");
        
        
    }
    
    protected TraceUtilLibrary(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // Function /Script/TraceUtilities.TraceUtilLibrary:TraceMarkRegionStart
    static readonly IntPtr TraceMarkRegionStart_NativeFunction;
    static readonly int TraceMarkRegionStart_ParamsSize;
    static readonly int TraceMarkRegionStart_Name_Offset;
    
    public static void TraceMarkRegionStart(string name)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[TraceMarkRegionStart_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            IntPtr Name_NativePtr = IntPtr.Add(ParamsBuffer,TraceMarkRegionStart_Name_Offset);
            StringMarshaller.ToNative(Name_NativePtr,0,null,name);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, TraceMarkRegionStart_NativeFunction, ParamsBuffer);
            
            StringMarshaller.DestructInstance(Name_NativePtr, 0);
        }
    }
    
    // Function /Script/TraceUtilities.TraceUtilLibrary:TraceMarkRegionEnd
    static readonly IntPtr TraceMarkRegionEnd_NativeFunction;
    static readonly int TraceMarkRegionEnd_ParamsSize;
    static readonly int TraceMarkRegionEnd_Name_Offset;
    
    public static void TraceMarkRegionEnd(string name)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[TraceMarkRegionEnd_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            IntPtr Name_NativePtr = IntPtr.Add(ParamsBuffer,TraceMarkRegionEnd_Name_Offset);
            StringMarshaller.ToNative(Name_NativePtr,0,null,name);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, TraceMarkRegionEnd_NativeFunction, ParamsBuffer);
            
            StringMarshaller.DestructInstance(Name_NativePtr, 0);
        }
    }
    
    // Function /Script/TraceUtilities.TraceUtilLibrary:TraceBookmark
    static readonly IntPtr TraceBookmark_NativeFunction;
    static readonly int TraceBookmark_ParamsSize;
    static readonly int TraceBookmark_Name_Offset;
    
    public static void TraceBookmark(string name)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[TraceBookmark_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            IntPtr Name_NativePtr = IntPtr.Add(ParamsBuffer,TraceBookmark_Name_Offset);
            StringMarshaller.ToNative(Name_NativePtr,0,null,name);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, TraceBookmark_NativeFunction, ParamsBuffer);
            
            StringMarshaller.DestructInstance(Name_NativePtr, 0);
        }
    }
    
    // Function /Script/TraceUtilities.TraceUtilLibrary:ToggleChannel
    static readonly IntPtr ToggleChannel_NativeFunction;
    static readonly int ToggleChannel_ParamsSize;
    static readonly int ToggleChannel_ChannelName_Offset;
    static readonly int ToggleChannel_enabled_Offset;
    static readonly int ToggleChannel_ReturnValue_Offset;
    
    public static bool ToggleChannel(string channelName, bool enabled)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[ToggleChannel_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            IntPtr ChannelName_NativePtr = IntPtr.Add(ParamsBuffer,ToggleChannel_ChannelName_Offset);
            StringMarshaller.ToNative(ChannelName_NativePtr,0,null,channelName);
            BoolMarshaller.ToNative(IntPtr.Add(ParamsBuffer, ToggleChannel_enabled_Offset), 0, null, enabled);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, ToggleChannel_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, ToggleChannel_ReturnValue_Offset), 0, null);
            
            StringMarshaller.DestructInstance(ChannelName_NativePtr, 0);
            return returnValue;
        }
    }
    
    // Function /Script/TraceUtilities.TraceUtilLibrary:StopTracing
    static readonly IntPtr StopTracing_NativeFunction;
    static readonly int StopTracing_ParamsSize;
    static readonly int StopTracing_ReturnValue_Offset;
    
    public static bool StopTracing()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[StopTracing_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, StopTracing_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, StopTracing_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/TraceUtilities.TraceUtilLibrary:ResumeTracing
    static readonly IntPtr ResumeTracing_NativeFunction;
    static readonly int ResumeTracing_ParamsSize;
    static readonly int ResumeTracing_ReturnValue_Offset;
    
    public static bool ResumeTracing()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[ResumeTracing_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, ResumeTracing_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, ResumeTracing_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/TraceUtilities.TraceUtilLibrary:PauseTracing
    static readonly IntPtr PauseTracing_NativeFunction;
    static readonly int PauseTracing_ParamsSize;
    static readonly int PauseTracing_ReturnValue_Offset;
    
    public static bool PauseTracing()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[PauseTracing_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, PauseTracing_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, PauseTracing_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/TraceUtilities.TraceUtilLibrary:IsTracing
    static readonly IntPtr IsTracing_NativeFunction;
    static readonly int IsTracing_ParamsSize;
    static readonly int IsTracing_ReturnValue_Offset;
    
    public static bool IsTracing()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[IsTracing_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, IsTracing_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, IsTracing_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/TraceUtilities.TraceUtilLibrary:IsChannelEnabled
    static readonly IntPtr IsChannelEnabled_NativeFunction;
    static readonly int IsChannelEnabled_ParamsSize;
    static readonly int IsChannelEnabled_ChannelName_Offset;
    static readonly int IsChannelEnabled_ReturnValue_Offset;
    
    public static bool IsChannelEnabled(string channelName)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[IsChannelEnabled_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            IntPtr ChannelName_NativePtr = IntPtr.Add(ParamsBuffer,IsChannelEnabled_ChannelName_Offset);
            StringMarshaller.ToNative(ChannelName_NativePtr,0,null,channelName);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, IsChannelEnabled_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, IsChannelEnabled_ReturnValue_Offset), 0, null);
            
            StringMarshaller.DestructInstance(ChannelName_NativePtr, 0);
            return returnValue;
        }
    }
    
    
}