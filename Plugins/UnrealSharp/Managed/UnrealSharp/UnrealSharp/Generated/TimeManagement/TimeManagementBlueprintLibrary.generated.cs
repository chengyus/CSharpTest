// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.TimeManagement;

[UClass]
public partial class TimeManagementLibrary : UnrealSharp.Engine.BlueprintFunctionLibrary
{
    
    static readonly IntPtr NativeClassPtr;
    static TimeManagementLibrary()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("TimeManagementBlueprintLibrary");
        
        
        TransformTime_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "TransformTime");
        TransformTime_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(TransformTime_NativeFunction);
        TransformTime_SourceTime_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(TransformTime_NativeFunction, "SourceTime");
        TransformTime_SourceRate_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(TransformTime_NativeFunction, "SourceRate");
        TransformTime_DestinationRate_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(TransformTime_NativeFunction, "DestinationRate");
        TransformTime_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(TransformTime_NativeFunction, "ReturnValue");
        Subtract_FrameNumberInteger_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "Subtract_FrameNumberInteger");
        Subtract_FrameNumberInteger_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(Subtract_FrameNumberInteger_NativeFunction);
        Subtract_FrameNumberInteger_A_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(Subtract_FrameNumberInteger_NativeFunction, "A");
        Subtract_FrameNumberInteger_B_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(Subtract_FrameNumberInteger_NativeFunction, "B");
        Subtract_FrameNumberInteger_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(Subtract_FrameNumberInteger_NativeFunction, "ReturnValue");
        Subtract_FrameNumberFrameNumber_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "Subtract_FrameNumberFrameNumber");
        Subtract_FrameNumberFrameNumber_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(Subtract_FrameNumberFrameNumber_NativeFunction);
        Subtract_FrameNumberFrameNumber_A_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(Subtract_FrameNumberFrameNumber_NativeFunction, "A");
        Subtract_FrameNumberFrameNumber_B_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(Subtract_FrameNumberFrameNumber_NativeFunction, "B");
        Subtract_FrameNumberFrameNumber_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(Subtract_FrameNumberFrameNumber_NativeFunction, "ReturnValue");
        SnapFrameTimeToRate_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SnapFrameTimeToRate");
        SnapFrameTimeToRate_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SnapFrameTimeToRate_NativeFunction);
        SnapFrameTimeToRate_SourceTime_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SnapFrameTimeToRate_NativeFunction, "SourceTime");
        SnapFrameTimeToRate_SourceRate_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SnapFrameTimeToRate_NativeFunction, "SourceRate");
        SnapFrameTimeToRate_SnapToRate_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SnapFrameTimeToRate_NativeFunction, "SnapToRate");
        SnapFrameTimeToRate_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SnapFrameTimeToRate_NativeFunction, "ReturnValue");
        Multiply_SecondsFrameRate_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "Multiply_SecondsFrameRate");
        Multiply_SecondsFrameRate_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(Multiply_SecondsFrameRate_NativeFunction);
        Multiply_SecondsFrameRate_TimeInSeconds_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(Multiply_SecondsFrameRate_NativeFunction, "TimeInSeconds");
        Multiply_SecondsFrameRate_FrameRate_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(Multiply_SecondsFrameRate_NativeFunction, "FrameRate");
        Multiply_SecondsFrameRate_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(Multiply_SecondsFrameRate_NativeFunction, "ReturnValue");
        Multiply_FrameNumberInteger_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "Multiply_FrameNumberInteger");
        Multiply_FrameNumberInteger_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(Multiply_FrameNumberInteger_NativeFunction);
        Multiply_FrameNumberInteger_A_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(Multiply_FrameNumberInteger_NativeFunction, "A");
        Multiply_FrameNumberInteger_B_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(Multiply_FrameNumberInteger_NativeFunction, "B");
        Multiply_FrameNumberInteger_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(Multiply_FrameNumberInteger_NativeFunction, "ReturnValue");
        IsValid_MultipleOf_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "IsValid_MultipleOf");
        IsValid_MultipleOf_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(IsValid_MultipleOf_NativeFunction);
        IsValid_MultipleOf_InFrameRate_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(IsValid_MultipleOf_NativeFunction, "InFrameRate");
        IsValid_MultipleOf_OtherFramerate_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(IsValid_MultipleOf_NativeFunction, "OtherFramerate");
        IsValid_MultipleOf_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(IsValid_MultipleOf_NativeFunction, "ReturnValue");
        IsValid_Framerate_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "IsValid_Framerate");
        IsValid_Framerate_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(IsValid_Framerate_NativeFunction);
        IsValid_Framerate_InFrameRate_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(IsValid_Framerate_NativeFunction, "InFrameRate");
        IsValid_Framerate_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(IsValid_Framerate_NativeFunction, "ReturnValue");
        GetTimecodeFrameRate_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetTimecodeFrameRate");
        GetTimecodeFrameRate_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetTimecodeFrameRate_NativeFunction);
        GetTimecodeFrameRate_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetTimecodeFrameRate_NativeFunction, "ReturnValue");
        GetTimecode_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetTimecode");
        GetTimecode_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetTimecode_NativeFunction);
        GetTimecode_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetTimecode_NativeFunction, "ReturnValue");
        Divide_FrameNumberInteger_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "Divide_FrameNumberInteger");
        Divide_FrameNumberInteger_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(Divide_FrameNumberInteger_NativeFunction);
        Divide_FrameNumberInteger_A_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(Divide_FrameNumberInteger_NativeFunction, "A");
        Divide_FrameNumberInteger_B_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(Divide_FrameNumberInteger_NativeFunction, "B");
        Divide_FrameNumberInteger_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(Divide_FrameNumberInteger_NativeFunction, "ReturnValue");
        Conv_TimecodeToString_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "Conv_TimecodeToString");
        Conv_TimecodeToString_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(Conv_TimecodeToString_NativeFunction);
        Conv_TimecodeToString_InTimecode_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(Conv_TimecodeToString_NativeFunction, "InTimecode");
        Conv_TimecodeToString_bForceSignDisplay_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(Conv_TimecodeToString_NativeFunction, "bForceSignDisplay");
        Conv_TimecodeToString_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(Conv_TimecodeToString_NativeFunction, "ReturnValue");
        Conv_QualifiedFrameTimeToSeconds_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "Conv_QualifiedFrameTimeToSeconds");
        Conv_QualifiedFrameTimeToSeconds_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(Conv_QualifiedFrameTimeToSeconds_NativeFunction);
        Conv_QualifiedFrameTimeToSeconds_InFrameTime_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(Conv_QualifiedFrameTimeToSeconds_NativeFunction, "InFrameTime");
        Conv_QualifiedFrameTimeToSeconds_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(Conv_QualifiedFrameTimeToSeconds_NativeFunction, "ReturnValue");
        Conv_FrameRateToSeconds_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "Conv_FrameRateToSeconds");
        Conv_FrameRateToSeconds_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(Conv_FrameRateToSeconds_NativeFunction);
        Conv_FrameRateToSeconds_InFrameRate_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(Conv_FrameRateToSeconds_NativeFunction, "InFrameRate");
        Conv_FrameRateToSeconds_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(Conv_FrameRateToSeconds_NativeFunction, "ReturnValue");
        Conv_FrameRateToInterval_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "Conv_FrameRateToInterval");
        Conv_FrameRateToInterval_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(Conv_FrameRateToInterval_NativeFunction);
        Conv_FrameRateToInterval_InFrameRate_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(Conv_FrameRateToInterval_NativeFunction, "InFrameRate");
        Conv_FrameRateToInterval_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(Conv_FrameRateToInterval_NativeFunction, "ReturnValue");
        Conv_FrameNumberToInteger_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "Conv_FrameNumberToInteger");
        Conv_FrameNumberToInteger_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(Conv_FrameNumberToInteger_NativeFunction);
        Conv_FrameNumberToInteger_InFrameNumber_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(Conv_FrameNumberToInteger_NativeFunction, "InFrameNumber");
        Conv_FrameNumberToInteger_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(Conv_FrameNumberToInteger_NativeFunction, "ReturnValue");
        Add_FrameNumberInteger_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "Add_FrameNumberInteger");
        Add_FrameNumberInteger_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(Add_FrameNumberInteger_NativeFunction);
        Add_FrameNumberInteger_A_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(Add_FrameNumberInteger_NativeFunction, "A");
        Add_FrameNumberInteger_B_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(Add_FrameNumberInteger_NativeFunction, "B");
        Add_FrameNumberInteger_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(Add_FrameNumberInteger_NativeFunction, "ReturnValue");
        Add_FrameNumberFrameNumber_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "Add_FrameNumberFrameNumber");
        Add_FrameNumberFrameNumber_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(Add_FrameNumberFrameNumber_NativeFunction);
        Add_FrameNumberFrameNumber_A_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(Add_FrameNumberFrameNumber_NativeFunction, "A");
        Add_FrameNumberFrameNumber_B_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(Add_FrameNumberFrameNumber_NativeFunction, "B");
        Add_FrameNumberFrameNumber_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(Add_FrameNumberFrameNumber_NativeFunction, "ReturnValue");
        
        
    }
    
    protected TimeManagementLibrary(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // Function /Script/TimeManagement.TimeManagementBlueprintLibrary:TransformTime
    static readonly IntPtr TransformTime_NativeFunction;
    static readonly int TransformTime_ParamsSize;
    static readonly int TransformTime_SourceTime_Offset;
    static readonly int TransformTime_SourceRate_Offset;
    static readonly int TransformTime_DestinationRate_Offset;
    static readonly int TransformTime_ReturnValue_Offset;
    
    public static UnrealSharp.CoreUObject.FrameTime TransformTime(UnrealSharp.CoreUObject.FrameTime sourceTime, UnrealSharp.CoreUObject.FrameRate sourceRate, UnrealSharp.CoreUObject.FrameRate destinationRate)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[TransformTime_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<UnrealSharp.CoreUObject.FrameTime>.ToNative(IntPtr.Add(ParamsBuffer, TransformTime_SourceTime_Offset), 0, null, sourceTime);
            BlittableMarshaller<UnrealSharp.CoreUObject.FrameRate>.ToNative(IntPtr.Add(ParamsBuffer, TransformTime_SourceRate_Offset), 0, null, sourceRate);
            BlittableMarshaller<UnrealSharp.CoreUObject.FrameRate>.ToNative(IntPtr.Add(ParamsBuffer, TransformTime_DestinationRate_Offset), 0, null, destinationRate);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, TransformTime_NativeFunction, ParamsBuffer);
            
            UnrealSharp.CoreUObject.FrameTime returnValue;
            returnValue = BlittableMarshaller<UnrealSharp.CoreUObject.FrameTime>.FromNative(IntPtr.Add(ParamsBuffer, TransformTime_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/TimeManagement.TimeManagementBlueprintLibrary:Subtract_FrameNumberInteger
    static readonly IntPtr Subtract_FrameNumberInteger_NativeFunction;
    static readonly int Subtract_FrameNumberInteger_ParamsSize;
    static readonly int Subtract_FrameNumberInteger_A_Offset;
    static readonly int Subtract_FrameNumberInteger_B_Offset;
    static readonly int Subtract_FrameNumberInteger_ReturnValue_Offset;
    
    public static UnrealSharp.CoreUObject.FrameNumber Subtract_FrameNumberInteger(UnrealSharp.CoreUObject.FrameNumber a, int b)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[Subtract_FrameNumberInteger_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<UnrealSharp.CoreUObject.FrameNumber>.ToNative(IntPtr.Add(ParamsBuffer, Subtract_FrameNumberInteger_A_Offset), 0, null, a);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(ParamsBuffer, Subtract_FrameNumberInteger_B_Offset), 0, null, b);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, Subtract_FrameNumberInteger_NativeFunction, ParamsBuffer);
            
            UnrealSharp.CoreUObject.FrameNumber returnValue;
            returnValue = BlittableMarshaller<UnrealSharp.CoreUObject.FrameNumber>.FromNative(IntPtr.Add(ParamsBuffer, Subtract_FrameNumberInteger_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/TimeManagement.TimeManagementBlueprintLibrary:Subtract_FrameNumberFrameNumber
    static readonly IntPtr Subtract_FrameNumberFrameNumber_NativeFunction;
    static readonly int Subtract_FrameNumberFrameNumber_ParamsSize;
    static readonly int Subtract_FrameNumberFrameNumber_A_Offset;
    static readonly int Subtract_FrameNumberFrameNumber_B_Offset;
    static readonly int Subtract_FrameNumberFrameNumber_ReturnValue_Offset;
    
    public static UnrealSharp.CoreUObject.FrameNumber Subtract_FrameNumberFrameNumber(UnrealSharp.CoreUObject.FrameNumber a, UnrealSharp.CoreUObject.FrameNumber b)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[Subtract_FrameNumberFrameNumber_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<UnrealSharp.CoreUObject.FrameNumber>.ToNative(IntPtr.Add(ParamsBuffer, Subtract_FrameNumberFrameNumber_A_Offset), 0, null, a);
            BlittableMarshaller<UnrealSharp.CoreUObject.FrameNumber>.ToNative(IntPtr.Add(ParamsBuffer, Subtract_FrameNumberFrameNumber_B_Offset), 0, null, b);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, Subtract_FrameNumberFrameNumber_NativeFunction, ParamsBuffer);
            
            UnrealSharp.CoreUObject.FrameNumber returnValue;
            returnValue = BlittableMarshaller<UnrealSharp.CoreUObject.FrameNumber>.FromNative(IntPtr.Add(ParamsBuffer, Subtract_FrameNumberFrameNumber_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/TimeManagement.TimeManagementBlueprintLibrary:SnapFrameTimeToRate
    static readonly IntPtr SnapFrameTimeToRate_NativeFunction;
    static readonly int SnapFrameTimeToRate_ParamsSize;
    static readonly int SnapFrameTimeToRate_SourceTime_Offset;
    static readonly int SnapFrameTimeToRate_SourceRate_Offset;
    static readonly int SnapFrameTimeToRate_SnapToRate_Offset;
    static readonly int SnapFrameTimeToRate_ReturnValue_Offset;
    
    public static UnrealSharp.CoreUObject.FrameTime SnapFrameTimeToRate(UnrealSharp.CoreUObject.FrameTime sourceTime, UnrealSharp.CoreUObject.FrameRate sourceRate, UnrealSharp.CoreUObject.FrameRate snapToRate)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SnapFrameTimeToRate_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<UnrealSharp.CoreUObject.FrameTime>.ToNative(IntPtr.Add(ParamsBuffer, SnapFrameTimeToRate_SourceTime_Offset), 0, null, sourceTime);
            BlittableMarshaller<UnrealSharp.CoreUObject.FrameRate>.ToNative(IntPtr.Add(ParamsBuffer, SnapFrameTimeToRate_SourceRate_Offset), 0, null, sourceRate);
            BlittableMarshaller<UnrealSharp.CoreUObject.FrameRate>.ToNative(IntPtr.Add(ParamsBuffer, SnapFrameTimeToRate_SnapToRate_Offset), 0, null, snapToRate);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, SnapFrameTimeToRate_NativeFunction, ParamsBuffer);
            
            UnrealSharp.CoreUObject.FrameTime returnValue;
            returnValue = BlittableMarshaller<UnrealSharp.CoreUObject.FrameTime>.FromNative(IntPtr.Add(ParamsBuffer, SnapFrameTimeToRate_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/TimeManagement.TimeManagementBlueprintLibrary:Multiply_SecondsFrameRate
    static readonly IntPtr Multiply_SecondsFrameRate_NativeFunction;
    static readonly int Multiply_SecondsFrameRate_ParamsSize;
    static readonly int Multiply_SecondsFrameRate_TimeInSeconds_Offset;
    static readonly int Multiply_SecondsFrameRate_FrameRate_Offset;
    static readonly int Multiply_SecondsFrameRate_ReturnValue_Offset;
    
    public static UnrealSharp.CoreUObject.FrameTime Multiply_SecondsFrameRate(float timeInSeconds, UnrealSharp.CoreUObject.FrameRate frameRate)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[Multiply_SecondsFrameRate_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<float>.ToNative(IntPtr.Add(ParamsBuffer, Multiply_SecondsFrameRate_TimeInSeconds_Offset), 0, null, timeInSeconds);
            BlittableMarshaller<UnrealSharp.CoreUObject.FrameRate>.ToNative(IntPtr.Add(ParamsBuffer, Multiply_SecondsFrameRate_FrameRate_Offset), 0, null, frameRate);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, Multiply_SecondsFrameRate_NativeFunction, ParamsBuffer);
            
            UnrealSharp.CoreUObject.FrameTime returnValue;
            returnValue = BlittableMarshaller<UnrealSharp.CoreUObject.FrameTime>.FromNative(IntPtr.Add(ParamsBuffer, Multiply_SecondsFrameRate_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/TimeManagement.TimeManagementBlueprintLibrary:Multiply_FrameNumberInteger
    static readonly IntPtr Multiply_FrameNumberInteger_NativeFunction;
    static readonly int Multiply_FrameNumberInteger_ParamsSize;
    static readonly int Multiply_FrameNumberInteger_A_Offset;
    static readonly int Multiply_FrameNumberInteger_B_Offset;
    static readonly int Multiply_FrameNumberInteger_ReturnValue_Offset;
    
    public static UnrealSharp.CoreUObject.FrameNumber Multiply_FrameNumberInteger(UnrealSharp.CoreUObject.FrameNumber a, int b)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[Multiply_FrameNumberInteger_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<UnrealSharp.CoreUObject.FrameNumber>.ToNative(IntPtr.Add(ParamsBuffer, Multiply_FrameNumberInteger_A_Offset), 0, null, a);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(ParamsBuffer, Multiply_FrameNumberInteger_B_Offset), 0, null, b);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, Multiply_FrameNumberInteger_NativeFunction, ParamsBuffer);
            
            UnrealSharp.CoreUObject.FrameNumber returnValue;
            returnValue = BlittableMarshaller<UnrealSharp.CoreUObject.FrameNumber>.FromNative(IntPtr.Add(ParamsBuffer, Multiply_FrameNumberInteger_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/TimeManagement.TimeManagementBlueprintLibrary:IsValid_MultipleOf
    static readonly IntPtr IsValid_MultipleOf_NativeFunction;
    static readonly int IsValid_MultipleOf_ParamsSize;
    static readonly int IsValid_MultipleOf_InFrameRate_Offset;
    static readonly int IsValid_MultipleOf_OtherFramerate_Offset;
    static readonly int IsValid_MultipleOf_ReturnValue_Offset;
    
    public static bool IsValid_MultipleOf(UnrealSharp.CoreUObject.FrameRate inFrameRate, UnrealSharp.CoreUObject.FrameRate otherFramerate)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[IsValid_MultipleOf_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<UnrealSharp.CoreUObject.FrameRate>.ToNative(IntPtr.Add(ParamsBuffer, IsValid_MultipleOf_InFrameRate_Offset), 0, null, inFrameRate);
            BlittableMarshaller<UnrealSharp.CoreUObject.FrameRate>.ToNative(IntPtr.Add(ParamsBuffer, IsValid_MultipleOf_OtherFramerate_Offset), 0, null, otherFramerate);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, IsValid_MultipleOf_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, IsValid_MultipleOf_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/TimeManagement.TimeManagementBlueprintLibrary:IsValid_Framerate
    static readonly IntPtr IsValid_Framerate_NativeFunction;
    static readonly int IsValid_Framerate_ParamsSize;
    static readonly int IsValid_Framerate_InFrameRate_Offset;
    static readonly int IsValid_Framerate_ReturnValue_Offset;
    
    public static bool IsValid_Framerate(UnrealSharp.CoreUObject.FrameRate inFrameRate)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[IsValid_Framerate_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<UnrealSharp.CoreUObject.FrameRate>.ToNative(IntPtr.Add(ParamsBuffer, IsValid_Framerate_InFrameRate_Offset), 0, null, inFrameRate);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, IsValid_Framerate_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, IsValid_Framerate_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/TimeManagement.TimeManagementBlueprintLibrary:GetTimecodeFrameRate
    static readonly IntPtr GetTimecodeFrameRate_NativeFunction;
    static readonly int GetTimecodeFrameRate_ParamsSize;
    static readonly int GetTimecodeFrameRate_ReturnValue_Offset;
    
    public static UnrealSharp.CoreUObject.FrameRate GetTimecodeFrameRate()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetTimecodeFrameRate_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, GetTimecodeFrameRate_NativeFunction, ParamsBuffer);
            
            UnrealSharp.CoreUObject.FrameRate returnValue;
            returnValue = BlittableMarshaller<UnrealSharp.CoreUObject.FrameRate>.FromNative(IntPtr.Add(ParamsBuffer, GetTimecodeFrameRate_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/TimeManagement.TimeManagementBlueprintLibrary:GetTimecode
    static readonly IntPtr GetTimecode_NativeFunction;
    static readonly int GetTimecode_ParamsSize;
    static readonly int GetTimecode_ReturnValue_Offset;
    
    public static UnrealSharp.CoreUObject.Timecode GetTimecode()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetTimecode_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, GetTimecode_NativeFunction, ParamsBuffer);
            
            UnrealSharp.CoreUObject.Timecode returnValue;
            returnValue = UnrealSharp.CoreUObject.TimecodeMarshaler.FromNative(IntPtr.Add(ParamsBuffer, GetTimecode_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/TimeManagement.TimeManagementBlueprintLibrary:Divide_FrameNumberInteger
    static readonly IntPtr Divide_FrameNumberInteger_NativeFunction;
    static readonly int Divide_FrameNumberInteger_ParamsSize;
    static readonly int Divide_FrameNumberInteger_A_Offset;
    static readonly int Divide_FrameNumberInteger_B_Offset;
    static readonly int Divide_FrameNumberInteger_ReturnValue_Offset;
    
    public static UnrealSharp.CoreUObject.FrameNumber Divide_FrameNumberInteger(UnrealSharp.CoreUObject.FrameNumber a, int b)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[Divide_FrameNumberInteger_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<UnrealSharp.CoreUObject.FrameNumber>.ToNative(IntPtr.Add(ParamsBuffer, Divide_FrameNumberInteger_A_Offset), 0, null, a);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(ParamsBuffer, Divide_FrameNumberInteger_B_Offset), 0, null, b);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, Divide_FrameNumberInteger_NativeFunction, ParamsBuffer);
            
            UnrealSharp.CoreUObject.FrameNumber returnValue;
            returnValue = BlittableMarshaller<UnrealSharp.CoreUObject.FrameNumber>.FromNative(IntPtr.Add(ParamsBuffer, Divide_FrameNumberInteger_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/TimeManagement.TimeManagementBlueprintLibrary:Conv_TimecodeToString
    static readonly IntPtr Conv_TimecodeToString_NativeFunction;
    static readonly int Conv_TimecodeToString_ParamsSize;
    static readonly int Conv_TimecodeToString_InTimecode_Offset;
    static readonly int Conv_TimecodeToString_bForceSignDisplay_Offset;
    static readonly int Conv_TimecodeToString_ReturnValue_Offset;
    
    public static string Conv_TimecodeToString(UnrealSharp.CoreUObject.Timecode inTimecode, bool bForceSignDisplay = false)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[Conv_TimecodeToString_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            UnrealSharp.CoreUObject.TimecodeMarshaler.ToNative(IntPtr.Add(ParamsBuffer, Conv_TimecodeToString_InTimecode_Offset), 0, null, inTimecode);
            BoolMarshaller.ToNative(IntPtr.Add(ParamsBuffer, Conv_TimecodeToString_bForceSignDisplay_Offset), 0, null, bForceSignDisplay);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, Conv_TimecodeToString_NativeFunction, ParamsBuffer);
            
            string returnValue;
            IntPtr ReturnValue_NativePtr = IntPtr.Add(ParamsBuffer,Conv_TimecodeToString_ReturnValue_Offset);
            returnValue = StringMarshaller.FromNative(ReturnValue_NativePtr,0,null);
            StringMarshaller.DestructInstance(ReturnValue_NativePtr, 0);
            
            return returnValue;
        }
    }
    
    // Function /Script/TimeManagement.TimeManagementBlueprintLibrary:Conv_QualifiedFrameTimeToSeconds
    static readonly IntPtr Conv_QualifiedFrameTimeToSeconds_NativeFunction;
    static readonly int Conv_QualifiedFrameTimeToSeconds_ParamsSize;
    static readonly int Conv_QualifiedFrameTimeToSeconds_InFrameTime_Offset;
    static readonly int Conv_QualifiedFrameTimeToSeconds_ReturnValue_Offset;
    
    public static float Conv_QualifiedFrameTimeToSeconds(UnrealSharp.CoreUObject.QualifiedTime inFrameTime)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[Conv_QualifiedFrameTimeToSeconds_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<UnrealSharp.CoreUObject.QualifiedTime>.ToNative(IntPtr.Add(ParamsBuffer, Conv_QualifiedFrameTimeToSeconds_InFrameTime_Offset), 0, null, inFrameTime);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, Conv_QualifiedFrameTimeToSeconds_NativeFunction, ParamsBuffer);
            
            float returnValue;
            returnValue = BlittableMarshaller<float>.FromNative(IntPtr.Add(ParamsBuffer, Conv_QualifiedFrameTimeToSeconds_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/TimeManagement.TimeManagementBlueprintLibrary:Conv_FrameRateToSeconds
    static readonly IntPtr Conv_FrameRateToSeconds_NativeFunction;
    static readonly int Conv_FrameRateToSeconds_ParamsSize;
    static readonly int Conv_FrameRateToSeconds_InFrameRate_Offset;
    static readonly int Conv_FrameRateToSeconds_ReturnValue_Offset;
    
    [Obsolete("FrameRateToInterval replaces this function, which returns the expected result of seconds per frame, rather than (incorrectly) frames per second.")]
    public static float Conv_FrameRateToSeconds(UnrealSharp.CoreUObject.FrameRate inFrameRate)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[Conv_FrameRateToSeconds_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<UnrealSharp.CoreUObject.FrameRate>.ToNative(IntPtr.Add(ParamsBuffer, Conv_FrameRateToSeconds_InFrameRate_Offset), 0, null, inFrameRate);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, Conv_FrameRateToSeconds_NativeFunction, ParamsBuffer);
            
            float returnValue;
            returnValue = BlittableMarshaller<float>.FromNative(IntPtr.Add(ParamsBuffer, Conv_FrameRateToSeconds_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/TimeManagement.TimeManagementBlueprintLibrary:Conv_FrameRateToInterval
    static readonly IntPtr Conv_FrameRateToInterval_NativeFunction;
    static readonly int Conv_FrameRateToInterval_ParamsSize;
    static readonly int Conv_FrameRateToInterval_InFrameRate_Offset;
    static readonly int Conv_FrameRateToInterval_ReturnValue_Offset;
    
    public static float Conv_FrameRateToInterval(UnrealSharp.CoreUObject.FrameRate inFrameRate)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[Conv_FrameRateToInterval_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<UnrealSharp.CoreUObject.FrameRate>.ToNative(IntPtr.Add(ParamsBuffer, Conv_FrameRateToInterval_InFrameRate_Offset), 0, null, inFrameRate);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, Conv_FrameRateToInterval_NativeFunction, ParamsBuffer);
            
            float returnValue;
            returnValue = BlittableMarshaller<float>.FromNative(IntPtr.Add(ParamsBuffer, Conv_FrameRateToInterval_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/TimeManagement.TimeManagementBlueprintLibrary:Conv_FrameNumberToInteger
    static readonly IntPtr Conv_FrameNumberToInteger_NativeFunction;
    static readonly int Conv_FrameNumberToInteger_ParamsSize;
    static readonly int Conv_FrameNumberToInteger_InFrameNumber_Offset;
    static readonly int Conv_FrameNumberToInteger_ReturnValue_Offset;
    
    public static int FrameNumberToInteger(UnrealSharp.CoreUObject.FrameNumber inFrameNumber)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[Conv_FrameNumberToInteger_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<UnrealSharp.CoreUObject.FrameNumber>.ToNative(IntPtr.Add(ParamsBuffer, Conv_FrameNumberToInteger_InFrameNumber_Offset), 0, null, inFrameNumber);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, Conv_FrameNumberToInteger_NativeFunction, ParamsBuffer);
            
            int returnValue;
            returnValue = BlittableMarshaller<int>.FromNative(IntPtr.Add(ParamsBuffer, Conv_FrameNumberToInteger_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/TimeManagement.TimeManagementBlueprintLibrary:Add_FrameNumberInteger
    static readonly IntPtr Add_FrameNumberInteger_NativeFunction;
    static readonly int Add_FrameNumberInteger_ParamsSize;
    static readonly int Add_FrameNumberInteger_A_Offset;
    static readonly int Add_FrameNumberInteger_B_Offset;
    static readonly int Add_FrameNumberInteger_ReturnValue_Offset;
    
    public static UnrealSharp.CoreUObject.FrameNumber Add_FrameNumberInteger(UnrealSharp.CoreUObject.FrameNumber a, int b)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[Add_FrameNumberInteger_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<UnrealSharp.CoreUObject.FrameNumber>.ToNative(IntPtr.Add(ParamsBuffer, Add_FrameNumberInteger_A_Offset), 0, null, a);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(ParamsBuffer, Add_FrameNumberInteger_B_Offset), 0, null, b);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, Add_FrameNumberInteger_NativeFunction, ParamsBuffer);
            
            UnrealSharp.CoreUObject.FrameNumber returnValue;
            returnValue = BlittableMarshaller<UnrealSharp.CoreUObject.FrameNumber>.FromNative(IntPtr.Add(ParamsBuffer, Add_FrameNumberInteger_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/TimeManagement.TimeManagementBlueprintLibrary:Add_FrameNumberFrameNumber
    static readonly IntPtr Add_FrameNumberFrameNumber_NativeFunction;
    static readonly int Add_FrameNumberFrameNumber_ParamsSize;
    static readonly int Add_FrameNumberFrameNumber_A_Offset;
    static readonly int Add_FrameNumberFrameNumber_B_Offset;
    static readonly int Add_FrameNumberFrameNumber_ReturnValue_Offset;
    
    public static UnrealSharp.CoreUObject.FrameNumber Add_FrameNumberFrameNumber(UnrealSharp.CoreUObject.FrameNumber a, UnrealSharp.CoreUObject.FrameNumber b)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[Add_FrameNumberFrameNumber_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<UnrealSharp.CoreUObject.FrameNumber>.ToNative(IntPtr.Add(ParamsBuffer, Add_FrameNumberFrameNumber_A_Offset), 0, null, a);
            BlittableMarshaller<UnrealSharp.CoreUObject.FrameNumber>.ToNative(IntPtr.Add(ParamsBuffer, Add_FrameNumberFrameNumber_B_Offset), 0, null, b);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, Add_FrameNumberFrameNumber_NativeFunction, ParamsBuffer);
            
            UnrealSharp.CoreUObject.FrameNumber returnValue;
            returnValue = BlittableMarshaller<UnrealSharp.CoreUObject.FrameNumber>.FromNative(IntPtr.Add(ParamsBuffer, Add_FrameNumberFrameNumber_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    
}