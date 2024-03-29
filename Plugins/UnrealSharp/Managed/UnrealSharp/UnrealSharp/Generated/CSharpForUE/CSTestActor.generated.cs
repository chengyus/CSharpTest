// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.CSharpForUE;

[UClass]
public partial class CSTestActor : UnrealSharp.Engine.Actor
{
    
    static CSTestActor()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("CSTestActor");
        
        MyTestInteger_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MyTestInteger");
        
        MyScriptMethod_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "MyScriptMethod");
        MyScriptMethod_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(MyScriptMethod_NativeFunction);
        MyScriptMethod_MyInteger_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(MyScriptMethod_NativeFunction, "MyInteger");
        MyScriptMethod_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(MyScriptMethod_NativeFunction, "ReturnValue");
        
        
    }
    
    protected CSTestActor(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // IntProperty /Script/CSharpForUE.CSTestActor:MyTestInteger
    static readonly int MyTestInteger_Offset;
    
    public int MyTestInteger
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<int>.FromNative(IntPtr.Add(NativeObject, MyTestInteger_Offset), 0, this);
        }
    }
    
    // Function /Script/CSharpForUE.CSTestActor:MyScriptMethod
    static readonly IntPtr MyScriptMethod_NativeFunction;
    static readonly int MyScriptMethod_ParamsSize;
    static readonly int MyScriptMethod_MyInteger_Offset;
    static readonly int MyScriptMethod_ReturnValue_Offset;
    
    public bool MyScriptMethod(int myInteger)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[MyScriptMethod_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<int>.ToNative(IntPtr.Add(ParamsBuffer, MyScriptMethod_MyInteger_Offset), 0, null, myInteger);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, MyScriptMethod_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, MyScriptMethod_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    
}