using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.InterchangeNodes;

[UStruct]
public partial struct InterchangeAnimationPayLoadKey
{
    // EnumProperty /Script/InterchangeNodes.InterchangeAnimationPayLoadKey:Type
    static readonly int Type_Offset;
    public UnrealSharp.InterchangeNodes.EInterchangeAnimationPayLoadType Type;
    
    
    public static readonly int NativeDataSize;
    static InterchangeAnimationPayLoadKey()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("InterchangeAnimationPayLoadKey");
        
        Type_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Type");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public InterchangeAnimationPayLoadKey(IntPtr InNativeStruct)
    {
        unsafe
        {
            Type = BlittableMarshaller<UnrealSharp.InterchangeNodes.EInterchangeAnimationPayLoadType>.FromNative(IntPtr.Add(InNativeStruct, Type_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.InterchangeNodes.EInterchangeAnimationPayLoadType>.ToNative(IntPtr.Add(Buffer, Type_Offset), 0, null, Type);
        }
    }
}

public static class InterchangeAnimationPayLoadKeyMarshaler
{
    public static InterchangeAnimationPayLoadKey FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new InterchangeAnimationPayLoadKey(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, InterchangeAnimationPayLoadKey obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return InterchangeAnimationPayLoadKey.NativeDataSize;
    }
}