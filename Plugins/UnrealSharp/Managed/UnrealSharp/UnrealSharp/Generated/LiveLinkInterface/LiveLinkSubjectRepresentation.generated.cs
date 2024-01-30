using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.LiveLinkInterface;

[UStruct]
public partial struct LiveLinkSubjectRepresentation
{
    // StructProperty /Script/LiveLinkInterface.LiveLinkSubjectRepresentation:Subject
    static readonly int Subject_Offset;
    public UnrealSharp.LiveLinkInterface.LiveLinkSubjectName Subject;
    
    // ClassProperty /Script/LiveLinkInterface.LiveLinkSubjectRepresentation:Role
    static readonly int Role_Offset;
    public SubclassOf<UnrealSharp.LiveLinkInterface.LiveLinkRole> Role;
    
    
    public static readonly int NativeDataSize;
    static LiveLinkSubjectRepresentation()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("LiveLinkSubjectRepresentation");
        
        Subject_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Subject");
        Role_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Role");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public LiveLinkSubjectRepresentation(IntPtr InNativeStruct)
    {
        unsafe
        {
            Subject = BlittableMarshaller<UnrealSharp.LiveLinkInterface.LiveLinkSubjectName>.FromNative(IntPtr.Add(InNativeStruct, Subject_Offset), 0, null);
            Role = SubclassOfMarshaller<UnrealSharp.LiveLinkInterface.LiveLinkRole>.FromNative(IntPtr.Add(InNativeStruct, Role_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.LiveLinkInterface.LiveLinkSubjectName>.ToNative(IntPtr.Add(Buffer, Subject_Offset), 0, null, Subject);
            SubclassOfMarshaller<UnrealSharp.LiveLinkInterface.LiveLinkRole>.ToNative(IntPtr.Add(Buffer, Role_Offset), 0, null, Role);
        }
    }
}

public static class LiveLinkSubjectRepresentationMarshaler
{
    public static LiveLinkSubjectRepresentation FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new LiveLinkSubjectRepresentation(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, LiveLinkSubjectRepresentation obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return LiveLinkSubjectRepresentation.NativeDataSize;
    }
}