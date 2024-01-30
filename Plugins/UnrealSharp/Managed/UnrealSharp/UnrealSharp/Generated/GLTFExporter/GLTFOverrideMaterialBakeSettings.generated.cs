using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.GLTFExporter;

[UStruct]
public partial struct GLTFOverrideMaterialBakeSettings
{
    // BoolProperty /Script/GLTFExporter.GLTFOverrideMaterialBakeSettings:bOverrideSize
    static readonly int bOverrideSize_Offset;
    public bool OverrideSize;
    
    // EnumProperty /Script/GLTFExporter.GLTFOverrideMaterialBakeSettings:Size
    static readonly int Size_Offset;
    public UnrealSharp.GLTFExporter.EGLTFMaterialBakeSizePOT Size;
    
    // BoolProperty /Script/GLTFExporter.GLTFOverrideMaterialBakeSettings:bOverrideFilter
    static readonly int bOverrideFilter_Offset;
    public bool OverrideFilter;
    
    // ByteProperty /Script/GLTFExporter.GLTFOverrideMaterialBakeSettings:Filter
    static readonly int Filter_Offset;
    public UnrealSharp.Engine.TextureFilter Filter;
    
    // BoolProperty /Script/GLTFExporter.GLTFOverrideMaterialBakeSettings:bOverrideTiling
    static readonly int bOverrideTiling_Offset;
    public bool OverrideTiling;
    
    // ByteProperty /Script/GLTFExporter.GLTFOverrideMaterialBakeSettings:Tiling
    static readonly int Tiling_Offset;
    public UnrealSharp.Engine.TextureAddress Tiling;
    
    
    public static readonly int NativeDataSize;
    static GLTFOverrideMaterialBakeSettings()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("GLTFOverrideMaterialBakeSettings");
        
        bOverrideSize_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverrideSize");
        Size_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Size");
        bOverrideFilter_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverrideFilter");
        Filter_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Filter");
        bOverrideTiling_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverrideTiling");
        Tiling_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Tiling");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public GLTFOverrideMaterialBakeSettings(IntPtr InNativeStruct)
    {
        unsafe
        {
            OverrideSize = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bOverrideSize_Offset), 0, null);
            Size = BlittableMarshaller<UnrealSharp.GLTFExporter.EGLTFMaterialBakeSizePOT>.FromNative(IntPtr.Add(InNativeStruct, Size_Offset), 0, null);
            OverrideFilter = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bOverrideFilter_Offset), 0, null);
            Filter = BlittableMarshaller<UnrealSharp.Engine.TextureFilter>.FromNative(IntPtr.Add(InNativeStruct, Filter_Offset), 0, null);
            OverrideTiling = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bOverrideTiling_Offset), 0, null);
            Tiling = BlittableMarshaller<UnrealSharp.Engine.TextureAddress>.FromNative(IntPtr.Add(InNativeStruct, Tiling_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bOverrideSize_Offset), 0, null, OverrideSize);
            BlittableMarshaller<UnrealSharp.GLTFExporter.EGLTFMaterialBakeSizePOT>.ToNative(IntPtr.Add(Buffer, Size_Offset), 0, null, Size);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bOverrideFilter_Offset), 0, null, OverrideFilter);
            BlittableMarshaller<UnrealSharp.Engine.TextureFilter>.ToNative(IntPtr.Add(Buffer, Filter_Offset), 0, null, Filter);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bOverrideTiling_Offset), 0, null, OverrideTiling);
            BlittableMarshaller<UnrealSharp.Engine.TextureAddress>.ToNative(IntPtr.Add(Buffer, Tiling_Offset), 0, null, Tiling);
        }
    }
}

public static class GLTFOverrideMaterialBakeSettingsMarshaler
{
    public static GLTFOverrideMaterialBakeSettings FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new GLTFOverrideMaterialBakeSettings(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, GLTFOverrideMaterialBakeSettings obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return GLTFOverrideMaterialBakeSettings.NativeDataSize;
    }
}