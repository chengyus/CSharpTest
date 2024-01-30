// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UClass]
public partial class HeterogeneousVolume : UnrealSharp.Engine.Info
{
    
    static HeterogeneousVolume()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("HeterogeneousVolume");
        
        HeterogeneousVolumeComponent_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "HeterogeneousVolumeComponent");
        
        
        
    }
    
    protected HeterogeneousVolume(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // ObjectProperty /Script/Engine.HeterogeneousVolume:HeterogeneousVolumeComponent
    static readonly int HeterogeneousVolumeComponent_Offset;
    
    public UnrealSharp.Engine.HeterogeneousVolumeComponent HeterogeneousVolumeComponent
    {
        get
        {
            CheckObjectForValidity();
            return ObjectMarshaller<UnrealSharp.Engine.HeterogeneousVolumeComponent>.FromNative(IntPtr.Add(NativeObject, HeterogeneousVolumeComponent_Offset), 0, this);
        }
    }
    
    
}