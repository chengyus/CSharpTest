// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UClass]
public partial class TextRenderActor : UnrealSharp.Engine.Actor
{
    
    static TextRenderActor()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("TextRenderActor");
        
        TextRender_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "TextRender");
        
        
        
    }
    
    protected TextRenderActor(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // ObjectProperty /Script/Engine.TextRenderActor:TextRender
    static readonly int TextRender_Offset;
    
    public UnrealSharp.Engine.TextRenderComponent TextRender
    {
        get
        {
            CheckObjectForValidity();
            return ObjectMarshaller<UnrealSharp.Engine.TextRenderComponent>.FromNative(IntPtr.Add(NativeObject, TextRender_Offset), 0, this);
        }
    }
    
    
}