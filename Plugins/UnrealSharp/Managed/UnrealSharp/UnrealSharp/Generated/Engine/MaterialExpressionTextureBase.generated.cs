// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UClass]
abstract public partial class MaterialExpressionTextureBase : UnrealSharp.Engine.MaterialExpression
{
    
    static MaterialExpressionTextureBase()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("MaterialExpressionTextureBase");
        
        Texture_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Texture");
        SamplerType_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SamplerType");
        
        
        
    }
    
    protected MaterialExpressionTextureBase(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // ObjectProperty /Script/Engine.MaterialExpressionTextureBase:Texture
    static readonly int Texture_Offset;
    
    public UnrealSharp.Engine.Texture Texture
    {
        get
        {
            CheckObjectForValidity();
            return ObjectMarshaller<UnrealSharp.Engine.Texture>.FromNative(IntPtr.Add(NativeObject, Texture_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            ObjectMarshaller<UnrealSharp.Engine.Texture>.ToNative(IntPtr.Add(NativeObject, Texture_Offset), 0, this, value);
        }
    }
    
    // ByteProperty /Script/Engine.MaterialExpressionTextureBase:SamplerType
    static readonly int SamplerType_Offset;
    
    public UnrealSharp.Engine.EMaterialSamplerType SamplerType
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<UnrealSharp.Engine.EMaterialSamplerType>.FromNative(IntPtr.Add(NativeObject, SamplerType_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<UnrealSharp.Engine.EMaterialSamplerType>.ToNative(IntPtr.Add(NativeObject, SamplerType_Offset), 0, this, value);
        }
    }
    
    
}