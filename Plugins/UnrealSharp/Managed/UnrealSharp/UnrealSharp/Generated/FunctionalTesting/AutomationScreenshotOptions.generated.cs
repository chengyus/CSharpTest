using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.FunctionalTesting;

[UStruct]
public partial struct AutomationScreenshotOptions
{
    // StructProperty /Script/FunctionalTesting.AutomationScreenshotOptions:Resolution
    static readonly int Resolution_Offset;
    public System.DoubleNumerics.Vector2 Resolution;
    
    // FloatProperty /Script/FunctionalTesting.AutomationScreenshotOptions:Delay
    static readonly int Delay_Offset;
    public float Delay;
    
    // IntProperty /Script/FunctionalTesting.AutomationScreenshotOptions:FrameDelay
    static readonly int FrameDelay_Offset;
    public int FrameDelay;
    
    // BoolProperty /Script/FunctionalTesting.AutomationScreenshotOptions:bOverride_OverrideTimeTo
    static readonly int bOverride_OverrideTimeTo_Offset;
    public bool Override_OverrideTimeTo;
    
    // DoubleProperty /Script/FunctionalTesting.AutomationScreenshotOptions:OverrideTimeTo
    static readonly int OverrideTimeTo_Offset;
    public double OverrideTimeTo;
    
    // BoolProperty /Script/FunctionalTesting.AutomationScreenshotOptions:bDisableNoisyRenderingFeatures
    static readonly int bDisableNoisyRenderingFeatures_Offset;
    public bool DisableNoisyRenderingFeatures;
    
    // BoolProperty /Script/FunctionalTesting.AutomationScreenshotOptions:bDisableTonemapping
    static readonly int bDisableTonemapping_Offset;
    public bool DisableTonemapping;
    
    // ObjectProperty /Script/FunctionalTesting.AutomationScreenshotOptions:ViewSettings
    static readonly int ViewSettings_Offset;
    public UnrealSharp.FunctionalTesting.AutomationViewSettings ViewSettings;
    
    // NameProperty /Script/FunctionalTesting.AutomationScreenshotOptions:VisualizeBuffer
    static readonly int VisualizeBuffer_Offset;
    public Name VisualizeBuffer;
    
    // EnumProperty /Script/FunctionalTesting.AutomationScreenshotOptions:Tolerance
    static readonly int Tolerance_Offset;
    public UnrealSharp.FunctionalTesting.EComparisonTolerance Tolerance;
    
    // StructProperty /Script/FunctionalTesting.AutomationScreenshotOptions:ToleranceAmount
    static readonly int ToleranceAmount_Offset;
    public UnrealSharp.FunctionalTesting.ComparisonToleranceAmount ToleranceAmount;
    
    // FloatProperty /Script/FunctionalTesting.AutomationScreenshotOptions:MaximumLocalError
    static readonly int MaximumLocalError_Offset;
    public float MaximumLocalError;
    
    // FloatProperty /Script/FunctionalTesting.AutomationScreenshotOptions:MaximumGlobalError
    static readonly int MaximumGlobalError_Offset;
    public float MaximumGlobalError;
    
    // BoolProperty /Script/FunctionalTesting.AutomationScreenshotOptions:bIgnoreAntiAliasing
    static readonly int bIgnoreAntiAliasing_Offset;
    public bool IgnoreAntiAliasing;
    
    // BoolProperty /Script/FunctionalTesting.AutomationScreenshotOptions:bIgnoreColors
    static readonly int bIgnoreColors_Offset;
    public bool IgnoreColors;
    
    
    public static readonly int NativeDataSize;
    static AutomationScreenshotOptions()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("AutomationScreenshotOptions");
        
