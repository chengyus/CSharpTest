using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.TakeRecorder;

[UStruct]
public partial struct TakeRecorderParameters
{
    // StructProperty /Script/TakeRecorder.TakeRecorderParameters:User
    static readonly int User_Offset;
    public UnrealSharp.TakeRecorder.TakeRecorderUserParameters User;
    
    // StructProperty /Script/TakeRecorder.TakeRecorderParameters:Project
    static readonly int Project_Offset;
    public UnrealSharp.TakeRecorder.TakeRecorderProjectParameters Project;
    
    // EnumProperty /Script/TakeRecorder.TakeRecorderParameters:TakeRecorderMode
    static readonly int TakeRecorderMode_Offset;
    public UnrealSharp.TakeRecorder.ETakeRecorderMode TakeRecorderMode;
    
    // StructProperty /Script/TakeRecorder.TakeRecorderParameters:StartFrame
    static readonly int StartFrame_Offset;
    public UnrealSharp.CoreUObject.FrameNumber StartFrame;
    
    
    public static readonly int NativeDataSize;
    static TakeRecorderParameters()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("TakeRecorderParameters");
        
        User_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "User");
        Project_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Project");
        TakeRecorderMode_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "TakeRecorderMode");
        StartFrame_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "StartFrame");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public TakeRecorderParameters(IntPtr InNativeStruct)
    {
        unsafe
        {
            User = UnrealSharp.TakeRecorder.TakeRecorderUserParametersMarshaler.FromNative(IntPtr.Add(InNativeStruct, User_Offset), 0, null);
            Project = UnrealSharp.TakeRecorder.TakeRecorderProjectParametersMarshaler.FromNative(IntPtr.Add(InNativeStruct, Project_Offset), 0, null);
            TakeRecorderMode = BlittableMarshaller<UnrealSharp.TakeRecorder.ETakeRecorderMode>.FromNative(IntPtr.Add(InNativeStruct, TakeRecorderMode_Offset), 0, null);
            StartFrame = BlittableMarshaller<UnrealSharp.CoreUObject.FrameNumber>.FromNative(IntPtr.Add(InNativeStruct, StartFrame_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.TakeRecorder.TakeRecorderUserParametersMarshaler.ToNative(IntPtr.Add(Buffer, User_Offset), 0, null, User);
            UnrealSharp.TakeRecorder.TakeRecorderProjectParametersMarshaler.ToNative(IntPtr.Add(Buffer, Project_Offset), 0, null, Project);
            BlittableMarshaller<UnrealSharp.TakeRecorder.ETakeRecorderMode>.ToNative(IntPtr.Add(Buffer, TakeRecorderMode_Offset), 0, null, TakeRecorderMode);
            BlittableMarshaller<UnrealSharp.CoreUObject.FrameNumber>.ToNative(IntPtr.Add(Buffer, StartFrame_Offset), 0, null, StartFrame);
        }
    }
}

public static class TakeRecorderParametersMarshaler
{
    public static TakeRecorderParameters FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new TakeRecorderParameters(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, TakeRecorderParameters obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return TakeRecorderParameters.NativeDataSize;
    }
}