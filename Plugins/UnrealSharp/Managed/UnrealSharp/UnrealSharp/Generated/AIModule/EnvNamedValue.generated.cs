using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AIModule;

[UStruct]
public partial struct EnvNamedValue
{
    // NameProperty /Script/AIModule.EnvNamedValue:ParamName
    static readonly int ParamName_Offset;
    public Name ParamName;
    
    // EnumProperty /Script/AIModule.EnvNamedValue:ParamType
    static readonly int ParamType_Offset;
    public UnrealSharp.AIModule.EAIParamType ParamType;
    
    // FloatProperty /Script/AIModule.EnvNamedValue:Value
    static readonly int Value_Offset;
    public float Value;
    
    
    public static readonly int NativeDataSize;
    static EnvNamedValue()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("EnvNamedValue");
        
        ParamName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ParamName");
        ParamType_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ParamType");
        Value_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Value");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public EnvNamedValue(IntPtr InNativeStruct)
    {
        unsafe
        {
            ParamName = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, ParamName_Offset), 0, null);
            ParamType = BlittableMarshaller<UnrealSharp.AIModule.EAIParamType>.FromNative(IntPtr.Add(InNativeStruct, ParamType_Offset), 0, null);
            Value = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Value_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, ParamName_Offset), 0, null, ParamName);
            BlittableMarshaller<UnrealSharp.AIModule.EAIParamType>.ToNative(IntPtr.Add(Buffer, ParamType_Offset), 0, null, ParamType);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Value_Offset), 0, null, Value);
        }
    }
}

public static class EnvNamedValueMarshaler
{
    public static EnvNamedValue FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new EnvNamedValue(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, EnvNamedValue obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return EnvNamedValue.NativeDataSize;
    }
}