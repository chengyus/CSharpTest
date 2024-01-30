using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigControl
{
    // EnumProperty /Script/ControlRig.RigControl:ControlType
    static readonly int ControlType_Offset;
    public UnrealSharp.ControlRig.ERigControlType ControlType;
    
    // NameProperty /Script/ControlRig.RigControl:DisplayName
    static readonly int DisplayName_Offset;
    public Name DisplayName;
    
    // NameProperty /Script/ControlRig.RigControl:ParentName
    static readonly int ParentName_Offset;
    public Name ParentName;
    
    // IntProperty /Script/ControlRig.RigControl:ParentIndex
    static readonly int ParentIndex_Offset;
    public int ParentIndex;
    
    // NameProperty /Script/ControlRig.RigControl:SpaceName
    static readonly int SpaceName_Offset;
    public Name SpaceName;
    
    // IntProperty /Script/ControlRig.RigControl:SpaceIndex
    static readonly int SpaceIndex_Offset;
    public int SpaceIndex;
    
    // StructProperty /Script/ControlRig.RigControl:OffsetTransform
    static readonly int OffsetTransform_Offset;
    public UnrealSharp.Transform OffsetTransform;
    
    // StructProperty /Script/ControlRig.RigControl:InitialValue
    static readonly int InitialValue_Offset;
    public UnrealSharp.ControlRig.RigControlValue InitialValue;
    
    // StructProperty /Script/ControlRig.RigControl:Value
    static readonly int Value_Offset;
    public UnrealSharp.ControlRig.RigControlValue Value;
    
    // EnumProperty /Script/ControlRig.RigControl:PrimaryAxis
    static readonly int PrimaryAxis_Offset;
    public UnrealSharp.ControlRig.ERigControlAxis PrimaryAxis;
    
    // BoolProperty /Script/ControlRig.RigControl:bAnimatable
    static readonly int bAnimatable_Offset;
    public bool Animatable;
    
    // BoolProperty /Script/ControlRig.RigControl:bLimitTranslation
    static readonly int bLimitTranslation_Offset;
    public bool LimitTranslation;
    
    // BoolProperty /Script/ControlRig.RigControl:bLimitRotation
    static readonly int bLimitRotation_Offset;
    public bool LimitRotation;
    
    // BoolProperty /Script/ControlRig.RigControl:bLimitScale
    static readonly int bLimitScale_Offset;
    public bool LimitScale;
    
    // BoolProperty /Script/ControlRig.RigControl:bDrawLimits
    static readonly int bDrawLimits_Offset;
    public bool DrawLimits;
    
    // StructProperty /Script/ControlRig.RigControl:MinimumValue
    static readonly int MinimumValue_Offset;
    public UnrealSharp.ControlRig.RigControlValue MinimumValue;
    
    // StructProperty /Script/ControlRig.RigControl:MaximumValue
    static readonly int MaximumValue_Offset;
    public UnrealSharp.ControlRig.RigControlValue MaximumValue;
    
    // BoolProperty /Script/ControlRig.RigControl:bGizmoEnabled
    static readonly int bGizmoEnabled_Offset;
    public bool GizmoEnabled;
    
    // BoolProperty /Script/ControlRig.RigControl:bGizmoVisible
    static readonly int bGizmoVisible_Offset;
    public bool GizmoVisible;
    
    // NameProperty /Script/ControlRig.RigControl:GizmoName
    static readonly int GizmoName_Offset;
    public Name GizmoName;
    
    // StructProperty /Script/ControlRig.RigControl:GizmoTransform
    static readonly int GizmoTransform_Offset;
    public UnrealSharp.Transform GizmoTransform;
    
    // StructProperty /Script/ControlRig.RigControl:GizmoColor
    static readonly int GizmoColor_Offset;
    public UnrealSharp.CoreUObject.LinearColor GizmoColor;
    
    // BoolProperty /Script/ControlRig.RigControl:bIsTransientControl
    static readonly int bIsTransientControl_Offset;
    public bool IsTransientControl;
    
    // ObjectProperty /Script/ControlRig.RigControl:ControlEnum
    static readonly int ControlEnum_Offset;
    public UnrealSharp.CoreUObject.Enum ControlEnum;
    
    
    public static readonly int NativeDataSize;
    static RigControl()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigControl");
        
        ControlType_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ControlType");
        DisplayName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DisplayName");
        ParentName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ParentName");
        ParentIndex_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ParentIndex");
        SpaceName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SpaceName");
        SpaceIndex_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SpaceIndex");
        OffsetTransform_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "OffsetTransform");
        InitialValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "InitialValue");
        Value_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Value");
        PrimaryAxis_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PrimaryAxis");
        bAnimatable_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bAnimatable");
        bLimitTranslation_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bLimitTranslation");
        bLimitRotation_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bLimitRotation");
        bLimitScale_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bLimitScale");
        bDrawLimits_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bDrawLimits");
        MinimumValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MinimumValue");
        MaximumValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MaximumValue");
        bGizmoEnabled_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bGizmoEnabled");
        bGizmoVisible_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bGizmoVisible");
        GizmoName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "GizmoName");
        GizmoTransform_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "GizmoTransform");
        GizmoColor_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "GizmoColor");
        bIsTransientControl_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bIsTransientControl");
        ControlEnum_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ControlEnum");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigControl(IntPtr InNativeStruct)
    {
        unsafe
        {
            ControlType = BlittableMarshaller<UnrealSharp.ControlRig.ERigControlType>.FromNative(IntPtr.Add(InNativeStruct, ControlType_Offset), 0, null);
            DisplayName = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, DisplayName_Offset), 0, null);
            ParentName = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, ParentName_Offset), 0, null);
            ParentIndex = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, ParentIndex_Offset), 0, null);
            SpaceName = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, SpaceName_Offset), 0, null);
            SpaceIndex = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, SpaceIndex_Offset), 0, null);
            OffsetTransform = BlittableMarshaller<UnrealSharp.Transform>.FromNative(IntPtr.Add(InNativeStruct, OffsetTransform_Offset), 0, null);
            InitialValue = UnrealSharp.ControlRig.RigControlValueMarshaler.FromNative(IntPtr.Add(InNativeStruct, InitialValue_Offset), 0, null);
            Value = UnrealSharp.ControlRig.RigControlValueMarshaler.FromNative(IntPtr.Add(InNativeStruct, Value_Offset), 0, null);
            PrimaryAxis = BlittableMarshaller<UnrealSharp.ControlRig.ERigControlAxis>.FromNative(IntPtr.Add(InNativeStruct, PrimaryAxis_Offset), 0, null);
            Animatable = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bAnimatable_Offset), 0, null);
            LimitTranslation = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bLimitTranslation_Offset), 0, null);
            LimitRotation = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bLimitRotation_Offset), 0, null);
            LimitScale = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bLimitScale_Offset), 0, null);
            DrawLimits = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bDrawLimits_Offset), 0, null);
            MinimumValue = UnrealSharp.ControlRig.RigControlValueMarshaler.FromNative(IntPtr.Add(InNativeStruct, MinimumValue_Offset), 0, null);
            MaximumValue = UnrealSharp.ControlRig.RigControlValueMarshaler.FromNative(IntPtr.Add(InNativeStruct, MaximumValue_Offset), 0, null);
            GizmoEnabled = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bGizmoEnabled_Offset), 0, null);
            GizmoVisible = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bGizmoVisible_Offset), 0, null);
            GizmoName = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, GizmoName_Offset), 0, null);
            GizmoTransform = BlittableMarshaller<UnrealSharp.Transform>.FromNative(IntPtr.Add(InNativeStruct, GizmoTransform_Offset), 0, null);
            GizmoColor = BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.FromNative(IntPtr.Add(InNativeStruct, GizmoColor_Offset), 0, null);
            IsTransientControl = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bIsTransientControl_Offset), 0, null);
            ControlEnum = ObjectMarshaller<UnrealSharp.CoreUObject.Enum>.FromNative(IntPtr.Add(InNativeStruct, ControlEnum_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.ControlRig.ERigControlType>.ToNative(IntPtr.Add(Buffer, ControlType_Offset), 0, null, ControlType);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, DisplayName_Offset), 0, null, DisplayName);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, ParentName_Offset), 0, null, ParentName);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, ParentIndex_Offset), 0, null, ParentIndex);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, SpaceName_Offset), 0, null, SpaceName);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, SpaceIndex_Offset), 0, null, SpaceIndex);
            BlittableMarshaller<UnrealSharp.Transform>.ToNative(IntPtr.Add(Buffer, OffsetTransform_Offset), 0, null, OffsetTransform);
            UnrealSharp.ControlRig.RigControlValueMarshaler.ToNative(IntPtr.Add(Buffer, InitialValue_Offset), 0, null, InitialValue);
            UnrealSharp.ControlRig.RigControlValueMarshaler.ToNative(IntPtr.Add(Buffer, Value_Offset), 0, null, Value);
            BlittableMarshaller<UnrealSharp.ControlRig.ERigControlAxis>.ToNative(IntPtr.Add(Buffer, PrimaryAxis_Offset), 0, null, PrimaryAxis);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bAnimatable_Offset), 0, null, Animatable);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bLimitTranslation_Offset), 0, null, LimitTranslation);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bLimitRotation_Offset), 0, null, LimitRotation);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bLimitScale_Offset), 0, null, LimitScale);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bDrawLimits_Offset), 0, null, DrawLimits);
            UnrealSharp.ControlRig.RigControlValueMarshaler.ToNative(IntPtr.Add(Buffer, MinimumValue_Offset), 0, null, MinimumValue);
            UnrealSharp.ControlRig.RigControlValueMarshaler.ToNative(IntPtr.Add(Buffer, MaximumValue_Offset), 0, null, MaximumValue);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bGizmoEnabled_Offset), 0, null, GizmoEnabled);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bGizmoVisible_Offset), 0, null, GizmoVisible);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, GizmoName_Offset), 0, null, GizmoName);
            BlittableMarshaller<UnrealSharp.Transform>.ToNative(IntPtr.Add(Buffer, GizmoTransform_Offset), 0, null, GizmoTransform);
            BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.ToNative(IntPtr.Add(Buffer, GizmoColor_Offset), 0, null, GizmoColor);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bIsTransientControl_Offset), 0, null, IsTransientControl);
            ObjectMarshaller<UnrealSharp.CoreUObject.Enum>.ToNative(IntPtr.Add(Buffer, ControlEnum_Offset), 0, null, ControlEnum);
        }
    }
}

public static class RigControlMarshaler
{
    public static RigControl FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigControl(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigControl obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigControl.NativeDataSize;
    }
}