using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.DatasmithContent;

[UStruct]
public partial struct DatasmithReimportOptions
{
    // BoolProperty /Script/DatasmithContent.DatasmithReimportOptions:bUpdateActors
    static readonly int bUpdateActors_Offset;
    public bool UpdateActors;
    
    // BoolProperty /Script/DatasmithContent.DatasmithReimportOptions:bRespawnDeletedActors
    static readonly int bRespawnDeletedActors_Offset;
    public bool RespawnDeletedActors;
    
    
    public static readonly int NativeDataSize;
    static DatasmithReimportOptions()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("DatasmithReimportOptions");
        
        bUpdateActors_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bUpdateActors");
        bRespawnDeletedActors_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bRespawnDeletedActors");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public DatasmithReimportOptions(IntPtr InNativeStruct)
    {
        unsafe
        {
            UpdateActors = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bUpdateActors_Offset), 0, null);
            RespawnDeletedActors = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bRespawnDeletedActors_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bUpdateActors_Offset), 0, null, UpdateActors);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bRespawnDeletedActors_Offset), 0, null, RespawnDeletedActors);
        }
    }
}

public static class DatasmithReimportOptionsMarshaler
{
    public static DatasmithReimportOptions FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new DatasmithReimportOptions(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, DatasmithReimportOptions obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return DatasmithReimportOptions.NativeDataSize;
    }
}