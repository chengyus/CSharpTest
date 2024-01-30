using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.OnlineSubsystemUtils;

[UStruct]
public partial struct InAppPurchaseRestoreInfo2
{
    
    public static readonly int NativeDataSize;
    static InAppPurchaseRestoreInfo2()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("InAppPurchaseRestoreInfo2");
        
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public InAppPurchaseRestoreInfo2(IntPtr InNativeStruct)
    {
        unsafe
        {
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
        }
    }
}

public static class InAppPurchaseRestoreInfo2Marshaler
{
    public static InAppPurchaseRestoreInfo2 FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new InAppPurchaseRestoreInfo2(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, InAppPurchaseRestoreInfo2 obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return InAppPurchaseRestoreInfo2.NativeDataSize;
    }
}