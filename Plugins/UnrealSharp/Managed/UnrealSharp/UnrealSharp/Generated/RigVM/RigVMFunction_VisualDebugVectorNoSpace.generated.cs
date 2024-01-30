using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMFunction_VisualDebugVectorNoSpace
{
    // StructProperty /Script/RigVM.RigVMFunction_VisualDebugVectorNoSpace:Value
    static readonly int Value_Offset;
    public System.DoubleNumerics.Vector3 Value;
    
    // BoolProperty /Script/RigVM.RigVMFunction_VisualDebugVectorNoSpace:bEnabled
    static readonly int bEnabled_Offset;
    public bool Enabled;
    
    // EnumProperty /Script/RigVM.RigVMFunction_VisualDebugVectorNoSpace:Mode
    static readonly int Mode_Offset;
    public UnrealSharp.RigVM.ERigUnitVisualDebugPointMode Mode;
    
    // StructProperty /Script/RigVM.RigVMFunction_VisualDebugVectorNoSpace:Color
    static readonly int Color_Offset;
    public UnrealSharp.CoreUObject.LinearColor Color;
    
    // FloatProperty /Script/RigVM.RigVMFunction_VisualDebugVectorNoSpace:Thickness
    static readonly int Thickness_Offset;
    public float Thickness;
    
    // FloatProperty /Script/RigVM.RigVMFunction_VisualDebugVectorNoSpace:Scale
    static readonly int Scale_Offset;
    public float Scale;
    
    
    public static readonly int NativeDataSize;
    static RigVMFunction_VisualDebugVectorNoSpace()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMFunction_VisualDebugVectorNoSpace");
        
        Value_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Value");
        bEnabled_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bEnabled");
        Mode_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Mode");
        Color_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Color");
        Thickness_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Thickness");
        Scale_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Scale");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMFunction_VisualDebugVectorNoSpace(IntPtr InNativeStruct)
    {
        unsafe
        {
            Value = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Value_Offset), 0, null);
            Enabled = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bEnabled_Offset), 0, null);
            Mode = BlittableMarshaller<UnrealSharp.RigVM.ERigUnitVisualDebugPointMode>.FromNative(IntPtr.Add(InNativeStruct, Mode_Offset), 0, null);
            Color = BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.FromNative(IntPtr.Add(InNativeStruct, Color_Offset), 0, null);
            Thickness = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Thickness_Offset), 0, null);
            Scale = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Scale_Offset), 0, null);
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
        }
    }
}

public static class RigVMFunction_VisualDebugVectorNoSpaceMarshaler
{
    public static RigVMFunction_VisualDebugVectorNoSpace FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMFunction_VisualDebugVectorNoSpace(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMFunction_VisualDebugVectorNoSpace obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMFunction_VisualDebugVectorNoSpace.NativeDataSize;
    }
}