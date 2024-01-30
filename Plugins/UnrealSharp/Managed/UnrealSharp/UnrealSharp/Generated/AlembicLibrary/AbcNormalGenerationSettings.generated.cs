using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AlembicLibrary;

[UStruct]
public partial struct AbcNormalGenerationSettings
{
    // BoolProperty /Script/AlembicLibrary.AbcNormalGenerationSettings:bForceOneSmoothingGroupPerObject
    static readonly int bForceOneSmoothingGroupPerObject_Offset;
    public bool ForceOneSmoothingGroupPerObject;
    
    // FloatProperty /Script/AlembicLibrary.AbcNormalGenerationSettings:HardEdgeAngleThreshold
    static readonly int HardEdgeAngleThreshold_Offset;
    public float HardEdgeAngleThreshold;
    
    // BoolProperty /Script/AlembicLibrary.AbcNormalGenerationSettings:bRecomputeNormals
    static readonly int bRecomputeNormals_Offset;
    public bool RecomputeNormals;
    
    // BoolProperty /Script/AlembicLibrary.AbcNormalGenerationSettings:bIgnoreDegenerateTriangles
    static readonly int bIgnoreDegenerateTriangles_Offset;
    public bool IgnoreDegenerateTriangles;
    
    // BoolProperty /Script/AlembicLibrary.AbcNormalGenerationSettings:bSkipComputingTangents
    static readonly int bSkipComputingTangents_Offset;
    public bool SkipComputingTangents;
    
    
    public static readonly int NativeDataSize;
    static AbcNormalGenerationSettings()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("AbcNormalGenerationSettings");
        
        bForceOneSmoothingGroupPerObject_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bForceOneSmoothingGroupPerObject");
        HardEdgeAngleThreshold_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "HardEdgeAngleThreshold");
        bRecomputeNormals_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bRecomputeNormals");
        bIgnoreDegenerateTriangles_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bIgnoreDegenerateTriangles");
        bSkipComputingTangents_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bSkipComputingTangents");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public AbcNormalGenerationSettings(IntPtr InNativeStruct)
    {
        unsafe
        {
            ForceOneSmoothingGroupPerObject = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bForceOneSmoothingGroupPerObject_Offset), 0, null);
            HardEdgeAngleThreshold = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, HardEdgeAngleThreshold_Offset), 0, null);
            RecomputeNormals = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bRecomputeNormals_Offset), 0, null);
            IgnoreDegenerateTriangles = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bIgnoreDegenerateTriangles_Offset), 0, null);
            SkipComputingTangents = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bSkipComputingTangents_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bForceOneSmoothingGroupPerObject_Offset), 0, null, ForceOneSmoothingGroupPerObject);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, HardEdgeAngleThreshold_Offset), 0, null, HardEdgeAngleThreshold);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bRecomputeNormals_Offset), 0, null, RecomputeNormals);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bIgnoreDegenerateTriangles_Offset), 0, null, IgnoreDegenerateTriangles);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bSkipComputingTangents_Offset), 0, null, SkipComputingTangents);
        }
    }
}

public static class AbcNormalGenerationSettingsMarshaler
{
    public static AbcNormalGenerationSettings FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new AbcNormalGenerationSettings(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, AbcNormalGenerationSettings obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return AbcNormalGenerationSettings.NativeDataSize;
    }
}