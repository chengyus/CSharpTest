using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct StaticMaterial
{
    // ObjectProperty /Script/Engine.StaticMaterial:MaterialInterface
    static readonly int MaterialInterface_Offset;
    public UnrealSharp.Engine.MaterialInterface MaterialInterface;
    
    // NameProperty /Script/Engine.StaticMaterial:MaterialSlotName
    static readonly int MaterialSlotName_Offset;
    public Name MaterialSlotName;
    
    // StructProperty /Script/Engine.StaticMaterial:UVChannelData
    static readonly int UVChannelData_Offset;
    public UnrealSharp.Engine.MeshUVChannelInfo UVChannelData;
    
    
    public static readonly int NativeDataSize;
    static StaticMaterial()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("StaticMaterial");
        
        MaterialInterface_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MaterialInterface");
        MaterialSlotName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MaterialSlotName");
        UVChannelData_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "UVChannelData");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public StaticMaterial(IntPtr InNativeStruct)
    {
        unsafe
        {
            MaterialInterface = ObjectMarshaller<UnrealSharp.Engine.MaterialInterface>.FromNative(IntPtr.Add(InNativeStruct, MaterialInterface_Offset), 0, null);
            MaterialSlotName = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, MaterialSlotName_Offset), 0, null);
            UVChannelData = UnrealSharp.Engine.MeshUVChannelInfoMarshaler.FromNative(IntPtr.Add(InNativeStruct, UVChannelData_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            ObjectMarshaller<UnrealSharp.Engine.MaterialInterface>.ToNative(IntPtr.Add(Buffer, MaterialInterface_Offset), 0, null, MaterialInterface);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, MaterialSlotName_Offset), 0, null, MaterialSlotName);
            UnrealSharp.Engine.MeshUVChannelInfoMarshaler.ToNative(IntPtr.Add(Buffer, UVChannelData_Offset), 0, null, UVChannelData);
        }
    }
}

public static class StaticMaterialMarshaler
{
    public static StaticMaterial FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new StaticMaterial(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, StaticMaterial obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return StaticMaterial.NativeDataSize;
    }
}