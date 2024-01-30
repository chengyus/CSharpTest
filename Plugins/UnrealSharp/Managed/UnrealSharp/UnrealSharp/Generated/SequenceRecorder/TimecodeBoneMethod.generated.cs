using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.SequenceRecorder;

[UStruct]
public partial struct TimecodeBoneMethod
{
    // EnumProperty /Script/SequenceRecorder.TimecodeBoneMethod:BoneMode
    static readonly int BoneMode_Offset;
    public UnrealSharp.SequenceRecorder.ETimecodeBoneMode BoneMode;
    
    // NameProperty /Script/SequenceRecorder.TimecodeBoneMethod:BoneName
    static readonly int BoneName_Offset;
    public Name BoneName;
    
    
    public static readonly int NativeDataSize;
    static TimecodeBoneMethod()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("TimecodeBoneMethod");
        
        BoneMode_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BoneMode");
        BoneName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BoneName");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public TimecodeBoneMethod(IntPtr InNativeStruct)
    {
        unsafe
        {
            BoneMode = BlittableMarshaller<UnrealSharp.SequenceRecorder.ETimecodeBoneMode>.FromNative(IntPtr.Add(InNativeStruct, BoneMode_Offset), 0, null);
            BoneName = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, BoneName_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.SequenceRecorder.ETimecodeBoneMode>.ToNative(IntPtr.Add(Buffer, BoneMode_Offset), 0, null, BoneMode);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, BoneName_Offset), 0, null, BoneName);
        }
    }
}

public static class TimecodeBoneMethodMarshaler
{
    public static TimecodeBoneMethod FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new TimecodeBoneMethod(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, TimecodeBoneMethod obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return TimecodeBoneMethod.NativeDataSize;
    }
}