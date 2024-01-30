using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AnimationCore;

[UStruct]
public partial struct TransformFilter
{
    // StructProperty /Script/AnimationCore.TransformFilter:TranslationFilter
    static readonly int TranslationFilter_Offset;
    public UnrealSharp.AnimationCore.FilterOptionPerAxis TranslationFilter;
    
    // StructProperty /Script/AnimationCore.TransformFilter:RotationFilter
    static readonly int RotationFilter_Offset;
    public UnrealSharp.AnimationCore.FilterOptionPerAxis RotationFilter;
    
    // StructProperty /Script/AnimationCore.TransformFilter:ScaleFilter
    static readonly int ScaleFilter_Offset;
    public UnrealSharp.AnimationCore.FilterOptionPerAxis ScaleFilter;
    
    
    public static readonly int NativeDataSize;
    static TransformFilter()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("TransformFilter");
        
        TranslationFilter_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "TranslationFilter");
        RotationFilter_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "RotationFilter");
        ScaleFilter_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ScaleFilter");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public TransformFilter(IntPtr InNativeStruct)
    {
        unsafe
        {
            TranslationFilter = UnrealSharp.AnimationCore.FilterOptionPerAxisMarshaler.FromNative(IntPtr.Add(InNativeStruct, TranslationFilter_Offset), 0, null);
            RotationFilter = UnrealSharp.AnimationCore.FilterOptionPerAxisMarshaler.FromNative(IntPtr.Add(InNativeStruct, RotationFilter_Offset), 0, null);
            ScaleFilter = UnrealSharp.AnimationCore.FilterOptionPerAxisMarshaler.FromNative(IntPtr.Add(InNativeStruct, ScaleFilter_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.AnimationCore.FilterOptionPerAxisMarshaler.ToNative(IntPtr.Add(Buffer, TranslationFilter_Offset), 0, null, TranslationFilter);
            UnrealSharp.AnimationCore.FilterOptionPerAxisMarshaler.ToNative(IntPtr.Add(Buffer, RotationFilter_Offset), 0, null, RotationFilter);
            UnrealSharp.AnimationCore.FilterOptionPerAxisMarshaler.ToNative(IntPtr.Add(Buffer, ScaleFilter_Offset), 0, null, ScaleFilter);
        }
    }
}

public static class TransformFilterMarshaler
{
    public static TransformFilter FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new TransformFilter(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, TransformFilter obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return TransformFilter.NativeDataSize;
    }
}