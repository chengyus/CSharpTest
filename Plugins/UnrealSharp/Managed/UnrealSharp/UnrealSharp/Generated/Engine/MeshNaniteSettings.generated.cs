using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct MeshNaniteSettings
{
    // BoolProperty /Script/Engine.MeshNaniteSettings:bEnabled
    static readonly int bEnabled_Offset;
    static readonly IntPtr bEnabled_NativeProperty;
    public bool Enabled;
    
    // BoolProperty /Script/Engine.MeshNaniteSettings:bPreserveArea
    static readonly int bPreserveArea_Offset;
    static readonly IntPtr bPreserveArea_NativeProperty;
    public bool PreserveArea;
    
    // BoolProperty /Script/Engine.MeshNaniteSettings:bExplicitTangents
    static readonly int bExplicitTangents_Offset;
    static readonly IntPtr bExplicitTangents_NativeProperty;
    public bool ExplicitTangents;
    
    // IntProperty /Script/Engine.MeshNaniteSettings:PositionPrecision
    static readonly int PositionPrecision_Offset;
    public int PositionPrecision;
    
    // IntProperty /Script/Engine.MeshNaniteSettings:NormalPrecision
    static readonly int NormalPrecision_Offset;
    public int NormalPrecision;
    
    // IntProperty /Script/Engine.MeshNaniteSettings:TangentPrecision
    static readonly int TangentPrecision_Offset;
    public int TangentPrecision;
    
    // FloatProperty /Script/Engine.MeshNaniteSettings:KeepPercentTriangles
    static readonly int KeepPercentTriangles_Offset;
    public float KeepPercentTriangles;
    
    // FloatProperty /Script/Engine.MeshNaniteSettings:TrimRelativeError
    static readonly int TrimRelativeError_Offset;
    public float TrimRelativeError;
    
    // EnumProperty /Script/Engine.MeshNaniteSettings:FallbackTarget
    static readonly int FallbackTarget_Offset;
    public UnrealSharp.Engine.ENaniteFallbackTarget FallbackTarget;
    
    // FloatProperty /Script/Engine.MeshNaniteSettings:FallbackPercentTriangles
    static readonly int FallbackPercentTriangles_Offset;
    public float FallbackPercentTriangles;
    
    // FloatProperty /Script/Engine.MeshNaniteSettings:FallbackRelativeError
    static readonly int FallbackRelativeError_Offset;
    public float FallbackRelativeError;
    
    // IntProperty /Script/Engine.MeshNaniteSettings:DisplacementUVChannel
    static readonly int DisplacementUVChannel_Offset;
    public int DisplacementUVChannel;
    
    
    public static readonly int NativeDataSize;
    static MeshNaniteSettings()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("MeshNaniteSettings");
        
        bEnabled_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bEnabled");
        bEnabled_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bEnabled");
        bPreserveArea_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bPreserveArea");
        bPreserveArea_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bPreserveArea");
        bExplicitTangents_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bExplicitTangents");
        bExplicitTangents_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bExplicitTangents");
        PositionPrecision_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PositionPrecision");
        NormalPrecision_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "NormalPrecision");
        TangentPrecision_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "TangentPrecision");
        KeepPercentTriangles_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "KeepPercentTriangles");
        TrimRelativeError_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "TrimRelativeError");
        FallbackTarget_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FallbackTarget");
        FallbackPercentTriangles_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FallbackPercentTriangles");
        FallbackRelativeError_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FallbackRelativeError");
        DisplacementUVChannel_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DisplacementUVChannel");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public MeshNaniteSettings(IntPtr InNativeStruct)
    {
        unsafe
        {
            Enabled = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bEnabled_NativeProperty, bEnabled_Offset);
            PreserveArea = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bPreserveArea_NativeProperty, bPreserveArea_Offset);
            ExplicitTangents = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bExplicitTangents_NativeProperty, bExplicitTangents_Offset);
            PositionPrecision = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, PositionPrecision_Offset), 0, null);
            NormalPrecision = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, NormalPrecision_Offset), 0, null);
            TangentPrecision = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, TangentPrecision_Offset), 0, null);
            KeepPercentTriangles = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, KeepPercentTriangles_Offset), 0, null);
            TrimRelativeError = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, TrimRelativeError_Offset), 0, null);
            FallbackTarget = BlittableMarshaller<UnrealSharp.Engine.ENaniteFallbackTarget>.FromNative(IntPtr.Add(InNativeStruct, FallbackTarget_Offset), 0, null);
            FallbackPercentTriangles = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, FallbackPercentTriangles_Offset), 0, null);
            FallbackRelativeError = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, FallbackRelativeError_Offset), 0, null);
            DisplacementUVChannel = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, DisplacementUVChannel_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bEnabled_NativeProperty, bEnabled_Offset, Enabled);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bPreserveArea_NativeProperty, bPreserveArea_Offset, PreserveArea);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bExplicitTangents_NativeProperty, bExplicitTangents_Offset, ExplicitTangents);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, PositionPrecision_Offset), 0, null, PositionPrecision);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, NormalPrecision_Offset), 0, null, NormalPrecision);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, TangentPrecision_Offset), 0, null, TangentPrecision);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, KeepPercentTriangles_Offset), 0, null, KeepPercentTriangles);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, TrimRelativeError_Offset), 0, null, TrimRelativeError);
            BlittableMarshaller<UnrealSharp.Engine.ENaniteFallbackTarget>.ToNative(IntPtr.Add(Buffer, FallbackTarget_Offset), 0, null, FallbackTarget);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, FallbackPercentTriangles_Offset), 0, null, FallbackPercentTriangles);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, FallbackRelativeError_Offset), 0, null, FallbackRelativeError);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, DisplacementUVChannel_Offset), 0, null, DisplacementUVChannel);
        }
    }
}

public static class MeshNaniteSettingsMarshaler
{
    public static MeshNaniteSettings FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new MeshNaniteSettings(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, MeshNaniteSettings obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return MeshNaniteSettings.NativeDataSize;
    }
}