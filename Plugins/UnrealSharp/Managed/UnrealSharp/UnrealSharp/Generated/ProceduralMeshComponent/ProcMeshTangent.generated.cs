using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ProceduralMeshComponent;

[UStruct]
public partial struct ProcMeshTangent
{
    // StructProperty /Script/ProceduralMeshComponent.ProcMeshTangent:TangentX
    static readonly int TangentX_Offset;
    public System.DoubleNumerics.Vector3 TangentX;
    
    // BoolProperty /Script/ProceduralMeshComponent.ProcMeshTangent:bFlipTangentY
    static readonly int bFlipTangentY_Offset;
    public bool FlipTangentY;
    
    
    public static readonly int NativeDataSize;
    static ProcMeshTangent()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("ProcMeshTangent");
        
        TangentX_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "TangentX");
        bFlipTangentY_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bFlipTangentY");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public ProcMeshTangent(IntPtr InNativeStruct)
    {
        unsafe
        {
            TangentX = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, TangentX_Offset), 0, null);
            FlipTangentY = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bFlipTangentY_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, TangentX_Offset), 0, null, TangentX);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bFlipTangentY_Offset), 0, null, FlipTangentY);
        }
    }
}

public static class ProcMeshTangentMarshaler
{
    public static ProcMeshTangent FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new ProcMeshTangent(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, ProcMeshTangent obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return ProcMeshTangent.NativeDataSize;
    }
}