// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UClass]
public partial class SoundSourceBus : UnrealSharp.Engine.SoundWave
{
    
    static SoundSourceBus()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("SoundSourceBus");
        
        bAutoDeactivateWhenSilent_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bAutoDeactivateWhenSilent");
        bAutoDeactivateWhenSilent_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bAutoDeactivateWhenSilent");
        
        
        
    }
    
    protected SoundSourceBus(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // BoolProperty /Script/Engine.SoundSourceBus:bAutoDeactivateWhenSilent
    static readonly int bAutoDeactivateWhenSilent_Offset;
    static readonly IntPtr bAutoDeactivateWhenSilent_NativeProperty;
    
    public bool bAutoDeactivateWhenSilent
    {
        get
        {
            CheckObjectForValidity();
            return FBoolPropertyExporter.CallGetBitfieldValueFromProperty(NativeObject, bAutoDeactivateWhenSilent_NativeProperty, bAutoDeactivateWhenSilent_Offset);
        }
        set
        {
            CheckObjectForValidity();
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(NativeObject, bAutoDeactivateWhenSilent_NativeProperty, bAutoDeactivateWhenSilent_Offset, value);
        }
    }
    
    
}