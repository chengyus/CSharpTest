using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.CoreUObject;

[UStruct]
public partial struct Transform
{
    // StructProperty /Script/CoreUObject.Transform:Rotation
    static readonly int Rotation_Offset;
    public System.DoubleNumerics.Quaternion Rotation;
    
    // StructProperty /Script/CoreUObject.Transform:Translation
    static readonly int Translation_Offset;
    public System.DoubleNumerics.Vector3 Translation;
    
    // StructProperty /Script/CoreUObject.Transform:Scale3D
    static readonly int Scale3D_Offset;
    public System.DoubleNumerics.Vector3 Scale3D;
    
    
    public static readonly int NativeDataSize;
    static Transform()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("Transform");
        
        Rotation_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Rotation");
        Translation_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Translation");
        Scale3D_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Scale3D");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public Transform(IntPtr InNativeStruct)
    {
        unsafe
        {
            Rotation = BlittableMarshaller<System.DoubleNumerics.Quaternion>.FromNative(IntPtr.Add(InNativeStruct, Rotation_Offset), 0, null);
            Translation = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Translation_Offset), 0, null);
            Scale3D = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Scale3D_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<System.DoubleNumerics.Quaternion>.ToNative(IntPtr.Add(Buffer, Rotation_Offset), 0, null, Rotation);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Translation_Offset), 0, null, Translation);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Scale3D_Offset), 0, null, Scale3D);
        }
    }
}

public static class TransformMarshaler
{
    public static Transform FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new Transform(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, Transform obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return Transform.NativeDataSize;
    }
}