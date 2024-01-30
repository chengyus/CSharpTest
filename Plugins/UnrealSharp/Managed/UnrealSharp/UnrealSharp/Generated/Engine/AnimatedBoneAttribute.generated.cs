using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct AnimatedBoneAttribute
{
    // StructProperty /Script/Engine.AnimatedBoneAttribute:Identifier
    static readonly int Identifier_Offset;
    public UnrealSharp.Engine.AnimationAttributeIdentifier Identifier;
    
    // StructProperty /Script/Engine.AnimatedBoneAttribute:Curve
    static readonly int Curve_Offset;
    public UnrealSharp.Engine.AttributeCurve Curve;
    
    
    public static readonly int NativeDataSize;
    static AnimatedBoneAttribute()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("AnimatedBoneAttribute");
        
        Identifier_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Identifier");
        Curve_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Curve");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public AnimatedBoneAttribute(IntPtr InNativeStruct)
    {
        unsafe
        {
            Identifier = UnrealSharp.Engine.AnimationAttributeIdentifierMarshaler.FromNative(IntPtr.Add(InNativeStruct, Identifier_Offset), 0, null);
            Curve = UnrealSharp.Engine.AttributeCurveMarshaler.FromNative(IntPtr.Add(InNativeStruct, Curve_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.Engine.AnimationAttributeIdentifierMarshaler.ToNative(IntPtr.Add(Buffer, Identifier_Offset), 0, null, Identifier);
            UnrealSharp.Engine.AttributeCurveMarshaler.ToNative(IntPtr.Add(Buffer, Curve_Offset), 0, null, Curve);
        }
    }
}

public static class AnimatedBoneAttributeMarshaler
{
    public static AnimatedBoneAttribute FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new AnimatedBoneAttribute(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, AnimatedBoneAttribute obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return AnimatedBoneAttribute.NativeDataSize;
    }
}