// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Paper2D;

[UClass]
public partial class PaperTerrainActor : UnrealSharp.Engine.Actor
{
    
    static PaperTerrainActor()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("PaperTerrainActor");
        
        RenderComponent_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "RenderComponent");
        
        
        
    }
    
    protected PaperTerrainActor(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // ObjectProperty /Script/Paper2D.PaperTerrainActor:RenderComponent
    static readonly int RenderComponent_Offset;
    
    public UnrealSharp.Paper2D.PaperTerrainComponent RenderComponent
    {
        get
        {
            CheckObjectForValidity();
            return ObjectMarshaller<UnrealSharp.Paper2D.PaperTerrainComponent>.FromNative(IntPtr.Add(NativeObject, RenderComponent_Offset), 0, this);
        }
    }
    
    
}