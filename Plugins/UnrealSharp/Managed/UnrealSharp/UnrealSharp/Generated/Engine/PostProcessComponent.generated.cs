// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UClass]
public partial class PostProcessComponent : UnrealSharp.Engine.SceneComponent
{
    
    static PostProcessComponent()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("PostProcessComponent");
        
        Settings_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Settings");
        Priority_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Priority");
        BlendRadius_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BlendRadius");
        BlendWeight_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BlendWeight");
        bEnabled_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bEnabled");
        bEnabled_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bEnabled");
        bUnbound_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bUnbound");
        bUnbound_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bUnbound");
        
        
        
    }
    
    protected PostProcessComponent(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // StructProperty /Script/Engine.PostProcessComponent:Settings
    static readonly int Settings_Offset;
    
    public UnrealSharp.Engine.PostProcessSettings Settings
    {
        get
        {
            CheckObjectForValidity();
            return UnrealSharp.Engine.PostProcessSettingsMarshaler.FromNative(IntPtr.Add(NativeObject, Settings_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            UnrealSharp.Engine.PostProcessSettingsMarshaler.ToNative(IntPtr.Add(NativeObject, Settings_Offset), 0, this, value);
        }
    }
    
    // FloatProperty /Script/Engine.PostProcessComponent:Priority
    static readonly int Priority_Offset;
    
    public float Priority
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, Priority_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<float>.ToNative(IntPtr.Add(NativeObject, Priority_Offset), 0, this, value);
        }
    }
    
    // FloatProperty /Script/Engine.PostProcessComponent:BlendRadius
    static readonly int BlendRadius_Offset;
    
    public float BlendRadius
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, BlendRadius_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<float>.ToNative(IntPtr.Add(NativeObject, BlendRadius_Offset), 0, this, value);
        }
    }
    
    // FloatProperty /Script/Engine.PostProcessComponent:BlendWeight
    static readonly int BlendWeight_Offset;
    
    public float BlendWeight
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, BlendWeight_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<float>.ToNative(IntPtr.Add(NativeObject, BlendWeight_Offset), 0, this, value);
        }
    }
    
    // BoolProperty /Script/Engine.PostProcessComponent:bEnabled
    static readonly int bEnabled_Offset;
    static readonly IntPtr bEnabled_NativeProperty;
    
    public bool bEnabled
    {
        get
        {
            CheckObjectForValidity();
            return FBoolPropertyExporter.CallGetBitfieldValueFromProperty(NativeObject, bEnabled_NativeProperty, bEnabled_Offset);
        }
        set
        {
            CheckObjectForValidity();
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(NativeObject, bEnabled_NativeProperty, bEnabled_Offset, value);
        }
    }
    
    // BoolProperty /Script/Engine.PostProcessComponent:bUnbound
    static readonly int bUnbound_Offset;
    static readonly IntPtr bUnbound_NativeProperty;
    
    public bool bUnbound
    {
        get
        {
            CheckObjectForValidity();
            return FBoolPropertyExporter.CallGetBitfieldValueFromProperty(NativeObject, bUnbound_NativeProperty, bUnbound_Offset);
        }
        set
        {
            CheckObjectForValidity();
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(NativeObject, bUnbound_NativeProperty, bUnbound_Offset, value);
        }
    }
    
    
}