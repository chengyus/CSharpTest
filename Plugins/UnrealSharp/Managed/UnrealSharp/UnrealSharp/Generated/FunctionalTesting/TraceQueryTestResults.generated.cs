// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.FunctionalTesting;

[UClass]
public partial class TraceQueryTestResults : UnrealSharp.CoreUObject.Object
{
    
    static TraceQueryTestResults()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("TraceQueryTestResults");
        
        ChannelResults_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ChannelResults");
        ObjectResults_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ObjectResults");
        ProfileResults_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ProfileResults");
        BatchOptions_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BatchOptions");
        
        ToString_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "ToString");
        ToString_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(ToString_NativeFunction);
        ToString_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ToString_NativeFunction, "ReturnValue");
        
        
    }
    
    protected TraceQueryTestResults(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // StructProperty /Script/FunctionalTesting.TraceQueryTestResults:ChannelResults
    static readonly int ChannelResults_Offset;
    
    public UnrealSharp.FunctionalTesting.TraceQueryTestResultsInner ChannelResults
    {
        get
        {
            CheckObjectForValidity();
            return UnrealSharp.FunctionalTesting.TraceQueryTestResultsInnerMarshaler.FromNative(IntPtr.Add(NativeObject, ChannelResults_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            UnrealSharp.FunctionalTesting.TraceQueryTestResultsInnerMarshaler.ToNative(IntPtr.Add(NativeObject, ChannelResults_Offset), 0, this, value);
        }
    }
    
    // StructProperty /Script/FunctionalTesting.TraceQueryTestResults:ObjectResults
    static readonly int ObjectResults_Offset;
    
    public UnrealSharp.FunctionalTesting.TraceQueryTestResultsInner ObjectResults
    {
        get
        {
            CheckObjectForValidity();
            return UnrealSharp.FunctionalTesting.TraceQueryTestResultsInnerMarshaler.FromNative(IntPtr.Add(NativeObject, ObjectResults_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            UnrealSharp.FunctionalTesting.TraceQueryTestResultsInnerMarshaler.ToNative(IntPtr.Add(NativeObject, ObjectResults_Offset), 0, this, value);
        }
    }
    
    // StructProperty /Script/FunctionalTesting.TraceQueryTestResults:ProfileResults
    static readonly int ProfileResults_Offset;
    
    public UnrealSharp.FunctionalTesting.TraceQueryTestResultsInner ProfileResults
    {
        get
        {
            CheckObjectForValidity();
            return UnrealSharp.FunctionalTesting.TraceQueryTestResultsInnerMarshaler.FromNative(IntPtr.Add(NativeObject, ProfileResults_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            UnrealSharp.FunctionalTesting.TraceQueryTestResultsInnerMarshaler.ToNative(IntPtr.Add(NativeObject, ProfileResults_Offset), 0, this, value);
        }
    }
    
    // StructProperty /Script/FunctionalTesting.TraceQueryTestResults:BatchOptions
    static readonly int BatchOptions_Offset;
    
    public UnrealSharp.FunctionalTesting.TraceChannelTestBatchOptions BatchOptions
    {
        get
        {
            CheckObjectForValidity();
            return UnrealSharp.FunctionalTesting.TraceChannelTestBatchOptionsMarshaler.FromNative(IntPtr.Add(NativeObject, BatchOptions_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            UnrealSharp.FunctionalTesting.TraceChannelTestBatchOptionsMarshaler.ToNative(IntPtr.Add(NativeObject, BatchOptions_Offset), 0, this, value);
        }
    }
    
    // Function /Script/FunctionalTesting.TraceQueryTestResults:ToString
    static readonly IntPtr ToString_NativeFunction;
    static readonly int ToString_ParamsSize;
    static readonly int ToString_ReturnValue_Offset;
    
    public string ToString()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[ToString_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, ToString_NativeFunction, ParamsBuffer);
            
            string returnValue;
            IntPtr ReturnValue_NativePtr = IntPtr.Add(ParamsBuffer,ToString_ReturnValue_Offset);
            returnValue = StringMarshaller.FromNative(ReturnValue_NativePtr,0,null);
            StringMarshaller.DestructInstance(ReturnValue_NativePtr, 0);
            
            return returnValue;
        }
    }
    
    
}