using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMFunction_DebugPoint
{
    // StructProperty /Script/RigVM.RigVMFunction_DebugPoint:Vector
    static readonly int Vector_Offset;
    public System.DoubleNumerics.Vector3 Vector;
    
    // EnumProperty /Script/RigVM.RigVMFunction_DebugPoint:Mode
    static readonly int Mode_Offset;
    public UnrealSharp.RigVM.ERigUnitDebugPointMode Mode;
    
    // StructProperty /Script/RigVM.RigVMFunction_DebugPoint:Color
    static readonly int Color_Offset;
    public UnrealSharp.CoreUObject.LinearColor Color;
    
    // FloatProperty /Script/RigVM.RigVMFunction_DebugPoint:Scale
    static readonly int Scale_Offset;
    public float Scale;
    
    // FloatProperty /Script/RigVM.RigVMFunction_DebugPoint:Thickness
    static readonly int Thickness_Offset;
    public float Thickness;
    
    // NameProperty /Script/RigVM.RigVMFunction_DebugPoint:Space
    static readonly int Space_Offset;
    public Name Space;
    
    // StructProperty /Script/RigVM.RigVMFunction_DebugPoint:WorldOffset
    static readonly int WorldOffset_Offset;
    public UnrealSharp.Transform WorldOffset;
    
    // BoolProperty /Script/RigVM.RigVMFunction_DebugPoint:bEnabled
    static readonly int bEnabled_Offset;
    public bool Enabled;
    
    
    public static readonly int NativeDataSize;
    static RigVMFunction_DebugPoint()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMFunction_DebugPoint");
        
        Vector_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Vector");
        Mode_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Mode");
        Color_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Color");
        Scale_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Scale");
        Thickness_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Thickness");
        Space_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Space");
        WorldOffset_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "WorldOffset");
        bEnabled_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bEnabled");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMFunction_DebugPoint(IntPtr InNativeStruct)
    {
        unsafe
        {
            Vector = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Vector_Offset), 0, null);
            Mode = BlittableMarshaller<UnrealSharp.RigVM.ERigUnitDebugPointMode>.FromNative(IntPtr.Add(InNativeStruct, Mode_Offset), 0, null);
            Color = BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.FromNative(IntPtr.Add(InNativeStruct, Color_Offset), 0, null);
            Scale = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Scale_Offset), 0, null);
            Thickness = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Thickness_Offset), 0, null);
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
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Vector_Offset), 0, null, Vector);
            BlittableMarshaller<UnrealSharp.RigVM.ERigUnitDebugPointMode>.ToNative(IntPtr.Add(Buffer, Mode_Offset), 0, null, Mode);
            BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.ToNative(IntPtr.Add(Buffer, Color_Offset), 0, null, Color);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Scale_Offset), 0, null, Scale);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Thickness_Offset), 0, null, Thickness);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, Space_Offset), 0, null, Space);
            BlittableMarshaller<UnrealSharp.Transform>.ToNative(IntPtr.Add(Buffer, WorldOffset_Offset), 0, null, WorldOffset);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bEnabled_Offset), 0, null, Enabled);
        }
    }
}

public static class RigVMFunction_DebugPointMarshaler
{
    public static RigVMFunction_DebugPoint FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMFunction_DebugPoint(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMFunction_DebugPoint obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMFunction_DebugPoint.NativeDataSize;
    }
}