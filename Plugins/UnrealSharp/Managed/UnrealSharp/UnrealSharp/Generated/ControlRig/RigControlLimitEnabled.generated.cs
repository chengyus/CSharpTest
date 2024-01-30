using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigControlLimitEnabled
{
    // BoolProperty /Script/ControlRig.RigControlLimitEnabled:bMinimum
    static readonly int bMinimum_Offset;
    public bool Minimum;
    
    // BoolProperty /Script/ControlRig.RigControlLimitEnabled:bMaximum
    static readonly int bMaximum_Offset;
    public bool Maximum;
    
    
    public static readonly int NativeDataSize;
    static RigControlLimitEnabled()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigControlLimitEnabled");
        
        bMinimum_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bMinimum");
        bMaximum_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bMaximum");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigControlLimitEnabled(IntPtr InNativeStruct)
    {
        unsafe
        {
            Minimum = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bMinimum_Offset), 0, null);
            Maximum = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bMaximum_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bMinimum_Offset), 0, null, Minimum);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bMaximum_Offset), 0, null, Maximum);
        }
    }
}

public static class RigControlLimitEnabledMarshaler
{
    public static RigControlLimitEnabled FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigControlLimitEnabled(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigControlLimitEnabled obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigControlLimitEnabled.NativeDataSize;
    }
}