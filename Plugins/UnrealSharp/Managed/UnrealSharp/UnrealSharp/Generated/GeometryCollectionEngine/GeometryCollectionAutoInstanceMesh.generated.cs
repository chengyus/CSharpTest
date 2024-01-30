using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.GeometryCollectionEngine;

[UStruct]
public partial struct GeometryCollectionAutoInstanceMesh
{
    // ObjectProperty /Script/GeometryCollectionEngine.GeometryCollectionAutoInstanceMesh:Mesh
    static readonly int Mesh_Offset;
    public UnrealSharp.Engine.StaticMesh Mesh;
    
    
    public static readonly int NativeDataSize;
    static GeometryCollectionAutoInstanceMesh()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("GeometryCollectionAutoInstanceMesh");
        
        Mesh_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Mesh");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public GeometryCollectionAutoInstanceMesh(IntPtr InNativeStruct)
    {
        unsafe
        {
            Mesh = ObjectMarshaller<UnrealSharp.Engine.StaticMesh>.FromNative(IntPtr.Add(InNativeStruct, Mesh_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            ObjectMarshaller<UnrealSharp.Engine.StaticMesh>.ToNative(IntPtr.Add(Buffer, Mesh_Offset), 0, null, Mesh);
        }
    }
}

public static class GeometryCollectionAutoInstanceMeshMarshaler
{
    public static GeometryCollectionAutoInstanceMesh FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new GeometryCollectionAutoInstanceMesh(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, GeometryCollectionAutoInstanceMesh obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return GeometryCollectionAutoInstanceMesh.NativeDataSize;
    }
}