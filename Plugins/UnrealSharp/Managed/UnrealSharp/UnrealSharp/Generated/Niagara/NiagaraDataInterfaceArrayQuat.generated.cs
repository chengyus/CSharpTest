// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Niagara;

[UClass]
public partial class NiagaraDataInterfaceArrayQuat : UnrealSharp.Niagara.NiagaraDataInterfaceArray
{
    
    static NiagaraDataInterfaceArrayQuat()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("NiagaraDataInterfaceArrayQuat");
        
        QuatData_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "QuatData");
        QuatData_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "QuatData");
        
        
        
    }
    
    protected NiagaraDataInterfaceArrayQuat(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // ArrayProperty /Script/Niagara.NiagaraDataInterfaceArrayQuat:QuatData
    static readonly int QuatData_Offset;
    static readonly IntPtr QuatData_NativeProperty;
    UnrealArrayReadWriteMarshaler<System.DoubleNumerics.Quaternion> QuatData_Wrapper = null;
    
    public System.Collections.Generic.IList<System.DoubleNumerics.Quaternion> QuatData
    {
        get
        {
            if(QuatData_Wrapper == null)
            {
                QuatData_Wrapper = new UnrealArrayReadWriteMarshaler<System.DoubleNumerics.Quaternion>(1, QuatData_NativeProperty, BlittableMarshaller<System.DoubleNumerics.Quaternion>.ToNative, BlittableMarshaller<System.DoubleNumerics.Quaternion>.FromNative);
            }
            
            return QuatData_Wrapper.FromNative(IntPtr.Add(NativeObject,QuatData_Offset),0,this);
        }
    }
    
    
}