using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct AttenuationSubmixSendSettings
{
    // ObjectProperty /Script/Engine.AttenuationSubmixSendSettings:Submix
    static readonly int Submix_Offset;
    public UnrealSharp.Engine.SoundSubmixBase Submix;
    
    // EnumProperty /Script/Engine.AttenuationSubmixSendSettings:SubmixSendMethod
    static readonly int SubmixSendMethod_Offset;
    public UnrealSharp.Engine.ESubmixSendMethod SubmixSendMethod;
    
    // FloatProperty /Script/Engine.AttenuationSubmixSendSettings:SubmixSendLevelMin
    static readonly int SubmixSendLevelMin_Offset;
    public float SubmixSendLevelMin;
    
    // FloatProperty /Script/Engine.AttenuationSubmixSendSettings:SubmixSendLevelMax
    static readonly int SubmixSendLevelMax_Offset;
    public float SubmixSendLevelMax;
    
    // FloatProperty /Script/Engine.AttenuationSubmixSendSettings:SubmixSendDistanceMin
    static readonly int SubmixSendDistanceMin_Offset;
    public float SubmixSendDistanceMin;
    
    // FloatProperty /Script/Engine.AttenuationSubmixSendSettings:SubmixSendDistanceMax
    static readonly int SubmixSendDistanceMax_Offset;
    public float SubmixSendDistanceMax;
    
    // FloatProperty /Script/Engine.AttenuationSubmixSendSettings:ManualSubmixSendLevel
    static readonly int ManualSubmixSendLevel_Offset;
    public float ManualSubmixSendLevel;
    
    // StructProperty /Script/Engine.AttenuationSubmixSendSettings:CustomSubmixSendCurve
    static readonly int CustomSubmixSendCurve_Offset;
    public UnrealSharp.Engine.RuntimeFloatCurve CustomSubmixSendCurve;
    
    
    public static readonly int NativeDataSize;
    static AttenuationSubmixSendSettings()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("AttenuationSubmixSendSettings");
        
        Submix_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Submix");
        SubmixSendMethod_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SubmixSendMethod");
        SubmixSendLevelMin_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SubmixSendLevelMin");
        SubmixSendLevelMax_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SubmixSendLevelMax");
        SubmixSendDistanceMin_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SubmixSendDistanceMin");
        SubmixSendDistanceMax_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SubmixSendDistanceMax");
        ManualSubmixSendLevel_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ManualSubmixSendLevel");
        CustomSubmixSendCurve_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "CustomSubmixSendCurve");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public AttenuationSubmixSendSettings(IntPtr InNativeStruct)
    {
        unsafe
        {
            Submix = ObjectMarshaller<UnrealSharp.Engine.SoundSubmixBase>.FromNative(IntPtr.Add(InNativeStruct, Submix_Offset), 0, null);
            SubmixSendMethod = BlittableMarshaller<UnrealSharp.Engine.ESubmixSendMethod>.FromNative(IntPtr.Add(InNativeStruct, SubmixSendMethod_Offset), 0, null);
            SubmixSendLevelMin = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, SubmixSendLevelMin_Offset), 0, null);
            SubmixSendLevelMax = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, SubmixSendLevelMax_Offset), 0, null);
            SubmixSendDistanceMin = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, SubmixSendDistanceMin_Offset), 0, null);
            SubmixSendDistanceMax = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, SubmixSendDistanceMax_Offset), 0, null);
            ManualSubmixSendLevel = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, ManualSubmixSendLevel_Offset), 0, null);
            CustomSubmixSendCurve = UnrealSharp.Engine.RuntimeFloatCurveMarshaler.FromNative(IntPtr.Add(InNativeStruct, CustomSubmixSendCurve_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            ObjectMarshaller<UnrealSharp.Engine.SoundSubmixBase>.ToNative(IntPtr.Add(Buffer, Submix_Offset), 0, null, Submix);
            BlittableMarshaller<UnrealSharp.Engine.ESubmixSendMethod>.ToNative(IntPtr.Add(Buffer, SubmixSendMethod_Offset), 0, null, SubmixSendMethod);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, SubmixSendLevelMin_Offset), 0, null, SubmixSendLevelMin);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, SubmixSendLevelMax_Offset), 0, null, SubmixSendLevelMax);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, SubmixSendDistanceMin_Offset), 0, null, SubmixSendDistanceMin);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, SubmixSendDistanceMax_Offset), 0, null, SubmixSendDistanceMax);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, ManualSubmixSendLevel_Offset), 0, null, ManualSubmixSendLevel);
            UnrealSharp.Engine.RuntimeFloatCurveMarshaler.ToNative(IntPtr.Add(Buffer, CustomSubmixSendCurve_Offset), 0, null, CustomSubmixSendCurve);
        }
    }
}

public static class AttenuationSubmixSendSettingsMarshaler
{
    public static AttenuationSubmixSendSettings FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new AttenuationSubmixSendSettings(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, AttenuationSubmixSendSettings obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return AttenuationSubmixSendSettings.NativeDataSize;
    }
}