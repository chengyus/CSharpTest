using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AlembicLibrary;

[UStruct]
public partial struct AbcGeometryCacheSettings
{
    // BoolProperty /Script/AlembicLibrary.AbcGeometryCacheSettings:bFlattenTracks
    static readonly int bFlattenTracks_Offset;
    public bool FlattenTracks;
    
    // BoolProperty /Script/AlembicLibrary.AbcGeometryCacheSettings:bStoreImportedVertexNumbers
    static readonly int bStoreImportedVertexNumbers_Offset;
    public bool StoreImportedVertexNumbers;
    
    // BoolProperty /Script/AlembicLibrary.AbcGeometryCacheSettings:bApplyConstantTopologyOptimizations
    static readonly int bApplyConstantTopologyOptimizations_Offset;
    public bool ApplyConstantTopologyOptimizations;
    
    // EnumProperty /Script/AlembicLibrary.AbcGeometryCacheSettings:MotionVectors
    static readonly int MotionVectors_Offset;
    public UnrealSharp.AlembicLibrary.EAbcGeometryCacheMotionVectorsImport MotionVectors;
    
    // BoolProperty /Script/AlembicLibrary.AbcGeometryCacheSettings:bOptimizeIndexBuffers
    static readonly int bOptimizeIndexBuffers_Offset;
    public bool OptimizeIndexBuffers;
    
    // FloatProperty /Script/AlembicLibrary.AbcGeometryCacheSettings:CompressedPositionPrecision
    static readonly int CompressedPositionPrecision_Offset;
    public float CompressedPositionPrecision;
    
    // IntProperty /Script/AlembicLibrary.AbcGeometryCacheSettings:CompressedTextureCoordinatesNumberOfBits
    static readonly int CompressedTextureCoordinatesNumberOfBits_Offset;
    public int CompressedTextureCoordinatesNumberOfBits;
    
    
    public static readonly int NativeDataSize;
    static AbcGeometryCacheSettings()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("AbcGeometryCacheSettings");
        
        bFlattenTracks_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bFlattenTracks");
        bStoreImportedVertexNumbers_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bStoreImportedVertexNumbers");
        bApplyConstantTopologyOptimizations_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bApplyConstantTopologyOptimizations");
        MotionVectors_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MotionVectors");
        bOptimizeIndexBuffers_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOptimizeIndexBuffers");
        CompressedPositionPrecision_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "CompressedPositionPrecision");
        CompressedTextureCoordinatesNumberOfBits_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "CompressedTextureCoordinatesNumberOfBits");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public AbcGeometryCacheSettings(IntPtr InNativeStruct)
    {
        unsafe
        {
            FlattenTracks = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bFlattenTracks_Offset), 0, null);
            StoreImportedVertexNumbers = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bStoreImportedVertexNumbers_Offset), 0, null);
            ApplyConstantTopologyOptimizations = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bApplyConstantTopologyOptimizations_Offset), 0, null);
            MotionVectors = BlittableMarshaller<UnrealSharp.AlembicLibrary.EAbcGeometryCacheMotionVectorsImport>.FromNative(IntPtr.Add(InNativeStruct, MotionVectors_Offset), 0, null);
            OptimizeIndexBuffers = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bOptimizeIndexBuffers_Offset), 0, null);
            CompressedPositionPrecision = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, CompressedPositionPrecision_Offset), 0, null);
            CompressedTextureCoordinatesNumberOfBits = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, CompressedTextureCoordinatesNumberOfBits_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bFlattenTracks_Offset), 0, null, FlattenTracks);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bStoreImportedVertexNumbers_Offset), 0, null, StoreImportedVertexNumbers);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bApplyConstantTopologyOptimizations_Offset), 0, null, ApplyConstantTopologyOptimizations);
            BlittableMarshaller<UnrealSharp.AlembicLibrary.EAbcGeometryCacheMotionVectorsImport>.ToNative(IntPtr.Add(Buffer, MotionVectors_Offset), 0, null, MotionVectors);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bOptimizeIndexBuffers_Offset), 0, null, OptimizeIndexBuffers);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, CompressedPositionPrecision_Offset), 0, null, CompressedPositionPrecision);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, CompressedTextureCoordinatesNumberOfBits_Offset), 0, null, CompressedTextureCoordinatesNumberOfBits);
        }
    }
}

public static class AbcGeometryCacheSettingsMarshaler
{
    public static AbcGeometryCacheSettings FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new AbcGeometryCacheSettings(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, AbcGeometryCacheSettings obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return AbcGeometryCacheSettings.NativeDataSize;
    }
}