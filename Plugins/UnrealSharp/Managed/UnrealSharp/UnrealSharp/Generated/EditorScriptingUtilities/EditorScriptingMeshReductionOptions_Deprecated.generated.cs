using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.EditorScriptingUtilities;

[UStruct]
public partial struct EditorScriptingMeshReductionOptions_Deprecated
{
    // BoolProperty /Script/EditorScriptingUtilities.EditorScriptingMeshReductionOptions_Deprecated:bAutoComputeLODScreenSize
    static readonly int bAutoComputeLODScreenSize_Offset;
    public bool AutoComputeLODScreenSize;
    
    
    public static readonly int NativeDataSize;
    static EditorScriptingMeshReductionOptions_Deprecated()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("EditorScriptingMeshReductionOptions_Deprecated");
        
        bAutoComputeLODScreenSize_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bAutoComputeLODScreenSize");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public EditorScriptingMeshReductionOptions_Deprecated(IntPtr InNativeStruct)
    {
        unsafe
        {
            AutoComputeLODScreenSize = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bAutoComputeLODScreenSize_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bAutoComputeLODScreenSize_Offset), 0, null, AutoComputeLODScreenSize);
        }
    }
}

public static class EditorScriptingMeshReductionOptions_DeprecatedMarshaler
{
    public static EditorScriptingMeshReductionOptions_Deprecated FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new EditorScriptingMeshReductionOptions_Deprecated(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, EditorScriptingMeshReductionOptions_Deprecated obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return EditorScriptingMeshReductionOptions_Deprecated.NativeDataSize;
    }
}