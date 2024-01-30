using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.LiveLinkInterface;

[UStruct]
public partial struct LiveLinkSubjectKey
{
    // StructProperty /Script/LiveLinkInterface.LiveLinkSubjectKey:Source
    static readonly int Source_Offset;
    public UnrealSharp.CoreUObject.Guid Source;
    
    // StructProperty /Script/LiveLinkInterface.LiveLinkSubjectKey:SubjectName
    static readonly int SubjectName_Offset;
    public UnrealSharp.LiveLinkInterface.LiveLinkSubjectName SubjectName;
    
    
    public static readonly int NativeDataSize;
    static LiveLinkSubjectKey()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("LiveLinkSubjectKey");
        
        Source_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Source");
        SubjectName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SubjectName");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public LiveLinkSubjectKey(IntPtr InNativeStruct)
    {
        unsafe
        {
            Source = UnrealSharp.CoreUObject.GuidMarshaler.FromNative(IntPtr.Add(InNativeStruct, Source_Offset), 0, null);
            SubjectName = BlittableMarshaller<UnrealSharp.LiveLinkInterface.LiveLinkSubjectName>.FromNative(IntPtr.Add(InNativeStruct, SubjectName_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.CoreUObject.GuidMarshaler.ToNative(IntPtr.Add(Buffer, Source_Offset), 0, null, Source);
            BlittableMarshaller<UnrealSharp.LiveLinkInterface.LiveLinkSubjectName>.ToNative(IntPtr.Add(Buffer, SubjectName_Offset), 0, null, SubjectName);
        }
    }
}

public static class LiveLinkSubjectKeyMarshaler
{
    public static LiveLinkSubjectKey FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new LiveLinkSubjectKey(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, LiveLinkSubjectKey obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return LiveLinkSubjectKey.NativeDataSize;
    }
}