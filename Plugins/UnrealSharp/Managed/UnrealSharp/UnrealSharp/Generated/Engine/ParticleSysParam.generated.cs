using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct ParticleSysParam
{
    // NameProperty /Script/Engine.ParticleSysParam:Name
    static readonly int Name_Offset;
    public Name Name;
    
    // ByteProperty /Script/Engine.ParticleSysParam:ParamType
    static readonly int ParamType_Offset;
    public UnrealSharp.Engine.EParticleSysParamType ParamType;
    
    // FloatProperty /Script/Engine.ParticleSysParam:Scalar
    static readonly int Scalar_Offset;
    public float Scalar;
    
    // FloatProperty /Script/Engine.ParticleSysParam:Scalar_Low
    static readonly int Scalar_Low_Offset;
    public float Scalar_Low;
    
    // StructProperty /Script/Engine.ParticleSysParam:Vector
    static readonly int Vector_Offset;
    public System.DoubleNumerics.Vector3 Vector;
    
    // StructProperty /Script/Engine.ParticleSysParam:Vector_Low
    static readonly int Vector_Low_Offset;
    public System.DoubleNumerics.Vector3 Vector_Low;
    
    // StructProperty /Script/Engine.ParticleSysParam:Color
    static readonly int Color_Offset;
    public UnrealSharp.CoreUObject.Color Color;
    
    // ObjectProperty /Script/Engine.ParticleSysParam:Actor
    static readonly int Actor_Offset;
    public UnrealSharp.Engine.Actor Actor;
    
    // ObjectProperty /Script/Engine.ParticleSysParam:Material
    static readonly int Material_Offset;
    public UnrealSharp.Engine.MaterialInterface Material;
    
    
    public static readonly int NativeDataSize;
    static ParticleSysParam()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("ParticleSysParam");
        
        Name_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Name");
        ParamType_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ParamType");
        Scalar_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Scalar");
        Scalar_Low_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Scalar_Low");
        Vector_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Vector");
        Vector_Low_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Vector_Low");
        Color_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Color");
        Actor_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Actor");
        Material_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Material");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public ParticleSysParam(IntPtr InNativeStruct)
    {
        unsafe
        {
            Name = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, Name_Offset), 0, null);
            ParamType = BlittableMarshaller<UnrealSharp.Engine.EParticleSysParamType>.FromNative(IntPtr.Add(InNativeStruct, ParamType_Offset), 0, null);
            Scalar = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Scalar_Offset), 0, null);
            Scalar_Low = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Scalar_Low_Offset), 0, null);
            Vector = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Vector_Offset), 0, null);
            Vector_Low = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Vector_Low_Offset), 0, null);
            Color = BlittableMarshaller<UnrealSharp.CoreUObject.Color>.FromNative(IntPtr.Add(InNativeStruct, Color_Offset), 0, null);
            Actor = ObjectMarshaller<UnrealSharp.Engine.Actor>.FromNative(IntPtr.Add(InNativeStruct, Actor_Offset), 0, null);
            Material = ObjectMarshaller<UnrealSharp.Engine.MaterialInterface>.FromNative(IntPtr.Add(InNativeStruct, Material_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, Name_Offset), 0, null, Name);
            BlittableMarshaller<UnrealSharp.Engine.EParticleSysParamType>.ToNative(IntPtr.Add(Buffer, ParamType_Offset), 0, null, ParamType);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Scalar_Offset), 0, null, Scalar);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Scalar_Low_Offset), 0, null, Scalar_Low);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Vector_Offset), 0, null, Vector);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Vector_Low_Offset), 0, null, Vector_Low);
            BlittableMarshaller<UnrealSharp.CoreUObject.Color>.ToNative(IntPtr.Add(Buffer, Color_Offset), 0, null, Color);
            ObjectMarshaller<UnrealSharp.Engine.Actor>.ToNative(IntPtr.Add(Buffer, Actor_Offset), 0, null, Actor);
            ObjectMarshaller<UnrealSharp.Engine.MaterialInterface>.ToNative(IntPtr.Add(Buffer, Material_Offset), 0, null, Material);
        }
    }
}

public static class ParticleSysParamMarshaler
{
    public static ParticleSysParam FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new ParticleSysParam(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, ParticleSysParam obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return ParticleSysParam.NativeDataSize;
    }
}