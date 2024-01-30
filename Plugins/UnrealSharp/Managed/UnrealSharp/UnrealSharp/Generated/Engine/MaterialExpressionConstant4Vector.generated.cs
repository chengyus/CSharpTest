// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UClass]
public partial class MaterialExpressionConstant4Vector : UnrealSharp.Engine.MaterialExpression
{
    
    static MaterialExpressionConstant4Vector()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("MaterialExpressionConstant4Vector");
        
        Constant_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Constant");
        
        
        
    }
    
    protected MaterialExpressionConstant4Vector(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // StructProperty /Script/Engine.MaterialExpressionConstant4Vector:Constant
    static readonly int Constant_Offset;
    
    public UnrealSharp.CoreUObject.LinearColor Constant
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.FromNative(IntPtr.Add(NativeObject, Constant_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.ToNative(IntPtr.Add(NativeObject, Constant_Offset), 0, this, value);
        }
    }
    
    
}