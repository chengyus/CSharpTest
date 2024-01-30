using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct ScalarParameterValue
{
    // StructProperty /Script/Engine.ScalarParameterValue:ParameterInfo
    static readonly int ParameterInfo_Offset;
    public UnrealSharp.Engine.MaterialParameterInfo ParameterInfo;
    
    // FloatProperty /Script/Engine.ScalarParameterValue:ParameterValue
    static readonly int ParameterValue_Offset;
    public float ParameterValue;
    
    
    public static readonly int NativeDataSize;
    static ScalarParameterValue()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("ScalarParameterValue");
        
        ParameterInfo_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ParameterInfo");
        ParameterValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ParameterValue");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public ScalarParameterValue(IntPtr InNativeStruct)
    {
        unsafe
        {
            ParameterInfo = UnrealSharp.Engine.MaterialParameterInfoMarshaler.FromNative(IntPtr.Add(InNativeStruct, ParameterInfo_Offset), 0, null);
            ParameterValue = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, ParameterValue_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.Engine.MaterialParameterInfoMarshaler.ToNative(IntPtr.Add(Buffer, ParameterInfo_Offset), 0, null, ParameterInfo);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, ParameterValue_Offset), 0, null, ParameterValue);
        }
    }
}

public static class ScalarParameterValueMarshaler
{
    public static ScalarParameterValue FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new ScalarParameterValue(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, ScalarParameterValue obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return ScalarParameterValue.NativeDataSize;
    }
}