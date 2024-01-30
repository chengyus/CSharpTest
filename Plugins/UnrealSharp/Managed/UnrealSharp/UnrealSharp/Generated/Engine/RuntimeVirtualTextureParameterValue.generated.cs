using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct RuntimeVirtualTextureParameterValue
{
    // StructProperty /Script/Engine.RuntimeVirtualTextureParameterValue:ParameterInfo
    static readonly int ParameterInfo_Offset;
    public UnrealSharp.Engine.MaterialParameterInfo ParameterInfo;
    
    // ObjectProperty /Script/Engine.RuntimeVirtualTextureParameterValue:ParameterValue
    static readonly int ParameterValue_Offset;
    public UnrealSharp.Engine.RuntimeVirtualTexture ParameterValue;
    
    
    public static readonly int NativeDataSize;
    static RuntimeVirtualTextureParameterValue()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RuntimeVirtualTextureParameterValue");
        
        ParameterInfo_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ParameterInfo");
        ParameterValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ParameterValue");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RuntimeVirtualTextureParameterValue(IntPtr InNativeStruct)
    {
        unsafe
        {
            ParameterInfo = UnrealSharp.Engine.MaterialParameterInfoMarshaler.FromNative(IntPtr.Add(InNativeStruct, ParameterInfo_Offset), 0, null);
            ParameterValue = ObjectMarshaller<UnrealSharp.Engine.RuntimeVirtualTexture>.FromNative(IntPtr.Add(InNativeStruct, ParameterValue_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.Engine.MaterialParameterInfoMarshaler.ToNative(IntPtr.Add(Buffer, ParameterInfo_Offset), 0, null, ParameterInfo);
            ObjectMarshaller<UnrealSharp.Engine.RuntimeVirtualTexture>.ToNative(IntPtr.Add(Buffer, ParameterValue_Offset), 0, null, ParameterValue);
        }
    }
}

public static class RuntimeVirtualTextureParameterValueMarshaler
{
    public static RuntimeVirtualTextureParameterValue FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RuntimeVirtualTextureParameterValue(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RuntimeVirtualTextureParameterValue obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RuntimeVirtualTextureParameterValue.NativeDataSize;
    }
}