// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UClass]
public partial class LightmassPortal : UnrealSharp.Engine.Actor
{
    
    static LightmassPortal()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("LightmassPortal");
        
        PortalComponent_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PortalComponent");
        
        
        
    }
    
    protected LightmassPortal(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // ObjectProperty /Script/Engine.LightmassPortal:PortalComponent
    static readonly int PortalComponent_Offset;
    
    public UnrealSharp.Engine.LightmassPortalComponent PortalComponent
    {
        get
        {
            CheckObjectForValidity();
            return ObjectMarshaller<UnrealSharp.Engine.LightmassPortalComponent>.FromNative(IntPtr.Add(NativeObject, PortalComponent_Offset), 0, this);
        }
    }
    
    
}