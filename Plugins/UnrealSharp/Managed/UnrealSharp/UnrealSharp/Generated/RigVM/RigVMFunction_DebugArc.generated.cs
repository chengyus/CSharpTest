using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMFunction_DebugArc
{
    // StructProperty /Script/RigVM.RigVMFunction_DebugArc:Transform
    static readonly int Transform_Offset;
    public UnrealSharp.Transform Transform;
    
    // StructProperty /Script/RigVM.RigVMFunction_DebugArc:Color
    static readonly int Color_Offset;
    public UnrealSharp.CoreUObject.LinearColor Color;
    
    // FloatProperty /Script/RigVM.RigVMFunction_DebugArc:Radius
    static readonly int Radius_Offset;
    public float Radius;
    
    // FloatProperty /Script/RigVM.RigVMFunction_DebugArc:MinimumDegrees
    static readonly int MinimumDegrees_Offset;
    public float MinimumDegrees;
    
    // FloatProperty /Script/RigVM.RigVMFunction_DebugArc:MaximumDegrees
    static readonly int MaximumDegrees_Offset;
    public float MaximumDegrees;
    
    // FloatProperty /Script/RigVM.RigVMFunction_DebugArc:Thickness
    static readonly int Thickness_Offset;
    public float Thickness;
    
    // IntProperty /Script/RigVM.RigVMFunction_DebugArc:Detail
    static readonly int Detail_Offset;
    public int Detail;
    
    // NameProperty /Script/RigVM.RigVMFunction_DebugArc:Space
    static readonly int Space_Offset;
    public Name Space;
    
    // StructProperty /Script/RigVM.RigVMFunction_DebugArc:WorldOffset
    static readonly int WorldOffset_Offset;
    public UnrealSharp.Transform WorldOffset;
    
    // BoolProperty /Script/RigVM.RigVMFunction_DebugArc:bEnabled
    static readonly int bEnabled_Offset;
    public bool Enabled;
    
    
    public static readonly int NativeDataSize;
    static RigVMFunction_DebugArc()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMFunction_DebugArc");
        
        Transform_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Transform");
        Color_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Color");
        Radius_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Radius");
        MinimumDegrees_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MinimumDegrees");
        MaximumDegrees_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MaximumDegrees");
        Thickness_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Thickness");
        Detail_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Detail");
        Space_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Space");
        WorldOffset_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "WorldOffset");
        bEnabled_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bEnabled");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMFunction_DebugArc(IntPtr InNativeStruct)
    {
        unsafe
        {
            Transform = BlittableMarshaller<UnrealSharp.Transform>.FromNative(IntPtr.Add(InNativeStruct, Transform_Offset), 0, null);
            Color = BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.FromNative(IntPtr.Add(InNativeStruct, Color_Offset), 0, null);
            Radius = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Radius_Offset), 0, null);
            MinimumDegrees = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, MinimumDegrees_Offset), 0, null);
            MaximumDegrees = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, MaximumDegrees_Offset), 0, null);
            Thickness = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Thickness_Offset), 0, null);
            Detail = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, Detail_Offset), 0, null);
            Space = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, Space_Offset), 0, null);
            WorldOffset = BlittableMarshaller<UnrealSharp.Transform>.FromNative(IntPtr.Add(InNativeStruct, WorldOffset_Offset), 0, null);
            Enabled = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bEnabled_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.Transform>.ToNative(IntPtr.Add(Buffer, Transform_Offset), 0, null, Transform);
            BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.ToNative(IntPtr.Add(Buffer, Color_Offset), 0, null, Color);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Radius_Offset), 0, null, Radius);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, MinimumDegrees_Offset), 0, null, MinimumDegrees);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, MaximumDegrees_Offset), 0, null, MaximumDegrees);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Thickness_Offset), 0, null, Thickness);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, Detail_Offset), 0, null, Detail);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, Space_Offset), 0, null, Space);
            BlittableMarshaller<UnrealSharp.Transform>.ToNative(IntPtr.Add(Buffer, WorldOffset_Offset), 0, null, WorldOffset);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bEnabled_Offset), 0, null, Enabled);
        }
    }
}

public static class RigVMFunction_DebugArcMarshaler
{
    public static RigVMFunction_DebugArc FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMFunction_DebugArc(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMFunction_DebugArc obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMFunction_DebugArc.NativeDataSize;
    }
}