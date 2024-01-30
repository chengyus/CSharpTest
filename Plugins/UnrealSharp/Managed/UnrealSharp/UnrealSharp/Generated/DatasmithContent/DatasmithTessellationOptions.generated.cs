using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.DatasmithContent;

[UStruct]
public partial struct DatasmithTessellationOptions
{
    // FloatProperty /Script/DatasmithContent.DatasmithTessellationOptions:ChordTolerance
    static readonly int ChordTolerance_Offset;
    public float ChordTolerance;
    
    // FloatProperty /Script/DatasmithContent.DatasmithTessellationOptions:MaxEdgeLength
    static readonly int MaxEdgeLength_Offset;
    public float MaxEdgeLength;
    
    // FloatProperty /Script/DatasmithContent.DatasmithTessellationOptions:NormalTolerance
    static readonly int NormalTolerance_Offset;
    public float NormalTolerance;
    
    // EnumProperty /Script/DatasmithContent.DatasmithTessellationOptions:StitchingTechnique
    static readonly int StitchingTechnique_Offset;
    public UnrealSharp.DatasmithContent.EDatasmithCADStitchingTechnique StitchingTechnique;
    
    
    public static readonly int NativeDataSize;
    static DatasmithTessellationOptions()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("DatasmithTessellationOptions");
        
        ChordTolerance_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ChordTolerance");
        MaxEdgeLength_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MaxEdgeLength");
        NormalTolerance_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "NormalTolerance");
        StitchingTechnique_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "StitchingTechnique");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public DatasmithTessellationOptions(IntPtr InNativeStruct)
    {
        unsafe
        {
            ChordTolerance = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, ChordTolerance_Offset), 0, null);
            MaxEdgeLength = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, MaxEdgeLength_Offset), 0, null);
            NormalTolerance = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, NormalTolerance_Offset), 0, null);
            StitchingTechnique = BlittableMarshaller<UnrealSharp.DatasmithContent.EDatasmithCADStitchingTechnique>.FromNative(IntPtr.Add(InNativeStruct, StitchingTechnique_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, ChordTolerance_Offset), 0, null, ChordTolerance);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, MaxEdgeLength_Offset), 0, null, MaxEdgeLength);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, NormalTolerance_Offset), 0, null, NormalTolerance);
            BlittableMarshaller<UnrealSharp.DatasmithContent.EDatasmithCADStitchingTechnique>.ToNative(IntPtr.Add(Buffer, StitchingTechnique_Offset), 0, null, StitchingTechnique);
        }
    }
}

public static class DatasmithTessellationOptionsMarshaler
{
    public static DatasmithTessellationOptions FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new DatasmithTessellationOptions(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, DatasmithTessellationOptions obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return DatasmithTessellationOptions.NativeDataSize;
    }
}