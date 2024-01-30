using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMFunction_GetWorldTime
{
    // FloatProperty /Script/RigVM.RigVMFunction_GetWorldTime:Year
    static readonly int Year_Offset;
    public float Year;
    
    // FloatProperty /Script/RigVM.RigVMFunction_GetWorldTime:Month
    static readonly int Month_Offset;
    public float Month;
    
    // FloatProperty /Script/RigVM.RigVMFunction_GetWorldTime:Day
    static readonly int Day_Offset;
    public float Day;
    
    // FloatProperty /Script/RigVM.RigVMFunction_GetWorldTime:WeekDay
    static readonly int WeekDay_Offset;
    public float WeekDay;
    
    // FloatProperty /Script/RigVM.RigVMFunction_GetWorldTime:Hours
    static readonly int Hours_Offset;
    public float Hours;
    
    // FloatProperty /Script/RigVM.RigVMFunction_GetWorldTime:Minutes
    static readonly int Minutes_Offset;
    public float Minutes;
    
    // FloatProperty /Script/RigVM.RigVMFunction_GetWorldTime:Seconds
    static readonly int Seconds_Offset;
    public float Seconds;
    
    // FloatProperty /Script/RigVM.RigVMFunction_GetWorldTime:OverallSeconds
    static readonly int OverallSeconds_Offset;
    public float OverallSeconds;
    
    
    public static readonly int NativeDataSize;
    static RigVMFunction_GetWorldTime()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMFunction_GetWorldTime");
        
        Year_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Year");
        Month_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Month");
        Day_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Day");
        WeekDay_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "WeekDay");
        Hours_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Hours");
        Minutes_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Minutes");
        Seconds_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Seconds");
        OverallSeconds_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "OverallSeconds");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMFunction_GetWorldTime(IntPtr InNativeStruct)
    {
        unsafe
        {
            Year = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Year_Offset), 0, null);
            Month = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Month_Offset), 0, null);
            Day = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Day_Offset), 0, null);
            WeekDay = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, WeekDay_Offset), 0, null);
            Hours = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Hours_Offset), 0, null);
            Minutes = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Minutes_Offset), 0, null);
            Seconds = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Seconds_Offset), 0, null);
            OverallSeconds = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, OverallSeconds_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Year_Offset), 0, null, Year);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Month_Offset), 0, null, Month);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Day_Offset), 0, null, Day);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, WeekDay_Offset), 0, null, WeekDay);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Hours_Offset), 0, null, Hours);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Minutes_Offset), 0, null, Minutes);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Seconds_Offset), 0, null, Seconds);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, OverallSeconds_Offset), 0, null, OverallSeconds);
        }
    }
}

public static class RigVMFunction_GetWorldTimeMarshaler
{
    public static RigVMFunction_GetWorldTime FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMFunction_GetWorldTime(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMFunction_GetWorldTime obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMFunction_GetWorldTime.NativeDataSize;
    }
}