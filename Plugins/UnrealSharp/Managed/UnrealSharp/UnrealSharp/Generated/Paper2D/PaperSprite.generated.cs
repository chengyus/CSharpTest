// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Paper2D;

[UClass]
public partial class PaperSprite : UnrealSharp.CoreUObject.Object
{
    
    static PaperSprite()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("PaperSprite");
        
        DefaultMaterial_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DefaultMaterial");
        AlternateMaterial_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AlternateMaterial");
        
        
        
    }
    
    protected PaperSprite(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // ObjectProperty /Script/Paper2D.PaperSprite:DefaultMaterial
    static readonly int DefaultMaterial_Offset;
    
    public UnrealSharp.Engine.MaterialInterface DefaultMaterial
    {
        get
        {
            CheckObjectForValidity();
            return ObjectMarshaller<UnrealSharp.Engine.MaterialInterface>.FromNative(IntPtr.Add(NativeObject, DefaultMaterial_Offset), 0, this);
        }
    }
    
    // ObjectProperty /Script/Paper2D.PaperSprite:AlternateMaterial
    static readonly int AlternateMaterial_Offset;
    
    public UnrealSharp.Engine.MaterialInterface AlternateMaterial
    {
        get
        {
            CheckObjectForValidity();
            return ObjectMarshaller<UnrealSharp.Engine.MaterialInterface>.FromNative(IntPtr.Add(NativeObject, AlternateMaterial_Offset), 0, this);
        }
    }
    
    
}