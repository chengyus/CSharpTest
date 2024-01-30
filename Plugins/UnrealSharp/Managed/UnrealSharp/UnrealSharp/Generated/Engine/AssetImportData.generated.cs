// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UClass]
public partial class AssetImportData : UnrealSharp.CoreUObject.Object
{
    
    static AssetImportData()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("AssetImportData");
        
        
        ScriptedAddFilename_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "ScriptedAddFilename");
        ScriptedAddFilename_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(ScriptedAddFilename_NativeFunction);
        ScriptedAddFilename_InPath_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ScriptedAddFilename_NativeFunction, "InPath");
        ScriptedAddFilename_Index_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ScriptedAddFilename_NativeFunction, "Index");
        ScriptedAddFilename_SourceFileLabel_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ScriptedAddFilename_NativeFunction, "SourceFileLabel");
        K2_GetFirstFilename_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "K2_GetFirstFilename");
        K2_GetFirstFilename_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(K2_GetFirstFilename_NativeFunction);
        K2_GetFirstFilename_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(K2_GetFirstFilename_NativeFunction, "ReturnValue");
        
        
    }
    
    protected AssetImportData(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // Function /Script/Engine.AssetImportData:ScriptedAddFilename
    static readonly IntPtr ScriptedAddFilename_NativeFunction;
    static readonly int ScriptedAddFilename_ParamsSize;
    static readonly int ScriptedAddFilename_InPath_Offset;
    static readonly int ScriptedAddFilename_Index_Offset;
    static readonly int ScriptedAddFilename_SourceFileLabel_Offset;
    
    public void ScriptedAddFilename(string inPath, int index, string sourceFileLabel)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[ScriptedAddFilename_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            IntPtr InPath_NativePtr = IntPtr.Add(ParamsBuffer,ScriptedAddFilename_InPath_Offset);
            StringMarshaller.ToNative(InPath_NativePtr,0,null,inPath);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(ParamsBuffer, ScriptedAddFilename_Index_Offset), 0, null, index);
            IntPtr SourceFileLabel_NativePtr = IntPtr.Add(ParamsBuffer,ScriptedAddFilename_SourceFileLabel_Offset);
            StringMarshaller.ToNative(SourceFileLabel_NativePtr,0,null,sourceFileLabel);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, ScriptedAddFilename_NativeFunction, ParamsBuffer);
            
            StringMarshaller.DestructInstance(InPath_NativePtr, 0);
            StringMarshaller.DestructInstance(SourceFileLabel_NativePtr, 0);
        }
    }
    
    // Function /Script/Engine.AssetImportData:K2_GetFirstFilename
    static readonly IntPtr K2_GetFirstFilename_NativeFunction;
    static readonly int K2_GetFirstFilename_ParamsSize;
    static readonly int K2_GetFirstFilename_ReturnValue_Offset;
    
    public string GetFirstFilename()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[K2_GetFirstFilename_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, K2_GetFirstFilename_NativeFunction, ParamsBuffer);
            
            string returnValue;
            IntPtr ReturnValue_NativePtr = IntPtr.Add(ParamsBuffer,K2_GetFirstFilename_ReturnValue_Offset);
            returnValue = StringMarshaller.FromNative(ReturnValue_NativePtr,0,null);
            StringMarshaller.DestructInstance(ReturnValue_NativePtr, 0);
            
            return returnValue;
        }
    }
    
    
}