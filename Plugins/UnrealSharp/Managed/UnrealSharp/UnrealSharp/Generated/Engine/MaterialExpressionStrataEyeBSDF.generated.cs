// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UClass]
public partial class MaterialExpressionStrataEyeBSDF : UnrealSharp.Engine.MaterialExpressionStrataBSDF
{
    
    static MaterialExpressionStrataEyeBSDF()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("MaterialExpressionStrataEyeBSDF");
        
        SubsurfaceProfile_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SubsurfaceProfile");
        
        
        
    }
    
    protected MaterialExpressionStrataEyeBSDF(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // ObjectProperty /Script/Engine.MaterialExpressionStrataEyeBSDF:SubsurfaceProfile
    static readonly int SubsurfaceProfile_Offset;
    
    public UnrealSharp.Engine.SubsurfaceProfile SubsurfaceProfile
    {
        get
        {
            CheckObjectForValidity();
            return ObjectMarshaller<UnrealSharp.Engine.SubsurfaceProfile>.FromNative(IntPtr.Add(NativeObject, SubsurfaceProfile_Offset), 0, this);
        }
    }
    
    
}