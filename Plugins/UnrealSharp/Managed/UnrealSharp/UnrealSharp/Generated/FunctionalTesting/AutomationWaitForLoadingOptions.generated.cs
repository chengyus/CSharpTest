using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.FunctionalTesting;

[UStruct]
public partial struct AutomationWaitForLoadingOptions
{
    // BoolProperty /Script/FunctionalTesting.AutomationWaitForLoadingOptions:WaitForReplicationToSettle
    static readonly int WaitForReplicationToSettle_Offset;
    public bool WaitForReplicationToSettle;
    
    
    public static readonly int NativeDataSize;
    static AutomationWaitForLoadingOptions()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("AutomationWaitForLoadingOptions");
        
        WaitForReplicationToSettle_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "WaitForReplicationToSettle");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public AutomationWaitForLoadingOptions(IntPtr InNativeStruct)
    {
        unsafe
        {
            WaitForReplicationToSettle = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, WaitForReplicationToSettle_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, WaitForReplicationToSettle_Offset), 0, null, WaitForReplicationToSettle);
        }
    }
}

public static class AutomationWaitForLoadingOptionsMarshaler
{
    public static AutomationWaitForLoadingOptions FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new AutomationWaitForLoadingOptions(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, AutomationWaitForLoadingOptions obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return AutomationWaitForLoadingOptions.NativeDataSize;
    }
}