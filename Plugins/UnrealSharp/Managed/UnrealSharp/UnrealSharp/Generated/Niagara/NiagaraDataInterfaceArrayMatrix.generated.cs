// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Niagara;

[UClass]
public partial class NiagaraDataInterfaceArrayMatrix : UnrealSharp.Niagara.NiagaraDataInterfaceArray
{
    
    static NiagaraDataInterfaceArrayMatrix()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("NiagaraDataInterfaceArrayMatrix");
        
        MatrixData_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MatrixData");
        MatrixData_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "MatrixData");
        
        
        
    }
    
    protected NiagaraDataInterfaceArrayMatrix(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // ArrayProperty /Script/Niagara.NiagaraDataInterfaceArrayMatrix:MatrixData
    static readonly int MatrixData_Offset;
    static readonly IntPtr MatrixData_NativeProperty;
    UnrealArrayReadWriteMarshaler<System.DoubleNumerics.Matrix4x4> MatrixData_Wrapper = null;
    
    public System.Collections.Generic.IList<System.DoubleNumerics.Matrix4x4> MatrixData
    {
        get
        {
            if(MatrixData_Wrapper == null)
            {
                MatrixData_Wrapper = new UnrealArrayReadWriteMarshaler<System.DoubleNumerics.Matrix4x4>(1, MatrixData_NativeProperty, BlittableMarshaller<System.DoubleNumerics.Matrix4x4>.ToNative, BlittableMarshaller<System.DoubleNumerics.Matrix4x4>.FromNative);
            }
            
            return MatrixData_Wrapper.FromNative(IntPtr.Add(NativeObject,MatrixData_Offset),0,this);
        }
    }
    
    
}