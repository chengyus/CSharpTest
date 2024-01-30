using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.VariantManagerContent;

[UStruct]
public partial struct VariantDependency
{
    // SoftObjectProperty /Script/VariantManagerContent.VariantDependency:VariantSet
    static readonly int VariantSet_Offset;
    public SoftObject<UnrealSharp.VariantManagerContent.VariantSet> VariantSet;
    
    // SoftObjectProperty /Script/VariantManagerContent.VariantDependency:Variant
    static readonly int Variant_Offset;
    public SoftObject<UnrealSharp.VariantManagerContent.Variant> Variant;
    
    // BoolProperty /Script/VariantManagerContent.VariantDependency:bEnabled
    static readonly int bEnabled_Offset;
    public bool Enabled;
    
    
    public static readonly int NativeDataSize;
    static VariantDependency()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("VariantDependency");
        
        VariantSet_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "VariantSet");
        Variant_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Variant");
        bEnabled_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bEnabled");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public VariantDependency(IntPtr InNativeStruct)
    {
        unsafe
        {
            VariantSet = BlittableMarshaller<SoftObject<UnrealSharp.VariantManagerContent.VariantSet>>.FromNative(IntPtr.Add(InNativeStruct, VariantSet_Offset), 0, null);
            Variant = BlittableMarshaller<SoftObject<UnrealSharp.VariantManagerContent.Variant>>.FromNative(IntPtr.Add(InNativeStruct, Variant_Offset), 0, null);
            Enabled = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bEnabled_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<SoftObject<UnrealSharp.VariantManagerContent.VariantSet>>.ToNative(IntPtr.Add(Buffer, VariantSet_Offset), 0, null, VariantSet);
            BlittableMarshaller<SoftObject<UnrealSharp.VariantManagerContent.Variant>>.ToNative(IntPtr.Add(Buffer, Variant_Offset), 0, null, Variant);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bEnabled_Offset), 0, null, Enabled);
        }
    }
}

public static class VariantDependencyMarshaler
{
    public static VariantDependency FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new VariantDependency(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, VariantDependency obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return VariantDependency.NativeDataSize;
    }
}