using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ProceduralMeshComponent;

[UStruct]
public partial struct ProcMeshVertex
{
    // StructProperty /Script/ProceduralMeshComponent.ProcMeshVertex:Position
    static readonly int Position_Offset;
    public System.DoubleNumerics.Vector3 Position;
    
    // StructProperty /Script/ProceduralMeshComponent.ProcMeshVertex:Normal
    static readonly int Normal_Offset;
    public System.DoubleNumerics.Vector3 Normal;
    
    // StructProperty /Script/ProceduralMeshComponent.ProcMeshVertex:Tangent
    static readonly int Tangent_Offset;
    public UnrealSharp.ProceduralMeshComponent.ProcMeshTangent Tangent;
    
    // StructProperty /Script/ProceduralMeshComponent.ProcMeshVertex:Color
    static readonly int Color_Offset;
    public UnrealSharp.CoreUObject.Color Color;
    
    // StructProperty /Script/ProceduralMeshComponent.ProcMeshVertex:UV0
    static readonly int UV0_Offset;
    public System.DoubleNumerics.Vector2 UV0;
    
    // StructProperty /Script/ProceduralMeshComponent.ProcMeshVertex:UV1
    static readonly int UV1_Offset;
    public System.DoubleNumerics.Vector2 UV1;
    
    // StructProperty /Script/ProceduralMeshComponent.ProcMeshVertex:UV2
    static readonly int UV2_Offset;
    public System.DoubleNumerics.Vector2 UV2;
    
    // StructProperty /Script/ProceduralMeshComponent.ProcMeshVertex:UV3
    static readonly int UV3_Offset;
    public System.DoubleNumerics.Vector2 UV3;
    
    
    public static readonly int NativeDataSize;
    static ProcMeshVertex()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("ProcMeshVertex");
        
        Position_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Position");
        Normal_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Normal");
        Tangent_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Tangent");
        Color_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Color");
        UV0_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "UV0");
        UV1_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "UV1");
        UV2_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "UV2");
        UV3_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "UV3");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public ProcMeshVertex(IntPtr InNativeStruct)
    {
        unsafe
        {
            Position = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Position_Offset), 0, null);
            Normal = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Normal_Offset), 0, null);
            Tangent = UnrealSharp.ProceduralMeshComponent.ProcMeshTangentMarshaler.FromNative(IntPtr.Add(InNativeStruct, Tangent_Offset), 0, null);
            Color = BlittableMarshaller<UnrealSharp.CoreUObject.Color>.FromNative(IntPtr.Add(InNativeStruct, Color_Offset), 0, null);
            UV0 = BlittableMarshaller<System.DoubleNumerics.Vector2>.FromNative(IntPtr.Add(InNativeStruct, UV0_Offset), 0, null);
            UV1 = BlittableMarshaller<System.DoubleNumerics.Vector2>.FromNative(IntPtr.Add(InNativeStruct, UV1_Offset), 0, null);
            UV2 = BlittableMarshaller<System.DoubleNumerics.Vector2>.FromNative(IntPtr.Add(InNativeStruct, UV2_Offset), 0, null);
            UV3 = BlittableMarshaller<System.DoubleNumerics.Vector2>.FromNative(IntPtr.Add(InNativeStruct, UV3_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Position_Offset), 0, null, Position);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Normal_Offset), 0, null, Normal);
            UnrealSharp.ProceduralMeshComponent.ProcMeshTangentMarshaler.ToNative(IntPtr.Add(Buffer, Tangent_Offset), 0, null, Tangent);
            BlittableMarshaller<UnrealSharp.CoreUObject.Color>.ToNative(IntPtr.Add(Buffer, Color_Offset), 0, null, Color);
            BlittableMarshaller<System.DoubleNumerics.Vector2>.ToNative(IntPtr.Add(Buffer, UV0_Offset), 0, null, UV0);
            BlittableMarshaller<System.DoubleNumerics.Vector2>.ToNative(IntPtr.Add(Buffer, UV1_Offset), 0, null, UV1);
            BlittableMarshaller<System.DoubleNumerics.Vector2>.ToNative(IntPtr.Add(Buffer, UV2_Offset), 0, null, UV2);
            BlittableMarshaller<System.DoubleNumerics.Vector2>.ToNative(IntPtr.Add(Buffer, UV3_Offset), 0, null, UV3);
        }
    }
}

public static class ProcMeshVertexMarshaler
{
    public static ProcMeshVertex FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new ProcMeshVertex(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, ProcMeshVertex obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return ProcMeshVertex.NativeDataSize;
    }
}