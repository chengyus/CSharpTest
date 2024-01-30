using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.OnlineSubsystemUtils;

[UStruct]
public partial struct OnlineProxyStoreOffer
{
    // IntProperty /Script/OnlineSubsystemUtils.OnlineProxyStoreOffer:RegularPrice
    static readonly int RegularPrice_Offset;
    public int RegularPrice;
    
    // IntProperty /Script/OnlineSubsystemUtils.OnlineProxyStoreOffer:NumericPrice
    static readonly int NumericPrice_Offset;
    public int NumericPrice;
    
    // StructProperty /Script/OnlineSubsystemUtils.OnlineProxyStoreOffer:ReleaseDate
    static readonly int ReleaseDate_Offset;
    public UnrealSharp.CoreUObject.DateTime ReleaseDate;
    
    // StructProperty /Script/OnlineSubsystemUtils.OnlineProxyStoreOffer:ExpirationDate
    static readonly int ExpirationDate_Offset;
    public UnrealSharp.CoreUObject.DateTime ExpirationDate;
    
    // EnumProperty /Script/OnlineSubsystemUtils.OnlineProxyStoreOffer:DiscountType
    static readonly int DiscountType_Offset;
    public UnrealSharp.OnlineSubsystemUtils.EOnlineProxyStoreOfferDiscountType DiscountType;
    
    
    public static readonly int NativeDataSize;
    static OnlineProxyStoreOffer()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("OnlineProxyStoreOffer");
        
        RegularPrice_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "RegularPrice");
        NumericPrice_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "NumericPrice");
        ReleaseDate_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ReleaseDate");
        ExpirationDate_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ExpirationDate");
        DiscountType_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DiscountType");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public OnlineProxyStoreOffer(IntPtr InNativeStruct)
    {
        unsafe
        {
            RegularPrice = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, RegularPrice_Offset), 0, null);
            NumericPrice = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, NumericPrice_Offset), 0, null);
            ReleaseDate = UnrealSharp.CoreUObject.DateTimeMarshaler.FromNative(IntPtr.Add(InNativeStruct, ReleaseDate_Offset), 0, null);
            ExpirationDate = UnrealSharp.CoreUObject.DateTimeMarshaler.FromNative(IntPtr.Add(InNativeStruct, ExpirationDate_Offset), 0, null);
            DiscountType = BlittableMarshaller<UnrealSharp.OnlineSubsystemUtils.EOnlineProxyStoreOfferDiscountType>.FromNative(IntPtr.Add(InNativeStruct, DiscountType_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, RegularPrice_Offset), 0, null, RegularPrice);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, NumericPrice_Offset), 0, null, NumericPrice);
            UnrealSharp.CoreUObject.DateTimeMarshaler.ToNative(IntPtr.Add(Buffer, ReleaseDate_Offset), 0, null, ReleaseDate);
            UnrealSharp.CoreUObject.DateTimeMarshaler.ToNative(IntPtr.Add(Buffer, ExpirationDate_Offset), 0, null, ExpirationDate);
            BlittableMarshaller<UnrealSharp.OnlineSubsystemUtils.EOnlineProxyStoreOfferDiscountType>.ToNative(IntPtr.Add(Buffer, DiscountType_Offset), 0, null, DiscountType);
        }
    }
}

public static class OnlineProxyStoreOfferMarshaler
{
    public static OnlineProxyStoreOffer FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new OnlineProxyStoreOffer(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, OnlineProxyStoreOffer obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return OnlineProxyStoreOffer.NativeDataSize;
    }
}