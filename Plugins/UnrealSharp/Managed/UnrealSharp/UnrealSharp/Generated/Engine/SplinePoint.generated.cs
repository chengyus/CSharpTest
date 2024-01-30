using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct SplinePoint
{
    // FloatProperty /Script/Engine.SplinePoint:InputKey
    static readonly int InputKey_Offset;
    public float InputKey;
    
    // StructProperty /Script/Engine.SplinePoint:Position
    static readonly int Position_Offset;
    public System.DoubleNumerics.Vector3 Position;
    
    // StructProperty /Script/Engine.SplinePoint:ArriveTangent
    static readonly int ArriveTangent_Offset;
    public System.DoubleNumerics.Vector3 ArriveTangent;
    
    // StructProperty /Script/Engine.SplinePoint:LeaveTangent
    static readonly int LeaveTangent_Offset;
    public System.DoubleNumerics.Vector3 LeaveTangent;
    
    // StructProperty /Script/Engine.SplinePoint:Rotation
    static readonly int Rotation_Offset;
    public UnrealSharp.Rotator Rotation;
    
    // StructProperty /Script/Engine.SplinePoint:Scale
    static readonly int Scale_Offset;
    public System.DoubleNumerics.Vector3 Scale;
    
    // ByteProperty /Script/Engine.SplinePoint:Type
    static readonly int Type_Offset;
    public UnrealSharp.Engine.ESplinePointType Type;
    
    
    public static readonly int NativeDataSize;
    static SplinePoint()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("SplinePoint");
        
        InputKey_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "InputKey");
        Position_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Position");
        ArriveTangent_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ArriveTangent");
        LeaveTangent_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LeaveTangent");
        Rotation_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Rotation");
        Scale_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Scale");
        Type_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Type");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public SplinePoint(IntPtr InNativeStruct)
    {
        unsafe
        {
            InputKey = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, InputKey_Offset), 0, null);
            Position = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Position_Offset), 0, null);
            ArriveTangent = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, ArriveTangent_Offset), 0, null);
            LeaveTangent = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, LeaveTangent_Offset), 0, null);
            Rotation = BlittableMarshaller<UnrealSharp.Rotator>.FromNative(IntPtr.Add(InNativeStruct, Rotation_Offset), 0, null);
            Scale = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Scale_Offset), 0, null);
            Type = BlittableMarshaller<UnrealSharp.Engine.ESplinePointType>.FromNative(IntPtr.Add(InNativeStruct, Type_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, InputKey_Offset), 0, null, InputKey);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Position_Offset), 0, null, Position);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, ArriveTangent_Offset), 0, null, ArriveTangent);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, LeaveTangent_Offset), 0, null, LeaveTangent);
            BlittableMarshaller<UnrealSharp.Rotator>.ToNative(IntPtr.Add(Buffer, Rotation_Offset), 0, null, Rotation);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Scale_Offset), 0, null, Scale);
            BlittableMarshaller<UnrealSharp.Engine.ESplinePointType>.ToNative(IntPtr.Add(Buffer, Type_Offset), 0, null, Type);
        }
    }
}

public static class SplinePointMarshaler
{
    public static SplinePoint FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new SplinePoint(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, SplinePoint obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return SplinePoint.NativeDataSize;
    }
}