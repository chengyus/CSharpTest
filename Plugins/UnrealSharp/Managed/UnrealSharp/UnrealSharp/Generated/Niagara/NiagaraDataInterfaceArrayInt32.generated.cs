// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Niagara;

[UClass]
public partial class NiagaraDataInterfaceArrayInt32 : UnrealSharp.Niagara.NiagaraDataInterfaceArray
{
    
    static NiagaraDataInterfaceArrayInt32()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("NiagaraDataInterfaceArrayInt32");
        
        IntData_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "IntData");
        IntData_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "IntData");
        
        
        
    }
    
    protected NiagaraDataInterfaceArrayInt32(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // ArrayProperty /Script/Niagara.NiagaraDataInterfaceArrayInt32:IntData
    static readonly int IntData_Offset;
    static readonly IntPtr IntData_NativeProperty;
    UnrealArrayReadWriteMarshaler<int> IntData_Wrapper = null;
    
    public System.Collections.Generic.IList<int> IntData
    {
        get
        {
            if(IntData_Wrapper == null)
            {
                IntData_Wrapper = new UnrealArrayReadWriteMarshaler<int>(1, IntData_NativeProperty, BlittableMarshaller<int>.ToNative, BlittableMarshaller<int>.FromNative);
            }
            
            return IntData_Wrapper.FromNative(IntPtr.Add(NativeObject,IntData_Offset),0,this);
        }
    }
    
    
}