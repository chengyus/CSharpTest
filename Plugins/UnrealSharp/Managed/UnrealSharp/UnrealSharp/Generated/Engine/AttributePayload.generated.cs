using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct AttributePayload
{
    // StructProperty /Script/Engine.AttributePayload:Identifier
    static readonly int Identifier_Offset;
    public UnrealSharp.Engine.AnimationAttributeIdentifier Identifier;
    
    
    public static readonly int NativeDataSize;
    static AttributePayload()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("AttributePayload");
        
        Identifier_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Identifier");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public AttributePayload(IntPtr InNativeStruct)
    {
        unsafe
        {
            Identifier = UnrealSharp.Engine.AnimationAttributeIdentifierMarshaler.FromNative(IntPtr.Add(InNativeStruct, Identifier_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.Engine.AnimationAttributeIdentifierMarshaler.ToNative(IntPtr.Add(Buffer, Identifier_Offset), 0, null, Identifier);
        }
    }
}

public static class AttributePayloadMarshaler
{
    public static AttributePayload FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new AttributePayload(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, AttributePayload obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return AttributePayload.NativeDataSize;
    }
}