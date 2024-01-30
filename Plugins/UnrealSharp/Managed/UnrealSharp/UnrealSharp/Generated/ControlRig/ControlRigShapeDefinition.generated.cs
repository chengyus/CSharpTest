using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct ControlRigShapeDefinition
{
    // NameProperty /Script/ControlRig.ControlRigShapeDefinition:ShapeName
    static readonly int ShapeName_Offset;
    public Name ShapeName;
    
    // SoftObjectProperty /Script/ControlRig.ControlRigShapeDefinition:StaticMesh
    static readonly int StaticMesh_Offset;
    public SoftObject<UnrealSharp.Engine.StaticMesh> StaticMesh;
    
    // StructProperty /Script/ControlRig.ControlRigShapeDefinition:Transform
    static readonly int Transform_Offset;
    public UnrealSharp.Transform Transform;
    
    
    public static readonly int NativeDataSize;
    static ControlRigShapeDefinition()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("ControlRigShapeDefinition");
        
        ShapeName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ShapeName");
        StaticMesh_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "StaticMesh");
        Transform_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Transform");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public ControlRigShapeDefinition(IntPtr InNativeStruct)
    {
        unsafe
        {
            ShapeName = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, ShapeName_Offset), 0, null);
            StaticMesh = BlittableMarshaller<SoftObject<UnrealSharp.Engine.StaticMesh>>.FromNative(IntPtr.Add(InNativeStruct, StaticMesh_Offset), 0, null);
            Transform = BlittableMarshaller<UnrealSharp.Transform>.FromNative(IntPtr.Add(InNativeStruct, Transform_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, ShapeName_Offset), 0, null, ShapeName);
            BlittableMarshaller<SoftObject<UnrealSharp.Engine.StaticMesh>>.ToNative(IntPtr.Add(Buffer, StaticMesh_Offset), 0, null, StaticMesh);
            BlittableMarshaller<UnrealSharp.Transform>.ToNative(IntPtr.Add(Buffer, Transform_Offset), 0, null, Transform);
        }
    }
}

public static class ControlRigShapeDefinitionMarshaler
{
    public static ControlRigShapeDefinition FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new ControlRigShapeDefinition(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, ControlRigShapeDefinition obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return ControlRigShapeDefinition.NativeDataSize;
    }
}