using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.UMG;

[UStruct]
public partial struct ShapedTextOptions
{
    // EnumProperty /Script/UMG.ShapedTextOptions:TextShapingMethod
    static readonly int TextShapingMethod_Offset;
    public UnrealSharp.SlateCore.ETextShapingMethod TextShapingMethod;
    
    // EnumProperty /Script/UMG.ShapedTextOptions:TextFlowDirection
    static readonly int TextFlowDirection_Offset;
    public UnrealSharp.Slate.ETextFlowDirection TextFlowDirection;
    
    
    public static readonly int NativeDataSize;
    static ShapedTextOptions()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("ShapedTextOptions");
        
        TextShapingMethod_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "TextShapingMethod");
        TextFlowDirection_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "TextFlowDirection");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public ShapedTextOptions(IntPtr InNativeStruct)
    {
        unsafe
        {
            TextShapingMethod = BlittableMarshaller<UnrealSharp.SlateCore.ETextShapingMethod>.FromNative(IntPtr.Add(InNativeStruct, TextShapingMethod_Offset), 0, null);
            TextFlowDirection = BlittableMarshaller<UnrealSharp.Slate.ETextFlowDirection>.FromNative(IntPtr.Add(InNativeStruct, TextFlowDirection_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.SlateCore.ETextShapingMethod>.ToNative(IntPtr.Add(Buffer, TextShapingMethod_Offset), 0, null, TextShapingMethod);
            BlittableMarshaller<UnrealSharp.Slate.ETextFlowDirection>.ToNative(IntPtr.Add(Buffer, TextFlowDirection_Offset), 0, null, TextFlowDirection);
        }
    }
}

public static class ShapedTextOptionsMarshaler
{
    public static ShapedTextOptions FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new ShapedTextOptions(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, ShapedTextOptions obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return ShapedTextOptions.NativeDataSize;
    }
}