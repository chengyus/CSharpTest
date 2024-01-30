// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UClass]
public partial class AnimationSettings : UnrealSharp.DeveloperSettings.DeveloperSettings
{
    
    static AnimationSettings()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("AnimationSettings");
        
        bRaiseMaxErrorToExisting_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bRaiseMaxErrorToExisting");
        
        
        
    }
    
    protected AnimationSettings(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // BoolProperty /Script/Engine.AnimationSettings:bRaiseMaxErrorToExisting
    static readonly int bRaiseMaxErrorToExisting_Offset;
    
    public bool bRaiseMaxErrorToExisting
    {
        get
        {
            CheckObjectForValidity();
            return BoolMarshaller.FromNative(IntPtr.Add(NativeObject, bRaiseMaxErrorToExisting_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BoolMarshaller.ToNative(IntPtr.Add(NativeObject, bRaiseMaxErrorToExisting_Offset), 0, this, value);
        }
    }
    
    
}