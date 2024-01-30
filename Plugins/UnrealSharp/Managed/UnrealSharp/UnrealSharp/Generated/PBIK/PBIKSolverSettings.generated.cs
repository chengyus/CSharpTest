using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.PBIK;

[UStruct]
public partial struct PBIKSolverSettings
{
    // IntProperty /Script/PBIK.PBIKSolverSettings:Iterations
    static readonly int Iterations_Offset;
    public int Iterations;
    
    // FloatProperty /Script/PBIK.PBIKSolverSettings:MassMultiplier
    static readonly int MassMultiplier_Offset;
    public float MassMultiplier;
    
    // BoolProperty /Script/PBIK.PBIKSolverSettings:bAllowStretch
    static readonly int bAllowStretch_Offset;
    public bool AllowStretch;
    
    // EnumProperty /Script/PBIK.PBIKSolverSettings:RootBehavior
    static readonly int RootBehavior_Offset;
    public UnrealSharp.PBIK.EPBIKRootBehavior RootBehavior;
    
    // StructProperty /Script/PBIK.PBIKSolverSettings:PrePullRootSettings
    static readonly int PrePullRootSettings_Offset;
    public UnrealSharp.PBIK.RootPrePullSettings PrePullRootSettings;
    
    // FloatProperty /Script/PBIK.PBIKSolverSettings:GlobalPullChainAlpha
    static readonly int GlobalPullChainAlpha_Offset;
    public float GlobalPullChainAlpha;
    
    // FloatProperty /Script/PBIK.PBIKSolverSettings:MaxAngle
    static readonly int MaxAngle_Offset;
    public float MaxAngle;
    
    // FloatProperty /Script/PBIK.PBIKSolverSettings:OverRelaxation
    static readonly int OverRelaxation_Offset;
    public float OverRelaxation;
    
    
    public static readonly int NativeDataSize;
    static PBIKSolverSettings()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("PBIKSolverSettings");
        
        Iterations_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Iterations");
        MassMultiplier_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MassMultiplier");
        bAllowStretch_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bAllowStretch");
        RootBehavior_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "RootBehavior");
        PrePullRootSettings_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PrePullRootSettings");
        GlobalPullChainAlpha_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "GlobalPullChainAlpha");
        MaxAngle_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MaxAngle");
        OverRelaxation_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "OverRelaxation");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public PBIKSolverSettings(IntPtr InNativeStruct)
    {
        unsafe
        {
            Iterations = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, Iterations_Offset), 0, null);
            MassMultiplier = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, MassMultiplier_Offset), 0, null);
            AllowStretch = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bAllowStretch_Offset), 0, null);
            RootBehavior = BlittableMarshaller<UnrealSharp.PBIK.EPBIKRootBehavior>.FromNative(IntPtr.Add(InNativeStruct, RootBehavior_Offset), 0, null);
            PrePullRootSettings = BlittableMarshaller<UnrealSharp.PBIK.RootPrePullSettings>.FromNative(IntPtr.Add(InNativeStruct, PrePullRootSettings_Offset), 0, null);
            GlobalPullChainAlpha = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, GlobalPullChainAlpha_Offset), 0, null);
            MaxAngle = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, MaxAngle_Offset), 0, null);
            OverRelaxation = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, OverRelaxation_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, Iterations_Offset), 0, null, Iterations);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, MassMultiplier_Offset), 0, null, MassMultiplier);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bAllowStretch_Offset), 0, null, AllowStretch);
            BlittableMarshaller<UnrealSharp.PBIK.EPBIKRootBehavior>.ToNative(IntPtr.Add(Buffer, RootBehavior_Offset), 0, null, RootBehavior);
            BlittableMarshaller<UnrealSharp.PBIK.RootPrePullSettings>.ToNative(IntPtr.Add(Buffer, PrePullRootSettings_Offset), 0, null, PrePullRootSettings);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, GlobalPullChainAlpha_Offset), 0, null, GlobalPullChainAlpha);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, MaxAngle_Offset), 0, null, MaxAngle);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, OverRelaxation_Offset), 0, null, OverRelaxation);
        }
    }
}

public static class PBIKSolverSettingsMarshaler
{
    public static PBIKSolverSettings FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new PBIKSolverSettings(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, PBIKSolverSettings obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return PBIKSolverSettings.NativeDataSize;
    }
}