        Resolution_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Resolution");
        Delay_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Delay");
        FrameDelay_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FrameDelay");
        bOverride_OverrideTimeTo_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_OverrideTimeTo");
        OverrideTimeTo_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "OverrideTimeTo");
        bDisableNoisyRenderingFeatures_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bDisableNoisyRenderingFeatures");
        bDisableTonemapping_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bDisableTonemapping");
        ViewSettings_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ViewSettings");
        VisualizeBuffer_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "VisualizeBuffer");
        Tolerance_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Tolerance");
        ToleranceAmount_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ToleranceAmount");
        MaximumLocalError_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MaximumLocalError");
        MaximumGlobalError_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MaximumGlobalError");
        bIgnoreAntiAliasing_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bIgnoreAntiAliasing");
        bIgnoreColors_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bIgnoreColors");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public AutomationScreenshotOptions(IntPtr InNativeStruct)
    {
        unsafe
        {
            Resolution = BlittableMarshaller<System.DoubleNumerics.Vector2>.FromNative(IntPtr.Add(InNativeStruct, Resolution_Offset), 0, null);
            Delay = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Delay_Offset), 0, null);
            FrameDelay = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, FrameDelay_Offset), 0, null);
            Override_OverrideTimeTo = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bOverride_OverrideTimeTo_Offset), 0, null);
            OverrideTimeTo = BlittableMarshaller<double>.FromNative(IntPtr.Add(InNativeStruct, OverrideTimeTo_Offset), 0, null);
            DisableNoisyRenderingFeatures = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bDisableNoisyRenderingFeatures_Offset), 0, null);
            DisableTonemapping = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bDisableTonemapping_Offset), 0, null);
            ViewSettings = ObjectMarshaller<UnrealSharp.FunctionalTesting.AutomationViewSettings>.FromNative(IntPtr.Add(InNativeStruct, ViewSettings_Offset), 0, null);
            VisualizeBuffer = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, VisualizeBuffer_Offset), 0, null);
            Tolerance = BlittableMarshaller<UnrealSharp.FunctionalTesting.EComparisonTolerance>.FromNative(IntPtr.Add(InNativeStruct, Tolerance_Offset), 0, null);
            ToleranceAmount = UnrealSharp.FunctionalTesting.ComparisonToleranceAmountMarshaler.FromNative(IntPtr.Add(InNativeStruct, ToleranceAmount_Offset), 0, null);
            MaximumLocalError = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, MaximumLocalError_Offset), 0, null);
            MaximumGlobalError = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, MaximumGlobalError_Offset), 0, null);
            IgnoreAntiAliasing = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bIgnoreAntiAliasing_Offset), 0, null);
            IgnoreColors = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bIgnoreColors_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<System.DoubleNumerics.Vector2>.ToNative(IntPtr.Add(Buffer, Resolution_Offset), 0, null, Resolution);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Delay_Offset), 0, null, Delay);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, FrameDelay_Offset), 0, null, FrameDelay);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bOverride_OverrideTimeTo_Offset), 0, null, Override_OverrideTimeTo);
            BlittableMarshaller<double>.ToNative(IntPtr.Add(Buffer, OverrideTimeTo_Offset), 0, null, OverrideTimeTo);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bDisableNoisyRenderingFeatures_Offset), 0, null, DisableNoisyRenderingFeatures);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bDisableTonemapping_Offset), 0, null, DisableTonemapping);
            ObjectMarshaller<UnrealSharp.FunctionalTesting.AutomationViewSettings>.ToNative(IntPtr.Add(Buffer, ViewSettings_Offset), 0, null, ViewSettings);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, VisualizeBuffer_Offset), 0, null, VisualizeBuffer);
            BlittableMarshaller<UnrealSharp.FunctionalTesting.EComparisonTolerance>.ToNative(IntPtr.Add(Buffer, Tolerance_Offset), 0, null, Tolerance);
            UnrealSharp.FunctionalTesting.ComparisonToleranceAmountMarshaler.ToNative(IntPtr.Add(Buffer, ToleranceAmount_Offset), 0, null, ToleranceAmount);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, MaximumLocalError_Offset), 0, null, MaximumLocalError);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, MaximumGlobalError_Offset), 0, null, MaximumGlobalError);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bIgnoreAntiAliasing_Offset), 0, null, IgnoreAntiAliasing);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bIgnoreColors_Offset), 0, null, IgnoreColors);
        }
    }
}

public static class AutomationScreenshotOptionsMarshaler
{
    public static AutomationScreenshotOptions FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new AutomationScreenshotOptions(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, AutomationScreenshotOptions obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return AutomationScreenshotOptions.NativeDataSize;
    }
}