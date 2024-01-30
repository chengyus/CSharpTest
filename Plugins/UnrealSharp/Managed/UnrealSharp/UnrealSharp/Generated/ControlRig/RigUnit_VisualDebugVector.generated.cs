using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_VisualDebugVector
{
    // StructProperty /Script/ControlRig.RigUnit_VisualDebugVector:Value
    static readonly int Value_Offset;
    public System.DoubleNumerics.Vector3 Value;
    
    // BoolProperty /Script/ControlRig.RigUnit_VisualDebugVector:bEnabled
    static readonly int bEnabled_Offset;
    public bool Enabled;
    
    // EnumProperty /Script/ControlRig.RigUnit_VisualDebugVector:Mode
    static readonly int Mode_Offset;
    public UnrealSharp.RigVM.ERigUnitVisualDebugPointMode Mode;
    
    // StructProperty /Script/ControlRig.RigUnit_VisualDebugVector:Color
    static readonly int Color_Offset;
    public UnrealSharp.CoreUObject.LinearColor Color;
    
    // FloatProperty /Script/ControlRig.RigUnit_VisualDebugVector:Thickness
    static readonly int Thickness_Offset;
    public float Thickness;
    
    // FloatProperty /Script/ControlRig.RigUnit_VisualDebugVector:Scale
    static readonly int Scale_Offset;
    public float Scale;
    
    // NameProperty /Script/ControlRig.RigUnit_VisualDebugVector:BoneSpace
    static readonly int BoneSpace_Offset;
    public Name BoneSpace;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_VisualDebugVector()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_VisualDebugVector");
        
        Value_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Value");
        bEnabled_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bEnabled");
        Mode_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Mode");
        Color_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Color");
        Thickness_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Thickness");
        Scale_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Scale");
        BoneSpace_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BoneSpace");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_VisualDebugVector(IntPtr InNativeStruct)
    {
        unsafe
        {
            Value = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Value_Offset), 0, null);
            Enabled = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bEnabled_Offset), 0, null);
            Mode = BlittableMarshaller<UnrealSharp.RigVM.ERigUnitVisualDebugPointMode>.FromNative(IntPtr.Add(InNativeStruct, Mode_Offset), 0, null);
            Color = BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.FromNative(IntPtr.Add(InNativeStruct, Color_Offset), 0, null);
            Thickness = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Thickness_Offset), 0, null);
            Scale = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Scale_Offset), 0, null);
            BoneSpace = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, BoneSpace_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Value_Offset), 0, null, Value);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bEnabled_Offset), 0, null, Enabled);
            BlittableMarshaller<UnrealSharp.RigVM.ERigUnitVisualDebugPointMode>.ToNative(IntPtr.Add(Buffer, Mode_Offset), 0, null, Mode);
            BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.ToNative(IntPtr.Add(Buffer, Color_Offset), 0, null, Color);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Thickness_Offset), 0, null, Thickness);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Scale_Offset), 0, null, Scale);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, BoneSpace_Offset), 0, null, BoneSpace);
        }
    }
}

public static class RigUnit_VisualDebugVectorMarshaler
{
    public static RigUnit_VisualDebugVector FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_VisualDebugVector(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_VisualDebugVector obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_VisualDebugVector.NativeDataSize;
    }
}