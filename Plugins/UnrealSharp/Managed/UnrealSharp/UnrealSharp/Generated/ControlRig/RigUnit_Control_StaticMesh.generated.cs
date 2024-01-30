using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_Control_StaticMesh
{
    // StructProperty /Script/ControlRig.RigUnit_Control_StaticMesh:MeshTransform
    static readonly int MeshTransform_Offset;
    public UnrealSharp.Transform MeshTransform;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_Control_StaticMesh()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_Control_StaticMesh");
        
        MeshTransform_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MeshTransform");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_Control_StaticMesh(IntPtr InNativeStruct)
    {
        unsafe
        {
            MeshTransform = BlittableMarshaller<UnrealSharp.Transform>.FromNative(IntPtr.Add(InNativeStruct, MeshTransform_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.Transform>.ToNative(IntPtr.Add(Buffer, MeshTransform_Offset), 0, null, MeshTransform);
        }
    }
}

public static class RigUnit_Control_StaticMeshMarshaler
{
    public static RigUnit_Control_StaticMesh FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_Control_StaticMesh(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_Control_StaticMesh obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_Control_StaticMesh.NativeDataSize;
    }
}