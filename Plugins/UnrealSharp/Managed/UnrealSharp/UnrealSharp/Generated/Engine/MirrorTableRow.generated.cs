using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct MirrorTableRow
{
    // NameProperty /Script/Engine.MirrorTableRow:Name
    static readonly int Name_Offset;
    public Name Name;
    
    // NameProperty /Script/Engine.MirrorTableRow:MirroredName
    static readonly int MirroredName_Offset;
    public Name MirroredName;
    
    // ByteProperty /Script/Engine.MirrorTableRow:MirrorEntryType
    static readonly int MirrorEntryType_Offset;
    public UnrealSharp.Engine.EMirrorRowType MirrorEntryType;
    
    
    public static readonly int NativeDataSize;
    static MirrorTableRow()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("MirrorTableRow");
        
        Name_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Name");
        MirroredName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MirroredName");
        MirrorEntryType_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MirrorEntryType");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public MirrorTableRow(IntPtr InNativeStruct)
    {
        unsafe
        {
            Name = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, Name_Offset), 0, null);
            MirroredName = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, MirroredName_Offset), 0, null);
            MirrorEntryType = BlittableMarshaller<UnrealSharp.Engine.EMirrorRowType>.FromNative(IntPtr.Add(InNativeStruct, MirrorEntryType_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, Name_Offset), 0, null, Name);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, MirroredName_Offset), 0, null, MirroredName);
            BlittableMarshaller<UnrealSharp.Engine.EMirrorRowType>.ToNative(IntPtr.Add(Buffer, MirrorEntryType_Offset), 0, null, MirrorEntryType);
        }
    }
}

public static class MirrorTableRowMarshaler
{
    public static MirrorTableRow FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new MirrorTableRow(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, MirrorTableRow obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return MirrorTableRow.NativeDataSize;
    }
}