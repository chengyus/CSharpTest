using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct FontRenderInfo
{
    // BoolProperty /Script/Engine.FontRenderInfo:bClipText
    static readonly int bClipText_Offset;
    static readonly IntPtr bClipText_NativeProperty;
    public bool ClipText;
    
    // BoolProperty /Script/Engine.FontRenderInfo:bEnableShadow
    static readonly int bEnableShadow_Offset;
    static readonly IntPtr bEnableShadow_NativeProperty;
    public bool EnableShadow;
    
    // StructProperty /Script/Engine.FontRenderInfo:GlowInfo
    static readonly int GlowInfo_Offset;
    public UnrealSharp.Engine.DepthFieldGlowInfo GlowInfo;
    
    
    public static readonly int NativeDataSize;
    static FontRenderInfo()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("FontRenderInfo");
        
        bClipText_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bClipText");
        bClipText_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bClipText");
        bEnableShadow_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bEnableShadow");
        bEnableShadow_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bEnableShadow");
        GlowInfo_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "GlowInfo");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public FontRenderInfo(IntPtr InNativeStruct)
    {
        unsafe
        {
            ClipText = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bClipText_NativeProperty, bClipText_Offset);
            EnableShadow = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bEnableShadow_NativeProperty, bEnableShadow_Offset);
            GlowInfo = UnrealSharp.Engine.DepthFieldGlowInfoMarshaler.FromNative(IntPtr.Add(InNativeStruct, GlowInfo_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bClipText_NativeProperty, bClipText_Offset, ClipText);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bEnableShadow_NativeProperty, bEnableShadow_Offset, EnableShadow);
            UnrealSharp.Engine.DepthFieldGlowInfoMarshaler.ToNative(IntPtr.Add(Buffer, GlowInfo_Offset), 0, null, GlowInfo);
        }
    }
}

public static class FontRenderInfoMarshaler
{
    public static FontRenderInfo FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new FontRenderInfo(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, FontRenderInfo obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return FontRenderInfo.NativeDataSize;
    }
}