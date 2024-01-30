using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct VectorParameterValue
{
    // StructProperty /Script/Engine.VectorParameterValue:ParameterInfo
    static readonly int ParameterInfo_Offset;
    public UnrealSharp.Engine.MaterialParameterInfo ParameterInfo;
    
    // StructProperty /Script/Engine.VectorParameterValue:ParameterValue
    static readonly int ParameterValue_Offset;
    public UnrealSharp.CoreUObject.LinearColor ParameterValue;
    
    
    public static readonly int NativeDataSize;
    static VectorParameterValue()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("VectorParameterValue");
        
        ParameterInfo_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ParameterInfo");
        ParameterValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ParameterValue");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public VectorParameterValue(IntPtr InNativeStruct)
    {
        unsafe
        {
            ParameterInfo = UnrealSharp.Engine.MaterialParameterInfoMarshaler.FromNative(IntPtr.Add(InNativeStruct, ParameterInfo_Offset), 0, null);
            ParameterValue = BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.FromNative(IntPtr.Add(InNativeStruct, ParameterValue_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.Engine.MaterialParameterInfoMarshaler.ToNative(IntPtr.Add(Buffer, ParameterInfo_Offset), 0, null, ParameterInfo);
            BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.ToNative(IntPtr.Add(Buffer, ParameterValue_Offset), 0, null, ParameterValue);
        }
    }
}

public static class VectorParameterValueMarshaler
{
    public static VectorParameterValue FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new VectorParameterValue(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, VectorParameterValue obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return VectorParameterValue.NativeDataSize;
    }
}