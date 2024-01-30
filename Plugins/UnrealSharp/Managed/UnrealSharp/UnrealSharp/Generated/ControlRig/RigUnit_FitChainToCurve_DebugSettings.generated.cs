using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_FitChainToCurve_DebugSettings
{
    // BoolProperty /Script/ControlRig.RigUnit_FitChainToCurve_DebugSettings:bEnabled
    static readonly int bEnabled_Offset;
    public bool Enabled;
    
    // FloatProperty /Script/ControlRig.RigUnit_FitChainToCurve_DebugSettings:Scale
    static readonly int Scale_Offset;
    public float Scale;
    
    // StructProperty /Script/ControlRig.RigUnit_FitChainToCurve_DebugSettings:CurveColor
    static readonly int CurveColor_Offset;
    public UnrealSharp.CoreUObject.LinearColor CurveColor;
    
    // StructProperty /Script/ControlRig.RigUnit_FitChainToCurve_DebugSettings:SegmentsColor
    static readonly int SegmentsColor_Offset;
    public UnrealSharp.CoreUObject.LinearColor SegmentsColor;
    
    // StructProperty /Script/ControlRig.RigUnit_FitChainToCurve_DebugSettings:WorldOffset
    static readonly int WorldOffset_Offset;
    public UnrealSharp.Transform WorldOffset;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_FitChainToCurve_DebugSettings()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_FitChainToCurve_DebugSettings");
        
        bEnabled_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bEnabled");
        Scale_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Scale");
        CurveColor_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "CurveColor");
        SegmentsColor_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SegmentsColor");
        WorldOffset_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "WorldOffset");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_FitChainToCurve_DebugSettings(IntPtr InNativeStruct)
    {
        unsafe
        {
            Enabled = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bEnabled_Offset), 0, null);
            Scale = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Scale_Offset), 0, null);
            CurveColor = BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.FromNative(IntPtr.Add(InNativeStruct, CurveColor_Offset), 0, null);
            SegmentsColor = BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.FromNative(IntPtr.Add(InNativeStruct, SegmentsColor_Offset), 0, null);
            WorldOffset = BlittableMarshaller<UnrealSharp.Transform>.FromNative(IntPtr.Add(InNativeStruct, WorldOffset_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bEnabled_Offset), 0, null, Enabled);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Scale_Offset), 0, null, Scale);
            BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.ToNative(IntPtr.Add(Buffer, CurveColor_Offset), 0, null, CurveColor);
            BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.ToNative(IntPtr.Add(Buffer, SegmentsColor_Offset), 0, null, SegmentsColor);
            BlittableMarshaller<UnrealSharp.Transform>.ToNative(IntPtr.Add(Buffer, WorldOffset_Offset), 0, null, WorldOffset);
        }
    }
}

public static class RigUnit_FitChainToCurve_DebugSettingsMarshaler
{
    public static RigUnit_FitChainToCurve_DebugSettings FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_FitChainToCurve_DebugSettings(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_FitChainToCurve_DebugSettings obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_FitChainToCurve_DebugSettings.NativeDataSize;
    }
}