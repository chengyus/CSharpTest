using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Landscape;

[UStruct]
public partial struct LandscapeBrushParameters
{
    // EnumProperty /Script/Landscape.LandscapeBrushParameters:LayerType
    static readonly int LayerType_Offset;
    public UnrealSharp.Landscape.ELandscapeToolTargetType LayerType;
    
    // ObjectProperty /Script/Landscape.LandscapeBrushParameters:CombinedResult
    static readonly int CombinedResult_Offset;
    public UnrealSharp.Engine.TextureRenderTarget2D CombinedResult;
    
    // NameProperty /Script/Landscape.LandscapeBrushParameters:WeightmapLayerName
    static readonly int WeightmapLayerName_Offset;
    public Name WeightmapLayerName;
    
    
    public static readonly int NativeDataSize;
    static LandscapeBrushParameters()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("LandscapeBrushParameters");
        
        LayerType_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LayerType");
        CombinedResult_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "CombinedResult");
        WeightmapLayerName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "WeightmapLayerName");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public LandscapeBrushParameters(IntPtr InNativeStruct)
    {
        unsafe
        {
            LayerType = BlittableMarshaller<UnrealSharp.Landscape.ELandscapeToolTargetType>.FromNative(IntPtr.Add(InNativeStruct, LayerType_Offset), 0, null);
            CombinedResult = ObjectMarshaller<UnrealSharp.Engine.TextureRenderTarget2D>.FromNative(IntPtr.Add(InNativeStruct, CombinedResult_Offset), 0, null);
            WeightmapLayerName = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, WeightmapLayerName_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.Landscape.ELandscapeToolTargetType>.ToNative(IntPtr.Add(Buffer, LayerType_Offset), 0, null, LayerType);
            ObjectMarshaller<UnrealSharp.Engine.TextureRenderTarget2D>.ToNative(IntPtr.Add(Buffer, CombinedResult_Offset), 0, null, CombinedResult);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, WeightmapLayerName_Offset), 0, null, WeightmapLayerName);
        }
    }
}

public static class LandscapeBrushParametersMarshaler
{
    public static LandscapeBrushParameters FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new LandscapeBrushParameters(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, LandscapeBrushParameters obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return LandscapeBrushParameters.NativeDataSize;
    }
}