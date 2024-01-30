using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMFunction_DebugRectangleNoSpace
{
    // StructProperty /Script/RigVM.RigVMFunction_DebugRectangleNoSpace:Transform
    static readonly int Transform_Offset;
    public UnrealSharp.Transform Transform;
    
    // StructProperty /Script/RigVM.RigVMFunction_DebugRectangleNoSpace:Color
    static readonly int Color_Offset;
    public UnrealSharp.CoreUObject.LinearColor Color;
    
    // FloatProperty /Script/RigVM.RigVMFunction_DebugRectangleNoSpace:Scale
    static readonly int Scale_Offset;
    public float Scale;
    
    // FloatProperty /Script/RigVM.RigVMFunction_DebugRectangleNoSpace:Thickness
    static readonly int Thickness_Offset;
    public float Thickness;
    
    // StructProperty /Script/RigVM.RigVMFunction_DebugRectangleNoSpace:WorldOffset
    static readonly int WorldOffset_Offset;
    public UnrealSharp.Transform WorldOffset;
    
    // BoolProperty /Script/RigVM.RigVMFunction_DebugRectangleNoSpace:bEnabled
    static readonly int bEnabled_Offset;
    public bool Enabled;
    
    
    public static readonly int NativeDataSize;
    static RigVMFunction_DebugRectangleNoSpace()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMFunction_DebugRectangleNoSpace");
        
        Transform_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Transform");
        Color_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Color");
        Scale_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Scale");
        Thickness_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Thickness");
        WorldOffset_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "WorldOffset");
        bEnabled_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bEnabled");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMFunction_DebugRectangleNoSpace(IntPtr InNativeStruct)
    {
        unsafe
        {
            Transform = BlittableMarshaller<UnrealSharp.Transform>.FromNative(IntPtr.Add(InNativeStruct, Transform_Offset), 0, null);
            Color = BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.FromNative(IntPtr.Add(InNativeStruct, Color_Offset), 0, null);
            Scale = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Scale_Offset), 0, null);
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
            BlittableMarshaller<UnrealSharp.Transform>.ToNative(IntPtr.Add(Buffer, Transform_Offset), 0, null, Transform);
            BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.ToNative(IntPtr.Add(Buffer, Color_Offset), 0, null, Color);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Scale_Offset), 0, null, Scale);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Thickness_Offset), 0, null, Thickness);
            BlittableMarshaller<UnrealSharp.Transform>.ToNative(IntPtr.Add(Buffer, WorldOffset_Offset), 0, null, WorldOffset);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bEnabled_Offset), 0, null, Enabled);
        }
    }
}

public static class RigVMFunction_DebugRectangleNoSpaceMarshaler
{
    public static RigVMFunction_DebugRectangleNoSpace FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMFunction_DebugRectangleNoSpace(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMFunction_DebugRectangleNoSpace obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMFunction_DebugRectangleNoSpace.NativeDataSize;
    }
}