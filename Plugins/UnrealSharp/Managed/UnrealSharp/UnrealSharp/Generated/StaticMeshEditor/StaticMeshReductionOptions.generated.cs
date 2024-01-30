using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.StaticMeshEditor;

[UStruct]
public partial struct StaticMeshReductionOptions
{
    // BoolProperty /Script/StaticMeshEditor.StaticMeshReductionOptions:bAutoComputeLODScreenSize
    static readonly int bAutoComputeLODScreenSize_Offset;
    public bool AutoComputeLODScreenSize;
    
    
    public static readonly int NativeDataSize;
    static StaticMeshReductionOptions()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("StaticMeshReductionOptions");
        
        bAutoComputeLODScreenSize_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bAutoComputeLODScreenSize");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public StaticMeshReductionOptions(IntPtr InNativeStruct)
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

public static class StaticMeshReductionOptionsMarshaler
{
    public static StaticMeshReductionOptions FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new StaticMeshReductionOptions(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, StaticMeshReductionOptions obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return StaticMeshReductionOptions.NativeDataSize;
    }
}