using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Niagara;

[UStruct]
public partial struct BasicParticleData
{
    // StructProperty /Script/Niagara.BasicParticleData:Position
    static readonly int Position_Offset;
    public System.DoubleNumerics.Vector3 Position;
    
    // FloatProperty /Script/Niagara.BasicParticleData:Size
    static readonly int Size_Offset;
    public float Size;
    
    // StructProperty /Script/Niagara.BasicParticleData:Velocity
    static readonly int Velocity_Offset;
    public System.DoubleNumerics.Vector3 Velocity;
    
    
    public static readonly int NativeDataSize;
    static BasicParticleData()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("BasicParticleData");
        
        Position_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Position");
        Size_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Size");
        Velocity_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Velocity");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public BasicParticleData(IntPtr InNativeStruct)
    {
        unsafe
        {
            Position = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Position_Offset), 0, null);
            Size = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Size_Offset), 0, null);
            Velocity = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Velocity_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Position_Offset), 0, null, Position);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Size_Offset), 0, null, Size);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Velocity_Offset), 0, null, Velocity);
        }
    }
}

public static class BasicParticleDataMarshaler
{
    public static BasicParticleData FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new BasicParticleData(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, BasicParticleData obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return BasicParticleData.NativeDataSize;
    }
}