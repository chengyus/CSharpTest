using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.IKRig;

[UStruct]
public partial struct IKRigGoal
{
    // NameProperty /Script/IKRig.IKRigGoal:Name
    static readonly int Name_Offset;
    public Name Name;
    
    // EnumProperty /Script/IKRig.IKRigGoal:TransformSource
    static readonly int TransformSource_Offset;
    public UnrealSharp.IKRig.EIKRigGoalTransformSource TransformSource;
    
    // StructProperty /Script/IKRig.IKRigGoal:Position
    static readonly int Position_Offset;
    public System.DoubleNumerics.Vector3 Position;
    
    // StructProperty /Script/IKRig.IKRigGoal:Rotation
    static readonly int Rotation_Offset;
    public UnrealSharp.Rotator Rotation;
    
    // FloatProperty /Script/IKRig.IKRigGoal:PositionAlpha
    static readonly int PositionAlpha_Offset;
    public float PositionAlpha;
    
    // FloatProperty /Script/IKRig.IKRigGoal:RotationAlpha
    static readonly int RotationAlpha_Offset;
    public float RotationAlpha;
    
    // EnumProperty /Script/IKRig.IKRigGoal:PositionSpace
    static readonly int PositionSpace_Offset;
    public UnrealSharp.IKRig.EIKRigGoalSpace PositionSpace;
    
    // EnumProperty /Script/IKRig.IKRigGoal:RotationSpace
    static readonly int RotationSpace_Offset;
    public UnrealSharp.IKRig.EIKRigGoalSpace RotationSpace;
    
    
    public static readonly int NativeDataSize;
    static IKRigGoal()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("IKRigGoal");
        
        Name_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Name");
        TransformSource_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "TransformSource");
        Position_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Position");
        Rotation_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Rotation");
        PositionAlpha_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PositionAlpha");
        RotationAlpha_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "RotationAlpha");
        PositionSpace_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PositionSpace");
        RotationSpace_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "RotationSpace");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public IKRigGoal(IntPtr InNativeStruct)
    {
        unsafe
        {
            Name = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, Name_Offset), 0, null);
            TransformSource = BlittableMarshaller<UnrealSharp.IKRig.EIKRigGoalTransformSource>.FromNative(IntPtr.Add(InNativeStruct, TransformSource_Offset), 0, null);
            Position = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Position_Offset), 0, null);
            Rotation = BlittableMarshaller<UnrealSharp.Rotator>.FromNative(IntPtr.Add(InNativeStruct, Rotation_Offset), 0, null);
            PositionAlpha = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, PositionAlpha_Offset), 0, null);
            RotationAlpha = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, RotationAlpha_Offset), 0, null);
            PositionSpace = BlittableMarshaller<UnrealSharp.IKRig.EIKRigGoalSpace>.FromNative(IntPtr.Add(InNativeStruct, PositionSpace_Offset), 0, null);
            RotationSpace = BlittableMarshaller<UnrealSharp.IKRig.EIKRigGoalSpace>.FromNative(IntPtr.Add(InNativeStruct, RotationSpace_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, Name_Offset), 0, null, Name);
            BlittableMarshaller<UnrealSharp.IKRig.EIKRigGoalTransformSource>.ToNative(IntPtr.Add(Buffer, TransformSource_Offset), 0, null, TransformSource);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Position_Offset), 0, null, Position);
            BlittableMarshaller<UnrealSharp.Rotator>.ToNative(IntPtr.Add(Buffer, Rotation_Offset), 0, null, Rotation);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, PositionAlpha_Offset), 0, null, PositionAlpha);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, RotationAlpha_Offset), 0, null, RotationAlpha);
            BlittableMarshaller<UnrealSharp.IKRig.EIKRigGoalSpace>.ToNative(IntPtr.Add(Buffer, PositionSpace_Offset), 0, null, PositionSpace);
            BlittableMarshaller<UnrealSharp.IKRig.EIKRigGoalSpace>.ToNative(IntPtr.Add(Buffer, RotationSpace_Offset), 0, null, RotationSpace);
        }
    }
}

public static class IKRigGoalMarshaler
{
    public static IKRigGoal FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new IKRigGoal(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, IKRigGoal obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return IKRigGoal.NativeDataSize;
    }
}