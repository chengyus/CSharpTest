// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UClass]
public partial class TargetPoint : UnrealSharp.Engine.Actor
{
    
    static TargetPoint()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("TargetPoint");
        
        SpriteComponent_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SpriteComponent");
        ArrowComponent_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ArrowComponent");
        
        
        
    }
    
    protected TargetPoint(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // ObjectProperty /Script/Engine.TargetPoint:SpriteComponent
    static readonly int SpriteComponent_Offset;
    
    public UnrealSharp.Engine.BillboardComponent SpriteComponent
    {
        get
        {
            CheckObjectForValidity();
            return ObjectMarshaller<UnrealSharp.Engine.BillboardComponent>.FromNative(IntPtr.Add(NativeObject, SpriteComponent_Offset), 0, this);
        }
    }
    
    // ObjectProperty /Script/Engine.TargetPoint:ArrowComponent
    static readonly int ArrowComponent_Offset;
    
    public UnrealSharp.Engine.ArrowComponent ArrowComponent
    {
        get
        {
            CheckObjectForValidity();
            return ObjectMarshaller<UnrealSharp.Engine.ArrowComponent>.FromNative(IntPtr.Add(NativeObject, ArrowComponent_Offset), 0, this);
        }
    }
    
    
}