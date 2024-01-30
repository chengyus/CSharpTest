using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Foliage;

[UStruct]
public partial struct ProceduralFoliageInstance
{
    // StructProperty /Script/Foliage.ProceduralFoliageInstance:Location
    static readonly int Location_Offset;
    public System.DoubleNumerics.Vector3 Location;
    
    // FloatProperty /Script/Foliage.ProceduralFoliageInstance:Age
    static readonly int Age_Offset;
    public float Age;
    
    // StructProperty /Script/Foliage.ProceduralFoliageInstance:Normal
    static readonly int Normal_Offset;
    public System.DoubleNumerics.Vector3 Normal;
    
    
    public static readonly int NativeDataSize;
    static ProceduralFoliageInstance()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("ProceduralFoliageInstance");
        
        Location_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Location");
        Age_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Age");
        Normal_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Normal");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public ProceduralFoliageInstance(IntPtr InNativeStruct)
    {
        unsafe
        {
            Location = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Location_Offset), 0, null);
            Age = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Age_Offset), 0, null);
            Normal = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Normal_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Location_Offset), 0, null, Location);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Age_Offset), 0, null, Age);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Normal_Offset), 0, null, Normal);
        }
    }
}

public static class ProceduralFoliageInstanceMarshaler
{
    public static ProceduralFoliageInstance FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new ProceduralFoliageInstance(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, ProceduralFoliageInstance obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return ProceduralFoliageInstance.NativeDataSize;
    }
}