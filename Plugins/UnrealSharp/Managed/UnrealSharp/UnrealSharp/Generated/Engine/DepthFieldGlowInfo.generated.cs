using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct DepthFieldGlowInfo
{
    // BoolProperty /Script/Engine.DepthFieldGlowInfo:bEnableGlow
    static readonly int bEnableGlow_Offset;
    static readonly IntPtr bEnableGlow_NativeProperty;
    public bool EnableGlow;
    
    // StructProperty /Script/Engine.DepthFieldGlowInfo:GlowColor
    static readonly int GlowColor_Offset;
    public UnrealSharp.CoreUObject.LinearColor GlowColor;
    
    // StructProperty /Script/Engine.DepthFieldGlowInfo:GlowOuterRadius
    static readonly int GlowOuterRadius_Offset;
    public System.DoubleNumerics.Vector2 GlowOuterRadius;
    
    // StructProperty /Script/Engine.DepthFieldGlowInfo:GlowInnerRadius
    static readonly int GlowInnerRadius_Offset;
    public System.DoubleNumerics.Vector2 GlowInnerRadius;
    
    
    public static readonly int NativeDataSize;
    static DepthFieldGlowInfo()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("DepthFieldGlowInfo");
        
        bEnableGlow_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bEnableGlow");
        bEnableGlow_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bEnableGlow");
        GlowColor_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "GlowColor");
        GlowOuterRadius_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "GlowOuterRadius");
        GlowInnerRadius_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "GlowInnerRadius");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public DepthFieldGlowInfo(IntPtr InNativeStruct)
    {
        unsafe
        {
            EnableGlow = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bEnableGlow_NativeProperty, bEnableGlow_Offset);
            GlowColor = BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.FromNative(IntPtr.Add(InNativeStruct, GlowColor_Offset), 0, null);
            GlowOuterRadius = BlittableMarshaller<System.DoubleNumerics.Vector2>.FromNative(IntPtr.Add(InNativeStruct, GlowOuterRadius_Offset), 0, null);
            GlowInnerRadius = BlittableMarshaller<System.DoubleNumerics.Vector2>.FromNative(IntPtr.Add(InNativeStruct, GlowInnerRadius_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bEnableGlow_NativeProperty, bEnableGlow_Offset, EnableGlow);
            BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.ToNative(IntPtr.Add(Buffer, GlowColor_Offset), 0, null, GlowColor);
            BlittableMarshaller<System.DoubleNumerics.Vector2>.ToNative(IntPtr.Add(Buffer, GlowOuterRadius_Offset), 0, null, GlowOuterRadius);
            BlittableMarshaller<System.DoubleNumerics.Vector2>.ToNative(IntPtr.Add(Buffer, GlowInnerRadius_Offset), 0, null, GlowInnerRadius);
        }
    }
}

public static class DepthFieldGlowInfoMarshaler
{
    public static DepthFieldGlowInfo FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new DepthFieldGlowInfo(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, DepthFieldGlowInfo obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return DepthFieldGlowInfo.NativeDataSize;
    }
}