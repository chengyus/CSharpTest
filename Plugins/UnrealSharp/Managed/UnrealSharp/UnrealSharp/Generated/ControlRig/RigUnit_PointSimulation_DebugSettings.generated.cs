using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_PointSimulation_DebugSettings
{
    // BoolProperty /Script/ControlRig.RigUnit_PointSimulation_DebugSettings:bEnabled
    static readonly int bEnabled_Offset;
    public bool Enabled;
    
    // FloatProperty /Script/ControlRig.RigUnit_PointSimulation_DebugSettings:Scale
    static readonly int Scale_Offset;
    public float Scale;
    
    // FloatProperty /Script/ControlRig.RigUnit_PointSimulation_DebugSettings:CollisionScale
    static readonly int CollisionScale_Offset;
    public float CollisionScale;
    
    // BoolProperty /Script/ControlRig.RigUnit_PointSimulation_DebugSettings:bDrawPointsAsSpheres
    static readonly int bDrawPointsAsSpheres_Offset;
    public bool DrawPointsAsSpheres;
    
    // StructProperty /Script/ControlRig.RigUnit_PointSimulation_DebugSettings:Color
    static readonly int Color_Offset;
    public UnrealSharp.CoreUObject.LinearColor Color;
    
    // StructProperty /Script/ControlRig.RigUnit_PointSimulation_DebugSettings:WorldOffset
    static readonly int WorldOffset_Offset;
    public UnrealSharp.Transform WorldOffset;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_PointSimulation_DebugSettings()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_PointSimulation_DebugSettings");
        
        bEnabled_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bEnabled");
        Scale_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Scale");
        CollisionScale_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "CollisionScale");
        bDrawPointsAsSpheres_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bDrawPointsAsSpheres");
        Color_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Color");
        WorldOffset_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "WorldOffset");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_PointSimulation_DebugSettings(IntPtr InNativeStruct)
    {
        unsafe
        {
            Enabled = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bEnabled_Offset), 0, null);
            Scale = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Scale_Offset), 0, null);
            CollisionScale = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, CollisionScale_Offset), 0, null);
            DrawPointsAsSpheres = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bDrawPointsAsSpheres_Offset), 0, null);
            Color = BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.FromNative(IntPtr.Add(InNativeStruct, Color_Offset), 0, null);
            WorldOffset = BlittableMarshaller<UnrealSharp.Transform>.FromNative(IntPtr.Add(InNativeStruct, WorldOffset_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bEnabled_Offset), 0, null, Enabled);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Scale_Offset), 0, null, Scale);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, CollisionScale_Offset), 0, null, CollisionScale);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bDrawPointsAsSpheres_Offset), 0, null, DrawPointsAsSpheres);
            BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.ToNative(IntPtr.Add(Buffer, Color_Offset), 0, null, Color);
            BlittableMarshaller<UnrealSharp.Transform>.ToNative(IntPtr.Add(Buffer, WorldOffset_Offset), 0, null, WorldOffset);
        }
    }
}

public static class RigUnit_PointSimulation_DebugSettingsMarshaler
{
    public static RigUnit_PointSimulation_DebugSettings FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_PointSimulation_DebugSettings(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_PointSimulation_DebugSettings obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_PointSimulation_DebugSettings.NativeDataSize;
    }
}