using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Niagara;

[UStruct]
public partial struct NiagaraSimCacheCreateParameters
{
    // EnumProperty /Script/Niagara.NiagaraSimCacheCreateParameters:AttributeCaptureMode
    static readonly int AttributeCaptureMode_Offset;
    public UnrealSharp.Niagara.ENiagaraSimCacheAttributeCaptureMode AttributeCaptureMode;
    
    // BoolProperty /Script/Niagara.NiagaraSimCacheCreateParameters:bAllowRebasing
    static readonly int bAllowRebasing_Offset;
    static readonly IntPtr bAllowRebasing_NativeProperty;
    public bool AllowRebasing;
    
    // BoolProperty /Script/Niagara.NiagaraSimCacheCreateParameters:bAllowDataInterfaceCaching
    static readonly int bAllowDataInterfaceCaching_Offset;
    static readonly IntPtr bAllowDataInterfaceCaching_NativeProperty;
    public bool AllowDataInterfaceCaching;
    
    // BoolProperty /Script/Niagara.NiagaraSimCacheCreateParameters:bAllowInterpolation
    static readonly int bAllowInterpolation_Offset;
    static readonly IntPtr bAllowInterpolation_NativeProperty;
    public bool AllowInterpolation;
    
    // BoolProperty /Script/Niagara.NiagaraSimCacheCreateParameters:bAllowVelocityExtrapolation
    static readonly int bAllowVelocityExtrapolation_Offset;
    static readonly IntPtr bAllowVelocityExtrapolation_NativeProperty;
    public bool AllowVelocityExtrapolation;
    
    
    public static readonly int NativeDataSize;
    static NiagaraSimCacheCreateParameters()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("NiagaraSimCacheCreateParameters");
        
        AttributeCaptureMode_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AttributeCaptureMode");
        bAllowRebasing_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bAllowRebasing");
        bAllowRebasing_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bAllowRebasing");
        bAllowDataInterfaceCaching_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bAllowDataInterfaceCaching");
        bAllowDataInterfaceCaching_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bAllowDataInterfaceCaching");
        bAllowInterpolation_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bAllowInterpolation");
        bAllowInterpolation_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bAllowInterpolation");
        bAllowVelocityExtrapolation_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bAllowVelocityExtrapolation");
        bAllowVelocityExtrapolation_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bAllowVelocityExtrapolation");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public NiagaraSimCacheCreateParameters(IntPtr InNativeStruct)
    {
        unsafe
        {
            AttributeCaptureMode = BlittableMarshaller<UnrealSharp.Niagara.ENiagaraSimCacheAttributeCaptureMode>.FromNative(IntPtr.Add(InNativeStruct, AttributeCaptureMode_Offset), 0, null);
            AllowRebasing = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bAllowRebasing_NativeProperty, bAllowRebasing_Offset);
            AllowDataInterfaceCaching = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bAllowDataInterfaceCaching_NativeProperty, bAllowDataInterfaceCaching_Offset);
            AllowInterpolation = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bAllowInterpolation_NativeProperty, bAllowInterpolation_Offset);
            AllowVelocityExtrapolation = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bAllowVelocityExtrapolation_NativeProperty, bAllowVelocityExtrapolation_Offset);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.Niagara.ENiagaraSimCacheAttributeCaptureMode>.ToNative(IntPtr.Add(Buffer, AttributeCaptureMode_Offset), 0, null, AttributeCaptureMode);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bAllowRebasing_NativeProperty, bAllowRebasing_Offset, AllowRebasing);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bAllowDataInterfaceCaching_NativeProperty, bAllowDataInterfaceCaching_Offset, AllowDataInterfaceCaching);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bAllowInterpolation_NativeProperty, bAllowInterpolation_Offset, AllowInterpolation);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bAllowVelocityExtrapolation_NativeProperty, bAllowVelocityExtrapolation_Offset, AllowVelocityExtrapolation);
        }
    }
}

public static class NiagaraSimCacheCreateParametersMarshaler
{
    public static NiagaraSimCacheCreateParameters FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new NiagaraSimCacheCreateParameters(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, NiagaraSimCacheCreateParameters obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return NiagaraSimCacheCreateParameters.NativeDataSize;
    }
}