using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AssetDefinition;

[UStruct]
public partial struct RevisionInfo
{
    // IntProperty /Script/AssetDefinition.RevisionInfo:Changelist
    static readonly int Changelist_Offset;
    public int Changelist;
    
    // StructProperty /Script/AssetDefinition.RevisionInfo:Date
    static readonly int Date_Offset;
    public UnrealSharp.CoreUObject.DateTime Date;
    
    
    public static readonly int NativeDataSize;
    static RevisionInfo()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RevisionInfo");
        
        Changelist_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Changelist");
        Date_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Date");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RevisionInfo(IntPtr InNativeStruct)
    {
        unsafe
        {
            Changelist = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, Changelist_Offset), 0, null);
            Date = UnrealSharp.CoreUObject.DateTimeMarshaler.FromNative(IntPtr.Add(InNativeStruct, Date_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, Changelist_Offset), 0, null, Changelist);
            UnrealSharp.CoreUObject.DateTimeMarshaler.ToNative(IntPtr.Add(Buffer, Date_Offset), 0, null, Date);
        }
    }
}

public static class RevisionInfoMarshaler
{
    public static RevisionInfo FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RevisionInfo(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RevisionInfo obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RevisionInfo.NativeDataSize;
    }
}