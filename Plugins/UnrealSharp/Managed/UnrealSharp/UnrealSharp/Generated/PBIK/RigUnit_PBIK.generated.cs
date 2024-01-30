using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.PBIK;

[UStruct]
public partial struct RigUnit_PBIK
{
    // NameProperty /Script/PBIK.RigUnit_PBIK:Root
    static readonly int Root_Offset;
    public Name Root;
    
    // StructProperty /Script/PBIK.RigUnit_PBIK:Settings
    static readonly int Settings_Offset;
    public UnrealSharp.PBIK.PBIKSolverSettings Settings;
    
    // StructProperty /Script/PBIK.RigUnit_PBIK:Debug
    static readonly int Debug_Offset;
    public UnrealSharp.PBIK.PBIKDebug Debug;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_PBIK()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_PBIK");
        
        Root_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Root");
        Settings_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Settings");
        Debug_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Debug");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_PBIK(IntPtr InNativeStruct)
    {
        unsafe
        {
            Root = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, Root_Offset), 0, null);
            Settings = UnrealSharp.PBIK.PBIKSolverSettingsMarshaler.FromNative(IntPtr.Add(InNativeStruct, Settings_Offset), 0, null);
            Debug = UnrealSharp.PBIK.PBIKDebugMarshaler.FromNative(IntPtr.Add(InNativeStruct, Debug_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, Root_Offset), 0, null, Root);
            UnrealSharp.PBIK.PBIKSolverSettingsMarshaler.ToNative(IntPtr.Add(Buffer, Settings_Offset), 0, null, Settings);
            UnrealSharp.PBIK.PBIKDebugMarshaler.ToNative(IntPtr.Add(Buffer, Debug_Offset), 0, null, Debug);
        }
    }
}

public static class RigUnit_PBIKMarshaler
{
    public static RigUnit_PBIK FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_PBIK(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_PBIK obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_PBIK.NativeDataSize;
    }
}