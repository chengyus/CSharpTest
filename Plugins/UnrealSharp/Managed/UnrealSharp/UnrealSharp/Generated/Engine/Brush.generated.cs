// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UClass]
public partial class Brush : UnrealSharp.Engine.Actor
{
    
    static Brush()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("Brush");
        
        BrushComponent_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BrushComponent");
        
        
        
    }
    
    protected Brush(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // ObjectProperty /Script/Engine.Brush:BrushComponent
    static readonly int BrushComponent_Offset;
    
    public UnrealSharp.Engine.BrushComponent BrushComponent
    {
        get
        {
            CheckObjectForValidity();
            return ObjectMarshaller<UnrealSharp.Engine.BrushComponent>.FromNative(IntPtr.Add(NativeObject, BrushComponent_Offset), 0, this);
        }
    }
    
    
}