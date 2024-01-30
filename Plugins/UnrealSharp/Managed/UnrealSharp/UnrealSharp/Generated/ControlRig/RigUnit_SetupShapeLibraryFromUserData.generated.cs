using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_SetupShapeLibraryFromUserData
{
    // BoolProperty /Script/ControlRig.RigUnit_SetupShapeLibraryFromUserData:ReplaceExisting
    static readonly int ReplaceExisting_Offset;
    public bool ReplaceExisting;
    
    // BoolProperty /Script/ControlRig.RigUnit_SetupShapeLibraryFromUserData:LogShapeLibraries
    static readonly int LogShapeLibraries_Offset;
    public bool LogShapeLibraries;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_SetupShapeLibraryFromUserData()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_SetupShapeLibraryFromUserData");
        
        ReplaceExisting_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ReplaceExisting");
        LogShapeLibraries_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LogShapeLibraries");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_SetupShapeLibraryFromUserData(IntPtr InNativeStruct)
    {
        unsafe
        {
            ReplaceExisting = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, ReplaceExisting_Offset), 0, null);
            LogShapeLibraries = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, LogShapeLibraries_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, ReplaceExisting_Offset), 0, null, ReplaceExisting);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, LogShapeLibraries_Offset), 0, null, LogShapeLibraries);
        }
    }
}

public static class RigUnit_SetupShapeLibraryFromUserDataMarshaler
{
    public static RigUnit_SetupShapeLibraryFromUserData FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_SetupShapeLibraryFromUserData(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_SetupShapeLibraryFromUserData obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_SetupShapeLibraryFromUserData.NativeDataSize;
    }
}