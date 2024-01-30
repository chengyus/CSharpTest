using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.DataLayerEditor;

[UStruct]
public partial struct DataLayerCreationParameters
{
    // ObjectProperty /Script/DataLayerEditor.DataLayerCreationParameters:DataLayerAsset
    static readonly int DataLayerAsset_Offset;
    public UnrealSharp.Engine.DataLayerAsset DataLayerAsset;
    
    // ObjectProperty /Script/DataLayerEditor.DataLayerCreationParameters:WorldDataLayers
    static readonly int WorldDataLayers_Offset;
    public UnrealSharp.Engine.WorldDataLayers WorldDataLayers;
    
    // BoolProperty /Script/DataLayerEditor.DataLayerCreationParameters:bIsPrivate
    static readonly int bIsPrivate_Offset;
    public bool IsPrivate;
    
    
    public static readonly int NativeDataSize;
    static DataLayerCreationParameters()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("DataLayerCreationParameters");
        
        DataLayerAsset_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DataLayerAsset");
        WorldDataLayers_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "WorldDataLayers");
        bIsPrivate_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bIsPrivate");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public DataLayerCreationParameters(IntPtr InNativeStruct)
    {
        unsafe
        {
            DataLayerAsset = ObjectMarshaller<UnrealSharp.Engine.DataLayerAsset>.FromNative(IntPtr.Add(InNativeStruct, DataLayerAsset_Offset), 0, null);
            WorldDataLayers = ObjectMarshaller<UnrealSharp.Engine.WorldDataLayers>.FromNative(IntPtr.Add(InNativeStruct, WorldDataLayers_Offset), 0, null);
            IsPrivate = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bIsPrivate_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            ObjectMarshaller<UnrealSharp.Engine.DataLayerAsset>.ToNative(IntPtr.Add(Buffer, DataLayerAsset_Offset), 0, null, DataLayerAsset);
            ObjectMarshaller<UnrealSharp.Engine.WorldDataLayers>.ToNative(IntPtr.Add(Buffer, WorldDataLayers_Offset), 0, null, WorldDataLayers);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bIsPrivate_Offset), 0, null, IsPrivate);
        }
    }
}

public static class DataLayerCreationParametersMarshaler
{
    public static DataLayerCreationParameters FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new DataLayerCreationParameters(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, DataLayerCreationParameters obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return DataLayerCreationParameters.NativeDataSize;
    }
}