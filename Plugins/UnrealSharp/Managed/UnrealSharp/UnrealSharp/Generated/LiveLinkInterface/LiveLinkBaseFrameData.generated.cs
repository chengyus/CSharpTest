using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.LiveLinkInterface;

[UStruct]
public partial struct LiveLinkBaseFrameData
{
    // StructProperty /Script/LiveLinkInterface.LiveLinkBaseFrameData:MetaData
    static readonly int MetaData_Offset;
    public UnrealSharp.LiveLinkInterface.LiveLinkMetaData MetaData;
    
    
    public static readonly int NativeDataSize;
    static LiveLinkBaseFrameData()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("LiveLinkBaseFrameData");
        
        MetaData_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MetaData");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public LiveLinkBaseFrameData(IntPtr InNativeStruct)
    {
        unsafe
        {
            MetaData = UnrealSharp.LiveLinkInterface.LiveLinkMetaDataMarshaler.FromNative(IntPtr.Add(InNativeStruct, MetaData_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.LiveLinkInterface.LiveLinkMetaDataMarshaler.ToNative(IntPtr.Add(Buffer, MetaData_Offset), 0, null, MetaData);
        }
    }
}

public static class LiveLinkBaseFrameDataMarshaler
{
    public static LiveLinkBaseFrameData FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new LiveLinkBaseFrameData(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, LiveLinkBaseFrameData obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return LiveLinkBaseFrameData.NativeDataSize;
    }
}