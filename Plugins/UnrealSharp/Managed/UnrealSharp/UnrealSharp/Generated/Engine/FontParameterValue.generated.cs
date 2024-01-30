using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct FontParameterValue
{
    // StructProperty /Script/Engine.FontParameterValue:ParameterInfo
    static readonly int ParameterInfo_Offset;
    public UnrealSharp.Engine.MaterialParameterInfo ParameterInfo;
    
    // ObjectProperty /Script/Engine.FontParameterValue:FontValue
    static readonly int FontValue_Offset;
    public UnrealSharp.Engine.Font FontValue;
    
    // IntProperty /Script/Engine.FontParameterValue:FontPage
    static readonly int FontPage_Offset;
    public int FontPage;
    
    
    public static readonly int NativeDataSize;
    static FontParameterValue()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("FontParameterValue");
        
        ParameterInfo_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ParameterInfo");
        FontValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FontValue");
        FontPage_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FontPage");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public FontParameterValue(IntPtr InNativeStruct)
    {
        unsafe
        {
            ParameterInfo = UnrealSharp.Engine.MaterialParameterInfoMarshaler.FromNative(IntPtr.Add(InNativeStruct, ParameterInfo_Offset), 0, null);
            FontValue = ObjectMarshaller<UnrealSharp.Engine.Font>.FromNative(IntPtr.Add(InNativeStruct, FontValue_Offset), 0, null);
            FontPage = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, FontPage_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.Engine.MaterialParameterInfoMarshaler.ToNative(IntPtr.Add(Buffer, ParameterInfo_Offset), 0, null, ParameterInfo);
            ObjectMarshaller<UnrealSharp.Engine.Font>.ToNative(IntPtr.Add(Buffer, FontValue_Offset), 0, null, FontValue);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, FontPage_Offset), 0, null, FontPage);
        }
    }
}

public static class FontParameterValueMarshaler
{
    public static FontParameterValue FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new FontParameterValue(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, FontParameterValue obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return FontParameterValue.NativeDataSize;
    }
}