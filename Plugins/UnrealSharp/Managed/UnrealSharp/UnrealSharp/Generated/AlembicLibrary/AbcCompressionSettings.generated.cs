using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AlembicLibrary;

[UStruct]
public partial struct AbcCompressionSettings
{
    // BoolProperty /Script/AlembicLibrary.AbcCompressionSettings:bMergeMeshes
    static readonly int bMergeMeshes_Offset;
    public bool MergeMeshes;
    
    // BoolProperty /Script/AlembicLibrary.AbcCompressionSettings:bBakeMatrixAnimation
    static readonly int bBakeMatrixAnimation_Offset;
    public bool BakeMatrixAnimation;
    
    // EnumProperty /Script/AlembicLibrary.AbcCompressionSettings:BaseCalculationType
    static readonly int BaseCalculationType_Offset;
    public UnrealSharp.AlembicLibrary.EBaseCalculationType BaseCalculationType;
    
    // FloatProperty /Script/AlembicLibrary.AbcCompressionSettings:PercentageOfTotalBases
    static readonly int PercentageOfTotalBases_Offset;
    public float PercentageOfTotalBases;
    
    // IntProperty /Script/AlembicLibrary.AbcCompressionSettings:MaxNumberOfBases
    static readonly int MaxNumberOfBases_Offset;
    public int MaxNumberOfBases;
    
    // FloatProperty /Script/AlembicLibrary.AbcCompressionSettings:MinimumNumberOfVertexInfluencePercentage
    static readonly int MinimumNumberOfVertexInfluencePercentage_Offset;
    public float MinimumNumberOfVertexInfluencePercentage;
    
    
    public static readonly int NativeDataSize;
    static AbcCompressionSettings()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("AbcCompressionSettings");
        
        bMergeMeshes_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bMergeMeshes");
        bBakeMatrixAnimation_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bBakeMatrixAnimation");
        BaseCalculationType_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BaseCalculationType");
        PercentageOfTotalBases_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PercentageOfTotalBases");
        MaxNumberOfBases_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MaxNumberOfBases");
        MinimumNumberOfVertexInfluencePercentage_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MinimumNumberOfVertexInfluencePercentage");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public AbcCompressionSettings(IntPtr InNativeStruct)
    {
        unsafe
        {
            MergeMeshes = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bMergeMeshes_Offset), 0, null);
            BakeMatrixAnimation = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bBakeMatrixAnimation_Offset), 0, null);
            BaseCalculationType = BlittableMarshaller<UnrealSharp.AlembicLibrary.EBaseCalculationType>.FromNative(IntPtr.Add(InNativeStruct, BaseCalculationType_Offset), 0, null);
            PercentageOfTotalBases = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, PercentageOfTotalBases_Offset), 0, null);
            MaxNumberOfBases = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, MaxNumberOfBases_Offset), 0, null);
            MinimumNumberOfVertexInfluencePercentage = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, MinimumNumberOfVertexInfluencePercentage_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bMergeMeshes_Offset), 0, null, MergeMeshes);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bBakeMatrixAnimation_Offset), 0, null, BakeMatrixAnimation);
            BlittableMarshaller<UnrealSharp.AlembicLibrary.EBaseCalculationType>.ToNative(IntPtr.Add(Buffer, BaseCalculationType_Offset), 0, null, BaseCalculationType);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, PercentageOfTotalBases_Offset), 0, null, PercentageOfTotalBases);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, MaxNumberOfBases_Offset), 0, null, MaxNumberOfBases);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, MinimumNumberOfVertexInfluencePercentage_Offset), 0, null, MinimumNumberOfVertexInfluencePercentage);
        }
    }
}

public static class AbcCompressionSettingsMarshaler
{
    public static AbcCompressionSettings FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new AbcCompressionSettings(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, AbcCompressionSettings obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return AbcCompressionSettings.NativeDataSize;
    }
}