using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_DebugBezierItemSpace
{
    // StructProperty /Script/ControlRig.RigUnit_DebugBezierItemSpace:Bezier
    static readonly int Bezier_Offset;
    public UnrealSharp.RigVM.RigVMFourPointBezier Bezier;
    
    // FloatProperty /Script/ControlRig.RigUnit_DebugBezierItemSpace:MinimumU
    static readonly int MinimumU_Offset;
    public float MinimumU;
    
    // FloatProperty /Script/ControlRig.RigUnit_DebugBezierItemSpace:MaximumU
    static readonly int MaximumU_Offset;
    public float MaximumU;
    
    // StructProperty /Script/ControlRig.RigUnit_DebugBezierItemSpace:Color
    static readonly int Color_Offset;
    public UnrealSharp.CoreUObject.LinearColor Color;
    
    // FloatProperty /Script/ControlRig.RigUnit_DebugBezierItemSpace:Thickness
    static readonly int Thickness_Offset;
    public float Thickness;
    
    // IntProperty /Script/ControlRig.RigUnit_DebugBezierItemSpace:Detail
    static readonly int Detail_Offset;
    public int Detail;
    
    // StructProperty /Script/ControlRig.RigUnit_DebugBezierItemSpace:Space
    static readonly int Space_Offset;
    public UnrealSharp.ControlRig.RigElementKey Space;
    
    // StructProperty /Script/ControlRig.RigUnit_DebugBezierItemSpace:WorldOffset
    static readonly int WorldOffset_Offset;
    public UnrealSharp.Transform WorldOffset;
    
    // BoolProperty /Script/ControlRig.RigUnit_DebugBezierItemSpace:bEnabled
    static readonly int bEnabled_Offset;
    public bool Enabled;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_DebugBezierItemSpace()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_DebugBezierItemSpace");
        
        Bezier_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Bezier");
        MinimumU_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MinimumU");
        MaximumU_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MaximumU");
        Color_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Color");
        Thickness_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Thickness");
        Detail_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Detail");
        Space_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Space");
        WorldOffset_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "WorldOffset");
        bEnabled_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bEnabled");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_DebugBezierItemSpace(IntPtr InNativeStruct)
    {
        unsafe
        {
            Bezier = UnrealSharp.RigVM.RigVMFourPointBezierMarshaler.FromNative(IntPtr.Add(InNativeStruct, Bezier_Offset), 0, null);
            MinimumU = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, MinimumU_Offset), 0, null);
            MaximumU = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, MaximumU_Offset), 0, null);
            Color = BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.FromNative(IntPtr.Add(InNativeStruct, Color_Offset), 0, null);
            Thickness = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Thickness_Offset), 0, null);
            Detail = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, Detail_Offset), 0, null);
            Space = UnrealSharp.ControlRig.RigElementKeyMarshaler.FromNative(IntPtr.Add(InNativeStruct, Space_Offset), 0, null);
            WorldOffset = BlittableMarshaller<UnrealSharp.Transform>.FromNative(IntPtr.Add(InNativeStruct, WorldOffset_Offset), 0, null);
            Enabled = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bEnabled_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.RigVM.RigVMFourPointBezierMarshaler.ToNative(IntPtr.Add(Buffer, Bezier_Offset), 0, null, Bezier);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, MinimumU_Offset), 0, null, MinimumU);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, MaximumU_Offset), 0, null, MaximumU);
            BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.ToNative(IntPtr.Add(Buffer, Color_Offset), 0, null, Color);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Thickness_Offset), 0, null, Thickness);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, Detail_Offset), 0, null, Detail);
            UnrealSharp.ControlRig.RigElementKeyMarshaler.ToNative(IntPtr.Add(Buffer, Space_Offset), 0, null, Space);
            BlittableMarshaller<UnrealSharp.Transform>.ToNative(IntPtr.Add(Buffer, WorldOffset_Offset), 0, null, WorldOffset);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bEnabled_Offset), 0, null, Enabled);
        }
    }
}

public static class RigUnit_DebugBezierItemSpaceMarshaler
{
    public static RigUnit_DebugBezierItemSpace FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_DebugBezierItemSpace(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_DebugBezierItemSpace obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_DebugBezierItemSpace.NativeDataSize;
    }
}