using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.InterchangeNodes;

[UStruct]
public partial struct InterchangeMeshPayLoadKey
{
    // EnumProperty /Script/InterchangeNodes.InterchangeMeshPayLoadKey:Type
    static readonly int Type_Offset;
    public UnrealSharp.InterchangeNodes.EInterchangeMeshPayLoadType Type;
    
    
    public static readonly int NativeDataSize;
    static InterchangeMeshPayLoadKey()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("InterchangeMeshPayLoadKey");
        
        Type_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Type");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public InterchangeMeshPayLoadKey(IntPtr InNativeStruct)
    {
        unsafe
        {
            Type = BlittableMarshaller<UnrealSharp.InterchangeNodes.EInterchangeMeshPayLoadType>.FromNative(IntPtr.Add(InNativeStruct, Type_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.InterchangeNodes.EInterchangeMeshPayLoadType>.ToNative(IntPtr.Add(Buffer, Type_Offset), 0, null, Type);
        }
    }
}

public static class InterchangeMeshPayLoadKeyMarshaler
{
    public static InterchangeMeshPayLoadKey FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new InterchangeMeshPayLoadKey(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, InterchangeMeshPayLoadKey obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return InterchangeMeshPayLoadKey.NativeDataSize;
    }
}