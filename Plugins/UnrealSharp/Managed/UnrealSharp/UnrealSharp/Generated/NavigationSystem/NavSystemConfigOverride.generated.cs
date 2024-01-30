// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.NavigationSystem;

[UClass]
public partial class NavSystemConfigOverride : UnrealSharp.Engine.Actor
{
    
    static NavSystemConfigOverride()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("NavSystemConfigOverride");
        
        NavigationSystemConfig_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "NavigationSystemConfig");
        OverridePolicy_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "OverridePolicy");
        bLoadOnClient_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bLoadOnClient");
        bLoadOnClient_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bLoadOnClient");
        
        
        
    }
    
    protected NavSystemConfigOverride(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // ObjectProperty /Script/NavigationSystem.NavSystemConfigOverride:NavigationSystemConfig
    static readonly int NavigationSystemConfig_Offset;
    
    public UnrealSharp.Engine.NavigationSystemConfig NavigationSystemConfig
    {
        get
        {
            CheckObjectForValidity();
            return ObjectMarshaller<UnrealSharp.Engine.NavigationSystemConfig>.FromNative(IntPtr.Add(NativeObject, NavigationSystemConfig_Offset), 0, this);
        }
    }
    
    // EnumProperty /Script/NavigationSystem.NavSystemConfigOverride:OverridePolicy
    static readonly int OverridePolicy_Offset;
    
    public UnrealSharp.NavigationSystem.ENavSystemOverridePolicy OverridePolicy
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<UnrealSharp.NavigationSystem.ENavSystemOverridePolicy>.FromNative(IntPtr.Add(NativeObject, OverridePolicy_Offset), 0, this);
        }
    }
    
    // BoolProperty /Script/NavigationSystem.NavSystemConfigOverride:bLoadOnClient
    static readonly int bLoadOnClient_Offset;
    static readonly IntPtr bLoadOnClient_NativeProperty;
    
    public bool bLoadOnClient
    {
        get
        {
            CheckObjectForValidity();
            return FBoolPropertyExporter.CallGetBitfieldValueFromProperty(NativeObject, bLoadOnClient_NativeProperty, bLoadOnClient_Offset);
        }
        set
        {
            CheckObjectForValidity();
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(NativeObject, bLoadOnClient_NativeProperty, bLoadOnClient_Offset, value);
        }
    }
    
    
}