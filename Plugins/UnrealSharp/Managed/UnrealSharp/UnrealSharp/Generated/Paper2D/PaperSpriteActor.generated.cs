// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Paper2D;

[UClass]
public partial class PaperSpriteActor : UnrealSharp.Engine.Actor
{
    
    static PaperSpriteActor()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("PaperSpriteActor");
        
        RenderComponent_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "RenderComponent");
        
        
        
    }
    
    protected PaperSpriteActor(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // ObjectProperty /Script/Paper2D.PaperSpriteActor:RenderComponent
    static readonly int RenderComponent_Offset;
    
    public UnrealSharp.Paper2D.PaperSpriteComponent RenderComponent
    {
        get
        {
            CheckObjectForValidity();
            return ObjectMarshaller<UnrealSharp.Paper2D.PaperSpriteComponent>.FromNative(IntPtr.Add(NativeObject, RenderComponent_Offset), 0, this);
        }
    }
    
    
}