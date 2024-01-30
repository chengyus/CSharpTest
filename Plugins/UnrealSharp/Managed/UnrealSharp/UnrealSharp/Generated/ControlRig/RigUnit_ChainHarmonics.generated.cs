using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_ChainHarmonics
{
    // NameProperty /Script/ControlRig.RigUnit_ChainHarmonics:ChainRoot
    static readonly int ChainRoot_Offset;
    public Name ChainRoot;
    
    // StructProperty /Script/ControlRig.RigUnit_ChainHarmonics:Speed
    static readonly int Speed_Offset;
    public System.DoubleNumerics.Vector3 Speed;
    
    // StructProperty /Script/ControlRig.RigUnit_ChainHarmonics:Reach
    static readonly int Reach_Offset;
    public UnrealSharp.ControlRig.RigUnit_ChainHarmonics_Reach Reach;
    
    // StructProperty /Script/ControlRig.RigUnit_ChainHarmonics:Wave
    static readonly int Wave_Offset;
    public UnrealSharp.ControlRig.RigUnit_ChainHarmonics_Wave Wave;
    
    // StructProperty /Script/ControlRig.RigUnit_ChainHarmonics:WaveCurve
    static readonly int WaveCurve_Offset;
    public UnrealSharp.Engine.RuntimeFloatCurve WaveCurve;
    
    // StructProperty /Script/ControlRig.RigUnit_ChainHarmonics:Pendulum
    static readonly int Pendulum_Offset;
    public UnrealSharp.ControlRig.RigUnit_ChainHarmonics_Pendulum Pendulum;
    
    // BoolProperty /Script/ControlRig.RigUnit_ChainHarmonics:bDrawDebug
    static readonly int bDrawDebug_Offset;
    public bool DrawDebug;
    
    // StructProperty /Script/ControlRig.RigUnit_ChainHarmonics:DrawWorldOffset
    static readonly int DrawWorldOffset_Offset;
    public UnrealSharp.Transform DrawWorldOffset;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_ChainHarmonics()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_ChainHarmonics");
        
        ChainRoot_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ChainRoot");
        Speed_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Speed");
        Reach_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Reach");
        Wave_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Wave");
        WaveCurve_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "WaveCurve");
        Pendulum_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Pendulum");
        bDrawDebug_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bDrawDebug");
        DrawWorldOffset_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DrawWorldOffset");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_ChainHarmonics(IntPtr InNativeStruct)
    {
        unsafe
        {
            ChainRoot = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, ChainRoot_Offset), 0, null);
            Speed = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Speed_Offset), 0, null);
            Reach = UnrealSharp.ControlRig.RigUnit_ChainHarmonics_ReachMarshaler.FromNative(IntPtr.Add(InNativeStruct, Reach_Offset), 0, null);
            Wave = UnrealSharp.ControlRig.RigUnit_ChainHarmonics_WaveMarshaler.FromNative(IntPtr.Add(InNativeStruct, Wave_Offset), 0, null);
            WaveCurve = UnrealSharp.Engine.RuntimeFloatCurveMarshaler.FromNative(IntPtr.Add(InNativeStruct, WaveCurve_Offset), 0, null);
            Pendulum = UnrealSharp.ControlRig.RigUnit_ChainHarmonics_PendulumMarshaler.FromNative(IntPtr.Add(InNativeStruct, Pendulum_Offset), 0, null);
            DrawDebug = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bDrawDebug_Offset), 0, null);
            DrawWorldOffset = BlittableMarshaller<UnrealSharp.Transform>.FromNative(IntPtr.Add(InNativeStruct, DrawWorldOffset_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, ChainRoot_Offset), 0, null, ChainRoot);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Speed_Offset), 0, null, Speed);
            UnrealSharp.ControlRig.RigUnit_ChainHarmonics_ReachMarshaler.ToNative(IntPtr.Add(Buffer, Reach_Offset), 0, null, Reach);
            UnrealSharp.ControlRig.RigUnit_ChainHarmonics_WaveMarshaler.ToNative(IntPtr.Add(Buffer, Wave_Offset), 0, null, Wave);
            UnrealSharp.Engine.RuntimeFloatCurveMarshaler.ToNative(IntPtr.Add(Buffer, WaveCurve_Offset), 0, null, WaveCurve);
            UnrealSharp.ControlRig.RigUnit_ChainHarmonics_PendulumMarshaler.ToNative(IntPtr.Add(Buffer, Pendulum_Offset), 0, null, Pendulum);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bDrawDebug_Offset), 0, null, DrawDebug);
            BlittableMarshaller<UnrealSharp.Transform>.ToNative(IntPtr.Add(Buffer, DrawWorldOffset_Offset), 0, null, DrawWorldOffset);
        }
    }
}

public static class RigUnit_ChainHarmonicsMarshaler
{
    public static RigUnit_ChainHarmonics FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_ChainHarmonics(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_ChainHarmonics obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_ChainHarmonics.NativeDataSize;
    }
}