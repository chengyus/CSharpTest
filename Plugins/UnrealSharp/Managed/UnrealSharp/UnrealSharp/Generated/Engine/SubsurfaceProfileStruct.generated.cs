using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct SubsurfaceProfileStruct
{
    // StructProperty /Script/Engine.SubsurfaceProfileStruct:SurfaceAlbedo
    static readonly int SurfaceAlbedo_Offset;
    public UnrealSharp.CoreUObject.LinearColor SurfaceAlbedo;
    
    // StructProperty /Script/Engine.SubsurfaceProfileStruct:MeanFreePathColor
    static readonly int MeanFreePathColor_Offset;
    public UnrealSharp.CoreUObject.LinearColor MeanFreePathColor;
    
    // FloatProperty /Script/Engine.SubsurfaceProfileStruct:MeanFreePathDistance
    static readonly int MeanFreePathDistance_Offset;
    public float MeanFreePathDistance;
    
    // FloatProperty /Script/Engine.SubsurfaceProfileStruct:WorldUnitScale
    static readonly int WorldUnitScale_Offset;
    public float WorldUnitScale;
    
    // BoolProperty /Script/Engine.SubsurfaceProfileStruct:bEnableBurley
    static readonly int bEnableBurley_Offset;
    public bool EnableBurley;
    
    // BoolProperty /Script/Engine.SubsurfaceProfileStruct:bEnableMeanFreePath
    static readonly int bEnableMeanFreePath_Offset;
    public bool EnableMeanFreePath;
    
    // StructProperty /Script/Engine.SubsurfaceProfileStruct:Tint
    static readonly int Tint_Offset;
    public UnrealSharp.CoreUObject.LinearColor Tint;
    
    // FloatProperty /Script/Engine.SubsurfaceProfileStruct:ScatterRadius
    static readonly int ScatterRadius_Offset;
    public float ScatterRadius;
    
    // StructProperty /Script/Engine.SubsurfaceProfileStruct:SubsurfaceColor
    static readonly int SubsurfaceColor_Offset;
    public UnrealSharp.CoreUObject.LinearColor SubsurfaceColor;
    
    // StructProperty /Script/Engine.SubsurfaceProfileStruct:FalloffColor
    static readonly int FalloffColor_Offset;
    public UnrealSharp.CoreUObject.LinearColor FalloffColor;
    
    // StructProperty /Script/Engine.SubsurfaceProfileStruct:BoundaryColorBleed
    static readonly int BoundaryColorBleed_Offset;
    public UnrealSharp.CoreUObject.LinearColor BoundaryColorBleed;
    
    // FloatProperty /Script/Engine.SubsurfaceProfileStruct:ExtinctionScale
    static readonly int ExtinctionScale_Offset;
    public float ExtinctionScale;
    
    // FloatProperty /Script/Engine.SubsurfaceProfileStruct:NormalScale
    static readonly int NormalScale_Offset;
    public float NormalScale;
    
    // FloatProperty /Script/Engine.SubsurfaceProfileStruct:ScatteringDistribution
    static readonly int ScatteringDistribution_Offset;
    public float ScatteringDistribution;
    
    // FloatProperty /Script/Engine.SubsurfaceProfileStruct:IOR
    static readonly int IOR_Offset;
    public float IOR;
    
    // FloatProperty /Script/Engine.SubsurfaceProfileStruct:Roughness0
    static readonly int Roughness0_Offset;
    public float Roughness0;
    
    // FloatProperty /Script/Engine.SubsurfaceProfileStruct:Roughness1
    static readonly int Roughness1_Offset;
    public float Roughness1;
    
    // FloatProperty /Script/Engine.SubsurfaceProfileStruct:LobeMix
    static readonly int LobeMix_Offset;
    public float LobeMix;
    
    // StructProperty /Script/Engine.SubsurfaceProfileStruct:TransmissionTintColor
    static readonly int TransmissionTintColor_Offset;
    public UnrealSharp.CoreUObject.LinearColor TransmissionTintColor;
    
    
    public static readonly int NativeDataSize;
    static SubsurfaceProfileStruct()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("SubsurfaceProfileStruct");
        
        SurfaceAlbedo_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SurfaceAlbedo");
        MeanFreePathColor_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MeanFreePathColor");
        MeanFreePathDistance_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MeanFreePathDistance");
        WorldUnitScale_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "WorldUnitScale");
        bEnableBurley_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bEnableBurley");
        bEnableMeanFreePath_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bEnableMeanFreePath");
        Tint_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Tint");
        ScatterRadius_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ScatterRadius");
        SubsurfaceColor_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SubsurfaceColor");
        FalloffColor_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FalloffColor");
        BoundaryColorBleed_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BoundaryColorBleed");
        ExtinctionScale_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ExtinctionScale");
        NormalScale_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "NormalScale");
        ScatteringDistribution_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ScatteringDistribution");
        IOR_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "IOR");
        Roughness0_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Roughness0");
        Roughness1_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Roughness1");
        LobeMix_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LobeMix");
        TransmissionTintColor_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "TransmissionTintColor");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public SubsurfaceProfileStruct(IntPtr InNativeStruct)
    {
        unsafe
        {
            SurfaceAlbedo = BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.FromNative(IntPtr.Add(InNativeStruct, SurfaceAlbedo_Offset), 0, null);
            MeanFreePathColor = BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.FromNative(IntPtr.Add(InNativeStruct, MeanFreePathColor_Offset), 0, null);
            MeanFreePathDistance = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, MeanFreePathDistance_Offset), 0, null);
            WorldUnitScale = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, WorldUnitScale_Offset), 0, null);
            EnableBurley = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bEnableBurley_Offset), 0, null);
            EnableMeanFreePath = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bEnableMeanFreePath_Offset), 0, null);
            Tint = BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.FromNative(IntPtr.Add(InNativeStruct, Tint_Offset), 0, null);
            ScatterRadius = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, ScatterRadius_Offset), 0, null);
            SubsurfaceColor = BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.FromNative(IntPtr.Add(InNativeStruct, SubsurfaceColor_Offset), 0, null);
            FalloffColor = BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.FromNative(IntPtr.Add(InNativeStruct, FalloffColor_Offset), 0, null);
            BoundaryColorBleed = BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.FromNative(IntPtr.Add(InNativeStruct, BoundaryColorBleed_Offset), 0, null);
            ExtinctionScale = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, ExtinctionScale_Offset), 0, null);
            NormalScale = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, NormalScale_Offset), 0, null);
            ScatteringDistribution = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, ScatteringDistribution_Offset), 0, null);
            IOR = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, IOR_Offset), 0, null);
            Roughness0 = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Roughness0_Offset), 0, null);
            Roughness1 = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Roughness1_Offset), 0, null);
            LobeMix = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, LobeMix_Offset), 0, null);
            TransmissionTintColor = BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.FromNative(IntPtr.Add(InNativeStruct, TransmissionTintColor_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.ToNative(IntPtr.Add(Buffer, SurfaceAlbedo_Offset), 0, null, SurfaceAlbedo);
            BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.ToNative(IntPtr.Add(Buffer, MeanFreePathColor_Offset), 0, null, MeanFreePathColor);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, MeanFreePathDistance_Offset), 0, null, MeanFreePathDistance);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, WorldUnitScale_Offset), 0, null, WorldUnitScale);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bEnableBurley_Offset), 0, null, EnableBurley);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bEnableMeanFreePath_Offset), 0, null, EnableMeanFreePath);
            BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.ToNative(IntPtr.Add(Buffer, Tint_Offset), 0, null, Tint);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, ScatterRadius_Offset), 0, null, ScatterRadius);
            BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.ToNative(IntPtr.Add(Buffer, SubsurfaceColor_Offset), 0, null, SubsurfaceColor);
            BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.ToNative(IntPtr.Add(Buffer, FalloffColor_Offset), 0, null, FalloffColor);
            BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.ToNative(IntPtr.Add(Buffer, BoundaryColorBleed_Offset), 0, null, BoundaryColorBleed);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, ExtinctionScale_Offset), 0, null, ExtinctionScale);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, NormalScale_Offset), 0, null, NormalScale);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, ScatteringDistribution_Offset), 0, null, ScatteringDistribution);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, IOR_Offset), 0, null, IOR);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Roughness0_Offset), 0, null, Roughness0);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Roughness1_Offset), 0, null, Roughness1);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, LobeMix_Offset), 0, null, LobeMix);
            BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.ToNative(IntPtr.Add(Buffer, TransmissionTintColor_Offset), 0, null, TransmissionTintColor);
        }
    }
}

public static class SubsurfaceProfileStructMarshaler
{
    public static SubsurfaceProfileStruct FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new SubsurfaceProfileStruct(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, SubsurfaceProfileStruct obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return SubsurfaceProfileStruct.NativeDataSize;
    }
}