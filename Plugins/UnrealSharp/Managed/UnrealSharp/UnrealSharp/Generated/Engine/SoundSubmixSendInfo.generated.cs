using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct SoundSubmixSendInfo
{
    // EnumProperty /Script/Engine.SoundSubmixSendInfo:SendLevelControlMethod
    static readonly int SendLevelControlMethod_Offset;
    public UnrealSharp.Engine.ESendLevelControlMethod SendLevelControlMethod;
    
    // EnumProperty /Script/Engine.SoundSubmixSendInfo:SendStage
    static readonly int SendStage_Offset;
    public UnrealSharp.Engine.ESubmixSendStage SendStage;
    
    // ObjectProperty /Script/Engine.SoundSubmixSendInfo:SoundSubmix
    static readonly int SoundSubmix_Offset;
    public UnrealSharp.Engine.SoundSubmixBase SoundSubmix;
    
    // FloatProperty /Script/Engine.SoundSubmixSendInfo:SendLevel
    static readonly int SendLevel_Offset;
    public float SendLevel;
    
    // BoolProperty /Script/Engine.SoundSubmixSendInfo:DisableManualSendClamp
    static readonly int DisableManualSendClamp_Offset;
    public bool DisableManualSendClamp;
    
    // FloatProperty /Script/Engine.SoundSubmixSendInfo:MinSendLevel
    static readonly int MinSendLevel_Offset;
    public float MinSendLevel;
    
    // FloatProperty /Script/Engine.SoundSubmixSendInfo:MaxSendLevel
    static readonly int MaxSendLevel_Offset;
    public float MaxSendLevel;
    
    // FloatProperty /Script/Engine.SoundSubmixSendInfo:MinSendDistance
    static readonly int MinSendDistance_Offset;
    public float MinSendDistance;
    
    // FloatProperty /Script/Engine.SoundSubmixSendInfo:MaxSendDistance
    static readonly int MaxSendDistance_Offset;
    public float MaxSendDistance;
    
    // StructProperty /Script/Engine.SoundSubmixSendInfo:CustomSendLevelCurve
    static readonly int CustomSendLevelCurve_Offset;
    public UnrealSharp.Engine.RuntimeFloatCurve CustomSendLevelCurve;
    
    
    public static readonly int NativeDataSize;
    static SoundSubmixSendInfo()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("SoundSubmixSendInfo");
        
        SendLevelControlMethod_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SendLevelControlMethod");
        SendStage_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SendStage");
        SoundSubmix_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SoundSubmix");
        SendLevel_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SendLevel");
        DisableManualSendClamp_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DisableManualSendClamp");
        MinSendLevel_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MinSendLevel");
        MaxSendLevel_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MaxSendLevel");
        MinSendDistance_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MinSendDistance");
        MaxSendDistance_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MaxSendDistance");
        CustomSendLevelCurve_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "CustomSendLevelCurve");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public SoundSubmixSendInfo(IntPtr InNativeStruct)
    {
        unsafe
        {
            SendLevelControlMethod = BlittableMarshaller<UnrealSharp.Engine.ESendLevelControlMethod>.FromNative(IntPtr.Add(InNativeStruct, SendLevelControlMethod_Offset), 0, null);
            SendStage = BlittableMarshaller<UnrealSharp.Engine.ESubmixSendStage>.FromNative(IntPtr.Add(InNativeStruct, SendStage_Offset), 0, null);
            SoundSubmix = ObjectMarshaller<UnrealSharp.Engine.SoundSubmixBase>.FromNative(IntPtr.Add(InNativeStruct, SoundSubmix_Offset), 0, null);
            SendLevel = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, SendLevel_Offset), 0, null);
            DisableManualSendClamp = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, DisableManualSendClamp_Offset), 0, null);
            MinSendLevel = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, MinSendLevel_Offset), 0, null);
            MaxSendLevel = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, MaxSendLevel_Offset), 0, null);
            MinSendDistance = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, MinSendDistance_Offset), 0, null);
            MaxSendDistance = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, MaxSendDistance_Offset), 0, null);
            CustomSendLevelCurve = UnrealSharp.Engine.RuntimeFloatCurveMarshaler.FromNative(IntPtr.Add(InNativeStruct, CustomSendLevelCurve_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.Engine.ESendLevelControlMethod>.ToNative(IntPtr.Add(Buffer, SendLevelControlMethod_Offset), 0, null, SendLevelControlMethod);
            BlittableMarshaller<UnrealSharp.Engine.ESubmixSendStage>.ToNative(IntPtr.Add(Buffer, SendStage_Offset), 0, null, SendStage);
            ObjectMarshaller<UnrealSharp.Engine.SoundSubmixBase>.ToNative(IntPtr.Add(Buffer, SoundSubmix_Offset), 0, null, SoundSubmix);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, SendLevel_Offset), 0, null, SendLevel);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, DisableManualSendClamp_Offset), 0, null, DisableManualSendClamp);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, MinSendLevel_Offset), 0, null, MinSendLevel);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, MaxSendLevel_Offset), 0, null, MaxSendLevel);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, MinSendDistance_Offset), 0, null, MinSendDistance);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, MaxSendDistance_Offset), 0, null, MaxSendDistance);
            UnrealSharp.Engine.RuntimeFloatCurveMarshaler.ToNative(IntPtr.Add(Buffer, CustomSendLevelCurve_Offset), 0, null, CustomSendLevelCurve);
        }
    }
}

public static class SoundSubmixSendInfoMarshaler
{
    public static SoundSubmixSendInfo FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new SoundSubmixSendInfo(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, SoundSubmixSendInfo obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return SoundSubmixSendInfo.NativeDataSize;
    }
}