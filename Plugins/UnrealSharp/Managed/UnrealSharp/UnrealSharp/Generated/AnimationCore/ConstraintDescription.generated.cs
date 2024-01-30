using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AnimationCore;

[UStruct]
public partial struct ConstraintDescription
{
    // BoolProperty /Script/AnimationCore.ConstraintDescription:bTranslation
    static readonly int bTranslation_Offset;
    public bool Translation;
    
    // BoolProperty /Script/AnimationCore.ConstraintDescription:bRotation
    static readonly int bRotation_Offset;
    public bool Rotation;
    
    // BoolProperty /Script/AnimationCore.ConstraintDescription:bScale
    static readonly int bScale_Offset;
    public bool Scale;
    
    // BoolProperty /Script/AnimationCore.ConstraintDescription:bParent
    static readonly int bParent_Offset;
    public bool Parent;
    
    // StructProperty /Script/AnimationCore.ConstraintDescription:TranslationAxes
    static readonly int TranslationAxes_Offset;
    public UnrealSharp.AnimationCore.FilterOptionPerAxis TranslationAxes;
    
    // StructProperty /Script/AnimationCore.ConstraintDescription:RotationAxes
    static readonly int RotationAxes_Offset;
    public UnrealSharp.AnimationCore.FilterOptionPerAxis RotationAxes;
    
    // StructProperty /Script/AnimationCore.ConstraintDescription:ScaleAxes
    static readonly int ScaleAxes_Offset;
    public UnrealSharp.AnimationCore.FilterOptionPerAxis ScaleAxes;
    
    
    public static readonly int NativeDataSize;
    static ConstraintDescription()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("ConstraintDescription");
        
        bTranslation_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bTranslation");
        bRotation_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bRotation");
        bScale_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bScale");
        bParent_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bParent");
        TranslationAxes_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "TranslationAxes");
        RotationAxes_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "RotationAxes");
        ScaleAxes_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ScaleAxes");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public ConstraintDescription(IntPtr InNativeStruct)
    {
        unsafe
        {
            Translation = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bTranslation_Offset), 0, null);
            Rotation = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bRotation_Offset), 0, null);
            Scale = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bScale_Offset), 0, null);
            Parent = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bParent_Offset), 0, null);
            TranslationAxes = UnrealSharp.AnimationCore.FilterOptionPerAxisMarshaler.FromNative(IntPtr.Add(InNativeStruct, TranslationAxes_Offset), 0, null);
            RotationAxes = UnrealSharp.AnimationCore.FilterOptionPerAxisMarshaler.FromNative(IntPtr.Add(InNativeStruct, RotationAxes_Offset), 0, null);
            ScaleAxes = UnrealSharp.AnimationCore.FilterOptionPerAxisMarshaler.FromNative(IntPtr.Add(InNativeStruct, ScaleAxes_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bTranslation_Offset), 0, null, Translation);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bRotation_Offset), 0, null, Rotation);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bScale_Offset), 0, null, Scale);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bParent_Offset), 0, null, Parent);
            UnrealSharp.AnimationCore.FilterOptionPerAxisMarshaler.ToNative(IntPtr.Add(Buffer, TranslationAxes_Offset), 0, null, TranslationAxes);
            UnrealSharp.AnimationCore.FilterOptionPerAxisMarshaler.ToNative(IntPtr.Add(Buffer, RotationAxes_Offset), 0, null, RotationAxes);
            UnrealSharp.AnimationCore.FilterOptionPerAxisMarshaler.ToNative(IntPtr.Add(Buffer, ScaleAxes_Offset), 0, null, ScaleAxes);
        }
    }
}

public static class ConstraintDescriptionMarshaler
{
    public static ConstraintDescription FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new ConstraintDescription(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, ConstraintDescription obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return ConstraintDescription.NativeDataSize;
    }
}