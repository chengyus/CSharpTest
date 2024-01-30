using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMFunction_DebugLineNoSpace
{
    // StructProperty /Script/RigVM.RigVMFunction_DebugLineNoSpace:A
    static readonly int A_Offset;
    public System.DoubleNumerics.Vector3 A;
    
    // StructProperty /Script/RigVM.RigVMFunction_DebugLineNoSpace:B
    static readonly int B_Offset;
    public System.DoubleNumerics.Vector3 B;
    
    // StructProperty /Script/RigVM.RigVMFunction_DebugLineNoSpace:Color
    static readonly int Color_Offset;
    public UnrealSharp.CoreUObject.LinearColor Color;
    
    // FloatProperty /Script/RigVM.RigVMFunction_DebugLineNoSpace:Thickness
    static readonly int Thickness_Offset;
    public float Thickness;
    
    // StructProperty /Script/RigVM.RigVMFunction_DebugLineNoSpace:WorldOffset
    static readonly int WorldOffset_Offset;
    public UnrealSharp.Transform WorldOffset;
    
    // BoolProperty /Script/RigVM.RigVMFunction_DebugLineNoSpace:bEnabled
    static readonly int bEnabled_Offset;
    public bool Enabled;
    
    
    public static readonly int NativeDataSize;
    static RigVMFunction_DebugLineNoSpace()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMFunction_DebugLineNoSpace");
        
        A_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "A");
        B_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "B");
        Color_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Color");
        Thickness_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Thickness");
        WorldOffset_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "WorldOffset");
        bEnabled_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bEnabled");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMFunction_DebugLineNoSpace(IntPtr InNativeStruct)
    {
        unsafe
        {
            A = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, A_Offset), 0, null);
            B = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, B_Offset), 0, null);
            Color = BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.FromNative(IntPtr.Add(InNativeStruct, Color_Offset), 0, null);
            Thickness = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Thickness_Offset), 0, null);
            WorldOffset = BlittableMarshaller<UnrealSharp.Transform>.FromNative(IntPtr.Add(InNativeStruct, WorldOffset_Offset), 0, null);
            Enabled = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bEnabled_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, A_Offset), 0, null, A);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, B_Offset), 0, null, B);
            BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.ToNative(IntPtr.Add(Buffer, Color_Offset), 0, null, Color);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Thickness_Offset), 0, null, Thickness);
            BlittableMarshaller<UnrealSharp.Transform>.ToNative(IntPtr.Add(Buffer, WorldOffset_Offset), 0, null, WorldOffset);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bEnabled_Offset), 0, null, Enabled);
        }
    }
}

public static class RigVMFunction_DebugLineNoSpaceMarshaler
{
    public static RigVMFunction_DebugLineNoSpace FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMFunction_DebugLineNoSpace(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMFunction_DebugLineNoSpace obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMFunction_DebugLineNoSpace.NativeDataSize;
    }
}