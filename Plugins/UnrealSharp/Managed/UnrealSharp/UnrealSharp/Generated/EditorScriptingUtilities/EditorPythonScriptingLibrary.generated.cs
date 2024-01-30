// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.EditorScriptingUtilities;

[UClass]
public partial class EditorPythonScripting : UnrealSharp.Engine.BlueprintFunctionLibrary
{
    
    static readonly IntPtr NativeClassPtr;
    static EditorPythonScripting()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("EditorPythonScriptingLibrary");
        
        
        SetKeepPythonScriptAlive_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetKeepPythonScriptAlive");
        SetKeepPythonScriptAlive_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetKeepPythonScriptAlive_NativeFunction);
        SetKeepPythonScriptAlive_bNewKeepAlive_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetKeepPythonScriptAlive_NativeFunction, "bNewKeepAlive");
        GetKeepPythonScriptAlive_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetKeepPythonScriptAlive");
        GetKeepPythonScriptAlive_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetKeepPythonScriptAlive_NativeFunction);
        GetKeepPythonScriptAlive_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetKeepPythonScriptAlive_NativeFunction, "ReturnValue");
        
        
    }
    
    protected EditorPythonScripting(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // Function /Script/EditorScriptingUtilities.EditorPythonScriptingLibrary:SetKeepPythonScriptAlive
    static readonly IntPtr SetKeepPythonScriptAlive_NativeFunction;
    static readonly int SetKeepPythonScriptAlive_ParamsSize;
    static readonly int SetKeepPythonScriptAlive_bNewKeepAlive_Offset;
    
    public static void SetKeepPythonScriptAlive(bool bNewKeepAlive)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetKeepPythonScriptAlive_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BoolMarshaller.ToNative(IntPtr.Add(ParamsBuffer, SetKeepPythonScriptAlive_bNewKeepAlive_Offset), 0, null, bNewKeepAlive);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, SetKeepPythonScriptAlive_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/EditorScriptingUtilities.EditorPythonScriptingLibrary:GetKeepPythonScriptAlive
    static readonly IntPtr GetKeepPythonScriptAlive_NativeFunction;
    static readonly int GetKeepPythonScriptAlive_ParamsSize;
    static readonly int GetKeepPythonScriptAlive_ReturnValue_Offset;
    
    public static bool GetKeepPythonScriptAlive()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetKeepPythonScriptAlive_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, GetKeepPythonScriptAlive_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, GetKeepPythonScriptAlive_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    
}