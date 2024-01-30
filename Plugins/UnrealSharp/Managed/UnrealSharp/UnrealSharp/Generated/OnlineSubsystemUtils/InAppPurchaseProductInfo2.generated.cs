using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.OnlineSubsystemUtils;

[UStruct]
public partial struct InAppPurchaseProductInfo2
{
    // FloatProperty /Script/OnlineSubsystemUtils.InAppPurchaseProductInfo2:RawPrice
    static readonly int RawPrice_Offset;
    public float RawPrice;
    
    
    public static readonly int NativeDataSize;
    static InAppPurchaseProductInfo2()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("InAppPurchaseProductInfo2");
        
        RawPrice_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "RawPrice");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public InAppPurchaseProductInfo2(IntPtr InNativeStruct)
    {
        unsafe
        {
            RawPrice = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, RawPrice_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, RawPrice_Offset), 0, null, RawPrice);
        }
    }
}

public static class InAppPurchaseProductInfo2Marshaler
{
    public static InAppPurchaseProductInfo2 FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new InAppPurchaseProductInfo2(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, InAppPurchaseProductInfo2 obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return InAppPurchaseProductInfo2.NativeDataSize;
    }
}