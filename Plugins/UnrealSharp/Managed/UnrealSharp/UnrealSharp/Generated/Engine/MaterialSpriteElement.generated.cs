using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct MaterialSpriteElement
{
    // ObjectProperty /Script/Engine.MaterialSpriteElement:Material
    static readonly int Material_Offset;
    public UnrealSharp.Engine.MaterialInterface Material;
    
    // ObjectProperty /Script/Engine.MaterialSpriteElement:DistanceToOpacityCurve
    static readonly int DistanceToOpacityCurve_Offset;
    public UnrealSharp.Engine.CurveFloat DistanceToOpacityCurve;
    
    // BoolProperty /Script/Engine.MaterialSpriteElement:bSizeIsInScreenSpace
    static readonly int bSizeIsInScreenSpace_Offset;
    static readonly IntPtr bSizeIsInScreenSpace_NativeProperty;
    public bool SizeIsInScreenSpace;
    
    // FloatProperty /Script/Engine.MaterialSpriteElement:BaseSizeX
    static readonly int BaseSizeX_Offset;
    public float BaseSizeX;
    
    // FloatProperty /Script/Engine.MaterialSpriteElement:BaseSizeY
    static readonly int BaseSizeY_Offset;
    public float BaseSizeY;
    
    // ObjectProperty /Script/Engine.MaterialSpriteElement:DistanceToSizeCurve
    static readonly int DistanceToSizeCurve_Offset;
    public UnrealSharp.Engine.CurveFloat DistanceToSizeCurve;
    
    
    public static readonly int NativeDataSize;
    static MaterialSpriteElement()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("MaterialSpriteElement");
        
        Material_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Material");
        DistanceToOpacityCurve_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DistanceToOpacityCurve");
        bSizeIsInScreenSpace_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bSizeIsInScreenSpace");
        bSizeIsInScreenSpace_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bSizeIsInScreenSpace");
        BaseSizeX_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BaseSizeX");
        BaseSizeY_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BaseSizeY");
        DistanceToSizeCurve_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DistanceToSizeCurve");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public MaterialSpriteElement(IntPtr InNativeStruct)
    {
        unsafe
        {
            Material = ObjectMarshaller<UnrealSharp.Engine.MaterialInterface>.FromNative(IntPtr.Add(InNativeStruct, Material_Offset), 0, null);
            DistanceToOpacityCurve = ObjectMarshaller<UnrealSharp.Engine.CurveFloat>.FromNative(IntPtr.Add(InNativeStruct, DistanceToOpacityCurve_Offset), 0, null);
            SizeIsInScreenSpace = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bSizeIsInScreenSpace_NativeProperty, bSizeIsInScreenSpace_Offset);
            BaseSizeX = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, BaseSizeX_Offset), 0, null);
            BaseSizeY = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, BaseSizeY_Offset), 0, null);
            DistanceToSizeCurve = ObjectMarshaller<UnrealSharp.Engine.CurveFloat>.FromNative(IntPtr.Add(InNativeStruct, DistanceToSizeCurve_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            ObjectMarshaller<UnrealSharp.Engine.MaterialInterface>.ToNative(IntPtr.Add(Buffer, Material_Offset), 0, null, Material);
            ObjectMarshaller<UnrealSharp.Engine.CurveFloat>.ToNative(IntPtr.Add(Buffer, DistanceToOpacityCurve_Offset), 0, null, DistanceToOpacityCurve);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bSizeIsInScreenSpace_NativeProperty, bSizeIsInScreenSpace_Offset, SizeIsInScreenSpace);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, BaseSizeX_Offset), 0, null, BaseSizeX);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, BaseSizeY_Offset), 0, null, BaseSizeY);
            ObjectMarshaller<UnrealSharp.Engine.CurveFloat>.ToNative(IntPtr.Add(Buffer, DistanceToSizeCurve_Offset), 0, null, DistanceToSizeCurve);
        }
    }
}

public static class MaterialSpriteElementMarshaler
{
    public static MaterialSpriteElement FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new MaterialSpriteElement(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, MaterialSpriteElement obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return MaterialSpriteElement.NativeDataSize;
    }
}