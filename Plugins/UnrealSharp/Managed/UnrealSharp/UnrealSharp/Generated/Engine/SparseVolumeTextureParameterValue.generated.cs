using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct SparseVolumeTextureParameterValue
{
    // StructProperty /Script/Engine.SparseVolumeTextureParameterValue:ParameterInfo
    static readonly int ParameterInfo_Offset;
    public UnrealSharp.Engine.MaterialParameterInfo ParameterInfo;
    
    // ObjectProperty /Script/Engine.SparseVolumeTextureParameterValue:ParameterValue
    static readonly int ParameterValue_Offset;
    public UnrealSharp.Engine.SparseVolumeTexture ParameterValue;
    
    
    public static readonly int NativeDataSize;
    static SparseVolumeTextureParameterValue()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("SparseVolumeTextureParameterValue");
        
        ParameterInfo_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ParameterInfo");
        ParameterValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ParameterValue");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public SparseVolumeTextureParameterValue(IntPtr InNativeStruct)
    {
        unsafe
        {
            ParameterInfo = UnrealSharp.Engine.MaterialParameterInfoMarshaler.FromNative(IntPtr.Add(InNativeStruct, ParameterInfo_Offset), 0, null);
            ParameterValue = ObjectMarshaller<UnrealSharp.Engine.SparseVolumeTexture>.FromNative(IntPtr.Add(InNativeStruct, ParameterValue_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.Engine.MaterialParameterInfoMarshaler.ToNative(IntPtr.Add(Buffer, ParameterInfo_Offset), 0, null, ParameterInfo);
            ObjectMarshaller<UnrealSharp.Engine.SparseVolumeTexture>.ToNative(IntPtr.Add(Buffer, ParameterValue_Offset), 0, null, ParameterValue);
        }
    }
}

public static class SparseVolumeTextureParameterValueMarshaler
{
    public static SparseVolumeTextureParameterValue FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new SparseVolumeTextureParameterValue(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, SparseVolumeTextureParameterValue obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return SparseVolumeTextureParameterValue.NativeDataSize;
    }
}