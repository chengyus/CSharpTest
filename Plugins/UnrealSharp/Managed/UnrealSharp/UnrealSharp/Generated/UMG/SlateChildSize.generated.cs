using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.UMG;

[UStruct]
public partial struct SlateChildSize
{
    // FloatProperty /Script/UMG.SlateChildSize:Value
    static readonly int Value_Offset;
    public float Value;
    
    // ByteProperty /Script/UMG.SlateChildSize:SizeRule
    static readonly int SizeRule_Offset;
    public UnrealSharp.UMG.ESlateSizeRule SizeRule;
    
    
    public static readonly int NativeDataSize;
    static SlateChildSize()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("SlateChildSize");
        
        Value_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Value");
        SizeRule_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SizeRule");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public SlateChildSize(IntPtr InNativeStruct)
    {
        unsafe
        {
            Value = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Value_Offset), 0, null);
            SizeRule = BlittableMarshaller<UnrealSharp.UMG.ESlateSizeRule>.FromNative(IntPtr.Add(InNativeStruct, SizeRule_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Value_Offset), 0, null, Value);
            BlittableMarshaller<UnrealSharp.UMG.ESlateSizeRule>.ToNative(IntPtr.Add(Buffer, SizeRule_Offset), 0, null, SizeRule);
        }
    }
}

public static class SlateChildSizeMarshaler
{
    public static SlateChildSize FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new SlateChildSize(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, SlateChildSize obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return SlateChildSize.NativeDataSize;
    }
}