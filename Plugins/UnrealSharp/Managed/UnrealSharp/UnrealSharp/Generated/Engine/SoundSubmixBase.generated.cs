// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UClass]
abstract public partial class SoundSubmixBase : UnrealSharp.CoreUObject.Object
{
    
    static SoundSubmixBase()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("SoundSubmixBase");
        
        bAutoDisable_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bAutoDisable");
        AutoDisableTime_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AutoDisableTime");
        ChildSubmixes_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ChildSubmixes");
        ChildSubmixes_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "ChildSubmixes");
        
        
        
    }
    
    protected SoundSubmixBase(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // BoolProperty /Script/Engine.SoundSubmixBase:bAutoDisable
    static readonly int bAutoDisable_Offset;
    
    public bool bAutoDisable
    {
        get
        {
            CheckObjectForValidity();
            return BoolMarshaller.FromNative(IntPtr.Add(NativeObject, bAutoDisable_Offset), 0, this);
        }
    }
    
    // FloatProperty /Script/Engine.SoundSubmixBase:AutoDisableTime
    static readonly int AutoDisableTime_Offset;
    
    public float AutoDisableTime
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, AutoDisableTime_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<float>.ToNative(IntPtr.Add(NativeObject, AutoDisableTime_Offset), 0, this, value);
        }
    }
    
    // ArrayProperty /Script/Engine.SoundSubmixBase:ChildSubmixes
    static readonly int ChildSubmixes_Offset;
    static readonly IntPtr ChildSubmixes_NativeProperty;
    UnrealArrayReadOnlyMarshaler<UnrealSharp.Engine.SoundSubmixBase> ChildSubmixes_Wrapper = null;
    
    public System.Collections.Generic.IReadOnlyList<UnrealSharp.Engine.SoundSubmixBase> ChildSubmixes
    {
        get
        {
            if(ChildSubmixes_Wrapper == null)
            {
                ChildSubmixes_Wrapper = new UnrealArrayReadOnlyMarshaler<UnrealSharp.Engine.SoundSubmixBase>(1, ChildSubmixes_NativeProperty, ObjectMarshaller<UnrealSharp.Engine.SoundSubmixBase>.ToNative, ObjectMarshaller<UnrealSharp.Engine.SoundSubmixBase>.FromNative);
            }
            
            return ChildSubmixes_Wrapper.FromNative(IntPtr.Add(NativeObject,ChildSubmixes_Offset),0,this);
        }
    }
    
    
}