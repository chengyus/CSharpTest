using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AIModule;

[UStruct]
public partial struct AIDynamicParam
{
    // NameProperty /Script/AIModule.AIDynamicParam:ParamName
    static readonly int ParamName_Offset;
    public Name ParamName;
    
    // EnumProperty /Script/AIModule.AIDynamicParam:ParamType
    static readonly int ParamType_Offset;
    public UnrealSharp.AIModule.EAIParamType ParamType;
    
    // FloatProperty /Script/AIModule.AIDynamicParam:Value
    static readonly int Value_Offset;
    public float Value;
    
    // StructProperty /Script/AIModule.AIDynamicParam:BBKey
    static readonly int BBKey_Offset;
    public UnrealSharp.AIModule.BlackboardKeySelector BBKey;
    
    
    public static readonly int NativeDataSize;
    static AIDynamicParam()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("AIDynamicParam");
        
        ParamName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ParamName");
        ParamType_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ParamType");
        Value_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Value");
        BBKey_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BBKey");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public AIDynamicParam(IntPtr InNativeStruct)
    {
        unsafe
        {
            ParamName = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, ParamName_Offset), 0, null);
            ParamType = BlittableMarshaller<UnrealSharp.AIModule.EAIParamType>.FromNative(IntPtr.Add(InNativeStruct, ParamType_Offset), 0, null);
            Value = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Value_Offset), 0, null);
            BBKey = UnrealSharp.AIModule.BlackboardKeySelectorMarshaler.FromNative(IntPtr.Add(InNativeStruct, BBKey_Offset), 0, null);
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
            UnrealSharp.AIModule.BlackboardKeySelectorMarshaler.ToNative(IntPtr.Add(Buffer, BBKey_Offset), 0, null, BBKey);
        }
    }
}

public static class AIDynamicParamMarshaler
{
    public static AIDynamicParam FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new AIDynamicParam(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, AIDynamicParam obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return AIDynamicParam.NativeDataSize;
    }
}