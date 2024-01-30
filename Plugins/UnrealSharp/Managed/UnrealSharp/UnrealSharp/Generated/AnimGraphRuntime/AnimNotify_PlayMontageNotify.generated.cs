// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AnimGraphRuntime;

[UClass]
public partial class AnimNotify_PlayMontageNotify : UnrealSharp.Engine.AnimNotify
{
    
    static AnimNotify_PlayMontageNotify()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("AnimNotify_PlayMontageNotify");
        
        NotifyName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "NotifyName");
        
        
        
    }
    
    protected AnimNotify_PlayMontageNotify(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // NameProperty /Script/AnimGraphRuntime.AnimNotify_PlayMontageNotify:NotifyName
    static readonly int NotifyName_Offset;
    
    public Name NotifyName
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<Name>.FromNative(IntPtr.Add(NativeObject, NotifyName_Offset), 0, this);
        }
    }
    
    
}