using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.GeometryFramework;

[UStruct]
public partial struct DynamicMeshChangeInfo
{
    // EnumProperty /Script/GeometryFramework.DynamicMeshChangeInfo:Type
    static readonly int Type_Offset;
    public UnrealSharp.GeometryFramework.EDynamicMeshChangeType Type;
    
    // EnumProperty /Script/GeometryFramework.DynamicMeshChangeInfo:Flags
    static readonly int Flags_Offset;
    public UnrealSharp.GeometryFramework.EDynamicMeshAttributeChangeFlags Flags;
    
    // BoolProperty /Script/GeometryFramework.DynamicMeshChangeInfo:bIsRevertChange
    static readonly int bIsRevertChange_Offset;
    public bool IsRevertChange;
    
    
    public static readonly int NativeDataSize;
    static DynamicMeshChangeInfo()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("DynamicMeshChangeInfo");
        
        Type_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Type");
        Flags_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Flags");
        bIsRevertChange_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bIsRevertChange");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public DynamicMeshChangeInfo(IntPtr InNativeStruct)
    {
        unsafe
        {
            Type = BlittableMarshaller<UnrealSharp.GeometryFramework.EDynamicMeshChangeType>.FromNative(IntPtr.Add(InNativeStruct, Type_Offset), 0, null);
            Flags = BlittableMarshaller<UnrealSharp.GeometryFramework.EDynamicMeshAttributeChangeFlags>.FromNative(IntPtr.Add(InNativeStruct, Flags_Offset), 0, null);
            IsRevertChange = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bIsRevertChange_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.GeometryFramework.EDynamicMeshChangeType>.ToNative(IntPtr.Add(Buffer, Type_Offset), 0, null, Type);
            BlittableMarshaller<UnrealSharp.GeometryFramework.EDynamicMeshAttributeChangeFlags>.ToNative(IntPtr.Add(Buffer, Flags_Offset), 0, null, Flags);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bIsRevertChange_Offset), 0, null, IsRevertChange);
        }
    }
}

public static class DynamicMeshChangeInfoMarshaler
{
    public static DynamicMeshChangeInfo FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new DynamicMeshChangeInfo(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, DynamicMeshChangeInfo obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return DynamicMeshChangeInfo.NativeDataSize;
    }
}