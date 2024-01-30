// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UClass]
public partial class SoundCue : UnrealSharp.Engine.SoundBase
{
    
    static SoundCue()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("SoundCue");
        
        FirstNode_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FirstNode");
        VolumeMultiplier_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "VolumeMultiplier");
        PitchMultiplier_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PitchMultiplier");
        
        
        
    }
    
    protected SoundCue(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // ObjectProperty /Script/Engine.SoundCue:FirstNode
    static readonly int FirstNode_Offset;
    
    public UnrealSharp.Engine.SoundNode FirstNode
    {
        get
        {
            CheckObjectForValidity();
            return ObjectMarshaller<UnrealSharp.Engine.SoundNode>.FromNative(IntPtr.Add(NativeObject, FirstNode_Offset), 0, this);
        }
    }
    
    // FloatProperty /Script/Engine.SoundCue:VolumeMultiplier
    static readonly int VolumeMultiplier_Offset;
    
    public float VolumeMultiplier
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, VolumeMultiplier_Offset), 0, this);
        }
    }
    
    // FloatProperty /Script/Engine.SoundCue:PitchMultiplier
    static readonly int PitchMultiplier_Offset;
    
    public float PitchMultiplier
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, PitchMultiplier_Offset), 0, this);
        }
    }
    
    
}