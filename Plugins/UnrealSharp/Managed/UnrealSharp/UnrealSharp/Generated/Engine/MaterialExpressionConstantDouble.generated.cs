// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UClass]
public partial class MaterialExpressionConstantDouble : UnrealSharp.Engine.MaterialExpressionGenericConstant
{
    
    static MaterialExpressionConstantDouble()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("MaterialExpressionConstantDouble");
        
        Value_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Value");
        
        
        
    }
    
    protected MaterialExpressionConstantDouble(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // DoubleProperty /Script/Engine.MaterialExpressionConstantDouble:Value
    static readonly int Value_Offset;
    
    public double Value
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<double>.FromNative(IntPtr.Add(NativeObject, Value_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<double>.ToNative(IntPtr.Add(NativeObject, Value_Offset), 0, this, value);
        }
    }
    
    
}