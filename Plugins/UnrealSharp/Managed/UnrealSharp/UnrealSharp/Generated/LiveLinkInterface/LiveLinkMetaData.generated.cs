using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.LiveLinkInterface;

[UStruct]
public partial struct LiveLinkMetaData
{
    // StructProperty /Script/LiveLinkInterface.LiveLinkMetaData:SceneTime
    static readonly int SceneTime_Offset;
    public UnrealSharp.CoreUObject.QualifiedTime SceneTime;
    
    
    public static readonly int NativeDataSize;
    static LiveLinkMetaData()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("LiveLinkMetaData");
        
        SceneTime_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SceneTime");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public LiveLinkMetaData(IntPtr InNativeStruct)
    {
        unsafe
        {
            SceneTime = BlittableMarshaller<UnrealSharp.CoreUObject.QualifiedTime>.FromNative(IntPtr.Add(InNativeStruct, SceneTime_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.CoreUObject.QualifiedTime>.ToNative(IntPtr.Add(Buffer, SceneTime_Offset), 0, null, SceneTime);
        }
    }
}

public static class LiveLinkMetaDataMarshaler
{
    public static LiveLinkMetaData FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new LiveLinkMetaData(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, LiveLinkMetaData obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return LiveLinkMetaData.NativeDataSize;
    }
}