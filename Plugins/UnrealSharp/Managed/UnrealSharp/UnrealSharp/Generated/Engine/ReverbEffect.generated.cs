// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UClass]
public partial class ReverbEffect : UnrealSharp.CoreUObject.Object
{
    
    static ReverbEffect()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("ReverbEffect");
        
        bBypassEarlyReflections_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bBypassEarlyReflections");
        bBypassLateReflections_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bBypassLateReflections");
        
        
        
    }
    
    protected ReverbEffect(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // BoolProperty /Script/Engine.ReverbEffect:bBypassEarlyReflections
    static readonly int bBypassEarlyReflections_Offset;
    
    public bool bBypassEarlyReflections
    {
        get
        {
            CheckObjectForValidity();
            return BoolMarshaller.FromNative(IntPtr.Add(NativeObject, bBypassEarlyReflections_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BoolMarshaller.ToNative(IntPtr.Add(NativeObject, bBypassEarlyReflections_Offset), 0, this, value);
        }
    }
    
    // BoolProperty /Script/Engine.ReverbEffect:bBypassLateReflections
    static readonly int bBypassLateReflections_Offset;
    
    public bool bBypassLateReflections
    {
        get
        {
            CheckObjectForValidity();
            return BoolMarshaller.FromNative(IntPtr.Add(NativeObject, bBypassLateReflections_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BoolMarshaller.ToNative(IntPtr.Add(NativeObject, bBypassLateReflections_Offset), 0, this, value);
        }
    }
    
    
}