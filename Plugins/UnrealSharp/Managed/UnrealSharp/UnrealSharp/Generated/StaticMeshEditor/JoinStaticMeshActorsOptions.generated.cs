using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.StaticMeshEditor;

[UStruct]
public partial struct JoinStaticMeshActorsOptions
{
    // BoolProperty /Script/StaticMeshEditor.JoinStaticMeshActorsOptions:bDestroySourceActors
    static readonly int bDestroySourceActors_Offset;
    public bool DestroySourceActors;
    
    // BoolProperty /Script/StaticMeshEditor.JoinStaticMeshActorsOptions:bRenameComponentsFromSource
    static readonly int bRenameComponentsFromSource_Offset;
    public bool RenameComponentsFromSource;
    
    
    public static readonly int NativeDataSize;
    static JoinStaticMeshActorsOptions()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("JoinStaticMeshActorsOptions");
        
        bDestroySourceActors_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bDestroySourceActors");
        bRenameComponentsFromSource_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bRenameComponentsFromSource");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public JoinStaticMeshActorsOptions(IntPtr InNativeStruct)
    {
        unsafe
        {
            DestroySourceActors = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bDestroySourceActors_Offset), 0, null);
            RenameComponentsFromSource = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bRenameComponentsFromSource_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bDestroySourceActors_Offset), 0, null, DestroySourceActors);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bRenameComponentsFromSource_Offset), 0, null, RenameComponentsFromSource);
        }
    }
}

public static class JoinStaticMeshActorsOptionsMarshaler
{
    public static JoinStaticMeshActorsOptions FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new JoinStaticMeshActorsOptions(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, JoinStaticMeshActorsOptions obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return JoinStaticMeshActorsOptions.NativeDataSize;
    }
}