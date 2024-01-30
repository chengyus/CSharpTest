using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct FXSystemSpawnParameters
{
    // ObjectProperty /Script/Engine.FXSystemSpawnParameters:WorldContextObject
    static readonly int WorldContextObject_Offset;
    public UnrealSharp.CoreUObject.Object WorldContextObject;
    
    // ObjectProperty /Script/Engine.FXSystemSpawnParameters:SystemTemplate
    static readonly int SystemTemplate_Offset;
    public UnrealSharp.Engine.FXSystemAsset SystemTemplate;
    
    // StructProperty /Script/Engine.FXSystemSpawnParameters:Location
    static readonly int Location_Offset;
    public System.DoubleNumerics.Vector3 Location;
    
    // StructProperty /Script/Engine.FXSystemSpawnParameters:Rotation
    static readonly int Rotation_Offset;
    public UnrealSharp.Rotator Rotation;
    
    // StructProperty /Script/Engine.FXSystemSpawnParameters:Scale
    static readonly int Scale_Offset;
    public System.DoubleNumerics.Vector3 Scale;
    
    // ObjectProperty /Script/Engine.FXSystemSpawnParameters:AttachToComponent
    static readonly int AttachToComponent_Offset;
    public UnrealSharp.Engine.SceneComponent AttachToComponent;
    
    // NameProperty /Script/Engine.FXSystemSpawnParameters:AttachPointName
    static readonly int AttachPointName_Offset;
    public Name AttachPointName;
    
    // ByteProperty /Script/Engine.FXSystemSpawnParameters:LocationType
    static readonly int LocationType_Offset;
    public UnrealSharp.Engine.EAttachLocation LocationType;
    
    // BoolProperty /Script/Engine.FXSystemSpawnParameters:bAutoDestroy
    static readonly int bAutoDestroy_Offset;
    public bool AutoDestroy;
    
    // BoolProperty /Script/Engine.FXSystemSpawnParameters:bAutoActivate
    static readonly int bAutoActivate_Offset;
    public bool AutoActivate;
    
    // EnumProperty /Script/Engine.FXSystemSpawnParameters:PoolingMethod
    static readonly int PoolingMethod_Offset;
    public UnrealSharp.Engine.EPSCPoolMethod PoolingMethod;
    
    // BoolProperty /Script/Engine.FXSystemSpawnParameters:bPreCullCheck
    static readonly int bPreCullCheck_Offset;
    public bool PreCullCheck;
    
    // BoolProperty /Script/Engine.FXSystemSpawnParameters:bIsPlayerEffect
    static readonly int bIsPlayerEffect_Offset;
    public bool IsPlayerEffect;
    
    
    public static readonly int NativeDataSize;
    static FXSystemSpawnParameters()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("FXSystemSpawnParameters");
        
        WorldContextObject_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "WorldContextObject");
        SystemTemplate_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SystemTemplate");
        Location_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Location");
        Rotation_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Rotation");
        Scale_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Scale");
        AttachToComponent_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AttachToComponent");
        AttachPointName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AttachPointName");
        LocationType_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LocationType");
        bAutoDestroy_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bAutoDestroy");
        bAutoActivate_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bAutoActivate");
        PoolingMethod_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PoolingMethod");
        bPreCullCheck_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bPreCullCheck");
        bIsPlayerEffect_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bIsPlayerEffect");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public FXSystemSpawnParameters(IntPtr InNativeStruct)
    {
        unsafe
        {
            WorldContextObject = ObjectMarshaller<UnrealSharp.CoreUObject.Object>.FromNative(IntPtr.Add(InNativeStruct, WorldContextObject_Offset), 0, null);
            SystemTemplate = ObjectMarshaller<UnrealSharp.Engine.FXSystemAsset>.FromNative(IntPtr.Add(InNativeStruct, SystemTemplate_Offset), 0, null);
            Location = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Location_Offset), 0, null);
            Rotation = BlittableMarshaller<UnrealSharp.Rotator>.FromNative(IntPtr.Add(InNativeStruct, Rotation_Offset), 0, null);
            Scale = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Scale_Offset), 0, null);
            AttachToComponent = ObjectMarshaller<UnrealSharp.Engine.SceneComponent>.FromNative(IntPtr.Add(InNativeStruct, AttachToComponent_Offset), 0, null);
            AttachPointName = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, AttachPointName_Offset), 0, null);
            LocationType = BlittableMarshaller<UnrealSharp.Engine.EAttachLocation>.FromNative(IntPtr.Add(InNativeStruct, LocationType_Offset), 0, null);
            AutoDestroy = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bAutoDestroy_Offset), 0, null);
            AutoActivate = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bAutoActivate_Offset), 0, null);
            PoolingMethod = BlittableMarshaller<UnrealSharp.Engine.EPSCPoolMethod>.FromNative(IntPtr.Add(InNativeStruct, PoolingMethod_Offset), 0, null);
            PreCullCheck = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bPreCullCheck_Offset), 0, null);
            IsPlayerEffect = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bIsPlayerEffect_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            ObjectMarshaller<UnrealSharp.CoreUObject.Object>.ToNative(IntPtr.Add(Buffer, WorldContextObject_Offset), 0, null, WorldContextObject);
            ObjectMarshaller<UnrealSharp.Engine.FXSystemAsset>.ToNative(IntPtr.Add(Buffer, SystemTemplate_Offset), 0, null, SystemTemplate);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Location_Offset), 0, null, Location);
            BlittableMarshaller<UnrealSharp.Rotator>.ToNative(IntPtr.Add(Buffer, Rotation_Offset), 0, null, Rotation);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Scale_Offset), 0, null, Scale);
            ObjectMarshaller<UnrealSharp.Engine.SceneComponent>.ToNative(IntPtr.Add(Buffer, AttachToComponent_Offset), 0, null, AttachToComponent);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, AttachPointName_Offset), 0, null, AttachPointName);
            BlittableMarshaller<UnrealSharp.Engine.EAttachLocation>.ToNative(IntPtr.Add(Buffer, LocationType_Offset), 0, null, LocationType);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bAutoDestroy_Offset), 0, null, AutoDestroy);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bAutoActivate_Offset), 0, null, AutoActivate);
            BlittableMarshaller<UnrealSharp.Engine.EPSCPoolMethod>.ToNative(IntPtr.Add(Buffer, PoolingMethod_Offset), 0, null, PoolingMethod);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bPreCullCheck_Offset), 0, null, PreCullCheck);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bIsPlayerEffect_Offset), 0, null, IsPlayerEffect);
        }
    }
}

public static class FXSystemSpawnParametersMarshaler
{
    public static FXSystemSpawnParameters FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new FXSystemSpawnParameters(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, FXSystemSpawnParameters obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return FXSystemSpawnParameters.NativeDataSize;
    }
}