using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.OnlineSubsystemUtils;

[UStruct]
public partial struct InAppPurchaseProductRequest2
{
    // BoolProperty /Script/OnlineSubsystemUtils.InAppPurchaseProductRequest2:bIsConsumable
    static readonly int bIsConsumable_Offset;
    public bool IsConsumable;
    
    
    public static readonly int NativeDataSize;
    static InAppPurchaseProductRequest2()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("InAppPurchaseProductRequest2");
        
        bIsConsumable_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bIsConsumable");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public InAppPurchaseProductRequest2(IntPtr InNativeStruct)
    {
        unsafe
        {
            IsConsumable = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bIsConsumable_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bIsConsumable_Offset), 0, null, IsConsumable);
        }
    }
}

public static class InAppPurchaseProductRequest2Marshaler
{
    public static InAppPurchaseProductRequest2 FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new InAppPurchaseProductRequest2(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, InAppPurchaseProductRequest2 obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return InAppPurchaseProductRequest2.NativeDataSize;
    }
}