// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.GLTFExporter;

[UClass]
public partial class GLTFProxyOptions : UnrealSharp.CoreUObject.Object
{
    
    static GLTFProxyOptions()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("GLTFProxyOptions");
        
        bBakeMaterialInputs_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bBakeMaterialInputs");
        DefaultMaterialBakeSize_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DefaultMaterialBakeSize");
        DefaultMaterialBakeFilter_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DefaultMaterialBakeFilter");
        DefaultMaterialBakeTiling_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DefaultMaterialBakeTiling");
        
        ResetToDefault_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "ResetToDefault");
        
        
    }
    
    protected GLTFProxyOptions(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // BoolProperty /Script/GLTFExporter.GLTFProxyOptions:bBakeMaterialInputs
    static readonly int bBakeMaterialInputs_Offset;
    
    public bool bBakeMaterialInputs
    {
        get
        {
            CheckObjectForValidity();
            return BoolMarshaller.FromNative(IntPtr.Add(NativeObject, bBakeMaterialInputs_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BoolMarshaller.ToNative(IntPtr.Add(NativeObject, bBakeMaterialInputs_Offset), 0, this, value);
        }
    }
    
    // EnumProperty /Script/GLTFExporter.GLTFProxyOptions:DefaultMaterialBakeSize
    static readonly int DefaultMaterialBakeSize_Offset;
    
    public UnrealSharp.GLTFExporter.EGLTFMaterialBakeSizePOT DefaultMaterialBakeSize
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<UnrealSharp.GLTFExporter.EGLTFMaterialBakeSizePOT>.FromNative(IntPtr.Add(NativeObject, DefaultMaterialBakeSize_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<UnrealSharp.GLTFExporter.EGLTFMaterialBakeSizePOT>.ToNative(IntPtr.Add(NativeObject, DefaultMaterialBakeSize_Offset), 0, this, value);
        }
    }
    
    // ByteProperty /Script/GLTFExporter.GLTFProxyOptions:DefaultMaterialBakeFilter
    static readonly int DefaultMaterialBakeFilter_Offset;
    
    public UnrealSharp.Engine.TextureFilter DefaultMaterialBakeFilter
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<UnrealSharp.Engine.TextureFilter>.FromNative(IntPtr.Add(NativeObject, DefaultMaterialBakeFilter_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<UnrealSharp.Engine.TextureFilter>.ToNative(IntPtr.Add(NativeObject, DefaultMaterialBakeFilter_Offset), 0, this, value);
        }
    }
    
    // ByteProperty /Script/GLTFExporter.GLTFProxyOptions:DefaultMaterialBakeTiling
    static readonly int DefaultMaterialBakeTiling_Offset;
    
    public UnrealSharp.Engine.TextureAddress DefaultMaterialBakeTiling
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<UnrealSharp.Engine.TextureAddress>.FromNative(IntPtr.Add(NativeObject, DefaultMaterialBakeTiling_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<UnrealSharp.Engine.TextureAddress>.ToNative(IntPtr.Add(NativeObject, DefaultMaterialBakeTiling_Offset), 0, this, value);
        }
    }
    
    // Function /Script/GLTFExporter.GLTFProxyOptions:ResetToDefault
    static readonly IntPtr ResetToDefault_NativeFunction;
    
    public void ResetToDefault()
    {
        unsafe
        {
            UObjectExporter.CallInvokeNativeFunction(NativeObject, ResetToDefault_NativeFunction, IntPtr.Zero);
        }
    }
    
    
}