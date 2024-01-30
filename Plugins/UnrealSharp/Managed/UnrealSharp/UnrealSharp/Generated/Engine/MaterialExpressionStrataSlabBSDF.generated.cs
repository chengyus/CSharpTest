// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UClass]
public partial class MaterialExpressionStrataSlabBSDF : UnrealSharp.Engine.MaterialExpressionStrataBSDF
{
    
    static MaterialExpressionStrataSlabBSDF()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("MaterialExpressionStrataSlabBSDF");
        
        SubsurfaceProfile_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SubsurfaceProfile");
        SpecularProfile_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SpecularProfile");
        
        
        
    }
    
    protected MaterialExpressionStrataSlabBSDF(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // ObjectProperty /Script/Engine.MaterialExpressionStrataSlabBSDF:SubsurfaceProfile
    static readonly int SubsurfaceProfile_Offset;
    
    public UnrealSharp.Engine.SubsurfaceProfile SubsurfaceProfile
    {
        get
        {
            CheckObjectForValidity();
            return ObjectMarshaller<UnrealSharp.Engine.SubsurfaceProfile>.FromNative(IntPtr.Add(NativeObject, SubsurfaceProfile_Offset), 0, this);
        }
    }
    
    // ObjectProperty /Script/Engine.MaterialExpressionStrataSlabBSDF:SpecularProfile
    static readonly int SpecularProfile_Offset;
    
    public UnrealSharp.Engine.SpecularProfile SpecularProfile
    {
        get
        {
            CheckObjectForValidity();
            return ObjectMarshaller<UnrealSharp.Engine.SpecularProfile>.FromNative(IntPtr.Add(NativeObject, SpecularProfile_Offset), 0, this);
        }
    }
    
    
}