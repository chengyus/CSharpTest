using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_FilterItemsByMetadataTags
{
    // BoolProperty /Script/ControlRig.RigUnit_FilterItemsByMetadataTags:Inclusive
    static readonly int Inclusive_Offset;
    public bool Inclusive;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_FilterItemsByMetadataTags()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_FilterItemsByMetadataTags");
        
        Inclusive_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Inclusive");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_FilterItemsByMetadataTags(IntPtr InNativeStruct)
    {
        unsafe
        {
            Inclusive = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, Inclusive_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, Inclusive_Offset), 0, null, Inclusive);
        }
    }
}

public static class RigUnit_FilterItemsByMetadataTagsMarshaler
{
    public static RigUnit_FilterItemsByMetadataTags FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_FilterItemsByMetadataTags(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_FilterItemsByMetadataTags obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_FilterItemsByMetadataTags.NativeDataSize;
    }
}