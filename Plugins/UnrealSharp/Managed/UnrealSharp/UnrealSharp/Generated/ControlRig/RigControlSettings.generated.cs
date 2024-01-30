using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigControlSettings
{
    // EnumProperty /Script/ControlRig.RigControlSettings:AnimationType
    static readonly int AnimationType_Offset;
    public UnrealSharp.ControlRig.ERigControlAnimationType AnimationType;
    
    // EnumProperty /Script/ControlRig.RigControlSettings:ControlType
    static readonly int ControlType_Offset;
    public UnrealSharp.ControlRig.ERigControlType ControlType;
    
    // NameProperty /Script/ControlRig.RigControlSettings:DisplayName
    static readonly int DisplayName_Offset;
    public Name DisplayName;
    
    // EnumProperty /Script/ControlRig.RigControlSettings:PrimaryAxis
    static readonly int PrimaryAxis_Offset;
    public UnrealSharp.ControlRig.ERigControlAxis PrimaryAxis;
    
    // BoolProperty /Script/ControlRig.RigControlSettings:bDrawLimits
    static readonly int bDrawLimits_Offset;
    public bool DrawLimits;
    
    // StructProperty /Script/ControlRig.RigControlSettings:MinimumValue
    static readonly int MinimumValue_Offset;
    public UnrealSharp.ControlRig.RigControlValue MinimumValue;
    
    // StructProperty /Script/ControlRig.RigControlSettings:MaximumValue
    static readonly int MaximumValue_Offset;
    public UnrealSharp.ControlRig.RigControlValue MaximumValue;
    
    // BoolProperty /Script/ControlRig.RigControlSettings:bShapeVisible
    static readonly int bShapeVisible_Offset;
    public bool ShapeVisible;
    
    // EnumProperty /Script/ControlRig.RigControlSettings:ShapeVisibility
    static readonly int ShapeVisibility_Offset;
    public UnrealSharp.ControlRig.ERigControlVisibility ShapeVisibility;
    
    // NameProperty /Script/ControlRig.RigControlSettings:ShapeName
    static readonly int ShapeName_Offset;
    public Name ShapeName;
    
    // StructProperty /Script/ControlRig.RigControlSettings:ShapeColor
    static readonly int ShapeColor_Offset;
    public UnrealSharp.CoreUObject.LinearColor ShapeColor;
    
    // BoolProperty /Script/ControlRig.RigControlSettings:bIsTransientControl
    static readonly int bIsTransientControl_Offset;
    public bool IsTransientControl;
    
    // ObjectProperty /Script/ControlRig.RigControlSettings:ControlEnum
    static readonly int ControlEnum_Offset;
    public UnrealSharp.CoreUObject.Enum ControlEnum;
    
    // StructProperty /Script/ControlRig.RigControlSettings:Customization
    static readonly int Customization_Offset;
    public UnrealSharp.ControlRig.RigControlElementCustomization Customization;
    
    // BoolProperty /Script/ControlRig.RigControlSettings:bGroupWithParentControl
    static readonly int bGroupWithParentControl_Offset;
    public bool GroupWithParentControl;
    
    // BoolProperty /Script/ControlRig.RigControlSettings:bRestrictSpaceSwitching
    static readonly int bRestrictSpaceSwitching_Offset;
    public bool RestrictSpaceSwitching;
    
    // EnumProperty /Script/ControlRig.RigControlSettings:PreferredRotationOrder
    static readonly int PreferredRotationOrder_Offset;
    public UnrealSharp.AnimationCore.EEulerRotationOrder PreferredRotationOrder;
    
    // BoolProperty /Script/ControlRig.RigControlSettings:bUsePreferredRotationOrder
    static readonly int bUsePreferredRotationOrder_Offset;
    public bool UsePreferredRotationOrder;
    
    
    public static readonly int NativeDataSize;
    static RigControlSettings()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigControlSettings");
        
        AnimationType_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AnimationType");
        ControlType_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ControlType");
        DisplayName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DisplayName");
        PrimaryAxis_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PrimaryAxis");
        bDrawLimits_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bDrawLimits");
        MinimumValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MinimumValue");
        MaximumValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MaximumValue");
        bShapeVisible_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bShapeVisible");
        ShapeVisibility_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ShapeVisibility");
        ShapeName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ShapeName");
        ShapeColor_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ShapeColor");
        bIsTransientControl_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bIsTransientControl");
        ControlEnum_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ControlEnum");
        Customization_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Customization");
        bGroupWithParentControl_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bGroupWithParentControl");
        bRestrictSpaceSwitching_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bRestrictSpaceSwitching");
        PreferredRotationOrder_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PreferredRotationOrder");
        bUsePreferredRotationOrder_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bUsePreferredRotationOrder");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigControlSettings(IntPtr InNativeStruct)
    {
        unsafe
        {
            AnimationType = BlittableMarshaller<UnrealSharp.ControlRig.ERigControlAnimationType>.FromNative(IntPtr.Add(InNativeStruct, AnimationType_Offset), 0, null);
            ControlType = BlittableMarshaller<UnrealSharp.ControlRig.ERigControlType>.FromNative(IntPtr.Add(InNativeStruct, ControlType_Offset), 0, null);
            DisplayName = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, DisplayName_Offset), 0, null);
            PrimaryAxis = BlittableMarshaller<UnrealSharp.ControlRig.ERigControlAxis>.FromNative(IntPtr.Add(InNativeStruct, PrimaryAxis_Offset), 0, null);
            DrawLimits = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bDrawLimits_Offset), 0, null);
            MinimumValue = UnrealSharp.ControlRig.RigControlValueMarshaler.FromNative(IntPtr.Add(InNativeStruct, MinimumValue_Offset), 0, null);
            MaximumValue = UnrealSharp.ControlRig.RigControlValueMarshaler.FromNative(IntPtr.Add(InNativeStruct, MaximumValue_Offset), 0, null);
            ShapeVisible = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bShapeVisible_Offset), 0, null);
            ShapeVisibility = BlittableMarshaller<UnrealSharp.ControlRig.ERigControlVisibility>.FromNative(IntPtr.Add(InNativeStruct, ShapeVisibility_Offset), 0, null);
            ShapeName = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, ShapeName_Offset), 0, null);
            ShapeColor = BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.FromNative(IntPtr.Add(InNativeStruct, ShapeColor_Offset), 0, null);
            IsTransientControl = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bIsTransientControl_Offset), 0, null);
            ControlEnum = ObjectMarshaller<UnrealSharp.CoreUObject.Enum>.FromNative(IntPtr.Add(InNativeStruct, ControlEnum_Offset), 0, null);
            Customization = UnrealSharp.ControlRig.RigControlElementCustomizationMarshaler.FromNative(IntPtr.Add(InNativeStruct, Customization_Offset), 0, null);
            GroupWithParentControl = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bGroupWithParentControl_Offset), 0, null);
            RestrictSpaceSwitching = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bRestrictSpaceSwitching_Offset), 0, null);
            PreferredRotationOrder = BlittableMarshaller<UnrealSharp.AnimationCore.EEulerRotationOrder>.FromNative(IntPtr.Add(InNativeStruct, PreferredRotationOrder_Offset), 0, null);
            UsePreferredRotationOrder = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bUsePreferredRotationOrder_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.ControlRig.ERigControlAnimationType>.ToNative(IntPtr.Add(Buffer, AnimationType_Offset), 0, null, AnimationType);
            BlittableMarshaller<UnrealSharp.ControlRig.ERigControlType>.ToNative(IntPtr.Add(Buffer, ControlType_Offset), 0, null, ControlType);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, DisplayName_Offset), 0, null, DisplayName);
            BlittableMarshaller<UnrealSharp.ControlRig.ERigControlAxis>.ToNative(IntPtr.Add(Buffer, PrimaryAxis_Offset), 0, null, PrimaryAxis);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bDrawLimits_Offset), 0, null, DrawLimits);
            UnrealSharp.ControlRig.RigControlValueMarshaler.ToNative(IntPtr.Add(Buffer, MinimumValue_Offset), 0, null, MinimumValue);
            UnrealSharp.ControlRig.RigControlValueMarshaler.ToNative(IntPtr.Add(Buffer, MaximumValue_Offset), 0, null, MaximumValue);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bShapeVisible_Offset), 0, null, ShapeVisible);
            BlittableMarshaller<UnrealSharp.ControlRig.ERigControlVisibility>.ToNative(IntPtr.Add(Buffer, ShapeVisibility_Offset), 0, null, ShapeVisibility);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, ShapeName_Offset), 0, null, ShapeName);
            BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.ToNative(IntPtr.Add(Buffer, ShapeColor_Offset), 0, null, ShapeColor);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bIsTransientControl_Offset), 0, null, IsTransientControl);
            ObjectMarshaller<UnrealSharp.CoreUObject.Enum>.ToNative(IntPtr.Add(Buffer, ControlEnum_Offset), 0, null, ControlEnum);
            UnrealSharp.ControlRig.RigControlElementCustomizationMarshaler.ToNative(IntPtr.Add(Buffer, Customization_Offset), 0, null, Customization);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bGroupWithParentControl_Offset), 0, null, GroupWithParentControl);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bRestrictSpaceSwitching_Offset), 0, null, RestrictSpaceSwitching);
            BlittableMarshaller<UnrealSharp.AnimationCore.EEulerRotationOrder>.ToNative(IntPtr.Add(Buffer, PreferredRotationOrder_Offset), 0, null, PreferredRotationOrder);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bUsePreferredRotationOrder_Offset), 0, null, UsePreferredRotationOrder);
        }
    }
}

public static class RigControlSettingsMarshaler
{
    public static RigControlSettings FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigControlSettings(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigControlSettings obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigControlSettings.NativeDataSize;
    }
}