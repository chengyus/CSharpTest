using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.GeometryCollectionEngine;

[UStruct]
public partial struct GeometryCollectionSource
{
    // StructProperty /Script/GeometryCollectionEngine.GeometryCollectionSource:SourceGeometryObject
    static readonly int SourceGeometryObject_Offset;
    public UnrealSharp.CoreUObject.SoftObjectPath SourceGeometryObject;
    
    // StructProperty /Script/GeometryCollectionEngine.GeometryCollectionSource:LocalTransform
    static readonly int LocalTransform_Offset;
    public UnrealSharp.Transform LocalTransform;
    
    // BoolProperty /Script/GeometryCollectionEngine.GeometryCollectionSource:bAddInternalMaterials
    static readonly int bAddInternalMaterials_Offset;
    public bool AddInternalMaterials;
    
    // BoolProperty /Script/GeometryCollectionEngine.GeometryCollectionSource:bSplitComponents
    static readonly int bSplitComponents_Offset;
    public bool SplitComponents;
    
    // BoolProperty /Script/GeometryCollectionEngine.GeometryCollectionSource:bSetInternalFromMaterialIndex
    static readonly int bSetInternalFromMaterialIndex_Offset;
    public bool SetInternalFromMaterialIndex;
    
    
    public static readonly int NativeDataSize;
    static GeometryCollectionSource()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("GeometryCollectionSource");
        
        SourceGeometryObject_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SourceGeometryObject");
        LocalTransform_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LocalTransform");
        bAddInternalMaterials_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bAddInternalMaterials");
        bSplitComponents_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bSplitComponents");
        bSetInternalFromMaterialIndex_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bSetInternalFromMaterialIndex");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public GeometryCollectionSource(IntPtr InNativeStruct)
    {
        unsafe
        {
            SourceGeometryObject = UnrealSharp.CoreUObject.SoftObjectPathMarshaler.FromNative(IntPtr.Add(InNativeStruct, SourceGeometryObject_Offset), 0, null);
            LocalTransform = BlittableMarshaller<UnrealSharp.Transform>.FromNative(IntPtr.Add(InNativeStruct, LocalTransform_Offset), 0, null);
            AddInternalMaterials = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bAddInternalMaterials_Offset), 0, null);
            SplitComponents = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bSplitComponents_Offset), 0, null);
            SetInternalFromMaterialIndex = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bSetInternalFromMaterialIndex_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.CoreUObject.SoftObjectPathMarshaler.ToNative(IntPtr.Add(Buffer, SourceGeometryObject_Offset), 0, null, SourceGeometryObject);
            BlittableMarshaller<UnrealSharp.Transform>.ToNative(IntPtr.Add(Buffer, LocalTransform_Offset), 0, null, LocalTransform);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bAddInternalMaterials_Offset), 0, null, AddInternalMaterials);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bSplitComponents_Offset), 0, null, SplitComponents);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bSetInternalFromMaterialIndex_Offset), 0, null, SetInternalFromMaterialIndex);
        }
    }
}

public static class GeometryCollectionSourceMarshaler
{
    public static GeometryCollectionSource FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new GeometryCollectionSource(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, GeometryCollectionSource obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return GeometryCollectionSource.NativeDataSize;
    }
}