// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.UnrealEd;

[UClass]
public partial class ReimportFbxSceneFactory : UnrealSharp.UnrealEd.FbxSceneImportFactory
{
    
    static ReimportFbxSceneFactory()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("ReimportFbxSceneFactory");
        
        
        ScriptReimportHelper_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "ScriptReimportHelper");
        ScriptReimportHelper_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(ScriptReimportHelper_NativeFunction);
        ScriptReimportHelper_Obj_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ScriptReimportHelper_NativeFunction, "Obj");
        
        
    }
    
    protected ReimportFbxSceneFactory(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // Function /Script/UnrealEd.ReimportFbxSceneFactory:ScriptReimportHelper
    static readonly IntPtr ScriptReimportHelper_NativeFunction;
    static readonly int ScriptReimportHelper_ParamsSize;
    static readonly int ScriptReimportHelper_Obj_Offset;
    
    public void ScriptReimportHelper(UnrealSharp.CoreUObject.Object obj)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[ScriptReimportHelper_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.CoreUObject.Object>.ToNative(IntPtr.Add(ParamsBuffer, ScriptReimportHelper_Obj_Offset), 0, null, obj);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, ScriptReimportHelper_NativeFunction, ParamsBuffer);
            
        }
    }
    
    
}